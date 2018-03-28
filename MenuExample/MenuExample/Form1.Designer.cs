namespace MenuExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFormatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.editToolStripMenuItem,
            this.mnFormat,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(524, 24);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "mn";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFileNew,
            this.mnFileOpen,
            this.mnFileSave,
            this.mnFileSaveAs,
            this.toolStripSeparator1,
            this.mnFilePageSetup,
            this.mnFilePrint,
            this.toolStripSeparator2,
            this.mnFileExit});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(37, 20);
            this.mnFile.Text = "File";
            // 
            // mnFileNew
            // 
            this.mnFileNew.Name = "mnFileNew";
            this.mnFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnFileNew.Size = new System.Drawing.Size(190, 22);
            this.mnFileNew.Text = "New";
            this.mnFileNew.Click += new System.EventHandler(this.mnFileNew_Click);
            // 
            // mnFileOpen
            // 
            this.mnFileOpen.Name = "mnFileOpen";
            this.mnFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnFileOpen.Size = new System.Drawing.Size(190, 22);
            this.mnFileOpen.Text = "Open..";
            this.mnFileOpen.Click += new System.EventHandler(this.mnFileOpen_Click);
            // 
            // mnFileSave
            // 
            this.mnFileSave.Name = "mnFileSave";
            this.mnFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnFileSave.Size = new System.Drawing.Size(190, 22);
            this.mnFileSave.Text = "Save";
            this.mnFileSave.Click += new System.EventHandler(this.mnFileSave_Click);
            // 
            // mnFileSaveAs
            // 
            this.mnFileSaveAs.Name = "mnFileSaveAs";
            this.mnFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnFileSaveAs.Size = new System.Drawing.Size(190, 22);
            this.mnFileSaveAs.Text = "Save as..";
            this.mnFileSaveAs.Click += new System.EventHandler(this.mnFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // mnFilePageSetup
            // 
            this.mnFilePageSetup.Name = "mnFilePageSetup";
            this.mnFilePageSetup.Size = new System.Drawing.Size(190, 22);
            this.mnFilePageSetup.Text = "Page Setup..";
            this.mnFilePageSetup.Click += new System.EventHandler(this.mnFilePageSetup_Click);
            // 
            // mnFilePrint
            // 
            this.mnFilePrint.Name = "mnFilePrint";
            this.mnFilePrint.Size = new System.Drawing.Size(190, 22);
            this.mnFilePrint.Text = "Print";
            this.mnFilePrint.Click += new System.EventHandler(this.mnFilePrint_Click);
            // 
            // mnFileExit
            // 
            this.mnFileExit.Name = "mnFileExit";
            this.mnFileExit.Size = new System.Drawing.Size(190, 22);
            this.mnFileExit.Text = "Exit";
            this.mnFileExit.Click += new System.EventHandler(this.mnFileExit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnFormat
            // 
            this.mnFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFormatWordWrap,
            this.mnFormatFont});
            this.mnFormat.Name = "mnFormat";
            this.mnFormat.Size = new System.Drawing.Size(57, 20);
            this.mnFormat.Text = "Format";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnFormatWordWrap
            // 
            this.mnFormatWordWrap.CheckOnClick = true;
            this.mnFormatWordWrap.Name = "mnFormatWordWrap";
            this.mnFormatWordWrap.Size = new System.Drawing.Size(152, 22);
            this.mnFormatWordWrap.Text = "Word Wrap";
            // 
            // mnFormatFont
            // 
            this.mnFormatFont.Name = "mnFormatFont";
            this.mnFormatFont.Size = new System.Drawing.Size(152, 22);
            this.mnFormatFont.Text = "Font";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 343);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 367);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnFilePageSetup;
        private System.Windows.Forms.ToolStripMenuItem mnFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnFileExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnFormat;
        private System.Windows.Forms.ToolStripMenuItem mnFormatWordWrap;
        private System.Windows.Forms.ToolStripMenuItem mnFormatFont;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

