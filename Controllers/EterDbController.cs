using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;
using System.Xml.Serialization;

namespace EterPharmaPro.Controllers
{
	public class EterDbController
	{
		public List<PaymentDbModal> PaymentDbs { get; private set; }
		public List<SituationDbModal> SituationDbs { get; private set; }
		public List<DeliveryMethodDbModal> DeliveryMethodDbs { get; private set; }

		public EterDbController()
		{
			Task.Run(async () => await SetPropsAsync()).ConfigureAwait(false);
			Task.Run(async () => await SetPropsSettingsAsync()).ConfigureAwait(false);
		}

		private async Task SetPropsAsync()
		{
			PaymentDbs = EterCache.Instance.EterDb.PaymentService.GetAllAsync().Result.ToList();
			SituationDbs = EterCache.Instance.EterDb.SituationService.GetAllAsync().Result.ToList();
			DeliveryMethodDbs = EterCache.Instance.EterDb.DeliveryMethodService.GetAllAsync().Result.ToList();
		}

		private async Task SetPropsSettingsAsync()
		{
		

			if (!File.Exists($@"{Directory.GetCurrentDirectory()}\DADOS\SettingsApp.xml"))
			{
				SerializeToXmlFileAsync(new SettingsAppModel
				{
					NUMBERSTORE = 0,
					POINTS = new List<SettingsPoint>
					{
						new SettingsPoint
						{
							NAMEPC = System.Net.Dns.GetHostName(),
							PRINT_DEFAULT = "EPSON",
							PRINT_TERMAL = "BEMATECH"
						}
					}
				});
			}
		}

		public bool PermissionHas(PermissoesController local, PermissionEnum mod)
		{
			bool retutnPermission = false;
			try
			{
				int up = (int)EterCache.Instance?.UserDbModel?.Position?.PERMISSION;
				switch (mod)
				{
					case PermissionEnum.ADD:
						return local.HasPermission(local._permissoesE.ADD, up);
						break;
					case PermissionEnum.UPDATE:
						return local.HasPermission(local._permissoesE.UPDATE, up);
						break;
					case PermissionEnum.DELETE:
						return local.HasPermission(local._permissoesE.DELETE, up);
						break;
					case PermissionEnum.VIEW:
						return local.HasPermission(local._permissoesE.VIEW, up);
						break;
				}



			}
			catch (Exception ex)
			{
				return false;
				ex.ErrorGet();
			}
			return false;
		}

		public static async Task<SettingsAppModel> DeserializePessoaFromXmlAsync()
		{
			try
			{
				string fileName = $@"{Directory.GetCurrentDirectory()}\DADOS\SettingsApp.xml";

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
			string fileName = $@"{Directory.GetCurrentDirectory()}\DADOS\SettingsApp.xml";
			BACKUP bACKUP = new BACKUP(fileName); ;
			try
			{
				if (File.Exists(fileName))
				{
					File.Delete(fileName);
				}

				XmlSerializer serializer = new XmlSerializer(typeof(SettingsAppModel));
				using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
				{
					serializer.Serialize(fs, obj);
					fs.Close();
				}
				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				bACKUP?.RestoreBackup();
				return false;
			}

		}





	}


	public class BACKUP
	{
		private string fileName;
		private string data;
		public BACKUP(string _file)
		{
			fileName = _file;
			SetBackup();
		}
		private void SetBackup()
		{
			if (File.Exists(fileName))
			{
				data = File.ReadAllText(fileName);
			}
		}

		public void RestoreBackup()
		{
			if (data != null)
			{
				if (File.Exists(fileName))
				{
					File.Delete(fileName);
				}
				File.WriteAllText(fileName, data);
			}

		}
	}
}
