using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using MultithreadingEducationalApp.Constants;
using MultithreadingEducationalApp.Entities;
using MultithreadingEducationalApp.Interfaces;

namespace MultithreadingEducationalApp.Implementation
{
    public class DataTransferer : IDataTransferer
    {
        public TransferStatus PerformDataTransfer(string sourceFilePath, string targetFilePath, int operationStepsCount, BackgroundWorker worker,  ManualResetEvent locker)
        {
            var dataTransferObject = new DataTransferObject();

            TransferSettings.RegisterOperation(targetFilePath);

            try
            {
                var fileBytes = File.ReadAllBytes(sourceFilePath);
                dataTransferObject.BytesAmountPerTransfer = (int)Math.Ceiling((double)fileBytes.Length / operationStepsCount);

                for (var i = 0; i < operationStepsCount; i++)
                {
                    locker.WaitOne();

                    var startIndex = i == 0 ? 0 : dataTransferObject.EndByte.Index + 1;
                    dataTransferObject.SetTransferParameters(fileBytes, startIndex);

                    dataTransferObject = TransferData(targetFilePath, dataTransferObject);

                    if (CheckForOperationError(dataTransferObject.Status))
                    {
                        return dataTransferObject.Status;
                    }
                    
                    worker.ReportProgress(i);

                    if (CheckForOperationSuccess(dataTransferObject))
                    {
                        return dataTransferObject.Status;
                    }

                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                dataTransferObject.Status = TransferStatus.Failed;
            }

            dataTransferObject.Status = TransferStatus.Success;

            return dataTransferObject.Status;
        }

        private bool CheckForOperationError(TransferStatus status)
        {
            return status == TransferStatus.Failed;
        }

        private bool CheckForOperationSuccess(DataTransferObject dataTransferObject)
        {
            if (dataTransferObject.Bytes.Length < dataTransferObject.BytesAmountPerTransfer)
            {
                dataTransferObject.Status = TransferStatus.Success;

                return true;
            }

            return false;
        }

        private DataTransferObject TransferData(string targetFilePath, DataTransferObject dataTransferObject)
        {
            try
            {
                using (var stream = new FileStream(targetFilePath, FileMode.Append))
                {
                    stream.Write(dataTransferObject.Bytes, 0, dataTransferObject.Bytes.Length);
                }
            }
            catch (Exception e)
            {
                dataTransferObject.Status = TransferStatus.Failed;
            }

            return dataTransferObject;
        }
    }
}