using EterLibrary.Application.Services;
using EterLibrary.Domain.Entities.DbModels;
using EterLibrary.Domain.Interfaces;

namespace EterPharmaPro.Core
{
	public class EterDb
	{
		public IUserRepository<UserDbModel> UserService { get; private set; }

		public IGenericRepository<CategoryDbModal> CategoryService { get; private set; }

		public IGenericRepository<ProductValidadeDbModal> ProductValidadeService { get; private set; }

		public IGenericRepository<ValityDbModal> ValityService { get; private set; }

		public IGenericRepository<ClientDbModel> ClientService { get; private set; }

		public IGenericRepository<AddressClienteDbModel> AddressService { get; private set; }

		public EterDb()
		{
			UserService = new UserService();
			CategoryService = new CategoryService();
			ValityService = new ValityService();
			ProductValidadeService = new ProductValidadeService();
			ClientService = new ClientService();
			AddressService = new AddressService();
		}
	}
}
