using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using MultithreadingEducationalApp.Interfaces;

namespace MultithreadingEducationalApp.Implementation
{
    public class FileProvider : IFileProvider
    {
        private const int NumberOfUsers = 10;

        private int _usersInWork = 0;

        private string _filePath;

        private object _locker = new object();
        
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
            StartThreads();
        }

        private void StartThreads()
        {
            for (var i = 0; i < NumberOfUsers; i++)
            {
                var thread = new Thread(() => CalculateFileHash(_filePath));
                thread.Name = i.ToString();
                thread.Start();
            }
        }

        private void CalculateFileHash(string filePath)
        {
            StandInQueue();

            if (_usersInWork < 4)
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        var hash = md5.ComputeHash(stream);
                        var stringHash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

                        MessageBox.Show($"{stringHash}-{Thread.CurrentThread.Name}");

                        _usersInWork--;
                    }
                }
            }
        }

        private void StandInQueue()
        {
            lock (_locker)
            {
                if (_usersInWork < 3)
                {
                    _usersInWork++;
                }
            }
        }
    }
}