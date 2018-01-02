using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MultithreadingEducationalApp.Constants;
using MultithreadingEducationalApp.Entities;

namespace MultithreadingEducationalApp.Forms
{
    public partial class ProgressWindow : Form
    {
        private Thread _mainThread;

        private readonly EventWaitHandle _waitHandle;

        private string _sourceFilePath;

        private string _targetFilePath;

        public ProgressWindow(string sourceFilePath, string targetFilePath)
        {
            InitializeComponent();

            _waitHandle = new ManualResetEvent(initialState: true);

            _sourceFilePath = sourceFilePath;
            _targetFilePath = targetFilePath;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _waitHandle.Reset();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            _waitHandle.Set();
        }

        public TransferStatus PerformDataTransfer()
        {
            var dataTransferObject = new DataTransferObject();

            try
            {
                var fileBytes = File.ReadAllBytes(_sourceFilePath);
                dataTransferObject.BytesAmountPerTransfer = (int)Math.Ceiling((double)fileBytes.Length / ProgressBar.Step);

                for (var i = 0; i < ProgressBar.Step; i++)
                {
                    var startIndex = i == 0 ? 0 : dataTransferObject.EndByte.Index + 1;
                    dataTransferObject.SetTransferParameters(fileBytes, startIndex);

                    dataTransferObject = TransferData(_targetFilePath, dataTransferObject);

                    if (CheckForOperationError(dataTransferObject.Status))
                    {
                        return dataTransferObject.Status;
                    }

                    ProgressBar.PerformStep();

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
    }
}