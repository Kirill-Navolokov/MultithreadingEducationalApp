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

		public ProgressWindow(string sourceFilePath, string targetFilePath)
		{
			InitializeComponent();

			_waitHandle = new ManualResetEvent(initialState: true);

			PerformDataTransfer(sourceFilePath, targetFilePath);
		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			_waitHandle.Reset();
		}

		private void ContinueButton_Click(object sender, EventArgs e)
		{
			_waitHandle.Set();
		}

		private DataTransferObject PerformDataTransfer(string sourceFilePath, string targetFilePath)
		{
			var dataTransferObject = new DataTransferObject();

			try
			{
				var fileBytes = File.ReadAllBytes(sourceFilePath);
				var transfersCount = fileBytes.Length / dataTransferObject.BytesAmountPerIteration;

				for (var i = 0; i < transfersCount; i++)
				{
					var startIndex = dataTransferObject.EndByte.Index + 1;
					dataTransferObject.SetTransferParameters(fileBytes, startIndex);

					if (dataTransferObject.Bytes.Length == 0)
					{
						dataTransferObject.Status = TransferStatus.Success;

						return dataTransferObject;
					}

					dataTransferObject = TransferData(dataTransferObject);

					if (dataTransferObject.Status == TransferStatus.Failed)
					{
						return dataTransferObject;
					}

					ProgressBar.PerformStep();
					Thread.Sleep(2000);
				}
			}
			catch (Exception e)
			{
				dataTransferObject.Status = TransferStatus.Failed;

				return dataTransferObject;
			}

			dataTransferObject.Status = TransferStatus.Success;

			return dataTransferObject;
		}

		private DataTransferObject TransferData(DataTransferObject dataTransferObject)
		{
			try
			{

			}
			catch (Exception e)
			{
				dataTransferObject.Status = TransferStatus.Failed;

				return dataTransferObject;
			}
			return dataTransferObject;
		}
	}
}