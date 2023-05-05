namespace FileHandle
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
            cboSystemDrives = new ComboBox();
            txtSystemDetails = new TextBox();
            label1 = new Label();
            txtNewDirectory = new TextBox();
            btnCreateDirectory = new Button();
            label2 = new Label();
            txtNewSubDirectory = new TextBox();
            btnNewSubDirectory = new Button();
            label3 = new Label();
            cboDirectoryFiles = new ComboBox();
            btmShowDirectoryFiles = new Button();
            SuspendLayout();
            // 
            // cboSystemDrives
            // 
            cboSystemDrives.FormattingEnabled = true;
            cboSystemDrives.Location = new Point(52, 41);
            cboSystemDrives.Name = "cboSystemDrives";
            cboSystemDrives.Size = new Size(335, 28);
            cboSystemDrives.TabIndex = 0;
            cboSystemDrives.SelectedIndexChanged += cboSystemDrives_SelectedIndexChanged;
            // 
            // txtSystemDetails
            // 
            txtSystemDetails.Location = new Point(52, 103);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(336, 282);
            txtSystemDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(434, 39);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 2;
            label1.Text = "New Directory (Include path)";
            // 
            // txtNewDirectory
            // 
            txtNewDirectory.Location = new Point(670, 34);
            txtNewDirectory.Name = "txtNewDirectory";
            txtNewDirectory.Size = new Size(232, 27);
            txtNewDirectory.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(956, 29);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(163, 30);
            btnCreateDirectory.TabIndex = 4;
            btnCreateDirectory.Text = "Create";
            btnCreateDirectory.UseVisualStyleBackColor = true;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(434, 87);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 2;
            label2.Text = "New SubDirectory";
            // 
            // txtNewSubDirectory
            // 
            txtNewSubDirectory.Location = new Point(670, 82);
            txtNewSubDirectory.Name = "txtNewSubDirectory";
            txtNewSubDirectory.Size = new Size(232, 27);
            txtNewSubDirectory.TabIndex = 3;
            // 
            // btnNewSubDirectory
            // 
            btnNewSubDirectory.Location = new Point(956, 77);
            btnNewSubDirectory.Name = "btnNewSubDirectory";
            btnNewSubDirectory.Size = new Size(164, 30);
            btnNewSubDirectory.TabIndex = 5;
            btnNewSubDirectory.Text = "Create SubDirectory";
            btnNewSubDirectory.UseVisualStyleBackColor = true;
            btnNewSubDirectory.Click += btnNewSubDirectory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(434, 132);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 2;
            label3.Text = "Show Directory Details";
            // 
            // cboDirectoryFiles
            // 
            cboDirectoryFiles.FormattingEnabled = true;
            cboDirectoryFiles.Location = new Point(670, 130);
            cboDirectoryFiles.Name = "cboDirectoryFiles";
            cboDirectoryFiles.Size = new Size(232, 28);
            cboDirectoryFiles.TabIndex = 6;
            // 
            // btmShowDirectoryFiles
            // 
            btmShowDirectoryFiles.Location = new Point(955, 127);
            btmShowDirectoryFiles.Name = "btmShowDirectoryFiles";
            btmShowDirectoryFiles.Size = new Size(164, 32);
            btmShowDirectoryFiles.TabIndex = 7;
            btmShowDirectoryFiles.Text = "Show DirectoryFIles";
            btmShowDirectoryFiles.UseVisualStyleBackColor = true;
            btmShowDirectoryFiles.Click += btmShowDirectoryFiles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 589);
            Controls.Add(btmShowDirectoryFiles);
            Controls.Add(cboDirectoryFiles);
            Controls.Add(btnNewSubDirectory);
            Controls.Add(btnCreateDirectory);
            Controls.Add(txtNewSubDirectory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNewDirectory);
            Controls.Add(label1);
            Controls.Add(txtSystemDetails);
            Controls.Add(cboSystemDrives);
            Name = "Form1";
            Text = "FileHandler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSystemDrives;
        private TextBox txtSystemDetails;
        private Label label1;
        private TextBox txtNewDirectory;
        private Button btnCreateDirectory;
        private Label label2;
        private TextBox txtNewSubDirectory;
        private Button btnNewSubDirectory;
        private Label label3;
        private ComboBox cboDirectoryFiles;
        private Button btmShowDirectoryFiles;
    }
}