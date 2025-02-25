using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Enums;
using EterPharmaPro.Infrastructure.Services;
using EterPharmaPro.Models;
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

		public async Task<List<ClientDbModel>> GetCliente(string query = null, TypeDoc typeDoc = TypeDoc.NONE)
		{
			List<ClientDbModel> dadosCliente = new List<ClientDbModel>();
			//switch (typeDoc)
			//{
			//	case TypeDoc.CPF:
			//		dadosCliente = await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("CPF", query));
			//		break;
			//	case TypeDoc.RG:
			//		dadosCliente = await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("RG", query));
			//		break;
			//	default:
			//		dadosCliente = await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel());
			//		break;
			//}


			//for (int i = 0; i < dadosCliente.Count; i++)
			//{
			//	dadosCliente[i].ENDERECO = await eterDb.ActionDb.GETFIELDS<EnderecoClienteDbModel>(new QueryWhereModel().SetWhere("CLIENTE_ID", dadosCliente[i].ID));
			//}
			return dadosCliente;
		}

		public async Task<bool> PrintDocManipulado(ManipulacaoModel model, EnumManipulado enumManipulado, bool edit = false)
		{
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

			try
			{

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

		public async Task<List<ManipulacaoModel>> GetManipulacaoFromUser(object idUser)
		{

			List<ManipulacaoModel> manipulacaoModels = new List<ManipulacaoModel>();
			//try
			//{

			//	List<ManipulacaoDbModel> tempM = await eterDb.ActionDb.GETFIELDS<ManipulacaoDbModel>(new QueryWhereModel().SetWhere("ATEN_LOJA", idUser));


			//	for (int i = 0; i < tempM.Count; i++)
			//	{
			//		ManipulacaoModel temp = new ManipulacaoModel().ConvertDb(tempM[i]);
			//		DadosClienteManipulacao dadosClienteManipulacao = (DadosClienteManipulacao)temp.DADOSCLIENTE;

			//		temp.DADOSATENDIMENTO.ATEN_LOJA_NAME = (await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel().SetWhere("ID", temp.DADOSATENDIMENTO.ATEN_LOJA))).FirstOrDefault().NOME;

			//		temp.DADOSCLIENTE = (await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("ID", tempM[i].CLIENTE_ID))).FirstOrDefault().NOME;
			//		manipulacaoModels.Add(temp);
			//	}



			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();

			//}
			return manipulacaoModels;


		}
		public async Task<ManipulacaoModel> GetManipulacao(object id)
		{

			//try
			//{

			//	ManipulacaoDbModel tempM = (await eterDb.ActionDb.GETFIELDS<ManipulacaoDbModel>(new QueryWhereModel().SetWhere("ID", id))).FirstOrDefault();

			//	ManipulacaoModel temp = new ManipulacaoModel().ConvertDb(tempM);
			//	DadosClienteManipulacao dadosClienteManipulacao = (DadosClienteManipulacao)temp.DADOSCLIENTE;

			//	temp.DADOSCLIENTE = (await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("ID", tempM.CLIENTE_ID))).FirstOrDefault();

			//	((ClienteDbModel)temp.DADOSCLIENTE).ENDERECO = (await eterDb.ActionDb.GETFIELDS<EnderecoClienteDbModel>(new QueryWhereModel().SetWhere("ID", tempM.ENDERECO_ID))).FirstOrDefault();

			//	temp.MEDICAMENTOS = await eterDb.ActionDb.GETFIELDS<MedicamentosManipuladosDbModal>(new QueryWhereModel().SetWhere("MANIPULADOS_ID", tempM.ID));


			//	return temp;
			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();

			//}
			return null;


		}

		public async Task<bool> DeleteManipulacao(int temp)
		{
			//try
			//{
			//	await eterDb.ActionDb.DELETE<ManipulacaoDbModel>(new QueryDeleteModel().SetWhere("ID", temp), connection, transaction);

			//	transaction.Commit();
			//	return true;
			//}
			//catch (Exception ex)
			//{
			//	transaction.Rollback();
			//	ex.ErrorGet();
			//	return false;
			//}

			return false;
		}
	}
}
