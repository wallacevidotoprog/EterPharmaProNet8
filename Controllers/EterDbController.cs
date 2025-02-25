﻿using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Controllers
{
	public class EterDbController
	{


		public EterDbController()
		{
		}

		public async Task<(List<PaymentDbModal> paymente, List<SituationDbModal> situation, List<DeliveryMethodDbModal> deliveryMethod)> ReturnPropsAsync()
		{
			//List<PaymentDbModal> pay = await eterDb.ActionDb.GETFIELDS<PaymentDbModal>(new QueryWhereModel());
			//List<SituationDbModal> sit = await eterDb.ActionDb.GETFIELDS<SituationDbModal>(new QueryWhereModel());
			//List<DeliveryMethodDbModal> dm = await eterDb.ActionDb.GETFIELDS<DeliveryMethodDbModal>(new QueryWhereModel());

			return (null, null, null);
			//return (pay, sit, dm);
		}

		//public async Task<(bool exist, EnderecoClienteDbModel end)> ExistAdressCliente(EnderecoClienteDbModel enderecoCliente)
		//{
		//	List<EnderecoClienteDbModel> tempA = await eterDb.ActionDb.GETFIELDS<EnderecoClienteDbModel>(
		//		new QueryWhereModel().SetWhere("CLIENTE_ID", enderecoCliente.CLIENTE_ID)
		//		);


		//	for (int i = 0; i < tempA.Count; i++)
		//	{
		//		if (tempA[i].ENDERECO.ToUpper().Trim().Replace(" ", null) == enderecoCliente.ENDERECO.ToUpper().Trim().Replace(" ", null))
		//		{
		//			return (exist: true, end: tempA[i]);
		//		}
		//	}
		//	return (exist: false, end: null);
		//}

		//public async Task<ClienteDbModel> ExistCliente(ClienteDbModel dadosCliente, bool exist = false)
		//{
		//	try
		//	{
		//		if (exist)
		//		{
		//			return (await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("ID", dadosCliente.ID))).FirstOrDefault();
		//		}

		//		ClienteDbModel t1 = !string.IsNullOrEmpty(dadosCliente.CPF) ? (await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("CPF", dadosCliente.CPF))).FirstOrDefault() : null;

		//		ClienteDbModel t2 = !string.IsNullOrEmpty(dadosCliente.RG) ? (await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("RG", dadosCliente.RG))).FirstOrDefault() : null;

		//		return !(t1 is null) ? t1 : !(t2 is null) ? t2 : null;
		//	}
		//	catch (Exception ex)
		//	{
		//		ex.ErrorGet();
		//	}
		//	return null;

		//}

		//public async Task<(long? idC, long? idE)> RegisterCliente(ClienteDbModel dadosCliente)
		//{
		//	long? idc = null;
		//	long? ide = null;
		//	try
		//	{
		//		EnderecoClienteDbModel enderecoCliente = (EnderecoClienteDbModel)dadosCliente.ENDERECO;

		//		using (var connection = new SQLiteConnection(eterDb.DatabaseConnection))
		//		{
		//			await connection.OpenAsync().ConfigureAwait(false);
		//			using (var transaction = connection.BeginTransaction())
		//			{
		//				try
		//				{
		//					ClienteDbModel tempCliente = await ExistCliente(dadosCliente);

		//					if (tempCliente != null)
		//					{

		//						enderecoCliente.CLIENTE_ID = idc = dadosCliente.ID = tempCliente.ID;
		//						await eterDb.ActionDb.UPDATE(dadosCliente, connection, transaction);

		//						var (exist, tempEnderecos) = await ExistAdressCliente(enderecoCliente);

		//						if (!exist)
		//						{
		//							enderecoCliente.CLIENTE_ID = tempCliente.ID;
		//							ide = await eterDb.ActionDb.INSERT(enderecoCliente, connection, transaction);
		//						}
		//						else
		//						{
		//							enderecoCliente.ID = tempEnderecos.ID;
		//							enderecoCliente.CLIENTE_ID = tempCliente.ID;

		//							ide = enderecoCliente.ID;
		//							await eterDb.ActionDb.UPDATE(enderecoCliente, connection, transaction);
		//						}
		//					}
		//					else
		//					{
		//						idc = await eterDb.ActionDb.INSERT(dadosCliente, connection, transaction);
		//						enderecoCliente.CLIENTE_ID = idc;
		//						ide = await eterDb.ActionDb.INSERT(enderecoCliente, connection, transaction);
		//					}

		//					transaction.Commit();
		//				}
		//				catch (Exception ex)
		//				{
		//					transaction.Rollback();
		//					ex.ErrorGet();
		//				}
		//			}
		//		}

		//		return (idc, ide);
		//	}
		//	catch (Exception ex)
		//	{
		//		ex.ErrorGet();
		//		return (idc, ide);
		//	}
		//}

		public async Task<(bool acPass, bool acOk)> Login(string user, string pass, List<UserDbModel> userDbModels)
		{
			try
			{
				UserDbModel userModel = userDbModels.Where(x => x.NOME == user && x.PASS == pass).FirstOrDefault();
				if (userModel == null)
				{ return (false, false); }


				//userModel.FUNCAO_NAME = (await eterDb.ActionDb.GETFIELDS<FuncaoDbModel>(new QueryWhereModel().SetWhere("ID", userModel.FUNCAO))).FirstOrDefault()?.NOME;

				if (userModel.PASS == string.Empty)
				{

					//UserModelAcess = userModel;
					return (false, true);
				}
				else if (userModel.PASS != string.Empty && pass == null)
				{
					return (true, false);
				}
				else
				{
					if (userModel.PASS == pass)
					{
						//UserModelAcess = userModel;
						return (false, true);
					}
				}
				return (false, false);

			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return (false, false);
			}
		}


	}
}
