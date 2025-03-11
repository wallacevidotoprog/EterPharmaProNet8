using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers;
using EterPharmaPro.Infrastructure.Services.DbProdutos;
using EterPharmaPro.Models;

namespace EterPharmaPro.Core
{
	public class EterCache
	{
		private static readonly Lazy<EterCache> _instance = new Lazy<EterCache>(() => new EterCache());

		public static EterCache Instance => _instance.Value;


		private EterCache()
		{
			EterDb = new EterDb();
			EterDbController = new EterDbController();
			Task.Run(async () => await SetPropsSettingsAsync()).ConfigureAwait(false);
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
		private async Task SetPropsSettingsAsync()
		{
			SettingsApp = new SettingsAppModel();
			SettingsApp = await SettingsApp.CreateAsync();

		}

	}
}
