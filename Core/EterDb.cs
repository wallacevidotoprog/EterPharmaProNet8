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

		public IGenericRepository<MedControlDbModel> MedControlService { get; private set; }

		public IGenericRepository<PositionDbModel> PositionService { get; private set; }

		public IGenericRepository<ManipulationDbModel> ManipulationService { get; private set; }

		public IGenericRepository<PaymentDbModal> PaymentService { get; private set; }

		public IGenericRepository<SituationDbModal> SituationService { get; private set; }

		public IGenericRepository<DeliveryMethodDbModal> DeliveryMethodService { get; private set; }

		public EterDb()
		{
			UserService = new UserService();
			CategoryService = new CategoryService();
			ValityService = new ValityService();
			ProductValidadeService = new ProductValidadeService();
			ClientService = new ClientService();
			AddressService = new AddressService();
			MedControlService = new MedControlService();
			PositionService = new PositionService();
			ManipulationService = new ManipulationService();
			PaymentService = new PaymentService();
			SituationService = new SituationService();
			DeliveryMethodService = new DeliveryMethodService();
		}
	}
}
