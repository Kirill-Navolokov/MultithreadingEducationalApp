using System.IO;
using System.Windows.Forms;

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