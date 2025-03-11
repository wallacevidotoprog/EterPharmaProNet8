namespace EterPharmaPro.Utils
{
	public class BackupFile
	{
		private string fileName;
		private byte[] data;
		public BackupFile(string _file)
		{
			fileName = _file;
			_ = SetBackup();
		}
		private async Task SetBackup()
		{
			if (File.Exists(fileName))
			{
				data = File.ReadAllBytes(fileName);
			}
		}

		public async Task RestoreBackup()
		{
			if (data != null)
			{
				if (File.Exists(fileName))
				{
					File.Delete(fileName);
				}
				await File.WriteAllBytesAsync(fileName, data);
			}

		}
	}
}
