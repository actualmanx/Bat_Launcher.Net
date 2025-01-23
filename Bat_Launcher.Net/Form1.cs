using Bat_launcher.Net;

namespace Bat_Launcher.Net
{
    public partial class Form1 : Form
    {
        private ProcessCaller processCaller = null!; // Initialize with null-forgiving operator

        public Form1()
        {
            InitializeComponent();
            InitializeProcessCaller();
        }

        private void InitializeProcessCaller()
        {
            processCaller = new ProcessCaller
            {
                FileName = "F:\\Dual Universe Server\\scripts\\up.bat", // Set your batch file path here
                Arguments = "", // Set any arguments if needed
                WorkingDirectory = "" // Set the working directory if needed
            };

            processCaller.StdOutReceived += ProcessCaller_StdOutReceived;
            processCaller.StdErrReceived += ProcessCaller_StdErrReceived;
        }

        private void ProcessCaller_StdOutReceived(object sender, DataReceivedEventArgs e)
        {
            AppendTextToRichTextBox(e.Text);
        }

        private void ProcessCaller_StdErrReceived(object sender, DataReceivedEventArgs e)
        {
            AppendTextToRichTextBox(e.Text);
        }

        private void AppendTextToRichTextBox(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AppendTextToRichTextBox), text);
            }
            else
            {
                richTextBox1.AppendText(text + Environment.NewLine);
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }


        private async void ButtonRunBatch_Click(object sender, EventArgs e)
        {
            await processCaller.StartAsync();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            processCaller.Cancel();
        }
    }
}
