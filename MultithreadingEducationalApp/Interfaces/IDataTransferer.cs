using System.ComponentModel;
using System.Threading;
using MultithreadingEducationalApp.Constants;

namespace MultithreadingEducationalApp.Interfaces
{
    public interface IDataTransferer
    {
        TransferStatus PerformDataTransfer(string sourceFilePath, string targetFilePath, int operationStepsCount, BackgroundWorker worker, ManualResetEvent locker);
    }
}