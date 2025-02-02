using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Bat_Launcher.Net
{
    public partial class Form1 : Form
    {
        private BatchRunner _batchRunner;
        private bool _isRunning = false;
        public Form1()
        {
            InitializeComponent();
            _batchRunner = new BatchRunner(richTextBox1);
            Cancel.Enabled = false;
        }

        private async void ButtonRunBatch_Click(object sender, EventArgs e)
        {
            if (_isRunning)
                return; // Prevent multiple runs

            _isRunning = true;
            ButtonRunBatch.Enabled = false;
            Cancel.Enabled = true;

            string batchFilePath = @"C:\Users\Kieran Hill\Desktop\nnplus\misc\update_scripts\win_scripts\runme.bat";
            bool showCommands = checkBoxShowCommands.Checked;

            try
            {
                richTextBox1.Clear();
                AppendOutput("Starting batch file execution...");

                await _batchRunner.RunBatchFileAsync(batchFilePath, showCommands);

                AppendOutput("Batch file execution completed.");
            }
            catch (Exception ex)
            {
                AppendOutput($"An error occurred: {ex.Message}");
            }
            finally
            {
                _isRunning = false;
                ButtonRunBatch.Enabled = true;
                Cancel.Enabled = false;
            }
        }

        private void AppendOutput(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            richTextBox1.AppendText(text + Environment.NewLine);
            richTextBox1.ScrollToCaret();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _batchRunner.Cancel();
                // Optionally, you can reset the UI state here
                _isRunning = false;
                ButtonRunBatch.Enabled = true;
                Cancel.Enabled = false;
            }
        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
