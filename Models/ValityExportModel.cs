using EterLibrary.Domain.Entities.DbModels;

namespace EterPharmaPro.Models
{
	public class ValityExportModel
	{
		public long? ID_LOJA { get; set; }

		public string? NAME { get; set; }

		public ValityDbModal? ValityDbModal { get; set; }

		public List<CategoryDbModal>? Category { get; set; }

	}
}
