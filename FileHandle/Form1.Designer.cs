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
            txtSystemDetails.Location = new Point(51, 103);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(336, 211);
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
            txtNewDirectory.Size = new Size(178, 27);
            txtNewDirectory.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(882, 31);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(134, 30);
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
            txtNewSubDirectory.Size = new Size(178, 27);
            txtNewSubDirectory.TabIndex = 3;
            // 
            // btnNewSubDirectory
            // 
            btnNewSubDirectory.Location = new Point(882, 80);
            btnNewSubDirectory.Name = "btnNewSubDirectory";
            btnNewSubDirectory.Size = new Size(163, 29);
            btnNewSubDirectory.TabIndex = 5;
            btnNewSubDirectory.Text = "Create SubDirectory";
            btnNewSubDirectory.UseVisualStyleBackColor = true;
            btnNewSubDirectory.Click += btnNewSubDirectory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 450);
            Controls.Add(btnNewSubDirectory);
            Controls.Add(btnCreateDirectory);
            Controls.Add(txtNewSubDirectory);
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
    }
}