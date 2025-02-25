using EterLibrary.Application.Services;
using EterLibrary.Domain.Entities.DbModels;
using EterLibrary.Domain.Interfaces;
using EterPharmaPro.Infrastructure;

namespace EterPharmaPro.Core
{
	public class EterDb
	{
		public UserService UserService { get; private set; }

		public EterDb()
		{
			UserService = new UserService(DependencyInjection.GetService<IGenericRepository<UserDbModel>>());
		}
	}
}
