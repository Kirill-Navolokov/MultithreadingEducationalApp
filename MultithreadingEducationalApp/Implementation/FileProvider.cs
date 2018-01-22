using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultithreadingEducationalApp.Interfaces;

namespace MultithreadingEducationalApp.Implementation
{
    public class FileProvider : IFileProvider
    {
        private const int NumberOfUsers = 10;
        
        private string _filePath;

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

        public void SimalateUsersCalculationHash(string filePath)
        {
            _filePath = filePath;

            var actions = new Action[NumberOfUsers]
            {
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath),
                () => CalculateFileHash(_filePath)
            };
            var parralelOptions = new ParallelOptions { MaxDegreeOfParallelism = 3 };

            Parallel.Invoke(parralelOptions, actions);
        }
        
        private void CalculateFileHash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    var stringHash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

                    MessageBox.Show($"{stringHash}");
                }
            }
        }
    }
}