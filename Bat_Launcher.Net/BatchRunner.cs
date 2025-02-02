namespace Bat_Launcher.Net
{
    public class BatchRunner
    {
        private readonly RichTextBox _outputBox;
        private Process _process;

        public BatchRunner(RichTextBox outputBox)
        {
            _outputBox = outputBox;
        }

        public async Task RunBatchFileAsync(string batchFilePath, bool showCommands)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = BuildArguments(batchFilePath, showCommands),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8,
                WorkingDirectory = Path.GetDirectoryName(batchFilePath)
            };

            // Adjust the PROMPT based on showCommands
            if (showCommands)
            {
                startInfo.EnvironmentVariables["PROMPT"] = "$G"; // Display '>' as prompt
            }
            else
            {
                if (startInfo.EnvironmentVariables.ContainsKey("PROMPT"))
                    startInfo.EnvironmentVariables.Remove("PROMPT");
            }

            // Initialize the process and assign it to the _process field
            _process = new Process { StartInfo = startInfo };
            _process.OutputDataReceived += (sender, e) => { if (e.Data != null) AppendOutput(e.Data); };
            _process.ErrorDataReceived += (sender, e) => { if (e.Data != null) AppendOutput(e.Data); };

            _process.Start();

            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();

            // Await the process exit without blocking the UI thread
            await Task.Run(() => _process.WaitForExit());
        }

        public void Cancel()
        {
            if (_process != null && !_process.HasExited)
            {
                try
                {
                    _process.Kill();
                    AppendOutput("Process canceled by user.");
                }
                catch (Exception ex)
                {
                    AppendOutput($"Error canceling process: {ex.Message}");
                }
            }
        }

        private static string BuildArguments(string batchFilePath, bool showCommands)
        {
            return showCommands
                ? $"/C \"\"{batchFilePath}\"\""
                : $"/Q /C \"\"{batchFilePath}\"\"";
        }

        private void AppendOutput(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            if (_outputBox.InvokeRequired)
            {
                _outputBox.Invoke(new Action<string>(AppendOutput), text);
            }
            else
            {
                _outputBox.AppendText(text + Environment.NewLine);
                _outputBox.ScrollToCaret();
            }
        }
    }
}
