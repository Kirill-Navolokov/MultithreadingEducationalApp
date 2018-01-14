using System.IO;
using System.Windows.Forms;
using MultithreadingEducationalApp.Forms;
using MultithreadingEducationalApp.Interfaces;

namespace MultithreadingEducationalApp
{
    public partial class MainWindow : Form
    {
        private readonly IFileProvider _fileProvider;

        public MainWindow(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;

            InitializeComponent();
        }

        private void LeftFileBrowserButton_Click(object sender, System.EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            var targetPath = folderBrowser.SelectedPath;

            LeftFolderName.Text = targetPath;
            
            ResetTargetFolder(targetPath, LeftFilesList);
        }

        private void RightFolderBrowserButton_Click(object sender, System.EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            var targetPath = folderBrowser.SelectedPath;

            RightFolderName.Text = targetPath;

            ResetTargetFolder(targetPath, RightFilesList);
        }

        private void LeftCopyButton_Click(object sender, System.EventArgs e)
        {
            var selectedFile = LeftFilesList.SelectedItem;

            if (selectedFile != null)
            {
                var fileName = selectedFile.ToString();
                var sourceDirectory = LeftFolderName.Text;
                var sourcePath = Path.Combine(sourceDirectory, fileName);

                var targetDirectory = RightFolderName.Text;
                var targetPath = Path.Combine(targetDirectory, fileName);
                
                CopyFile(sourcePath, targetPath, RightFolderName.Text, RightFilesList);
            }
        }

        private void RightCopyButton_Click(object sender, System.EventArgs e)
        {
            var fileName = RightFilesList.SelectedItem.ToString();
            var sourceDirectory = RightFolderName.Text;
            var sourcePath = Path.Combine(sourceDirectory, fileName);

            var targetDirectory = LeftFolderName.Text;
            var targetPath = Path.Combine(targetDirectory, fileName);

            //CopyFile(sourcePath, targetPath);

            _fileProvider.SetListBoxContent(LeftFolderName.Text, LeftFilesList);
        }

        private void CopyFile(string sourcePath, string targetPath, string folderToReset, ListBox listBoxToReset)
        {
            var operationWindow = new ProgressWindow(sourcePath, targetPath);
            operationWindow.SetUpResetAction(folderToReset, listBoxToReset, ResetTargetFolder);
            operationWindow.Show();
        }

        private void RightDeleteButton_Click(object sender, System.EventArgs e)
        {
            var selectedFile = RightFilesList.SelectedItem;

            if (selectedFile != null)
            {
                var fileName = selectedFile.ToString();
                var sourceDirectory = RightFolderName.Text;
                var sourcePath = Path.Combine(sourceDirectory, fileName);

                File.Delete(sourcePath);
                _fileProvider.SetListBoxContent(RightFolderName.Text, RightFilesList);
            }
        }
        
        private void ResetTargetFolder(string targerDirectory, ListBox targetListBox)
        {
            _fileProvider.SetListBoxContent(targerDirectory, targetListBox);
        }
    }
}