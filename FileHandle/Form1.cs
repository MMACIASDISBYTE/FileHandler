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
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Please, enter a path for the directory");

                if (!Directory.Exists(txtNewFile.Text))
                {
                    Directory.CreateDirectory(txtNewFile.Text);
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
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a directory path on new Directory");
                if (string.IsNullOrEmpty(txtNewSubDirectory.Text))
                    throw new Exception("Make sure you have included a path for the  new subdirectory");

                var directoryPath = txtNewFile.Text;
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
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a directory path on new Directory");

                var directory = txtNewFile.Text;
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

        private void btnCopyDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCopyDirectorySource.Text) || string.IsNullOrEmpty(txtCopyDirectoryDestination.Text))
                    throw new Exception("Source and Destination fiels should have values");

                var sourceDirectory = new DirectoryInfo(txtCopyDirectorySource.Text);
                var sourceDestination = new DirectoryInfo(txtCopyDirectoryDestination.Text);
                CopyDirectory(sourceDirectory, sourceDestination);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopyDirectory(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {
            try
            {
                if (!sourceDirectory.Exists)
                    throw new Exception("Source directory doesn't exist");
                if (!destinationDirectory.Exists)
                    destinationDirectory.Create();

                var files = sourceDirectory.GetFiles();
                foreach (var file in files)
                {
                    file.CopyTo(Path.Combine(destinationDirectory.FullName, file.Name));
                }

                var directories = sourceDirectory.GetDirectories();
                foreach (var directory in directories)
                {
                    string destination = Path.Combine(destinationDirectory.FullName, directory.Name);
                    CopyDirectory(directory, new DirectoryInfo(destination));
                }
                MessageBox.Show("Directory copied successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a path for the New File");

                if (!File.Exists(txtNewFile.Text))
                {
                    File.Create(txtNewFile.Text);
                    MessageBox.Show("File Created");
                }
                else
                {
                    MessageBox.Show("Please enter the full path of the new File");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSelectedFile.Text = openFileDialog.FileName;
                    txtRanemeName.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                var source = txtSelectedFile.Text;
                var destination = txtRanemeName.Text;

                var sourceFileInfo = new FileInfo(source);
                if(sourceFileInfo.Exists)
                {
                    sourceFileInfo.MoveTo(destination);
                    MessageBox.Show("The file has been renamed");
                }
                else
                {
                    MessageBox.Show("Error when traying to rename the file. Is the path correct?");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}