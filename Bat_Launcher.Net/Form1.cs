namespace Bat_Launcher.Net
{
    public partial class Form1 : Form
    {
        private BatchRunner _batchRunner;

        public Form1()
        {
            InitializeComponent();
            _batchRunner = new BatchRunner(richTextBox1);
        }

        private async void ButtonRunBatch_Click(object sender, EventArgs e)
        {
            ButtonRunBatch.Enabled = false;

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
                ButtonRunBatch.Enabled = true;
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

        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
