using System.Globalization;

namespace Classe_lista.Entities
{
	public class Produto
	{
		public int IdProduto { get; set; }
		public string Descricao { get; set; }
		public double Price { get; set; }

		public Produto()
		{
		}

		public Produto(int idProduto, string descricao, double price)
		{
			IdProduto = idProduto;
			Descricao = descricao;
			Price = price;
		}

		public override int GetHashCode()
		{
			return IdProduto.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Produto))
				return false;
			Produto other = obj as Produto;
			return IdProduto.Equals(other.IdProduto);
		}

		public override string ToString()
		{
			return 
				""
				+ IdProduto 
				+ " - " 
				+ Descricao
				+ " - "
				+ Price.ToString("F2", CultureInfo.InvariantCulture);
		}

	}

}
