using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bat_launcher.Net
{
    public delegate void DataReceivedHandler(object sender, DataReceivedEventArgs e);

    public class DataReceivedEventArgs : EventArgs
    {
        public string Text { get; }

        public DataReceivedEventArgs(string text) => Text = text;
    }

    public class ProcessCaller
    {
        public required string FileName { get; set; }
        public required string Arguments { get; set; }
        public required string WorkingDirectory { get; set; }
        public event DataReceivedHandler? StdOutReceived;
        public event DataReceivedHandler? StdErrReceived;
        public int SleepTime { get; set; } = 500;

        private Process? process;
        private CancellationTokenSource? cancellationTokenSource;
        private SynchronizationContext synchronizationContext;

        public ProcessCaller()
        {
            synchronizationContext = SynchronizationContext.Current ?? new SynchronizationContext();
        }

        public async Task StartAsync()
        {
            cancellationTokenSource = new CancellationTokenSource();
            await StartProcessAsync(cancellationTokenSource.Token);
        }

        public void Cancel()
        {
            cancellationTokenSource?.Cancel();
        }

        private async Task StartProcessAsync(CancellationToken cancellationToken)
        {
            try
            {
                process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = FileName,
                        Arguments = Arguments,
                        WorkingDirectory = WorkingDirectory,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                process.Start();

                var stdOutTask = ReadStreamAsync(process.StandardOutput, StdOutReceived, cancellationToken);
                var stdErrTask = ReadStreamAsync(process.StandardError, StdErrReceived, cancellationToken);

                await Task.WhenAll(stdOutTask, stdErrTask);

                await process.WaitForExitAsync(cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // Handle the cancellation gracefully, e.g., log the cancellation or update the UI
                Console.WriteLine("The operation was canceled.");
            }
            catch (Exception ex)
            {
                // Handle other exceptions if necessary
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private async Task ReadStreamAsync(StreamReader reader, DataReceivedHandler? handler, CancellationToken cancellationToken)
        {
            string? line;
            while ((line = await reader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                synchronizationContext.Post(e => handler?.Invoke(this, new DataReceivedEventArgs(line)), null);
            }
        }
    }
}
