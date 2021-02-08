using System;
using System.Collections.Generic;
using System.Linq;
using Classe_lista.Entities;

namespace Classe_lista
{
	class Program
	{
		static void Main(string[] args)
		{

			//Comparando um valor fixo em uma lista
			/*
			Produto produto = new Produto() { IdProduto = 1, Descricao = "TV", Price = 900.00};

			List<Produto> prod = new List<Produto>();

			prod.Add(new Produto(1, "Notebook", 1200.00));
			prod.Add(new Produto(2, "TV", 800.00));
			prod.Add(new Produto(3, "Geladeira", 1800.00));
			prod.Add(new Produto(4, "Fogão", 700.00));

			var novo = prod.Where(p => p.Descricao == produto.Descricao)
						   .Select(p => p)
						   .ToList();

			Console.WriteLine("Produtos: ");
			Console.WriteLine();
			foreach (var n in novo)
			{
				Console.WriteLine(n.IdProduto + " - " + n.Descricao);
			}
			*/


			//Comparando uma lista com outra lista
			List<Produto> prod1 = new List<Produto>();

			prod1.Add(new Produto(1, "Notebook", 2000.00));
			prod1.Add(new Produto(2, "TV", 800.00));
			prod1.Add(new Produto(3, "Geladeira", 1800.00));
			prod1.Add(new Produto(4, "Fogão", 800.00));

			List<Produto> prod2 = new List<Produto>();

			prod2.Add(new Produto(2, "TV", 800.00));
			prod2.Add(new Produto(3, "Geladeira", 1800.00));


			var prod1Filtrado = prod1.Where(p => prod2.Contains(p)).ToList();

			Console.WriteLine("Produtos: ");
			Console.WriteLine();

			foreach (Produto p1 in prod1Filtrado)
			{
				Console.WriteLine(p1);
			}

			Console.ReadKey();
		}
	}
}
