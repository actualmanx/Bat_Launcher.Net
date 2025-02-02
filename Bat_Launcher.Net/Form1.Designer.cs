namespace Bat_Launcher.Net
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            ButtonRunBatch = new Button();
            Cancel = new Button();
            checkBoxShowCommands = new CheckBox();
            statusStrip1 = new StatusStrip();
            fileStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            fileOpenToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            ClearScreen = new Button();
            openFileDialog1 = new OpenFileDialog();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlDark;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(12, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(963, 270);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // ButtonRunBatch
            // 
            ButtonRunBatch.BackColor = SystemColors.ControlDarkDark;
            ButtonRunBatch.ForeColor = Color.Lime;
            ButtonRunBatch.Location = new Point(889, 391);
            ButtonRunBatch.Name = "ButtonRunBatch";
            ButtonRunBatch.Size = new Size(86, 34);
            ButtonRunBatch.TabIndex = 1;
            ButtonRunBatch.Text = "Start";
            ButtonRunBatch.UseVisualStyleBackColor = false;
            ButtonRunBatch.Click += ButtonRunBatch_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = SystemColors.ControlDarkDark;
            Cancel.ForeColor = Color.Red;
            Cancel.Location = new Point(777, 391);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(86, 34);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // checkBoxShowCommands
            // 
            checkBoxShowCommands.AutoSize = true;
            checkBoxShowCommands.Checked = true;
            checkBoxShowCommands.CheckState = CheckState.Checked;
            checkBoxShowCommands.ForeColor = SystemColors.GradientActiveCaption;
            checkBoxShowCommands.Location = new Point(339, 395);
            checkBoxShowCommands.Name = "checkBoxShowCommands";
            checkBoxShowCommands.Size = new Size(269, 29);
            checkBoxShowCommands.TabIndex = 4;
            checkBoxShowCommands.Text = "Show Processing Commands";
            checkBoxShowCommands.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlDark;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { fileStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 460);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(987, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // fileStripStatusLabel1
            // 
            fileStripStatusLabel1.Name = "fileStripStatusLabel1";
            fileStripStatusLabel1.Size = new Size(0, 15);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(987, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileOpenToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Image = (Image)resources.GetObject("menuToolStripMenuItem.Image");
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(97, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // fileOpenToolStripMenuItem
            // 
            fileOpenToolStripMenuItem.BackColor = SystemColors.ControlDark;
            fileOpenToolStripMenuItem.Image = (Image)resources.GetObject("fileOpenToolStripMenuItem.Image");
            fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            fileOpenToolStripMenuItem.Size = new Size(189, 34);
            fileOpenToolStripMenuItem.Text = "File Open";
            fileOpenToolStripMenuItem.Click += FileOpenToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ControlDark;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(189, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, helpToolStripMenuItem1 });
            helpToolStripMenuItem.Image = (Image)resources.GetObject("helpToolStripMenuItem.Image");
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(89, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = SystemColors.ControlDark;
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            helpToolStripMenuItem1.Image = (Image)resources.GetObject("helpToolStripMenuItem1.Image");
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(164, 34);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // ClearScreen
            // 
            ClearScreen.BackColor = SystemColors.ControlDarkDark;
            ClearScreen.ForeColor = Color.Yellow;
            ClearScreen.Location = new Point(12, 391);
            ClearScreen.Name = "ClearScreen";
            ClearScreen.Size = new Size(86, 34);
            ClearScreen.TabIndex = 7;
            ClearScreen.Text = "Clear Screen";
            ClearScreen.UseVisualStyleBackColor = false;
            ClearScreen.Click += ClearScreen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Batch Files|*.bat|All Files|*.*";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(987, 482);
            Controls.Add(ClearScreen);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(checkBoxShowCommands);
            Controls.Add(Cancel);
            Controls.Add(ButtonRunBatch);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bat Launcher.Net";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button ButtonRunBatch;
        private Button Cancel;
        private CheckBox checkBoxShowCommands;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel fileStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem fileOpenToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private Button ClearScreen;
        private OpenFileDialog openFileDialog1;
    }
}
