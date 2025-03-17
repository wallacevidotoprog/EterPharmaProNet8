using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EterPharmaPro.Models
{
	public class UnidadeFederativa
	{
		public string Nome { get; set; }
		public string Sigla { get; set; }

		public UnidadeFederativa(string nome, string sigla)
		{
			Nome = nome;
			Sigla = sigla;
		}
	}

	public static class UFs
	{
		public static readonly List<UnidadeFederativa> Lista = new List<UnidadeFederativa>
	{
		new UnidadeFederativa("Acre", "AC"),
		new UnidadeFederativa("Alagoas", "AL"),
		new UnidadeFederativa("Amapá", "AP"),
		new UnidadeFederativa("Amazonas", "AM"),
		new UnidadeFederativa("Bahia", "BA"),
		new UnidadeFederativa("Ceará", "CE"),
		new UnidadeFederativa("Distrito Federal", "DF"),
		new UnidadeFederativa("Espírito Santo", "ES"),
		new UnidadeFederativa("Goiás", "GO"),
		new UnidadeFederativa("Maranhão", "MA"),
		new UnidadeFederativa("Mato Grosso", "MT"),
		new UnidadeFederativa("Mato Grosso do Sul", "MS"),
		new UnidadeFederativa("Minas Gerais", "MG"),
		new UnidadeFederativa("Pará", "PA"),
		new UnidadeFederativa("Paraíba", "PB"),
		new UnidadeFederativa("Paraná", "PR"),
		new UnidadeFederativa("Pernambuco", "PE"),
		new UnidadeFederativa("Piauí", "PI"),
		new UnidadeFederativa("Rio de Janeiro", "RJ"),
		new UnidadeFederativa("Rio Grande do Norte", "RN"),
		new UnidadeFederativa("Rio Grande do Sul", "RS"),
		new UnidadeFederativa("Rondônia", "RO"),
		new UnidadeFederativa("Roraima", "RR"),
		new UnidadeFederativa("Santa Catarina", "SC"),
		new UnidadeFederativa("São Paulo", "SP"),
		new UnidadeFederativa("Sergipe", "SE"),
		new UnidadeFederativa("Tocantins", "TO")
	};
	}

}
