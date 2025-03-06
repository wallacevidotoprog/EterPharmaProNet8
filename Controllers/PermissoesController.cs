using EterPharmaPro.Enums;
using EterPharmaPro.Models;

namespace EterPharmaPro.Controllers
{
	public class PermissoesController
	{
		private int _permissoes;

		public PermissionModel _permissoesE;

		public PermissoesController(int permissoes)
		{
			_permissoes = permissoes;
		}
		public PermissoesController(PermissionModel permissoes)
		{
			_permissoesE = permissoes;
			//_permissoes = Add()
		}

		public PermissoesController(PermissionsEnum[] permissoesIniciais)
		{
			if (permissoesIniciais.Length != 0)
			{
				AddArray(permissoesIniciais);

			}
		}

		public void AddArray(PermissionsEnum[] permissoesIniciais)
		{
			for (int i = 0; i < permissoesIniciais.Length; i++)
			{
				Add(permissoesIniciais[i]);
			}
		}

		private int iAddArray(PermissionsEnum[] permissoesIniciais)
		{
			int tempPerm = 0;
			for (int i = 0; i < permissoesIniciais.Length; i++)
			{
				tempPerm |= (int)permissoesIniciais[i];
			}
			return tempPerm;
		}

		public void Add(PermissionsEnum permissao)
		{
			_permissoes |= (int)permissao;
		}

		public void Remove(PermissionsEnum permissao)
		{
			_permissoes &= ~(int)permissao;
		}

		public bool HasPermission(PermissionsEnum permissao)
		{
			return (_permissoes & (int)permissao) != 0;
		}
		public bool HasPermission(int permissao)
		{
			return (_permissoes & permissao) != 0;
		}
		public bool HasPermission(PermissionsEnum[] permissao,int copas)
		{
			foreach (var item in permissao)
			{
				int permissoes = 0;

				permissoes = iAddArray(permissao);

				if (permissoes==0)
				{
					return true;
				}

				return (permissoes & copas) != 0;
			}
			return false;
		}
		public int GetPermissionsAsInt()
		{
			return _permissoes;
		}

		public List<PermissionsEnum> GetActivePermissions()
		{
			List<PermissionsEnum> activePermissions = new List<PermissionsEnum>();

			foreach (PermissionsEnum perm in Enum.GetValues(typeof(PermissionsEnum)))
			{
				if (perm != PermissionsEnum.Padrao && HasPermission(perm))
				{
					activePermissions.Add(perm);
				}
			}

			return activePermissions;
		}

	}
}
