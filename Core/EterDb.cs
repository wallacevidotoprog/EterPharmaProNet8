using EterLibrary.Application.Services;
using EterLibrary.Domain.Entities.DbModels;
using EterLibrary.Domain.Interfaces;

namespace EterPharmaPro.Core
{
	public class EterDb
	{
		public IUserRepository<UserDbModel> UserService { get; private set; }
		public IGenericRepository<CategoryDbModal> CategoryService { get; private set; }
		public IGenericRepository<ValityDbModal> ValityService { get; private set; }
		public EterDb()
		{
			UserService = new UserService();
			CategoryService = new CategoryService();
			ValityService = new ValityService();
		}
	}
}
