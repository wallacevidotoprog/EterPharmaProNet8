using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Infrastructure.Services.XLSX;
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

				if (user_id == EterCache.Instance.UserDbModel.ID)
				{
					await EterCache.Instance.RefreshUserDbModel();
				}

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
			if (!EterCache.Instance.DatabaseProdutosDb.CheckingLoad())
			{
				inLoad = true;
				return null;
			}
			inLoad = false;
			return EterCache.Instance.DatabaseProdutosDb.produtos;

		}

		private void DatabaseProdutosLoaded(bool complet) => isLoadProd = complet;

		public ProdutosModel GetProduto(string text, out bool inLoad)
		{
			if (!EterCache.Instance.DatabaseProdutosDb.CheckingLoad())
			{
				inLoad = true;
				return null;
			}
			inLoad = false;
			return (text.Trim().Length >= 7) ? EterCache.Instance.DatabaseProdutosDb.produtos.Find((ProdutosModel x) => x.EAN.Contains(text.Trim())) : EterCache.Instance.DatabaseProdutosDb.produtos.Find((ProdutosModel x) => x.COD_PRODUTO.Contains(text.Trim().Replace(" ", null).PadLeft(6, '0')));
		}

		public async Task<(bool, long?)> CreateProdutoVality(SetValityModel setValityModel)
		{
			try
			{
				var tempIdV = await EterCache.Instance.EterDb.ProductValidadeService.AddAsync(new ProductValidadeDbModal
				{
					PRODUTO_CODIGO = setValityModel.produto.codigo,
					PRODUTO_DESCRICAO = setValityModel.produto.descricao,
					QUANTIDADE = setValityModel.produto.quantidade,
					DATA_VALIDADE = setValityModel.produto.dateVality,
					ID_CATEGORIA = setValityModel.produto.category_id,
					ID_VALIDADE = (int)setValityModel.vality_id
				});

				return (true, tempIdV.ID);
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return (false, -1);
			}
		}

		public async Task<List<CategoryDbModal>> GetCategoryUser()
		{
			return EterCache.Instance.UserDbModel.Category.ToList();
		}

		public async Task<bool> UpdateProdutoVality(SetValityModel setValityModel)
		{
			try
			{
				await EterCache.Instance.EterDb.ProductValidadeService.UpdateAsync(new ProductValidadeDbModal
				{
					ID = setValityModel.produto.id,
					PRODUTO_CODIGO = setValityModel.produto.codigo,
					PRODUTO_DESCRICAO = setValityModel.produto.descricao,
					QUANTIDADE = setValityModel.produto.quantidade,
					DATA_VALIDADE = setValityModel.produto.dateVality,
					ID_CATEGORIA = setValityModel.produto.category_id,
					ID_VALIDADE = (int)setValityModel.vality_id
				});

				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}

		public async Task<bool> DeleteProduto(int temp)
		{
			try
			{
				await EterCache.Instance.EterDb.ProductValidadeService.RemoveAsync(temp);
				return true;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}

		/// <summary>
		/// --------------------------------------------------------------------- REVISAR ISSO DEPOIS
		/// </summary>
		public async Task<ProductValidadeDbModal> GetProdutoDb(string text)
		{
			ProductValidadeDbModal tempObjUg = await EterCache.Instance.EterDb.ProductValidadeService.GetByAsync(p => p.ID == Convert.ToInt32(text));

			//List<ProdutoValidadeDbModal> temp = await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel().SetWhere("ID", text));

			return tempObjUg;// temp == null ? null : temp.Count > 0 ? temp[0] : null;
		}

		public async Task<List<(long? cat_id, string cat_name)>> GetCategoryList(List<long?> list)
		{
			List<(long? cat_id, string cat_name)> resp = new List<(long? cat_id, string cat_name)>();

			List<CategoryDbModal> allCat = EterCache.Instance.EterDb.CategoryService.GetAllAsync().Result.ToList();


			foreach (var item in list)
			{
				resp.Add((item, allCat.FirstOrDefault(x => x.ID == item)?.NAME ?? string.Empty));
			}


			return resp;
		}

		public string GetCategory(long? id) => EterCache.Instance.EterDb.CategoryService.GetByAsync(f => f.ID == id).Result.NAME ?? "SEM CATEGORIA";


		public async Task<List<(long? id, string nameUser, string date)>> GetValityDate(DateTime dateTime)
		{
			try
			{
				List<(long? id, string? nameUser, string? date)> values = new List<(long? id, string? nameUser, string? date)>();

				List<ValityDbModal> tempResult = (await EterCache.Instance.EterDb.ValityService.GetAllAsync(null, p => p.UserModel)).ToList();

				tempResult = tempResult.Where(x => x.DATE?.Month == dateTime.Month && x.DATE?.Year == dateTime.Year).ToList();

				for (int i = 0; i < tempResult.Count; i++)
				{
					values.Add((tempResult[i]?.ID,
						tempResult[i].UserModel?.NOME,
						tempResult[i].DATE?.ToShortDateString()));
				}
				return values;

			}
			catch (Exception ex)
			{
				ex.ErrorGet();

			}
			return null;

		}

		public async Task<(ValityDbModal v, List<ProductValidadeDbModal> p)> GetEditVality(long? idVality)
		{
			ValityDbModal tempValidadeDbModal = await EterCache.Instance.EterDb.ValityService.GetByAsync(p => p.ID == idVality, i => i.ProductValidades);

			var te = await EterCache.Instance.EterDb.ProductValidadeService.GetAllAsync(p => p.ID_VALIDADE == idVality, i => i.Vality);

			if (tempValidadeDbModal != null)
			{
				return (tempValidadeDbModal, tempValidadeDbModal.ProductValidades.ToList());
			}
			return (tempValidadeDbModal, null);


		}

		public async Task<bool> ExportValityXLSX(long? vality_id, string filePath)
		{
			try
			{
				ValityDbModal tempVT = await EterCache.Instance.EterDb.ValityService.GetByAsync(p => p.ID == vality_id, i => i.ProductValidades, i => i.UserModel);

				if (tempVT is null)
				{
					throw new Exception($"Vality or User not found.\nValityDbModal=>{tempVT}\nUserDbModel=>{tempVT.UserModel}");
				}

				List<CategoryDbModal> cat = (await EterCache.Instance.EterDb.CategoryService.GetAllAsync(f => f.ID_USER == tempVT.ID_USER)).ToList();

				foreach (var item in tempVT?.ProductValidades)
				{
					item.Category = cat == null ? new CategoryDbModal { ID = 1, NAME = "SEM CATEGORIA" } : cat.FirstOrDefault(x => x.ID == item.ID_CATEGORIA);
				}

				return await WriteValityExport.ExportValityExcel(
					new ValityExportModel
					{
						ID_LOJA = tempVT.UserModel.ID_LOJA,
						NAME = tempVT.UserModel.NOME,
						ValityDbModal = tempVT,
						Category = cat,
					}, filePath, true);

			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}
		public async Task<bool> ExportValityXLSX(List<ProductValidadeDbModal> produtoValidadeDbModals, string filePath)
		{
			try
			{
				return await WriteValityExport.ExportValityExcel(produtoValidadeDbModals, filePath);
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
				return false;
			}
		}


		/// <summary>
		/// --------------------------------------------------------------------- REVISAR ISSO DEPOIS
		/// </summary>
		public async Task<List<ProdutoSetValityModel>> ImportProdutos(DateTime? dateTimeQuery, long? user_id, long? vality_id)
		{
			//QueryWhereModel queryWhereModel = new QueryWhereModel();
			//queryWhereModel.SetWhere("DATE", dateTimeQuery.Value.ToShortDateString().ToDatetimeUnix(), "%LIKE");
			//queryWhereModel.SetMult("USER_ID", user_id);
			//var t1 = (await eterDb.ActionDb.GETFIELDS<ValidadeDbModal>(queryWhereModel)).FirstOrDefault();
			//if (t1 is null)
			//{
			//	return null;
			//}

			//var t2 = await eterDb.ActionDb.GETFIELDS<ProdutoValidadeDbModal>(new QueryWhereModel().SetWhere("VALIDADE_ID", t1.ID));
			//if (t2 is null)
			//{
			return null;
			//}


			//List<ProdutoSetValityModel> produtoSetValityModel = new List<ProdutoSetValityModel>();
			//using (var connection = new SQLiteConnection(eterDb.DatabaseConnection))
			//{
			//	await connection.OpenAsync().ConfigureAwait(false);
			//	using (var transaction = connection.BeginTransaction())
			//	{
			//		try
			//		{
			//			t2.ForEach((data) => data.VALIDADE_ID = Convert.ToInt32(vality_id));
			//			for (int i = 0; i < t2.Count; i++)
			//			{
			//				long? tempIdV = await eterDb.ActionDb.INSERT(t2[i], connection, transaction);

			//				ProdutoSetValityModel item = new ProdutoSetValityModel().ConvertDbModel(t2[i], tempIdV);



			//				produtoSetValityModel.Add(item);
			//			}

			//			transaction.Commit();
			//			return produtoSetValityModel;
			//		}
			//		catch (Exception ex)
			//		{
			//			transaction.Rollback();
			//			ex.ErrorGet();
			//			return null;
			//		}
			//	}
			//}

		}

		public async Task<List<UserDbModel>> GetUsers() => EterCache.Instance.EterDb.UserService.GetAllAsync().Result.ToList();
	}
}
