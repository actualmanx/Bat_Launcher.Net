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
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            fileOpenToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            ClearScreen = new Button();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 270);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ButtonRunBatch
            // 
            ButtonRunBatch.Location = new Point(683, 353);
            ButtonRunBatch.Name = "ButtonRunBatch";
            ButtonRunBatch.Size = new Size(86, 38);
            ButtonRunBatch.TabIndex = 1;
            ButtonRunBatch.Text = "Start";
            ButtonRunBatch.UseVisualStyleBackColor = true;
            ButtonRunBatch.Click += ButtonRunBatch_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(591, 353);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(86, 38);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // checkBoxShowCommands
            // 
            checkBoxShowCommands.AutoSize = true;
            checkBoxShowCommands.Checked = true;
            checkBoxShowCommands.CheckState = CheckState.Checked;
            checkBoxShowCommands.Location = new Point(253, 353);
            checkBoxShowCommands.Name = "checkBoxShowCommands";
            checkBoxShowCommands.Size = new Size(269, 29);
            checkBoxShowCommands.TabIndex = 4;
            checkBoxShowCommands.Text = "Show Processing Commands";
            checkBoxShowCommands.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(170, 25);
            toolStripStatusLabel1.Text = "fileStripStatusLabel1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileOpenToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, helpToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // fileOpenToolStripMenuItem
            // 
            fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            fileOpenToolStripMenuItem.Size = new Size(270, 34);
            fileOpenToolStripMenuItem.Text = "File Open";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(270, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(270, 34);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // ClearScreen
            // 
            ClearScreen.Location = new Point(35, 348);
            ClearScreen.Name = "ClearScreen";
            ClearScreen.Size = new Size(112, 34);
            ClearScreen.TabIndex = 7;
            ClearScreen.Text = "Clear Screen";
            ClearScreen.UseVisualStyleBackColor = true;
            ClearScreen.Click += ClearScreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem fileOpenToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private Button ClearScreen;
    }
}
