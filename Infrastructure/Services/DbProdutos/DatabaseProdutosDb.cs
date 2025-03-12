using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Infrastructure.Services.DbProdutos
{
	public class DatabaseProdutosDb
	{
		public delegate void DatabaseProdutosLoadedEventHandler(bool complet);

		public ToolStripProgressBar _progressBar { get; private set; }
		private FileSystemWatcher _fileSystemWatcher;
		private DateTime _lastReadTime;


		public List<ProdutosModel> produtos;
		CancellationToken cancellationToken;


		private bool Await;

		public event DatabaseProdutosLoadedEventHandler DatabaseProdutosLoaded;

		public DatabaseProdutosDb(ToolStripProgressBar progressBar)
		{
			try
			{

				//InitWatch();
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}

			Await = false;
			_progressBar = progressBar;

			Init();
		}

		//private void InitWatch()
		//{
		//	_fileSystemWatcher = new FileSystemWatcher(ini.Read("IMPORTPRODUT", "FILE_WATCH"));
		//	_fileSystemWatcher.Filter = "*.xlsx";
		//	_fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size;
		//	_fileSystemWatcher.EnableRaisingEvents = true;

		//	_fileSystemWatcher.Changed += _fileSystemWatcher_Changed;
		//	_fileSystemWatcher.Created += _fileSystemWatcher_Changed;
		//}

		//private void _fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
		//{
		//	if (e.Name.StartsWith(ini.Read("IMPORTPRODUT", "FILENAME_WATCH")))
		//	{
		//		MessageBox.Show(e.FullPath);
		//	}
		//}


		private void Init()
		{
			Await = true;
			produtos = ActionBinary.ReadProdutos(/*_progressBar*/);
			Await = false;
			OnDatabaseLoaded();
		}

		public void Refresh() => Init();

		public bool CheckingLoad()
		{
			if (Await) { MessageBox.Show("Aguarde o carregamento total de todos os PRODUTOS.\n Mais informações no todapé da aplicação."); }
			return !Await;
		}

		protected virtual void OnDatabaseLoaded()
		{
			DatabaseProdutosLoaded?.Invoke(complet: true);
		}

		public string ReturnNameProduto(string cod)
		{
			string ret = produtos.Find((x) => x.EAN.Contains(cod.Trim()))?.DESCRICAO_PRODUTO;
			if (ret == null)
			{
				ret = produtos.Find((x) => x.COD_PRODUTO.Contains(cod.Trim())).DESCRICAO_PRODUTO;
			}
			return ret;
		}
	}
}
