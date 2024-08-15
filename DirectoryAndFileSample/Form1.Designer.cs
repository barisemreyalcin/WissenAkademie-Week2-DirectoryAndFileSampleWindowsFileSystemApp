namespace DirectoryAndFileSample
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
            btnDriveInfo = new Button();
            btnDirectoryInfo = new Button();
            btnDirectoryOperations = new Button();
            btnMoveDirectory = new Button();
            btnMoveFİle = new Button();
            SuspendLayout();
            // 
            // btnDriveInfo
            // 
            btnDriveInfo.Location = new Point(22, 22);
            btnDriveInfo.Name = "btnDriveInfo";
            btnDriveInfo.Size = new Size(111, 45);
            btnDriveInfo.TabIndex = 0;
            btnDriveInfo.Text = "Drive Info";
            btnDriveInfo.UseVisualStyleBackColor = true;
            btnDriveInfo.Click += btnDriveInfo_Click;
            // 
            // btnDirectoryInfo
            // 
            btnDirectoryInfo.Location = new Point(154, 22);
            btnDirectoryInfo.Name = "btnDirectoryInfo";
            btnDirectoryInfo.Size = new Size(131, 45);
            btnDirectoryInfo.TabIndex = 1;
            btnDirectoryInfo.Text = "Directory Info";
            btnDirectoryInfo.UseVisualStyleBackColor = true;
            btnDirectoryInfo.Click += btnDirectoryInfo_Click;
            // 
            // btnDirectoryOperations
            // 
            btnDirectoryOperations.Location = new Point(306, 22);
            btnDirectoryOperations.Name = "btnDirectoryOperations";
            btnDirectoryOperations.Size = new Size(168, 45);
            btnDirectoryOperations.TabIndex = 2;
            btnDirectoryOperations.Text = "Directory Operations";
            btnDirectoryOperations.UseVisualStyleBackColor = true;
            btnDirectoryOperations.Click += btnDirectoryOperations_Click;
            // 
            // btnMoveDirectory
            // 
            btnMoveDirectory.Location = new Point(492, 22);
            btnMoveDirectory.Name = "btnMoveDirectory";
            btnMoveDirectory.Size = new Size(124, 45);
            btnMoveDirectory.TabIndex = 3;
            btnMoveDirectory.Text = "Move Directory";
            btnMoveDirectory.UseVisualStyleBackColor = true;
            btnMoveDirectory.Click += btnMoveDirectory_Click;
            // 
            // btnMoveFİle
            // 
            btnMoveFİle.Location = new Point(638, 22);
            btnMoveFİle.Name = "btnMoveFİle";
            btnMoveFİle.Size = new Size(100, 45);
            btnMoveFİle.TabIndex = 4;
            btnMoveFİle.Text = "Move File";
            btnMoveFİle.UseVisualStyleBackColor = true;
            btnMoveFİle.Click += btnMoveFİle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMoveFİle);
            Controls.Add(btnMoveDirectory);
            Controls.Add(btnDirectoryOperations);
            Controls.Add(btnDirectoryInfo);
            Controls.Add(btnDriveInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDriveInfo;
        private Button btnDirectoryInfo;
        private Button btnDirectoryOperations;
        private Button btnMoveDirectory;
        private Button btnMoveFİle;
    }
}
