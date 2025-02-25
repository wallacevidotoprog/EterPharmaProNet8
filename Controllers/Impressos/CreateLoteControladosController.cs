using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Enums;
using EterPharmaPro.Infrastructure.Services.Prints;
using EterPharmaPro.Models;
using EterPharmaPro.Models.Print;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Controllers.CarimboLoteValidade
{
	public class CreateLoteControladosController
	{

		private static RawPrinterHelper printerHelper;

		public bool inLoadProd = true;

		public CreateLoteControladosController()
		{

			//databaseProdutosDb.DatabaseProdutosLoaded += DatabaseProdutosLoaded;

		}

		public List<ProdutosModel> GetAllProdutos()
		{
			//if (!databaseProdutosDb.CheckingLoad())
			//{
			//	return null;
			//}

			//return databaseProdutosDb.produtos;
			return null;
		}
		//public bool CheckingLoadDbProd() => !databaseProdutosDb.CheckingLoad();
		public ProdutosModel GetProduto(string cod_produt)
		{
			//if (!databaseProdutosDb.CheckingLoad())
			//{
			return null;
			//}
			//return (cod_produt.Trim().Length >= 7) ?
			//	databaseProdutosDb.produtos.FirstOrDefault((ProdutosModel x) => x.EAN.Contains(cod_produt.Trim())) :
			//	databaseProdutosDb.produtos.FirstOrDefault((ProdutosModel x) => x.COD_PRODUTO.Contains(cod_produt.Trim().Replace(" ", null).PadLeft(6, '0')));
		}

		public async Task<ClientDbModel> GetCliente(string value)
		{
			//	ClientDbModel tempCliente = (await eterDb.ActionDb.GETFIELDS<ClienteDbModel>(new QueryWhereModel().SetWhere("RG", value))).FirstOrDefault();
			//	if (tempCliente is null)
			//	{
			//		return null;
			//	}
			//	tempCliente.ENDERECO = await eterDb.ActionDb.GETFIELDS<EnderecoClienteDbModel>(new QueryWhereModel().SetWhere("CLIENTE_ID", tempCliente.ID));

			return null;
		}

		private void DatabaseProdutosLoaded(bool complet) => inLoadProd = !complet;

		public async Task<bool> FinishAsync(ClientDbModel clienteModel, List<MedControlDbModel> medicamentosControladoLoteModel)
		{
			//try
			//{
			//	PrintDoc(clienteModel, medicamentosControladoLoteModel);
			//	SendAlertBox.Send($"Imprimindo {clienteModel.NOME}", TypeAlertEnum.Info);
			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();
			//}
			//try
			//{
			//	(long? IDC, long? IDE) = await eterDb.EterDbController.RegisterCliente(clienteModel);
			//	medicamentosControladoLoteModel.ForEach((data) => data.CLIENTE_ID = IDC);

			//	using (var connection = new SQLiteConnection(eterDb.DatabaseConnection))
			//	{
			//		await connection.OpenAsync().ConfigureAwait(false);
			//		using (var transaction = connection.BeginTransaction())
			//		{
			//			try
			//			{
			//				for (int i = 0; i < medicamentosControladoLoteModel.Count; i++)
			//				{
			//					await eterDb.ActionDb.INSERT(medicamentosControladoLoteModel[i], connection, transaction);

			//				}

			//				transaction.Commit();
			//				SendAlertBox.Send($"Dados Salvos", TypeAlertEnum.Success);
			//				return true;
			//			}
			//			catch (Exception ex)
			//			{
			//				transaction.Rollback();
			//				ex.ErrorGet();
			//			}
			//		}
			//	}


			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();
			//	return false;
			//}

			return false;
		}

		private void PrintDoc(ClientDbModel clienteModel, List<MedControlDbModel> medicamentosControladoLoteModel)
		{
			printerHelper = new RawPrinterHelper();
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "Nome: ",
				texto = clienteModel.NOME,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "RG: ",
				texto = clienteModel.RG.ReturnFormation(FormatationEnum.RG),
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "Endereço :",
				//texto = ((EnderecoClienteDbModel)clienteModel.ENDERECO).ENDERECO,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "Telefone :",
				texto = clienteModel.PHONE.ReturnFormation(FormatationEnum.TELEFONE),
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			for (int i = 0; i < medicamentosControladoLoteModel.Count; i++)
			{
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "Código: ",
					texto = medicamentosControladoLoteModel[i].CODIGO.ToString(),
					fontStyle = FormatTextPrintEnum.Default
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "Medicamento: ",
					texto = medicamentosControladoLoteModel[i].NAME_M,
					fontStyle = FormatTextPrintEnum.Default
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "Quantidade: ",
					texto = medicamentosControladoLoteModel[i].QTD.ToString(),
					fontStyle = FormatTextPrintEnum.Default
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "Validade: ",
					//texto = medicamentosControladoLoteModel[i].VALIDADE.ToUnixDatetime()?.ToShortDateString(),
					fontStyle = FormatTextPrintEnum.Default
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "Lote: ",
					texto = medicamentosControladoLoteModel[i].LOTE,
					fontStyle = FormatTextPrintEnum.Default
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					symbol = SymbolPrintEnum.Space
				});
			}
			printerHelper.PrintDocument();
		}
	}
}
