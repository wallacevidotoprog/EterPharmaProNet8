using EterPharmaPro.Enums;

namespace EterPharmaPro.Models
{
	public class PermissionModel
	{
		public PermissionsEnum[] ADD { get; set; } = new PermissionsEnum[] { PermissionsEnum.Padrao };
		public PermissionsEnum[] UPDATE { get; set; } = new PermissionsEnum[] { PermissionsEnum.Padrao };
		public PermissionsEnum[] DELETE { get; set; } = new PermissionsEnum[] { PermissionsEnum.Padrao };
		public PermissionsEnum[] VIEW { get; set; } = new PermissionsEnum[] { PermissionsEnum.Padrao };
	}
}
