using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultithreadingEducationalApp.Constants;
using MultithreadingEducationalApp.Forms;

namespace MultithreadingEducationalApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LeftFileBrowserButton_Click(object sender, System.EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            var path = folderBrowser.SelectedPath;

            LeftFolderName.Text = path;

            GetAllFiles(path, LeftFilesList);
        }

        private void RightFolderBrowserButton_Click(object sender, System.EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            var path = folderBrowser.SelectedPath;

            RightFolderName.Text = path;

            GetAllFiles(path, RightFilesList);
        }

        private void LeftCopyButton_Click(object sender, System.EventArgs e)
        {
            var fileName = LeftFilesList.SelectedItem.ToString();
            var sourceDirectory = LeftFolderName.Text;
            var sourcePath = Path.Combine(sourceDirectory, fileName);

            var targetDirectory = RightFolderName.Text;
            var targetPath = Path.Combine(targetDirectory, fileName);

            CopyFile(sourcePath, targetPath);

            ReloadFileListWindow(RightFolderName.Text, RightFilesList);
        }

        private void RightCopyButton_Click(object sender, System.EventArgs e)
        {
            var fileName = RightFilesList.SelectedItem.ToString();
            var sourceDirectory = RightFolderName.Text;
            var sourcePath = Path.Combine(sourceDirectory, fileName);

            var targetDirectory = LeftFolderName.Text;
            var targetPath = Path.Combine(targetDirectory, fileName);

            CopyFile(sourcePath, targetPath);

            ReloadFileListWindow(LeftFolderName.Text, LeftFilesList);
        }

        private void CopyFile(string sourcePath, string targetPath)
        {
            var operationProgress = new ProgressWindow(sourcePath, targetPath);
            operationProgress.Show();
            var result = operationProgress.PerformDataTransfer();

            if (result == TransferStatus.Success)
            {
                operationProgress.Close();
            }
        }

        private void ReloadFileListWindow(string directoryPath, ListBox requiredListBox)
        {
            requiredListBox.Items.Clear();

            GetAllFiles(directoryPath, requiredListBox);
        }

        private void GetAllFiles(string path, ListBox listBox)
        {
            var folder = new DirectoryInfo(path);
            var files = folder.GetFiles();

            foreach (var file in files)
            {
                listBox.Items.Add(file.Name);
            }
        }
    }
}