using System.IO;
using System.Windows.Forms;
using MultithreadingEducationalApp.Interfaces;

namespace MultithreadingEducationalApp.Implementation
{
    public class FileProvider : IFileProvider
    {
        public void SetListBoxContent(string directoryPath, ListBox listBox)
        {
            if (!string.IsNullOrEmpty(directoryPath))
            {
                listBox.Items.Clear();

                var folder = new DirectoryInfo(directoryPath);
                var files = folder.GetFiles();

                foreach (var file in files)
                {
                    listBox.Items.Add(file.Name);
                }
            }
        }
    }
}