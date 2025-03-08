namespace EterPharmaPro.Models
{
	[Serializable]
	public class SettingsAppModel
	{
		public int NUMBERSTORE { get; set; }

		public List<SettingsPoint> POINTS { get; set; }
	}

	public class SettingsPoint
	{
		public string NAMEPC { get; set; }

		public string PRINT_DEFAULT { get; set; }
		public string PRINT_TERMAL { get; set; }
	}
}
