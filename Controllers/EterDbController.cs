using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Controllers
{
	public class EterDbController
	{
		public List<PaymentDbModal> PaymentDbs { get; private set; }
		public List<SituationDbModal> SituationDbs { get; private set; }
		public List<DeliveryMethodDbModal> DeliveryMethodDbs { get; private set; }
		public SettingsAppModel SettingsAppModel { get; private set; }

		public EterDbController()
		{
			if (!Path.Exists(Path.Combine(Directory.GetCurrentDirectory(), "DADOS")))
			{
				Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "DADOS"));
			}



			Task.Run(async () => await SetPropsAsync()).ConfigureAwait(false);

		}

		private async Task SetPropsAsync()
		{
			PaymentDbs = EterCache.Instance.EterDb.PaymentService.GetAllAsync().Result.ToList();
			SituationDbs = EterCache.Instance.EterDb.SituationService.GetAllAsync().Result.ToList();
			DeliveryMethodDbs = EterCache.Instance.EterDb.DeliveryMethodService.GetAllAsync().Result.ToList();
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







	}

}
