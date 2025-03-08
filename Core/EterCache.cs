using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers;
using EterPharmaPro.Infrastructure.Services.DbProdutos;
using EterPharmaPro.Models;
using System.Threading.Tasks;

namespace EterPharmaPro.Core
{
	public class EterCache
	{		
		private static readonly Lazy<EterCache> _instance = new Lazy<EterCache>(() => new EterCache());
		
		public static EterCache Instance => _instance.Value;
		

		private EterCache() {
			EterDb = new EterDb();
			EterDbController = new EterDbController();
			//EterDbController.SetPropsAsync()?.Wait();
		}

		public EterDb EterDb { get; private set; }

		public UserDbModel UserDbModel { get; set; }

		public DatabaseProdutosDb DatabaseProdutosDb { get; set; }

		public EterDbController EterDbController { get; set; }

		public SettingsAppModel SettingsApp { get; set; }


		public async Task RefreshUserDbModel()
		{
			UserDbModel = await EterDb.UserService.GetIncudeAsync(UserDbModel.ID);
		}

	}
}
