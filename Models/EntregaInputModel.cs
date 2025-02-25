using EterLibrary.Domain.Entities.DbModels;

namespace EterPharmaPro.Models
{
	public class EntregaInputModel
	{
		public long? useridvend { get; set; }
		public DateTime? data { get; set; }

		public long? tipo { get; set; }

		public decimal valor { get; set; }

		public ClientDbModel clienteDbModel { get; set; }
	}
}
