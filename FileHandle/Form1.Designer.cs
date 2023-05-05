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
            txtNewFile = new TextBox();
            btnCreateDirectory = new Button();
            label2 = new Label();
            txtNewSubDirectory = new TextBox();
            btnNewSubDirectory = new Button();
            label3 = new Label();
            cboDirectoryFiles = new ComboBox();
            btmShowDirectoryFiles = new Button();
            panel1 = new Panel();
            btnCopyDirectory = new Button();
            txtCopyDirectoryDestination = new TextBox();
            txtCopyDirectorySource = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnNewFile = new Button();
            label7 = new Label();
            txtSelectedFile = new TextBox();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog = new OpenFileDialog();
            label8 = new Label();
            txtRanemeName = new TextBox();
            btnRenameFile = new Button();
            Write = new Label();
            txtWrite = new TextBox();
            txtRead = new TextBox();
            label10 = new Label();
            txtFind = new TextBox();
            label11 = new Label();
            txtUpdate = new TextBox();
            label12 = new Label();
            btnWrite = new Button();
            btnRead = new Button();
            btnFind = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboSystemDrives
            // 
            cboSystemDrives.FormattingEnabled = true;
            cboSystemDrives.Location = new Point(52, 12);
            cboSystemDrives.Name = "cboSystemDrives";
            cboSystemDrives.Size = new Size(335, 28);
            cboSystemDrives.TabIndex = 0;
            cboSystemDrives.SelectedIndexChanged += cboSystemDrives_SelectedIndexChanged;
            // 
            // txtSystemDetails
            // 
            txtSystemDetails.Location = new Point(51, 62);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(336, 244);
            txtSystemDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 331);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 2;
            label1.Text = "New File (Include path)";
            // 
            // txtNewFile
            // 
            txtNewFile.Location = new Point(669, 326);
            txtNewFile.Name = "txtNewFile";
            txtNewFile.Size = new Size(232, 27);
            txtNewFile.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(955, 14);
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
            label2.Location = new Point(433, 72);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 2;
            label2.Text = "New SubDirectory";
            // 
            // txtNewSubDirectory
            // 
            txtNewSubDirectory.Location = new Point(669, 67);
            txtNewSubDirectory.Name = "txtNewSubDirectory";
            txtNewSubDirectory.Size = new Size(232, 27);
            txtNewSubDirectory.TabIndex = 3;
            // 
            // btnNewSubDirectory
            // 
            btnNewSubDirectory.Location = new Point(955, 62);
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
            label3.Location = new Point(433, 117);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 2;
            label3.Text = "Show Directory Details";
            // 
            // cboDirectoryFiles
            // 
            cboDirectoryFiles.FormattingEnabled = true;
            cboDirectoryFiles.Location = new Point(669, 115);
            cboDirectoryFiles.Name = "cboDirectoryFiles";
            cboDirectoryFiles.Size = new Size(232, 28);
            cboDirectoryFiles.TabIndex = 6;
            // 
            // btmShowDirectoryFiles
            // 
            btmShowDirectoryFiles.Location = new Point(954, 112);
            btmShowDirectoryFiles.Name = "btmShowDirectoryFiles";
            btmShowDirectoryFiles.Size = new Size(164, 32);
            btmShowDirectoryFiles.TabIndex = 7;
            btmShowDirectoryFiles.Text = "Show DirectoryFIles";
            btmShowDirectoryFiles.UseVisualStyleBackColor = true;
            btmShowDirectoryFiles.Click += btmShowDirectoryFiles_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyDirectory);
            panel1.Controls.Add(txtCopyDirectoryDestination);
            panel1.Controls.Add(txtCopyDirectorySource);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(441, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 156);
            panel1.TabIndex = 8;
            // 
            // btnCopyDirectory
            // 
            btnCopyDirectory.Location = new Point(514, 58);
            btnCopyDirectory.Name = "btnCopyDirectory";
            btnCopyDirectory.Size = new Size(147, 75);
            btnCopyDirectory.TabIndex = 5;
            btnCopyDirectory.Text = "Copy";
            btnCopyDirectory.UseVisualStyleBackColor = true;
            btnCopyDirectory.Click += btnCopyDirectory_Click;
            // 
            // txtCopyDirectoryDestination
            // 
            txtCopyDirectoryDestination.Location = new Point(228, 106);
            txtCopyDirectoryDestination.Name = "txtCopyDirectoryDestination";
            txtCopyDirectoryDestination.Size = new Size(232, 27);
            txtCopyDirectoryDestination.TabIndex = 4;
            // 
            // txtCopyDirectorySource
            // 
            txtCopyDirectorySource.Location = new Point(228, 58);
            txtCopyDirectorySource.Name = "txtCopyDirectorySource";
            txtCopyDirectorySource.Size = new Size(232, 27);
            txtCopyDirectorySource.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 10);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 2;
            label4.Text = "Copy Directory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 113);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 2;
            label6.Text = "Destination";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 58);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 2;
            label5.Text = "Source";
            // 
            // btnNewFile
            // 
            btnNewFile.Location = new Point(955, 322);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(147, 33);
            btnNewFile.TabIndex = 9;
            btnNewFile.Text = "Create FIle";
            btnNewFile.UseVisualStyleBackColor = true;
            btnNewFile.Click += btnNewFile_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 376);
            label7.Name = "label7";
            label7.Size = new Size(172, 20);
            label7.TabIndex = 2;
            label7.Text = "New File (Include path)";
            // 
            // txtSelectedFile
            // 
            txtSelectedFile.Location = new Point(205, 373);
            txtSelectedFile.Name = "txtSelectedFile";
            txtSelectedFile.Size = new Size(197, 27);
            txtSelectedFile.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(423, 371);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(108, 30);
            btnOpenFile.TabIndex = 10;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 419);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Rename";
            // 
            // txtRanemeName
            // 
            txtRanemeName.Location = new Point(205, 416);
            txtRanemeName.Name = "txtRanemeName";
            txtRanemeName.Size = new Size(197, 27);
            txtRanemeName.TabIndex = 3;
            // 
            // btnRenameFile
            // 
            btnRenameFile.Location = new Point(423, 414);
            btnRenameFile.Name = "btnRenameFile";
            btnRenameFile.Size = new Size(108, 30);
            btnRenameFile.TabIndex = 11;
            btnRenameFile.Text = "Rename";
            btnRenameFile.UseVisualStyleBackColor = true;
            btnRenameFile.Click += btnRenameFile_Click;
            // 
            // Write
            // 
            Write.AutoSize = true;
            Write.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Write.Location = new Point(125, 465);
            Write.Name = "Write";
            Write.Size = new Size(48, 20);
            Write.TabIndex = 2;
            Write.Text = "Write";
            // 
            // txtWrite
            // 
            txtWrite.Location = new Point(53, 502);
            txtWrite.Multiline = true;
            txtWrite.Name = "txtWrite";
            txtWrite.Size = new Size(198, 138);
            txtWrite.TabIndex = 1;
            // 
            // txtRead
            // 
            txtRead.Location = new Point(330, 502);
            txtRead.Multiline = true;
            txtRead.Name = "txtRead";
            txtRead.Size = new Size(198, 138);
            txtRead.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(401, 465);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 2;
            label10.Text = "Read";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(633, 502);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(198, 138);
            txtFind.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(709, 465);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 2;
            label11.Text = "Find";
            // 
            // txtUpdate
            // 
            txtUpdate.Location = new Point(902, 502);
            txtUpdate.Multiline = true;
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(198, 138);
            txtUpdate.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(969, 465);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 2;
            label12.Text = "Update";
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(106, 660);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(95, 40);
            btnWrite.TabIndex = 12;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(379, 660);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(95, 40);
            btnRead.TabIndex = 13;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(683, 660);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(95, 40);
            btnFind.TabIndex = 14;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(953, 660);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 751);
            Controls.Add(btnUpdate);
            Controls.Add(btnFind);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(btnRenameFile);
            Controls.Add(btnOpenFile);
            Controls.Add(btnNewFile);
            Controls.Add(panel1);
            Controls.Add(btmShowDirectoryFiles);
            Controls.Add(cboDirectoryFiles);
            Controls.Add(btnNewSubDirectory);
            Controls.Add(btnCreateDirectory);
            Controls.Add(txtNewSubDirectory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRanemeName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Write);
            Controls.Add(label8);
            Controls.Add(txtSelectedFile);
            Controls.Add(txtUpdate);
            Controls.Add(label7);
            Controls.Add(txtFind);
            Controls.Add(txtNewFile);
            Controls.Add(txtRead);
            Controls.Add(label1);
            Controls.Add(txtWrite);
            Controls.Add(txtSystemDetails);
            Controls.Add(cboSystemDrives);
            Name = "Form1";
            Text = "FileHandler";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSystemDrives;
        private TextBox txtSystemDetails;
        private Label label1;
        private TextBox txtNewFile;
        private Button btnCreateDirectory;
        private Label label2;
        private TextBox txtNewSubDirectory;
        private Button btnNewSubDirectory;
        private Label label3;
        private ComboBox cboDirectoryFiles;
        private Button btmShowDirectoryFiles;
        private Panel panel1;
        private TextBox txtCopyDirectoryDestination;
        private TextBox txtCopyDirectorySource;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button btnCopyDirectory;
        private Button btnNewFile;
        private Label label7;
        private TextBox txtSelectedFile;
        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog;
        private Label label8;
        private TextBox txtRanemeName;
        private Button btnRenameFile;
        private Label Write;
        private TextBox txtWrite;
        private TextBox txtRead;
        private Label label10;
        private TextBox txtFind;
        private Label label11;
        private TextBox txtUpdate;
        private Label label12;
        private Button btnWrite;
        private Button btnRead;
        private Button btnFind;
        private Button btnUpdate;
    }
}