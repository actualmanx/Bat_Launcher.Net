namespace Bat_Launcher.Net
{
    public class BatchRunner(RichTextBox outputBox)
    {
        private readonly RichTextBox _outputBox = outputBox;

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

            using var process = new Process { StartInfo = startInfo };
            process.OutputDataReceived += (sender, e) => { if (e.Data != null) AppendOutput(e.Data); };
            process.ErrorDataReceived += (sender, e) => { if (e.Data != null) AppendOutput(e.Data); };

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await Task.Run(() => process.WaitForExit());
        }

        private static string BuildArguments(string batchFilePath, bool showCommands)
        {
            if (showCommands)
            {
                return $"/C \"\"{batchFilePath}\"\"";
            }
            else
            {
                return $"/Q /C \"\"{batchFilePath}\"\"";
            }
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