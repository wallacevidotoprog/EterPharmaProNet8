using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using System.Data;

namespace EterPharmaPro.Controllers.Configs
{
	public class ConfigsPageController
	{
		public event EventHandler ReloadProd;


		public ConfigsPageController()
		{

			//databaseProdutosDb.DatabaseProdutosLoaded += DatabaseProdutosDb_DatabaseProdutosLoaded;
		}

		private void DatabaseProdutosDb_DatabaseProdutosLoaded(bool complet)
		{
			ReloadProd?.Invoke(this, new EventArgs());
		}

		public List<ProdutosModel> GetAllProdutos() => null;// databaseProdutosDb.produtos;

		public List<ProdutosModel> GetProdutos(object query, QueryProdutoEnum queryProdutoEnum)
		{
			if (string.IsNullOrEmpty(query.ToString()))
			{
				//return databaseProdutosDb.produtos;
			}
			List<ProdutosModel> temp = null;

			//switch (queryProdutoEnum)
			//{
			//	case QueryProdutoEnum.EAN:
			//		temp = databaseProdutosDb.produtos.Where(p => p.EAN == (string)query).ToList();
			//		break;
			//	case QueryProdutoEnum.COD_INTERNO:
			//		temp = databaseProdutosDb.produtos.Where(p => p.COD_PRODUTO == (string)query.ToString().PadLeft(6, '0')).ToList();
			//		break;
			//	case QueryProdutoEnum.DESCRICAO:
			//		temp = databaseProdutosDb.produtos.Where(p => p.DESCRICAO_PRODUTO.Contains((string)query)).ToList();
			//		break;
			//	case QueryProdutoEnum.LABORATORIO:
			//		temp = databaseProdutosDb.produtos.Where(p => p.LABORATORIO.Contains((string)query)).ToList();
			//		break;
			//	case QueryProdutoEnum.GRUPO:
			//		temp = databaseProdutosDb.produtos.Where(p => p.GRUPO.Contains((string)query)).ToList();
			//		break;
			//}

			return temp;
		}

		public void RefreshProd() { } // databaseProdutosDb.Refresh();

		public async Task<bool> UpdateUser(UserDbModel userModel)
		{
			//try
			//{
			//	await eterDb.ActionDb.UPDATE(userModel, connection, transaction);

			//	transaction.Commit();
			//	return true;
			//}
			//catch (Exception ex)
			//{
			//	transaction.Rollback();
			//	ex.ErrorGet();
			return false;
			//}
		}

		public async Task<bool> CreateUser(UserDbModel userModel)
		{
			//try
			//{
			//	await eterDb.ActionDb.INSERT(userModel, connection, transaction);

			//	transaction.Commit();
			//	return true;
			//}
			//catch (Exception ex)
			//{
			//	transaction.Rollback();
			//	ex.ErrorGet();
			return false;
			//}
		}

		public async Task<List<PositionDbModel>> GetAllFuncao()
		{
			return null;// await eterDb.ActionDb.GETFIELDS<FuncaoDbModel>(new QueryWhereModel());
		}

		public async Task<DataTable> GetAllUser()
		{
			DataTable dataTable = Create();

			//var tempU = await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel());
			//var tempF = await eterDb.ActionDb.GETFIELDS<FuncaoDbModel>(new QueryWhereModel());

			//tempU.ForEach((data) => data.FUNCAO_NAME = tempF.FirstOrDefault(x => x.ID == Convert.ToUInt32(data.FUNCAO)).NOME);

			//foreach (var item in tempU)
			//{
			//	dataTable.Rows.Add(item.ID, item.ID_LOJA.ToString().PadLeft(4, '0'), item.NOME, item.FUNCAO_NAME, item.STATUS, item.CREATE?.ToShortDateString(), item.UPDATE?.ToShortDateString());
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

		public async Task<UserDbModel> GetUser(object value)
		{
			return null;// (await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel().SetWhere("ID", value))).FirstOrDefault();
		}

		public ProdutosModel GetProdutoCC(object tempCod)
		{
			QueryProdutoEnum queryProdutoEnum = tempCod.ToString().Length <= 7 ? QueryProdutoEnum.COD_INTERNO : (tempCod.ToString().Length > 7 && tempCod.ToString().Length <= 13) ? QueryProdutoEnum.EAN : QueryProdutoEnum.NONE;


			return GetProdutos(tempCod.ToString(), queryProdutoEnum).FirstOrDefault();
		}
	}
}
