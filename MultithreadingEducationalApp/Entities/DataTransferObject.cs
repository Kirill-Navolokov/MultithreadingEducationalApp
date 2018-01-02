using System;
using System.Linq;
using MultithreadingEducationalApp.Constants;

namespace MultithreadingEducationalApp.Entities
{
	public class DataTransferObject
	{
        private int _bytesAmountPerTransfer;

        public DataTransferObject()
		{
			Status = TransferStatus.InProgress;
			StartByte = new ByteInfo { Index = 0 };
			EndByte = new ByteInfo { Index = 0};
		}

		public byte[] Bytes { get; private set; }

		public TransferStatus Status { get; set; }

        public int BytesAmountPerTransfer
        {
            get
            {
                return _bytesAmountPerTransfer;
            }
            set
            {
                _bytesAmountPerTransfer = value;
                Bytes = new byte[_bytesAmountPerTransfer];
            }
        }

        public ByteInfo StartByte { get; private set; }

		public ByteInfo EndByte { get; private set; }

		public void SetTransferParameters(byte[] sourceBytes, long startIndex)
		{
            if (sourceBytes.Length - startIndex > BytesAmountPerTransfer)
            {
                Array.Copy(sourceBytes, startIndex, Bytes, 0, BytesAmountPerTransfer);
            }
            else
            {
                Bytes = new byte[sourceBytes.Length - startIndex];
                Array.Copy(sourceBytes, startIndex, Bytes, 0, Bytes.Length);
            }
            
            StartByte.Index = startIndex;
			StartByte.Value = sourceBytes[startIndex];

			EndByte.Value = Bytes.Last();
			EndByte.Index = startIndex + Bytes.Length;
		}
	}
}