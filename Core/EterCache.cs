using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers;
using EterPharmaPro.Infrastructure.Services.DbProdutos;
using System.Threading.Tasks;

namespace EterPharmaPro.Core
{
	public class EterCache
	{
		private static EterCache _instance;
		private static readonly object _lock = new object();

		public static EterCache Instance
		{
			get
			{
				lock (_lock)
				{
					if (_instance == null)
					{
						_instance = new EterCache();
					}
					return _instance;
				}
			}
		}

		private EterCache() {
			EterDb = new EterDb();
		}

		public EterDb EterDb { get; set; }

		public UserDbModel UserDbModel { get; set; }

		public DatabaseProdutosDb DatabaseProdutosDb { get; set; }

		public EterDbController EterDbController { get; set; }


		public async Task RefreshUserDbModel()
		{
			UserDbModel = await EterDb.UserService.GetIncudeAsync(UserDbModel.ID);
		}

	}
}
