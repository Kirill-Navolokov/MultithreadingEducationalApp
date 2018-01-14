using System.Windows.Forms;

namespace MultithreadingEducationalApp.Interfaces
{
    public interface IFileProvider
    {
        void SetListBoxContent(string directoryPath, ListBox listBox);
    }
}