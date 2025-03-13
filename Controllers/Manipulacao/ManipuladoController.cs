using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Infrastructure.Services;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Controllers.Manipulacao
{
	public class ManipuladoController
	{

		private readonly ManipuladoService manipuladoService;
		public readonly PermissoesController permissoesReport;

		public ManipuladoController()
		{
			manipuladoService = new ManipuladoService();

			permissoesReport = new PermissoesController(new PermissionModel
			{
				DELETE = new PermissionsEnum[] { PermissionsEnum.Dev, PermissionsEnum.Admin, PermissionsEnum.Gerente, PermissionsEnum.Supervisor }
			});
		}

		public async Task<List<ClientDbModel>> GetCliente(string query) => EterCache.Instance.EterDb.ClientService.GetAllAsync((!string.IsNullOrEmpty(query) ? f => f.CPF == query || f.RG == query : null), i => i.AddressCliente).Result.ToList();

		public async Task<bool> PrintDocManipulado(ManipulationDbModel model, EnumManipulado enumManipulado, bool edit = false)
		{

			model.UserModel = await EterCache.Instance.EterDb.UserService.GetByAsync(f => f.ID == model.ATEN_LOJA);
			model.Situation = await EterCache.Instance.EterDb.SituationService.GetByAsync(f => f.ID == model.ID_SITUCAO);
			model.Payment = await EterCache.Instance.EterDb.PaymentService.GetByAsync(f => f.ID == model.ID_FORMAPAGAMENTO);
			model.DeliveryMethod = await EterCache.Instance.EterDb.DeliveryMethodService.GetByAsync(f => f.ID == model.ID_MODOENTREGA);

			try
			{
				switch (enumManipulado)
				{
					case EnumManipulado.P_80:
						manipuladoService.PrintDocManipulado80mm(model);
						break;
					case EnumManipulado.A4:
						manipuladoService.PrintDocManipuladoA4(model);
						break;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			model.Situation = null;
			model.Payment = null;
			model.DeliveryMethod = null;
			model.UserModel = null;
			try
			{

				ClientDbModel client = model.Client;
				AddressClienteDbModel address = model.AddressCliente;


				model.AddressCliente = null;
				model.Client = null;



				if (client.ID != null && (await EterCache.Instance.EterDb.ClientService.GetByAsync(f => f.ID == client.ID) != null))
				{
					client = await EterCache.Instance.EterDb.ClientService.UpdateAsync(client);
				}
				else
				{
					client = await EterCache.Instance.EterDb.ClientService.AddAsync(client);
				}

				if (address.ID != null && (await EterCache.Instance.EterDb.AddressService.GetByAsync(f => f.ID == client.ID) != null))
				{
					address = await EterCache.Instance.EterDb.AddressService.UpdateAsync(address);
				}
				else
				{
					address = await EterCache.Instance.EterDb.AddressService.AddAsync(address);
				}



				model.ID_CLIENTE = client.ID;
				model.ID_ENDERECO = address.ID;

				if (model.ID != null && (await EterCache.Instance.EterDb.ManipulationService.GetByAsync(f => f.ID == client.ID) != null))
				{
					model = await EterCache.Instance.EterDb.ManipulationService.UpdateAsync(model);
				}
				else
				{
					model = await EterCache.Instance.EterDb.ManipulationService.AddAsync(model);
				}




				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
			return false;
		}

		public async Task<List<ManipulationDbModel>> GetManipulacaoFromUser(long? idUser) => EterCache.Instance.EterDb.ManipulationService.GetAllAsync(f => f.ATEN_LOJA == idUser,
			i => i.AddressCliente,
			i => i.MedManipulation,
			i => i.Client,
			i => i.UserModel,
			i => i.Payment,
			i => i.DeliveryMethod,
			i => i.Situation
			).Result.ToList();

		public async Task<ManipulationDbModel> GetManipulacao(long? id) => EterCache.Instance.EterDb.ManipulationService.GetByAsync(f => f.ID == id, i => i.AddressCliente, i => i.MedManipulation, i => i.Client).Result;

		public async Task<bool> DeleteManipulacao(long? id)
		{
			try
			{
				await EterCache.Instance.EterDb.ManipulationService.RemoveAsync((int)id);

				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}

		public async Task<List<ClientDbModel>> GetAllClient() => EterCache.Instance.EterDb.ClientService.GetAllAsync(null, i => i.AddressCliente).Result.ToList();
	}
}
