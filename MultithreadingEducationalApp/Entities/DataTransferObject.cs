using System;
using System.Linq;
using MultithreadingEducationalApp.Constants;

namespace MultithreadingEducationalApp.Entities
{
	public class DataTransferObject
	{
		public DataTransferObject()
		{
			Bytes = new byte[BytesAmountPerIteration];
			Status = TransferStatus.InProgress;
			StartByte = new ByteInfo { Index = 0 };
			EndByte = new ByteInfo { Index = 0};
		}

		public byte[] Bytes { get; private set; }

		public TransferStatus Status { get; set; }

		public long BytesAmountPerIteration { get; private set; }

		public ByteInfo StartByte { get; private set; }

		public ByteInfo EndByte { get; private set; }

		public void SetTransferParameters(byte[] sourceBytes, long startIndex)
		{
			Array.Copy(sourceBytes, startIndex, Bytes, 0, BytesAmountPerIteration);

			StartByte.Index = startIndex;
			StartByte.Value = sourceBytes[startIndex];

			EndByte.Value = Bytes.Last();
			EndByte.Index = startIndex + BytesAmountPerIteration;
		}
	}
}