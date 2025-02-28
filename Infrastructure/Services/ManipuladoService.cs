using EterPharmaPro.Models;

namespace EterPharmaPro.Infrastructure.Services
{
	public class ManipuladoService
	{

		private static RawPrinterHelper printerHelper;

		public ManipuladoService()
		{

		}

		public async void PrintDocManipulado80mm(ManipulacaoModel model)
		{
			//printerHelper = new RawPrinterHelper();
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	texto = "Formulário de Manipulados".ToUpper(),
			//	alignmentText = AlignmentTextPrintEnum.Center,
			//	fontStyle = FormatTextPrintEnum.Title
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});

			//UserDbModel userModel = (await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel().SetWhere("ID", model.DADOSATENDIMENTO.ATEN_LOJA))).FirstOrDefault();
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "Vendedor(a): ",
			//	texto = userModel.ID_LOJA + " - " + userModel.NOME,
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "Atendente: ",
			//	texto = model.DADOSATENDIMENTO.ATEN_MANI == string.Empty ? "NÃO INFORMADO" : model.DADOSATENDIMENTO.ATEN_MANI,
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "Data do Pedido: ",
			//	texto = model.DADOSATENDIMENTO.DATA?.ToShortDateString(),
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "NOME: ",
			//	texto = ((ClienteDbModel)model.DADOSCLIENTE).NOME,
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "CPF: ",
			//	texto = ((ClienteDbModel)model.DADOSCLIENTE).CPF.ReturnFormation(FormatationEnum.CPF),
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "RG: ",
			//	texto = ((ClienteDbModel)model.DADOSCLIENTE).RG.ReturnFormation(FormatationEnum.RG),
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "TELEFONE: ",
			//	texto = ((ClienteDbModel)model.DADOSCLIENTE).TELEFONE.ReturnFormation(FormatationEnum.TELEFONE),
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "ENDEREÇO: ",
			//	texto = ((EnderecoClienteDbModel)((ClienteDbModel)model.DADOSCLIENTE).ENDERECO).ENDERECO,
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//if (((EnderecoClienteDbModel)((ClienteDbModel)model.DADOSCLIENTE).ENDERECO).OBSERVACAO != string.Empty)
			//{
			//	printerHelper.AddLine(new TextPrintFormaterModel
			//	{
			//		tilte = "OBS. DO ENDEREÇO: ",
			//		texto = ((EnderecoClienteDbModel)((ClienteDbModel)model.DADOSCLIENTE).ENDERECO).OBSERVACAO,
			//		alignmentText = AlignmentTextPrintEnum.Left,
			//		fontStyle = FormatTextPrintEnum.Default
			//	});
			//}
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	texto = "MEDICAMENTOS PARA MANIPULAÇÃO".ToUpper(),
			//	alignmentText = AlignmentTextPrintEnum.Center,
			//	fontStyle = FormatTextPrintEnum.Title
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//for (int i = 0; i < ((List<MedicamentosManipuladosDbModal>)model.MEDICAMENTOS).Count; i++)
			//{
			//	printerHelper.AddLine(new TextPrintFormaterModel
			//	{
			//		tilte = "■ ",
			//		texto = ((List<MedicamentosManipuladosDbModal>)model.MEDICAMENTOS)[i].NAME_M.ToUpper(),
			//		alignmentText = AlignmentTextPrintEnum.Left,
			//		fontStyle = FormatTextPrintEnum.Default
			//	});
			//}
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//if (model.OBSGERAL != "")
			//{
			//	printerHelper.AddLine(new TextPrintFormaterModel
			//	{
			//		texto = "OBSERVAÇÕES".ToUpper(),
			//		alignmentText = AlignmentTextPrintEnum.Center,
			//		fontStyle = FormatTextPrintEnum.Title
			//	});
			//	printerHelper.AddLine(new TextPrintFormaterModel
			//	{
			//		symbol = SymbolPrintEnum.Space
			//	});
			//	printerHelper.AddLine(new TextPrintFormaterModel
			//	{
			//		texto = model.OBSGERAL.ToUpper(),
			//		alignmentText = AlignmentTextPrintEnum.Left,
			//		fontStyle = FormatTextPrintEnum.Default
			//	});
			//	printerHelper.AddLine(new TextPrintFormaterModel
			//	{
			//		symbol = SymbolPrintEnum.Space
			//	});
			//}
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	texto = "DADOS GERAIS".ToUpper(),
			//	alignmentText = AlignmentTextPrintEnum.Center,
			//	fontStyle = FormatTextPrintEnum.Title
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "SITUAÇÃO: ",

			//	texto = EterCache.Instance.Situation.Where(x => x.ID == model.SITUCAO).First().NAME,
			//	//texto = DGERAL.SITUACAO(model.SITUCAO),
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "FORMA DE PAGAMENTO: ",
			//	texto = EterCache.Instance.Paymente.Where(x => x.ID == model.FORMAPAGAMENTO).First().NAME,
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	tilte = "MODO DE ENTREGA: ",
			//	texto = EterCache.Instance.DeliveryMethod.Where(x => x.ID == model.MODOENTREGA).First().NAME,
			//	alignmentText = AlignmentTextPrintEnum.Left,
			//	fontStyle = FormatTextPrintEnum.Default
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	symbol = SymbolPrintEnum.Space
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel
			//{
			//	texto = ("VALOR TOTAL " + string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(model.VALORFINAL))).ToUpper(),
			//	alignmentText = AlignmentTextPrintEnum.Right,
			//	fontStyle = FormatTextPrintEnum.Header
			//});
			//printerHelper.AddLine(new TextPrintFormaterModel());
			//printerHelper.PrintDocument();
		}

		public void PrintDocManipuladoA4(ManipulacaoModel model)
		{
		}
	}
}
