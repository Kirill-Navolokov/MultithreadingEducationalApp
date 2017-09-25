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

        private void leftFileBrowserButton_Click(object sender, System.EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            var path = folderBrowser.SelectedPath;
            leftFolderName.Text = path;

            GetAllFiles(path);
        }

        private void GetAllFiles(string path)
        {
            var folder = new DirectoryInfo(path);
            var files = folder.GetFiles();

            foreach (var file in files)
            {
                listBox1.Items.Add(file.Name);
            }
        }
    }
}