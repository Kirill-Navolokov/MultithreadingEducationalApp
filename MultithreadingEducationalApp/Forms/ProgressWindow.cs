using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MultithreadingEducationalApp.Constants;
using MultithreadingEducationalApp.Interfaces;
using MultithreadingEducationalApp.IoC;

namespace MultithreadingEducationalApp.Forms
{
    public partial class ProgressWindow : Form
    {
        private string _sourceFilePath;

        private string _targetFilePath;
        
        private string _folderToReset;
        
        private ListBox _listBoxToReset;

        private BackgroundWorker _worker;

        private TransferStatus _operationStatus;

        private readonly ManualResetEvent _locker;

        private Action<string, ListBox> _resetAction;
        
        private readonly IDataTransferer _dataTransferer;

        private readonly IFileProvider _fileProvider;
        
        public ProgressWindow(string sourceFilePath, string targetFilePath)
        {
            InitializeComponent();

            _sourceFilePath = sourceFilePath;
            _targetFilePath = targetFilePath;

            _dataTransferer = IoCInitializer.Resolve<IDataTransferer>();

            _fileProvider = IoCInitializer.Resolve<IFileProvider>();
            
            _locker = new ManualResetEvent(initialState: true);

            SetUpBackgroundWorker();
        }

        public void SetUpResetAction(string folderToReset, ListBox listBoxToReset, Action<string, ListBox> resetAction)
        {
            _folderToReset = folderToReset;
            _listBoxToReset = listBoxToReset;
            _resetAction = resetAction;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _worker.RunWorkerAsync();
        }

        private void SetUpBackgroundWorker()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += WorkerDoWork;
            _worker.WorkerReportsProgress = true;
            _worker.ProgressChanged += WorkerProgressChanged;
            _worker.RunWorkerCompleted += WorkerRunWorkerCompleted;
        }

        private void WorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TransferSettings.UnRegisterOperation(_targetFilePath);

            if (_operationStatus == TransferStatus.Success)
            {
                _resetAction?.Invoke(_folderToReset, _listBoxToReset);
                Close();

                _fileProvider.SimalateUsersCalculationHash(_targetFilePath);
            }
            else
            {
                if (MessageBox.Show("Try again", "Operation failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    _worker.RunWorkerAsync();
                }
                else
                {
                    File.Delete(_targetFilePath);
                    this.Close();
                }
            }
        }

        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            if (TransferSettings.IsDataTransferAllowed)
            {
                _operationStatus = _dataTransferer.PerformDataTransfer(_sourceFilePath, _targetFilePath, ProgressBar.Step, _worker, _locker);
            }
            else
            {
                MessageBox.Show("All threads are busy at the moment");
            }
        }

        private void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.PerformStep();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _locker.Reset();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            _locker.Set();
        }
    }
}