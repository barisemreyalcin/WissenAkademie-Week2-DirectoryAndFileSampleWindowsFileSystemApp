namespace DirectoryAndFileSample
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFolderPath = new TextBox();
            btnChooseFolder = new Button();
            fbdGetFolder = new FolderBrowserDialog();
            btnGetFolderNames = new Button();
            lvFolderList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            cntMenuDetail = new ContextMenuStrip(components);
            foldersAndFilesToolStripMenuItem = new ToolStripMenuItem();
            cntMenuDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Select Directory";
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(143, 16);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(508, 27);
            txtFolderPath.TabIndex = 1;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(657, 15);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(37, 29);
            btnChooseFolder.TabIndex = 2;
            btnChooseFolder.Text = "...";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // btnGetFolderNames
            // 
            btnGetFolderNames.Location = new Point(582, 56);
            btnGetFolderNames.Name = "btnGetFolderNames";
            btnGetFolderNames.Size = new Size(113, 47);
            btnGetFolderNames.TabIndex = 3;
            btnGetFolderNames.Text = "List Folders";
            btnGetFolderNames.UseVisualStyleBackColor = true;
            btnGetFolderNames.Click += btnGetFolderNames_Click;
            // 
            // lvFolderList
            // 
            lvFolderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFolderList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvFolderList.ContextMenuStrip = cntMenuDetail;
            lvFolderList.FullRowSelect = true;
            lvFolderList.GridLines = true;
            lvFolderList.Location = new Point(23, 120);
            lvFolderList.Name = "lvFolderList";
            lvFolderList.Size = new Size(671, 258);
            lvFolderList.TabIndex = 4;
            lvFolderList.UseCompatibleStateImageBehavior = false;
            lvFolderList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Folder Name";
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Folder Path";
            columnHeader3.Width = 450;
            // 
            // cntMenuDetail
            // 
            cntMenuDetail.ImageScalingSize = new Size(20, 20);
            cntMenuDetail.Items.AddRange(new ToolStripItem[] { foldersAndFilesToolStripMenuItem });
            cntMenuDetail.Name = "cntMenuStrip";
            cntMenuDetail.Size = new Size(211, 56);
            cntMenuDetail.Opening += cntMenuDetail_Opening;
            cntMenuDetail.Click += cntMenuDetail_Click;
            // 
            // foldersAndFilesToolStripMenuItem
            // 
            foldersAndFilesToolStripMenuItem.Name = "foldersAndFilesToolStripMenuItem";
            foldersAndFilesToolStripMenuItem.Size = new Size(210, 24);
            foldersAndFilesToolStripMenuItem.Text = "Folders and Files";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 401);
            Controls.Add(lvFolderList);
            Controls.Add(btnGetFolderNames);
            Controls.Add(btnChooseFolder);
            Controls.Add(txtFolderPath);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            cntMenuDetail.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFolderPath;
        private Button btnChooseFolder;
        private FolderBrowserDialog fbdGetFolder;
        private Button btnGetFolderNames;
        private ListView lvFolderList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ContextMenuStrip cntMenuDetail;
        private ToolStripMenuItem foldersAndFilesToolStripMenuItem;
    }
}