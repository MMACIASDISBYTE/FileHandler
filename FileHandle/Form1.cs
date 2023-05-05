namespace FileHandle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }
        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cboSystemDrives.Items.Add(drive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboSystemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSystemDrives.SelectedItem.ToString();
                DriveInfo diskInfo = new DriveInfo(disk);
                var driveDetails = $@"
                    Drive: {disk} drive:
                    
        Total Size {diskInfo.TotalSize}
        Free space available: {diskInfo.AvailableFreeSpace}
        Format: {diskInfo.DriveFormat}
        Type: {diskInfo.DriveType}
                    ";

                txtSystemDetails.Text = driveDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Please, enter a path for the directory");

                if (!Directory.Exists(txtNewDirectory.Text))
                {
                    Directory.CreateDirectory(txtNewDirectory.Text);
                    MessageBox.Show("Directory created");
                }
                else
                {
                    MessageBox.Show("Please, enter the full path of the new directory");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewSubDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on new Directory");
                if (string.IsNullOrEmpty(txtNewSubDirectory.Text))
                    throw new Exception("Make sure you have included a path for the  new subdirectory");

                var directoryPath = txtNewDirectory.Text;
                var subDirInfor = new DirectoryInfo(directoryPath);
                subDirInfor.CreateSubdirectory(txtNewSubDirectory.Text);
                MessageBox.Show("subDirectory has Been created");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btmShowDirectoryFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on new Directory");

                var directory = txtNewDirectory.Text;
                var directoryInfo = new DirectoryInfo(directory);

                if (!directoryInfo.Exists)
                    throw new Exception("Directory doesn't exist");

                var subDirectories = directoryInfo.GetDirectories();
                foreach (var subDir in subDirectories)
                {
                    if (!cboDirectoryFiles.Items.Contains(subDir.Name))
                        cboDirectoryFiles.Items.Add(subDir.Name);
                }

                var files = directoryInfo.GetFiles("*"); // "*" trae todos los archivos
                foreach (var file in files)
                {
                    if (!cboDirectoryFiles.Items.Contains($"{file.Name}"))
                        cboDirectoryFiles.Items.Add($"{file.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}