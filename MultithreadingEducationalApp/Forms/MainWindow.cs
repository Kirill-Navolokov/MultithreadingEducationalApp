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
            var targetPath = GetTargetPathFromDialog();

            LeftFolderName.Text = targetPath;

            ResetTargetFolder(targetPath, LeftFilesList);
        }

        private void RightFolderBrowserButton_Click(object sender, System.EventArgs e)
        {
            var targetPath = GetTargetPathFromDialog();

            RightFolderName.Text = targetPath;

            ResetTargetFolder(targetPath, RightFilesList);
        }

        private void LeftCopyButton_Click(object sender, System.EventArgs e)
        {
            var selectedFile = LeftFilesList.SelectedItem;

            if (selectedFile != null)
            {
                var fileName = selectedFile.ToString();
                var sourcePath = GetSourcePath(selectedFile);

                var targetDirectory = RightFolderName.Text;
                var targetPath = Path.Combine(targetDirectory, fileName);

                CopyFile(sourcePath, targetPath, RightFolderName.Text, RightFilesList);
            }
        }

        private void RightDeleteButton_Click(object sender, System.EventArgs e)
        {
            var selectedFile = RightFilesList.SelectedItem;

            if (selectedFile != null)
            {
                var sourcePath = GetSourcePath(selectedFile);

                File.Delete(sourcePath);
                ResetTargetFolder(RightFolderName.Text, RightFilesList);
            }
        }

        private void CopyFile(string sourcePath, string targetPath, string folderToReset, ListBox listBoxToReset)
        {
            var operationWindow = new ProgressWindow(sourcePath, targetPath);
            operationWindow.SetUpResetAction(folderToReset, listBoxToReset, ResetTargetFolder);

            operationWindow.Show();
        }

        private void ResetTargetFolder(string targerDirectory, ListBox targetListBox)
        {
            _fileProvider.SetListBoxContent(targerDirectory, targetListBox);
        }

        private string GetSourcePath(object selectedFile)
        {
            var fileName = selectedFile.ToString();
            var sourceDirectory = RightFolderName.Text;
            var sourcePath = Path.Combine(sourceDirectory, fileName);

            return sourcePath;

        }

        private string GetTargetPathFromDialog()
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            return folderBrowser.SelectedPath;
        }
    }
}