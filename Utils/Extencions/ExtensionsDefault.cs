using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace EterPharmaPro.Utils.Extencions
{
	public static class ExtensionsDefault
	{
		public static string ReturnInt(this string value)
		{
			return Regex.Replace(value, "[^0-9]", string.Empty);
		}

		public static string ReturnFormation(this string value, FormatationEnum format)
		{
			try
			{
				if (value == "0" || value == "")
				{
					return string.Empty;
				}
				switch (format)
				{
					case FormatationEnum.CPF:
						return Convert.ToUInt64(value.ReturnInt()).ToString("000\\.000\\.000\\-00");
					case FormatationEnum.RG:
						return Convert.ToUInt64(value.ReturnInt()).ToString("00\\.000\\.000\\-0");
					case FormatationEnum.TELEFONE:
						{
							string tempR = value.ReturnInt();
							if (tempR.Length == 11)
							{
								return Convert.ToUInt64(tempR).ToString("\\(00\\) 00000\\-0000");
							}
							if (tempR.Length == 10)
							{
								return Convert.ToUInt64(tempR).ToString("\\(00\\) 0000\\-0000");
							}
							return tempR;
						}
				}
			}
			catch (Exception)
			{
				return value;
			}
			return null;
		}

		public static int ReturnIndexUserCB(this ComboBox cb, object id)
		{
			try
			{
				BindingSource sb = (BindingSource)cb.DataSource;
				Dictionary<string, string> tempD = (Dictionary<string, string>)sb.DataSource;
				int index = 0;
				foreach (KeyValuePair<string, string> item in tempD)
				{
					if (item.Key.Equals(id.ToString()))
					{
						return index;
					}
					index++;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return -1;
		}

		public static int ReturnIndexCategoryCB(this ComboBox cb, long? id)
		{
			try
			{
				BindingSource sb = (BindingSource)cb.DataSource;
				Dictionary<long?, string> tempD = (Dictionary<long?, string>)sb.DataSource;
				int index = 0;
				foreach (KeyValuePair<long?, string> item in tempD)
				{
					if (item.Key.Equals(id))
					{
						return index;
					}
					index++;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return -1;
		}

		public static int ReturnIndexFuncaoCB(this ComboBox cb, long? id)
		{
			try
			{
				BindingSource sb = (BindingSource)cb.DataSource;
				Dictionary<long?, string> tempD = (Dictionary<long?, string>)sb.DataSource;
				int index = 0;
				foreach (KeyValuePair<long?, string> item in tempD)
				{
					if (item.Key.Equals(id))
					{
						return index;
					}
					index++;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return -1;
		}

		public static async Task<ComboBox> CBListUserAsync(this ComboBox cb, bool isStatusAll = false)
		{
			List<UserDbModel> list = null;// await eterDb.ActionDb.GETFIELDS<UserDbModel>(new QueryWhereModel());

			Dictionary<string, string> users = new Dictionary<string, string>();

			foreach (var user in list)
			{
				string key = user.ID.ToString();

				string value = $"{user.ID_LOJA.ToString().PadLeft(4, '0')} - {user.NOME}";
				if (user.STATUS && !isStatusAll)
				{
					if (!users.ContainsKey(key))
					{
						users.Add(key, value);
					}
				}
				else if (isStatusAll)
				{
					if (!users.ContainsKey(key))
					{
						users.Add(key, value);
					}
				}

			}

			BindingSource bindingSource = new BindingSource
			{
				DataSource = users
			};

			cb.DataSource = bindingSource;
			cb.DisplayMember = "Value";
			cb.ValueMember = "Key";
			cb.SelectedIndex = 0;
			return cb;
		}
		public static ComboBox CBListUser(this ComboBox cb, List<UserDbModel> list, bool isStatusAll = false)
		{
			Dictionary<string, string> users = new Dictionary<string, string>();

			foreach (var user in list)
			{
				string key = user.ID.ToString();

				string value = $"{user.ID_LOJA.ToString().PadLeft(4, '0')} - {user.NOME}";
				if (user.STATUS && !isStatusAll)
				{
					if (!users.ContainsKey(key))
					{
						users.Add(key, value);
					}
				}
				else if (isStatusAll)
				{
					if (!users.ContainsKey(key))
					{
						users.Add(key, value);
					}
				}

			}

			BindingSource bindingSource = new BindingSource
			{
				DataSource = users
			};

			cb.DataSource = bindingSource;
			cb.DisplayMember = "Value";
			cb.ValueMember = "Key";
			cb.SelectedIndex = 0;
			return cb;
		}

		public static ComboBox CBListCategory(this ComboBox cb, List<CategoryDbModal> categoriaDbModal)
		{
			Dictionary<long?, string> cat = new Dictionary<long?, string>();

			cat.Add(1, "SEM CATEGORIA");


			for (int i = 0; i < categoriaDbModal.Count; i++)
			{
				long? key = categoriaDbModal[i].ID;
				if (!cat.ContainsKey(key))
				{
					cat.Add(key, categoriaDbModal[i].NAME);
				}
			}

			BindingSource bindingSource = new BindingSource
			{
				DataSource = cat
			};

			cb.DataSource = bindingSource;
			cb.DisplayMember = "Value";
			cb.ValueMember = "Key";
			cb.SelectedIndex = 0;
			return cb;
		}

		public static ComboBox CBListUserFuncao(this ComboBox cb, List<PositionDbModel> funcaoDbModels)
		{
			Dictionary<long?, string> func = new Dictionary<long?, string>();

			func.Add(1, "PADR�O");


			for (int i = 0; i < funcaoDbModels.Count; i++)
			{
				long? key = funcaoDbModels[i].ID;
				if (!func.ContainsKey(key))
				{
					func.Add(key, funcaoDbModels[i].NOME);
				}
			}

			BindingSource bindingSource = new BindingSource
			{
				DataSource = func
			};

			cb.DataSource = bindingSource;
			cb.DisplayMember = "Value";
			cb.ValueMember = "Key";
			cb.SelectedIndex = 0;
			return cb;
		}



		public static ComboBox CBListProps<T>(this ComboBox cb, List<T> type)
		{
			Dictionary<long?, string> func = new Dictionary<long?, string>();

			foreach (var item in type)
			{
				long? key = Convert.ToUInt32(typeof(T).GetProperty("ID").GetValue(item));
				if (!func.ContainsKey(key))
				{
					func.Add(key, typeof(T).GetProperty("NAME").GetValue(item).ToString());
				}
			}
			BindingSource bindingSource = new BindingSource
			{
				DataSource = func
			};

			cb.DataSource = bindingSource;
			cb.DisplayMember = "Value";
			cb.ValueMember = "Key";
			cb.SelectedIndex = 0;
			return cb;
		}

		public static int ReturnIndexPropsCB(this ComboBox cb, long? id)
		{
			try
			{
				BindingSource sb = (BindingSource)cb.DataSource;
				Dictionary<long?, string> tempD = (Dictionary<long?, string>)sb.DataSource;
				int index = 0;
				foreach (KeyValuePair<long?, string> item in tempD)
				{
					if (item.Key.Equals(id))
					{
						return index;
					}
					index++;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return -1;
		}

		public static async Task<AddressHttpModel> BuscaCepAsync(string cep)
		{
			HttpClient client = new HttpClient();
			cep = cep.ReturnInt();
			try
			{
				HttpResponseMessage response = await client.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");
				response.EnsureSuccessStatusCode();
				var temp = await response.Content.ReadAsStringAsync();
				if (temp.Contains("erro"))
				{
					return null;
				}

				return JsonConvert.DeserializeObject<AddressHttpModel>(temp);
			}
			catch (HttpRequestException val)
			{
				MessageBox.Show("Message :" + ((Exception)(object)val).Message, "Exception Caught!");
			}
			return null;
		}

		public static DateTime DateTimeDay(this DateTime dateTime)
		{
			return DateTime.Parse($"01/{DateTime.Now.Month}/{DateTime.Now.Year}");
		}


		public static long ToDatetimeUnix(this DateTime? dateTime) => ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
		public static long ToDatetimeUnix(this DateTime dateTime) => ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
		public static long ToDatetimeUnix(this string dateTime) => ((DateTimeOffset)Convert.ToDateTime(dateTime)).ToUnixTimeSeconds();
		public static DateTime? ToUnixDatetime(this long? DATE) => DATE.HasValue ? DateTimeOffset.FromUnixTimeSeconds(DATE.Value).DateTime : (DateTime?)null;
		public static string GetEnderecoArray(this List<AddressClienteDbModel> enderecoClienteModels, out int indexSelect)
		{
			try
			{
				if (enderecoClienteModels.Count == 0)
				{
					indexSelect = -1;
					return string.Empty;
				}
				if (enderecoClienteModels.Count == 1)
				{
					indexSelect = 0;
					return enderecoClienteModels[0].PLACE;

				}
				var tempEnd = new object[enderecoClienteModels.Count];
				for (int i = 0; i < tempEnd.Length; i++)
				{
					tempEnd[i] = new object[2]
					{
					i,
					enderecoClienteModels[i].PLACE
					};
				}
				var retList = InputList.Show(tempEnd, "Enderecos Cliente");
				if (retList != -1)
				{
					indexSelect = retList;
					return enderecoClienteModels[retList].PLACE;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			indexSelect = -1;
			return string.Empty;

		}

		public static AddressClienteDbModel GetEnderecoModel(this List<AddressClienteDbModel> enderecoClienteModels)
		{
			try
			{
				if (enderecoClienteModels.Count == 0)
				{
					return null;
				}
				if (enderecoClienteModels.Count == 1)
				{
					return enderecoClienteModels[0];

				}
				var tempEnd = new object[enderecoClienteModels.Count];
				for (int i = 0; i < tempEnd.Length; i++)
				{
					tempEnd[i] = new object[2]
					{
					i,
					enderecoClienteModels[i].PLACE
					};
				}
				var retList = InputList.Show(tempEnd, "Enderecos Cliente");
				if (retList != -1)
				{
					return enderecoClienteModels[retList];
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return null;

		}
		public static ClientDbModel GetClienteArray(this List<ClientDbModel> clienteModels)
		{
			try
			{
				//object[] tempEnd;
				//int retList;
				//if (clienteModels.Count > 1)
				//{
				//	tempEnd = new object[clienteModels.Count];
				//	for (int i = 0; i < tempEnd.Length; i++)
				//	{
				//		tempEnd[i] = new object[2]
				//		{
				//			i,
				//			"CLIENTE: " + clienteModels[i].NOME + $" | TOTAL DE ENDERE�OS: {(((List<EnderecoClienteDbModel>)clienteModels[i].ENDERECO != null) ? ((List<AddressClienteDbModel>)clienteModels[i].ID).Count : 0)}"
				//		};
				//	}
				//	retList = InputList.Show(tempEnd, "Clientes");
				//	if (retList == -1)
				//	{
				//		return null;
				//	}
				//	ClienteDbModel tempSelect = clienteModels[retList];
				//	tempSelect.ENDERECO = ((List<EnderecoClienteDbModel>)tempSelect.ENDERECO).GetEnderecoModel();
				//	return tempSelect;

				//}
				//else
				//{
				//	ClienteDbModel tempSelect = clienteModels[0];
				//	tempSelect.ENDERECO = ((List<EnderecoClienteDbModel>)tempSelect.ENDERECO).GetEnderecoModel();
				//	return tempSelect;
				//}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return null;
		}

		public static void StartVFD(this Control control)
		{

			ToolTip validationToolTip = new ToolTip
			{
				IsBalloon = true,
				ToolTipIcon = ToolTipIcon.Warning,
				ToolTipTitle = "Campo Obrigat�rio"
			};
			validationToolTip.Show("Este campo � obrigat�rio", control, 0, -40, 3000);
		}

		public static string PadRight(string text, int totalWidth)
		{
			if (text.Length >= totalWidth)
			{
				return text.Substring(0, totalWidth);
			}
			return text.PadRight(totalWidth);
		}


	}


}
