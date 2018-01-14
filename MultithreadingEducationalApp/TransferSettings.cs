using System.Collections.Generic;

namespace MultithreadingEducationalApp
{
    public class TransferSettings
    {
        private const int MaxTransfersCount = 5;

        private static object _locker = new object();
        
        private static List<string> _files = new List<string>(MaxTransfersCount);
        
        public static void RegisterOperation(string filePath)
        {
            lock (_locker)
            {
                _files.Add(filePath);
            }
        }

        public static void UnRegisterOperation(string filePath)
        {
            lock (_locker)
            {
                _files.Remove(filePath);
            }
        }

        public static bool IsDataTransferAllowed => _files.Count == MaxTransfersCount;
    }
}