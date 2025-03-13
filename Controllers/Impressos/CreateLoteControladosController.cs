using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Infrastructure.Services;
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

			EterCache.Instance.DatabaseProdutosDb.DatabaseProdutosLoaded += DatabaseProdutosLoaded;

		}

		public List<ProdutosModel> GetAllProdutos()
		{
			if (!EterCache.Instance.DatabaseProdutosDb.CheckingLoad())
			{
				return null;
			}

			return EterCache.Instance.DatabaseProdutosDb.produtos;
			return null;
		}
		public bool CheckingLoadDbProd() => !EterCache.Instance.DatabaseProdutosDb.CheckingLoad();
		public ProdutosModel GetProduto(string cod_produt)
		{
			if (!EterCache.Instance.DatabaseProdutosDb.CheckingLoad())
			{
				return null;
			}
			return (cod_produt.Trim().Length >= 7) ?
				EterCache.Instance.DatabaseProdutosDb.produtos.FirstOrDefault((ProdutosModel x) => x.EAN.Contains(cod_produt.Trim())) :
				EterCache.Instance.DatabaseProdutosDb.produtos.FirstOrDefault((ProdutosModel x) => x.COD_PRODUTO.Contains(cod_produt.Trim().Replace(" ", null).PadLeft(6, '0')));
		}

		public async Task<ClientDbModel> GetCliente(string value)
		{
			ClientDbModel tempCliente = EterCache.Instance.EterDb.ClientService.GetByAsync(f => f.RG == value, i => i.AddressCliente).Result;

			if (tempCliente is null) return null;

			return tempCliente;
		}

		private void DatabaseProdutosLoaded(bool complet) => inLoadProd = !complet;

		public async Task<bool> FinishAsync(ClientDbModel clienteModel)
		{
			try
			{
				PrintDoc(clienteModel);
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			try
			{


				List<MedControlDbModel> medControl = clienteModel.MedControl.ToList();
				clienteModel.MedControl = null;

				var tempResultC = await EterCache.Instance.EterDb.ClientService.AddOrUpdateAsync(clienteModel);

				medControl = medControl.Select(x =>
				{
					x.ID_CLIENT = tempResultC.ID;
					x.ID_ADDRESS = clienteModel.AddressCliente.First().ID;
					x.ID_USER = EterCache.Instance.UserDbModel.ID;
					return x;
				}).ToList();


				foreach (var item in medControl)
				{
					await EterCache.Instance.EterDb.MedControlService.AddAsync(item);
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

		private void PrintDoc(ClientDbModel clienteModel)
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
			if (clienteModel.AddressCliente.Count > 0)
			{
				AddressClienteDbModel tempAddres = clienteModel.AddressCliente.First();
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "Endereço :",
					texto = $"{tempAddres.PLACE}, {tempAddres.NUMBER}, {tempAddres.ZONE}, {tempAddres.CITY} - {tempAddres.UF}",
					fontStyle = FormatTextPrintEnum.Default
				});
			}

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

			if (clienteModel.MedControl.Count > 0)
			{
				List<MedControlDbModel> tempControl = clienteModel.MedControl.ToList();

				for (int i = 0; i < tempControl.Count; i++)
				{
					printerHelper.AddLine(new TextPrintFormaterModel
					{
						tilte = "Código: ",
						texto = tempControl[i].CODIGO.ToString(),
						fontStyle = FormatTextPrintEnum.Default
					});
					printerHelper.AddLine(new TextPrintFormaterModel
					{
						tilte = "Medicamento: ",
						texto = tempControl[i].NAME_M,
						fontStyle = FormatTextPrintEnum.Default
					});
					printerHelper.AddLine(new TextPrintFormaterModel
					{
						tilte = "Quantidade: ",
						texto = tempControl[i].QTD.ToString(),
						fontStyle = FormatTextPrintEnum.Default
					});
					printerHelper.AddLine(new TextPrintFormaterModel
					{
						tilte = "Validade: ",
						texto = tempControl[i].VALIDADE?.ToShortDateString(),
						fontStyle = FormatTextPrintEnum.Default
					});
					printerHelper.AddLine(new TextPrintFormaterModel
					{
						tilte = "Lote: ",
						texto = tempControl[i].LOTE,
						fontStyle = FormatTextPrintEnum.Default
					});
					printerHelper.AddLine(new TextPrintFormaterModel
					{
						symbol = SymbolPrintEnum.Space
					});
				}
			}

			printerHelper.PrintDocument();
		}
	}
}
