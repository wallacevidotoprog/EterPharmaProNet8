using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Enums;
using EterPharmaPro.Infrastructure.Services.Prints;
using EterPharmaPro.Interfaces;
using EterPharmaPro.Models.Print;
using EterPharmaPro.Utils.Extencions;
using System.Globalization;

namespace EterPharmaPro.Infrastructure.Services
{
	public class ManipuladoService
	{

		private static RawPrinterHelper printerHelper;

		public ManipuladoService()
		{

		}

		public async void PrintDocManipulado80mm(ManipulationDbModel model)
		{
			printerHelper = new RawPrinterHelper();
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				texto = "Formulário de Manipulados".ToUpper(),
				alignmentText = AlignmentTextPrintEnum.Center,
				fontStyle = FormatTextPrintEnum.Title
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});


			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "Vendedor(a): ",
				texto = $"{model.UserModel.ID_LOJA.ToString().PadLeft(4, '0')} - {model.UserModel.NOME}",
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "Atendente: ",
				texto = model.ATEN_MANI ?? "NÃO INFORMADO",
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "Data do Pedido: ",
				texto = model.DATA?.ToShortDateString(),
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "NOME: ",
				texto = model.UserModel.NOME,
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			if (!string.IsNullOrEmpty(model.Client.CPF))
			{
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "CPF: ",
					texto = model.Client.CPF.ReturnFormation(FormatationEnum.CPF),
					alignmentText = AlignmentTextPrintEnum.Left,
					fontStyle = FormatTextPrintEnum.Default
				});
			}
			if (!string.IsNullOrEmpty(model.Client.RG))
			{
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "RG: ",
					texto = model.Client.RG.ReturnFormation(FormatationEnum.RG),
					alignmentText = AlignmentTextPrintEnum.Left,
					fontStyle = FormatTextPrintEnum.Default
				});
			}

			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "TELEFONE: ",
				texto = model.Client.PHONE.ReturnFormation(FormatationEnum.TELEFONE),
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "ENDEREÇO: ",
				texto = model.AddressCliente.ToString(),
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});

			if (!string.IsNullOrEmpty(model.AddressCliente.OBSERVACAO))
			{
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "OBS. DO ENDEREÇO: ",
					texto = model.AddressCliente.OBSERVACAO,
					alignmentText = AlignmentTextPrintEnum.Left,
					fontStyle = FormatTextPrintEnum.Default
				});
			}
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				texto = "MEDICAMENTOS PARA MANIPULAÇÃO".ToUpper(),
				alignmentText = AlignmentTextPrintEnum.Center,
				fontStyle = FormatTextPrintEnum.Title
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});

			foreach (var item in model.MedManipulation)
			{
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					tilte = "■ ",
					texto = item.NAME_M.ToUpper(),
					alignmentText = AlignmentTextPrintEnum.Left,
					fontStyle = FormatTextPrintEnum.Default
				});
			}

			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			if (!string.IsNullOrEmpty(model.OBSGERAL))
			{
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					texto = "OBSERVAÇÕES".ToUpper(),
					alignmentText = AlignmentTextPrintEnum.Center,
					fontStyle = FormatTextPrintEnum.Title
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					symbol = SymbolPrintEnum.Space
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					texto = model.OBSGERAL.ToUpper(),
					alignmentText = AlignmentTextPrintEnum.Left,
					fontStyle = FormatTextPrintEnum.Default
				});
				printerHelper.AddLine(new TextPrintFormaterModel
				{
					symbol = SymbolPrintEnum.Space
				});
			}
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				texto = "DADOS GERAIS".ToUpper(),
				alignmentText = AlignmentTextPrintEnum.Center,
				fontStyle = FormatTextPrintEnum.Title
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "SITUAÇÃO: ",

				texto = model.Situation.NAME,
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "FORMA DE PAGAMENTO: ",
				texto = model.Payment.NAME,
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				tilte = "MODO DE ENTREGA: ",
				texto = model.DeliveryMethod.NAME,
				alignmentText = AlignmentTextPrintEnum.Left,
				fontStyle = FormatTextPrintEnum.Default
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				symbol = SymbolPrintEnum.Space
			});
			printerHelper.AddLine(new TextPrintFormaterModel
			{
				texto = ("VALOR TOTAL " + string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(model.VALORFINAL))).ToUpper(),
				alignmentText = AlignmentTextPrintEnum.Right,
				fontStyle = FormatTextPrintEnum.Header
			});
			printerHelper.AddLine(new TextPrintFormaterModel());

			printerHelper.PrintDocument();
		}

		public void PrintDocManipuladoA4(ManipulationDbModel model)
		{
			IPrint print = new ManipulationA4Print(model);
			print.ShowPrintPreview();

		}
	}
}
