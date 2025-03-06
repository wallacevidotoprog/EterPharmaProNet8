using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Infrastructure.Services;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Controllers.Manipulacao
{
	public class ManipuladoController
	{

		private readonly ManipuladoService manipuladoService;

		public ManipuladoController()
		{
			manipuladoService = new ManipuladoService();
		}

		public async Task<List<ClientDbModel>> GetCliente(string query) => EterCache.Instance.EterDb.ClientService.GetAllAsync((!string.IsNullOrEmpty(query) ? f => f.CPF == query || f.RG == query : null), i => i.AddressCliente).Result.ToList();

		public async Task<bool> PrintDocManipulado(ManipulationDbModel model, EnumManipulado enumManipulado, bool edit = false)
		{

			model.UserModel = await EterCache.Instance.EterDb.UserService.GetByAsync(f => f.ID == model.ATEN_LOJA);
			model.Situation = await EterCache.Instance.EterDb.SituationService.GetByAsync(f => f.ID == model.ID_SITUCAO);
			model.Payment = await EterCache.Instance.EterDb.PaymentService.GetByAsync(f => f.ID == model.ID_FORMAPAGAMENTO);
			model.DeliveryMethod = await EterCache.Instance.EterDb.DeliveryMethodService.GetByAsync(f => f.ID == model.ID_MODOENTREGA);

			//try
			//{
			//	switch (enumManipulado)
			//	{
			//		case EnumManipulado.P_80:
			//			manipuladoService.PrintDocManipulado80mm(model);
			//			break;
			//		case EnumManipulado.A4:
			//			manipuladoService.PrintDocManipuladoA4(model);
			//			break;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();
			//}
			model.Situation = null;
			model.Payment = null;
			model.DeliveryMethod = null;
			model.UserModel = null;
			try
			{
				/// verificar a questao de existente
				await EterCache.Instance.EterDb.ManipulationService.AddOrUpdateAsync(model);

				//(long? IDC, long? IDE) = await eterDb.EterDbController.RegisterCliente((ClienteDbModel)model.DADOSCLIENTE);

				//model.DADOSCLIENTE = new DadosClienteManipulacao { ID_CLIENTE = IDC, ID_ENDERECO = IDE };

				//using (var connection = new SQLiteConnection(eterDb.DatabaseConnection))
				//{
				//	await connection.OpenAsync().ConfigureAwait(false);
				//	using (var transaction = connection.BeginTransaction())
				//	{
				//		try
				//		{


				//			if (edit)
				//			{
				//				await eterDb.ActionDb.DELETE<MedicamentosManipuladosDbModal>(new QueryDeleteModel().SetWhere("ID", model.ID), connection, transaction);
				//				await eterDb.ActionDb.UPDATE(model, connection, transaction);

				//				((List<MedicamentosManipuladosDbModal>)model.MEDICAMENTOS).ForEach(m => m.MANIPULADOS_ID = model.ID);

				//				foreach (var medicamento in (List<MedicamentosManipuladosDbModal>)model.MEDICAMENTOS)
				//				{
				//					await eterDb.ActionDb.INSERT(medicamento, connection, transaction);
				//				}
				//			}
				//			else
				//			{
				//				var temp = new ManipulacaoDbModel().Convert(model);
				//				long? tempCM = await eterDb.ActionDb.INSERT(temp, connection, transaction);

				//				((List<MedicamentosManipuladosDbModal>)model.MEDICAMENTOS).ForEach(m => m.MANIPULADOS_ID = tempCM);

				//				foreach (var medicamento in (List<MedicamentosManipuladosDbModal>)model.MEDICAMENTOS)
				//				{
				//					await eterDb.ActionDb.INSERT(medicamento, connection, transaction);
				//				}
				//			}

				//			transaction.Commit();
				//			return true;
				//		}
				//		catch (Exception ex)
				//		{
				//			transaction.Rollback();
				//			ex.ErrorGet();
				//			return false;
				//		}
				//	}
				//}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
			return false;
		}

		public async Task<List<ManipulationDbModel>> GetManipulacaoFromUser(long? idUser) => EterCache.Instance.EterDb.ManipulationService.GetAllAsync(f => f.ATEN_LOJA == idUser, i => i.AddressCliente, i => i.MedManipulation, i => i.Client).Result.ToList();

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
