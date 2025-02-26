﻿using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Controllers.Validade
{
	public class ValidadeController
	{
		private bool isLoadProd = false;
		public ValidadeController()
		{
			EterCache.Instance.DatabaseProdutosDb.DatabaseProdutosLoaded += DatabaseProdutosLoaded;
		}

		public async Task<long?> CreateNewDocVality(SetValityModel model)
		{
			try
			{
				var temp = await EterCache.Instance.EterDb.ValityService.AddAsync(new ValityDbModal { ID_USER = model.user_id, DATE = model.dataCreate });

				return temp.ID;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return -1;
			}
		}

		public async Task<long?> CreateCategory(long? user_id, string cat_name)
		{
			try
			{

				var resp = await EterCache.Instance.EterDb.CategoryService.AddAsync(new CategoryDbModal { ID_USER = user_id, NAME = cat_name });
				await EterCache.Instance.RefreshUserDbModel();

				return resp.ID;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return -1;
			}
		}

		public async Task<bool> DeleteCategory(int cat_id)
		{

			try
			{
				await EterCache.Instance.EterDb.CategoryService.RemoveAsync(cat_id);
				await EterCache.Instance.RefreshUserDbModel();

				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}

			return false;
		}

		public List<ProdutosModel> GetAllProdutos(out bool inLoad)
		{
			//if (!databaseProdutosDb.CheckingLoad())
			//{
			//	inLoad = true;
			//	return null;
			//}
			inLoad = false;
			//return databaseProdutosDb.produtos;

			return new List<ProdutosModel>();
		}

		private void DatabaseProdutosLoaded(bool complet) => isLoadProd = complet;

		public ProdutosModel GetProduto(string text, out bool inLoad)
		{
			//	if (!databaseProdutosDb.CheckingLoad())
			//	{
			inLoad = true;
			return null;
			//	}
			//	inLoad = false;
			//	return ((text.Trim().Length >= 7) ? databaseProdutosDb.produtos.Find((ProdutosModel x) => x.EAN.Contains(text.Trim())) : databaseProdutosDb.produtos.Find((ProdutosModel x) => x.COD_PRODUTO.Contains(text.Trim().Replace(" ", null).PadLeft(6, '0'))));
		}

		public async Task<(bool, long?)> CreateProdutoVality(SetValityModel setValityModel)
		{
			//try
			//{

			//	long? tempIdV = await eterDb.ActionDb.INSERT(new ProdutoValidadeDbModal
			//	{
			//		PRODUTO_CODIGO = setValityModel.produto.codigo,
			//		PRODUTO_DESCRICAO = setValityModel.produto.descricao,
			//		QUANTIDADE = setValityModel.produto.quantidade,
			//		DATA_VALIDADE = setValityModel.produto.dateVality,
			//		CATEGORIA_ID = setValityModel.produto.category_id,
			//		VALIDADE_ID = (int)setValityModel.vality_id

			//	}, connection, transaction);

			//	transaction.Commit();
			//	return (true, tempIdV);
			//}
			//catch (Exception ex)
			//{
			//	transaction.Rollback();
			//	ex.ErrorGet();
			return (false, -1);
			//}
		}

		public async Task<List<CategoryDbModal>> GetCategoryUser(long? user_id)
		{
			return null;// await eterDb.ActionDb.GETFIELDS<CategoriaDbModal>(new QueryWhereModel().SetWhere("ID_LOJA", user_id));
		}

		public async Task<bool> UpdateProdutoVality(SetValityModel setValityModel)
		{
			//try
			//{
			//	bool tempIdV = await eterDb.ActionDb.UPDATE(new ProdutoValidadeDbModal
			//	{
			//		PRODUTO_CODIGO = setValityModel.produto.codigo,
			//		PRODUTO_DESCRICAO = setValityModel.produto.descricao,
			//		QUANTIDADE = setValityModel.produto.quantidade,
			//		DATA_VALIDADE = setValityModel.produto.dateVality,
			//		CATEGORIA_ID = setValityModel.produto.category_id,
			//		VALIDADE_ID = (int)setValityModel.vality_id,
			//		ID = setValityModel.produto.id
			//	}, connection, transaction);

			//	transaction.Commit();
			//	return tempIdV;
			//}
			//catch (Exception ex)
			//{
			//	transaction.Rollback();
			//	ex.ErrorGet();
			return false;
			//}
		}

		public async Task<bool> DeleteProduto(int temp)
		{
			//using (var connection = new SQLiteConnection(eterDb.DatabaseConnection))
			//{
			//	await connection.OpenAsync().ConfigureAwait(false);
			//	using (var transaction = connection.BeginTransaction())
			//	{
			//		try
			//		{
			//			bool tempIdV = await eterDb.ActionDb.DELETE<ProdutoValidadeDbModal>(new QueryDeleteModel().SetWhere("ID", temp), connection, transaction);

			//			transaction.Commit();
			//			return tempIdV;
			//		}
			//		catch (Exception ex)
			//		{
			//			transaction.Rollback();
			//			ex.ErrorGet();
			return false;
			//		}
			//	}
			//}
		}

		public async Task<ProductValidadeDbModal> GetProdutoDb(string text)
		{
			//List<ProdutoValidadeDbModal> temp = await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel().SetWhere("ID", text));

			return null;// temp == null ? null : temp.Count > 0 ? temp[0] : null;
		}

		public async Task<List<(int cat_id, string cat_name)>> GetCategoryList(List<int> list)
		{
			List<(int cat_id, string cat_name)> resp = new List<(int cat_id, string cat_name)>();

			//List<CategoriaDbModal> allCat = await eterDb.ActionDb.GETFIELDS<CategoriaDbModal>(new QueryWhereModel());

			//for (int i = 0; i < list.Count; i++)
			//{
			//	CategoriaDbModal cat = allCat.FirstOrDefault(x => x.ID == Convert.ToUInt32(list[i]));
			//	cat = cat ?? allCat.FirstOrDefault(x => x.ID == Convert.ToUInt32(1));
			//	resp.Add((
			//		list[i], cat?.NAME
			//		));
			//}

			return resp;
		}
		//public async Task<string> GetCategory(object id) => (await eterDb.ActionDb.GETFIELDS<CategoriaDbModal>(new QueryWhereModel().SetWhere("ID", id))).FirstOrDefault()?.NAME;

		public async Task<List<(long? id, string nameUser, string date)>> GetValityDate(DateTime dateTime)
		{
			//try
			//{
			//	List<(long? id, string nameUser, string date)> values = new List<(long? id, string nameUser, string date)>();

			//	List<ValidadeDbModal> tempResult = await eterDb.ActionDb.GETFIELDS<ValidadeDbModal>(new QueryWhereModel());
			//	tempResult = tempResult.Where(x => x.DATE.ToUnixDatetime()?.Month == dateTime.Month && x.DATE.ToUnixDatetime()?.Year == dateTime.Year).ToList();

			//	for (int i = 0; i < tempResult.Count; i++)
			//	{
			//		values.Add((tempResult[i].ID,
			//			(await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel().SetWhere("ID", tempResult[i].USER_ID))).FirstOrDefault().NOME, tempResult[i].DATE.ToUnixDatetime()?.ToShortDateString()));
			//	}
			//	return values;

			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();

			//}
			return null;

		}

		//public async Task<(ValidadeDbModal v, List<ProdutoValidadeDbModal> p)> GetEditVality(long idVality)
		//{
		//	ValidadeDbModal tempValidadeDbModal = (await eterDb.ActionDb.GETFIELDS<ValidadeDbModal>(new QueryWhereModel().SetWhere("ID", idVality))).FirstOrDefault(x => x.ID == idVality);

		//	List<ProdutoValidadeDbModal> produtoValidadeDbModals = await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel().SetWhere("VALIDADE_ID", tempValidadeDbModal.ID));
		//	if (tempValidadeDbModal != null)
		//	{
		//		return (tempValidadeDbModal, (await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel())).Where(x => x.VALIDADE_ID == Convert.ToInt32(tempValidadeDbModal.ID)).ToList());
		//	}
		//	return (tempValidadeDbModal, null);


		//}

		//public async Task<bool> ExportValityXLSX(long? vality_id, string filePath)
		//{
		//	try
		//	{
		//		ValidadeDbModal tempVT = (await eterDb.ActionDb.GETFIELDS<ValidadeDbModal>(new QueryWhereModel().SetWhere("ID", vality_id))).FirstOrDefault();

		//		List<ProdutoValidadeDbModal> tempPV = await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel().SetWhere("VALIDADE_ID", tempVT.ID));

		//		List<CategoriaDbModal> categoriaDbModals = new List<CategoriaDbModal>();

		//		(await GetCategoryList(tempPV.GroupBy(p => p.CATEGORIA_ID).Select(g => g.Key).ToList())).ForEach(item =>
		//		{
		//			categoriaDbModals.Add(new CategoriaDbModal { ID = item.cat_id, NAME = item.cat_name });
		//		});

		//		return await WriteValityExport.ExportValityExcel(new ValityExportModel { ID_LOJA = tempVT.USER_ID, NAME = (await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel().SetWhere("ID", tempVT.USER_ID))).FirstOrDefault().NOME, produtoValidadeDbModals = tempPV, categoriasDbModals = categoriaDbModals }, filePath, true);

		//	}
		//	catch (Exception ex)
		//	{
		//		ex.ErrorGet();
		//		return false;
		//	}
		//}
		//public async Task<bool> ExportValityXLSX(List<ProdutoValidadeDbModal> produtoValidadeDbModals, string filePath)
		//{
		//	try
		//	{
		//		return await WriteValityExport.ExportValityExcel(produtoValidadeDbModals, filePath);
		//	}
		//	catch (Exception ex)
		//	{
		//		ex.ErrorGet();
		//		return false;
		//	}
		//}

		//public async Task<List<ProdutoSetValityModel>> ImportProdutos(DateTime? dateTimeQuery, long? user_id, long? vality_id)
		//{
		//	QueryWhereModel queryWhereModel = new QueryWhereModel();
		//	queryWhereModel.SetWhere("DATE", dateTimeQuery.Value.ToShortDateString().ToDatetimeUnix(), "%LIKE");
		//	queryWhereModel.SetMult("USER_ID", user_id);
		//	var t1 = (await eterDb.ActionDb.GETFIELDS<ValidadeDbModal>(queryWhereModel)).FirstOrDefault();
		//	if (t1 is null)
		//	{
		//		return null;
		//	}

		//	var t2 = await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel().SetWhere("VALIDADE_ID", t1.ID));
		//	if (t2 is null)
		//	{
		//		return null;
		//	}


		//	List<ProdutoSetValityModel> produtoSetValityModel = new List<ProdutoSetValityModel>();
		//	using (var connection = new SQLiteConnection(eterDb.DatabaseConnection))
		//	{
		//		await connection.OpenAsync().ConfigureAwait(false);
		//		using (var transaction = connection.BeginTransaction())
		//		{
		//			try
		//			{
		//				t2.ForEach((data) => data.VALIDADE_ID = Convert.ToInt32(vality_id));
		//				for (int i = 0; i < t2.Count; i++)
		//				{
		//					long? tempIdV = await eterDb.ActionDb.INSERT(t2[i], connection, transaction);

		//					ProdutoSetValityModel item = new ProdutoSetValityModel().ConvertDbModel(t2[i], tempIdV);



		//					produtoSetValityModel.Add(item);
		//				}

		//				transaction.Commit();
		//				return produtoSetValityModel;
		//			}
		//			catch (Exception ex)
		//			{
		//				transaction.Rollback();
		//				ex.ErrorGet();
		//				return null;
		//			}
		//		}
		//	}

		//}

		//public async Task<UserModel> GetUser(long? uSER_ID)
		//{
		//	return (await eterDb.ActionDb.GETFIELDS<UserModel>(new QueryWhereModel().SetWhere("ID", uSER_ID))).First();
		//}
	}
}
