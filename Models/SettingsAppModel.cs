using EterPharmaPro.Utils;
using EterPharmaPro.Utils.Extencions;
using System.Xml.Serialization;

namespace EterPharmaPro.Models
{
	[Serializable]
	public class SettingsAppModel
	{
		[XmlIgnore]
		public string fileName { get; private set; } = $@"{Directory.GetCurrentDirectory()}\DADOS\SettingsApp.xml";
		public SettingsAppModel()
		{
			//string pcname = System.Net.Dns.GetHostName();

			//settingsPoint = POINTS.FirstOrDefault(c => c.NAMEPC == pcname);
		}

		public int NUMBERSTORE { get; set; }

		[XmlIgnore]
		public SettingsPoint settingsPoint { get; set; }

		public List<SettingsPoint> POINTS { get; set; }

		public async Task<SettingsAppModel> CreateAsync()
		{
			SettingsAppModel settings = new SettingsAppModel();
			if (!File.Exists(fileName))
			{
				return settings;
			}
			settings = await SetSettings.DeserializePessoaFromXmlAsync(fileName);
			settings.SetProps();
			return settings;
		}
		private void SetProps()
		{
			string NAME = System.Net.Dns.GetHostName();
			settingsPoint = POINTS.FirstOrDefault(x => x.NAMEPC == NAME);
		}

		public async Task<bool> SaveAsync()
		{
			bool temp = await SetSettings.SerializeToXmlFileAsync(this);
			SetProps();
			return temp;
		}


	}

	public class SettingsPoint
	{
		public string NAMEPC { get; set; }

		public string PRINT_DEFAULT { get; set; }
		public string PRINT_TERMAL { get; set; }
	}


	internal static class SetSettings
	{

		public static async Task<SettingsAppModel> DeserializePessoaFromXmlAsync(string fileName)
		{
			try
			{


				XmlSerializer serializer = new XmlSerializer(typeof(SettingsAppModel));
				SettingsAppModel validade = new SettingsAppModel();
				using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
				{
					validade = (SettingsAppModel)await Task.Run(() => serializer.Deserialize(fs));
					fs.Close();
				}
				return validade;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return null;
			}

		}
		public static async Task<bool> SerializeToXmlFileAsync(SettingsAppModel obj)
		{
			BackupFile bk = new BackupFile(obj.fileName); ;
			try
			{
				if (File.Exists(obj.fileName))
				{
					File.Delete(obj.fileName);
				}

				XmlSerializer serializer = new XmlSerializer(typeof(SettingsAppModel));
				using (FileStream fs = new FileStream(obj.fileName, FileMode.Create, FileAccess.Write))
				{

					serializer.Serialize(fs, obj);
					fs.Close();
				}
				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				bk?.RestoreBackup();
				return false;
			}

		}
	}


}
