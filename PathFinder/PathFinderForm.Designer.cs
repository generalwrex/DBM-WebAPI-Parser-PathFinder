namespace PathFinder
{
    partial class PathFinderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathFinderForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.bBrowseForFile = new System.Windows.Forms.Button();
            this.bGoPath = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bGoURL = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbInputJson = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvOutputViewer = new System.Windows.Forms.TreeView();
            this.fbLoadJsonFile = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Quit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_About = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1_Donate = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbSelectedPaths = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.bBrowseForFile);
            this.splitContainer1.Panel1.Controls.Add(this.bGoPath);
            this.splitContainer1.Panel1.Controls.Add(this.tbFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.bGoURL);
            this.splitContainer1.Panel1.Controls.Add(this.tbUrl);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Size = new System.Drawing.Size(762, 461);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "- -Or- -";
            // 
            // bBrowseForFile
            // 
            this.bBrowseForFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseForFile.Enabled = false;
            this.bBrowseForFile.Location = new System.Drawing.Point(709, 39);
            this.bBrowseForFile.Name = "bBrowseForFile";
            this.bBrowseForFile.Size = new System.Drawing.Size(50, 20);
            this.bBrowseForFile.TabIndex = 6;
            this.bBrowseForFile.Text = "Browse";
            this.bBrowseForFile.UseVisualStyleBackColor = true;
            this.bBrowseForFile.Click += new System.EventHandler(this.bBrowseForFile_Click);
            // 
            // bGoPath
            // 
            this.bGoPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGoPath.Enabled = false;
            this.bGoPath.Location = new System.Drawing.Point(670, 39);
            this.bGoPath.Name = "bGoPath";
            this.bGoPath.Size = new System.Drawing.Size(37, 20);
            this.bGoPath.TabIndex = 5;
            this.bGoPath.Text = "Go";
            this.bGoPath.UseVisualStyleBackColor = true;
            this.bGoPath.Click += new System.EventHandler(this.bGoPath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Enabled = false;
            this.tbFilePath.Location = new System.Drawing.Point(82, 39);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(590, 20);
            this.tbFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter File Path:";
            // 
            // bGoURL
            // 
            this.bGoURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGoURL.Location = new System.Drawing.Point(718, 13);
            this.bGoURL.Name = "bGoURL";
            this.bGoURL.Size = new System.Drawing.Size(41, 20);
            this.bGoURL.TabIndex = 2;
            this.bGoURL.Text = "Go";
            this.bGoURL.UseVisualStyleBackColor = true;
            this.bGoURL.Click += new System.EventHandler(this.bGoURL_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(82, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(639, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrl_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter URL: ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(762, 386);
            this.splitContainer2.SplitterDistance = 279;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(762, 279);
            this.splitContainer3.SplitterDistance = 366;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbInputJson);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON Input";
            // 
            // rtbInputJson
            // 
            this.rtbInputJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInputJson.Location = new System.Drawing.Point(3, 16);
            this.rtbInputJson.Name = "rtbInputJson";
            this.rtbInputJson.Size = new System.Drawing.Size(360, 260);
            this.rtbInputJson.TabIndex = 1;
            this.rtbInputJson.Text = "";
            this.rtbInputJson.Enter += new System.EventHandler(this.rtbInputJson_Enter);
            this.rtbInputJson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInputJson_KeyPress);
            this.rtbInputJson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbInputJson_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvOutputViewer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path Finder";
            // 
            // tvOutputViewer
            // 
            this.tvOutputViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOutputViewer.Location = new System.Drawing.Point(3, 16);
            this.tvOutputViewer.Name = "tvOutputViewer";
            this.tvOutputViewer.Size = new System.Drawing.Size(386, 260);
            this.tvOutputViewer.TabIndex = 1;
            this.tvOutputViewer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOutputViewer_AfterSelect);
            this.tvOutputViewer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvOutputViewer_NodeMouseDoubleClick);
            // 
            // fbLoadJsonFile
            // 
            this.fbLoadJsonFile.Description = "Load a file containing JSON";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Quit,
            this.toolStripButton_Help,
            this.toolStripButton_About,
            this.toolStripButton1_Donate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Quit
            // 
            this.toolStripButton_Quit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Quit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Quit.Image")));
            this.toolStripButton_Quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Quit.Name = "toolStripButton_Quit";
            this.toolStripButton_Quit.Size = new System.Drawing.Size(34, 22);
            this.toolStripButton_Quit.Text = "Quit";
            this.toolStripButton_Quit.ToolTipText = "Exits PathFinder";
            this.toolStripButton_Quit.Click += new System.EventHandler(this.toolStripButton_Quit_Click);
            // 
            // toolStripButton_About
            // 
            this.toolStripButton_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_About.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_About.Image")));
            this.toolStripButton_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_About.Name = "toolStripButton_About";
            this.toolStripButton_About.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton_About.Text = "About..";
            this.toolStripButton_About.Click += new System.EventHandler(this.toolStripButton_About_Click);
            // 
            // toolStripButton_Help
            // 
            this.toolStripButton_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Help.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Help.Image")));
            this.toolStripButton_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Help.Name = "toolStripButton_Help";
            this.toolStripButton_Help.Size = new System.Drawing.Size(42, 28);
            this.toolStripButton_Help.Text = "Help..";
            this.toolStripButton_Help.ToolTipText = "Opens the GitHub Readme in your Browser.";
            this.toolStripButton_Help.Click += new System.EventHandler(this.toolStripButton_Help_Click);
            // 
            // toolStripButton1_Donate
            // 
            this.toolStripButton1_Donate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1_Donate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1_Donate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1_Donate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_Donate.Name = "toolStripButton1_Donate";
            this.toolStripButton1_Donate.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1_Donate.Text = "Donate...";
            this.toolStripButton1_Donate.Click += new System.EventHandler(this.toolStripButton1_Donate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbSelectedPaths);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 103);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Paths";
            // 
            // rtbSelectedPaths
            // 
            this.rtbSelectedPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSelectedPaths.Location = new System.Drawing.Point(3, 16);
            this.rtbSelectedPaths.Name = "rtbSelectedPaths";
            this.rtbSelectedPaths.Size = new System.Drawing.Size(756, 84);
            this.rtbSelectedPaths.TabIndex = 1;
            this.rtbSelectedPaths.Text = "";
            // 
            // PathFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(762, 486);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PathFinderForm";
            this.Text = "PathFinder v1.0.0 - generalwrex";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bGoURL;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbInputJson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvOutputViewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBrowseForFile;
        private System.Windows.Forms.Button bGoPath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fbLoadJsonFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Quit;
        private System.Windows.Forms.ToolStripButton toolStripButton_Help;
        private System.Windows.Forms.ToolStripButton toolStripButton_About;
        private System.Windows.Forms.ToolStripButton toolStripButton1_Donate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbSelectedPaths;
    }
}

