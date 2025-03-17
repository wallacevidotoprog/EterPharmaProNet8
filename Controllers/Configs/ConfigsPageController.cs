using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;
using System.Data;
using System.Drawing.Printing;

namespace EterPharmaPro.Controllers.Configs
{
	public class ConfigsPageController
	{
		public event EventHandler ReloadProd;


		public ConfigsPageController()
		{
			EterCache.Instance.DatabaseProdutosDb.DatabaseProdutosLoaded += DatabaseProdutosDb_DatabaseProdutosLoaded;
		}

		private void DatabaseProdutosDb_DatabaseProdutosLoaded(bool complet)
		{
			ReloadProd?.Invoke(this, new EventArgs());
		}

		public List<ProdutosModel> GetAllProdutos() => EterCache.Instance.DatabaseProdutosDb.produtos;

		public List<ProdutosModel> GetProdutos(object query, QueryProdutoEnum queryProdutoEnum)
		{
			if (string.IsNullOrEmpty(query.ToString()))
			{
				return EterCache.Instance.DatabaseProdutosDb.produtos;
			}
			List<ProdutosModel> temp = null;

			switch (queryProdutoEnum)
			{
				case QueryProdutoEnum.EAN:
					temp = EterCache.Instance.DatabaseProdutosDb.produtos.Where(p => p.EAN == (string)query).ToList();
					break;
				case QueryProdutoEnum.COD_INTERNO:
					temp = EterCache.Instance.DatabaseProdutosDb.produtos.Where(p => p.COD_PRODUTO == (string)query.ToString().PadLeft(6, '0')).ToList();
					break;
				case QueryProdutoEnum.DESCRICAO:
					temp = EterCache.Instance.DatabaseProdutosDb.produtos.Where(p => p.DESCRICAO_PRODUTO.Contains((string)query)).ToList();
					break;
				case QueryProdutoEnum.LABORATORIO:
					temp = EterCache.Instance.DatabaseProdutosDb.produtos.Where(p => p.LABORATORIO.Contains((string)query)).ToList();
					break;
				case QueryProdutoEnum.GRUPO:
					temp = EterCache.Instance.DatabaseProdutosDb.produtos.Where(p => p.GRUPO.Contains((string)query)).ToList();
					break;
			}

			return temp;
		}

		public void RefreshProd() => EterCache.Instance.DatabaseProdutosDb.Refresh();

		public async Task<bool> UpdateUser(UserDbModel userModel)
		{
			try
			{

				await EterCache.Instance.EterDb.UserService.UpdateAsync(userModel);
				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}

		public async Task<bool> CreateUser(UserDbModel userModel)
		{
			try
			{
				await EterCache.Instance.EterDb.UserService.AddAsync(userModel);

				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}

		public async Task<List<PositionDbModel>> GetAllFuncao()
		{
			return EterCache.Instance.EterDb.PositionService.GetAllAsync().Result.ToList();
		}

		public async Task<DataTable> GetAllUser()
		{
			DataTable dataTable = Create();


			//List<UserDbModel> temoUsers = EterCache.Instance.EterDb.UserService.GetAllAsync(null,i=>i.Position).Result.ToList();


			foreach (var item in EterCache.Instance.EterDb.UserService.GetAllAsync(null, i => i.Position).Result)
			{
				dataTable.Rows.Add(
					item.ID, item.ID_LOJA.ToString().PadLeft(4, '0'),
					item.NOME,
					item.Position.NOME,
					item.STATUS,
					item.CREATE_AT?.ToShortDateString(),
					item.UPDATE_AT?.ToShortDateString());
			}


			//foreach (var item in temoUsers)
			//{
			//	dataTable.Rows.Add(
			//		item.ID, item.ID_LOJA.ToString().PadLeft(4, '0'), 
			//		item.NOME, 
			//		item.Position.NOME, 
			//		item.STATUS, 
			//		item.CREATE_AT?.ToShortDateString(), 
			//		item.UPDATE_AT?.ToShortDateString());
			//}

			return dataTable;
		}

		private DataTable Create()
		{
			DataTable tabela = new DataTable();
			tabela.Columns.Add("ID");
			tabela.Columns.Add("ID_LOJA");
			tabela.Columns.Add("NOME");
			tabela.Columns.Add("FUNCAO");
			tabela.Columns.Add("STATS", typeof(bool));
			tabela.Columns.Add("CREATE");
			tabela.Columns.Add("UPDATE");
			return tabela;
		}

		public async Task<UserDbModel> GetUser(long? value) => EterCache.Instance.EterDb.UserService.GetByAsync(f => f.ID == value).Result;

		public ProdutosModel GetProdutoCC(object tempCod)
		{
			QueryProdutoEnum queryProdutoEnum = tempCod.ToString().Length <= 7 ? QueryProdutoEnum.COD_INTERNO : (tempCod.ToString().Length > 7 && tempCod.ToString().Length <= 13) ? QueryProdutoEnum.EAN : QueryProdutoEnum.NONE;


			return GetProdutos(tempCod.ToString(), queryProdutoEnum).FirstOrDefault();
		}

		public List<string> NamePrists() => PrinterSettings.InstalledPrinters.Cast<string>().ToList();
	}
}
