using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Bat_Launcher.Net
{
    public partial class Form1 : Form
    {
        private readonly BatchRunner _batchRunner;
        private bool _isRunning = false;
        private string? filePath; // Remove readonly to allow updates

        public Form1()
        {
            InitializeComponent();
            _batchRunner = new BatchRunner(richTextBox1);
            Cancel.Enabled = false;

            filePath = RegistryHelper.Read("Settings", "FilePath") as string;

            fileStripStatusLabel1.Text = filePath;

            if (String.IsNullOrEmpty(fileStripStatusLabel1.Text))
            {
                this.richTextBox1.Text = "Please drag & drop a file or use the menu to add a file." + Environment.NewLine;
            }

            // Enable drag-and-drop for the form
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private async void ButtonRunBatch_Click(object sender, EventArgs e)
        {
            if (_isRunning)
                return; // Prevent multiple runs

            if (string.IsNullOrEmpty(filePath))
            {
                AppendOutput("No batch file path specified.");
                return;
            }

            _isRunning = true;
            ButtonRunBatch.Enabled = false;
            Cancel.Enabled = true;
            string? batchFilePath = filePath; // Use the already assigned filePath
            bool showCommands = checkBoxShowCommands.Checked;

            try
            {
                richTextBox1.Clear();
                AppendOutput("Starting batch file execution...");

                if (batchFilePath != null) // Ensure batchFilePath is not null
                {
                    await _batchRunner.RunBatchFileAsync(batchFilePath, showCommands);
                }

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
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                filePath = openFileDialog.FileName; // Update filePath

                // Save the file path to the registry
                RegistryHelper.Write("Settings", "FilePath", filePath);

                // Optionally, you can display the file path in a control or use it as needed
                fileStripStatusLabel1.Text = filePath;
            }
        }

        private void Form1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[]? files = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (files != null && files.Length > 0)
                {
                    filePath = files[0]; // Update filePath

                    // Save the file path to the registry
                    RegistryHelper.Write("Settings", "FilePath", filePath);

                    // Optionally, you can display the file path in a control or use it as needed
                    fileStripStatusLabel1.Text = filePath;
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _batchRunner.Cancel();
            }
            Application.Exit();
        }
    }
}
