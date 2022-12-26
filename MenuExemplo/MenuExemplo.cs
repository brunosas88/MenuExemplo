using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExemplo
{
	class MenuExemplo
	{
		static void Main(string[] args)
		{
			string opcao;
			string mensagem = "";
			List<string> nomes = new List<string>();

			do
			{
				MostrarCabecalho("Menu Principal");
				MostrarMenuPrincipal();
				Console.WriteLine(string.IsNullOrEmpty(mensagem) ? "" : mensagem);
				Console.Write("Escolha a opção: ");

				opcao = Console.ReadLine();

				switch (opcao)
				{
					case "1":
						CadastrarUsuario(nomes);
						mensagem = "";
						break;
					case "2":
						MostrarUsuarios(nomes);
						mensagem = "";
						break;
					case "0":
						MostrarCabecalho("Volte Sempre");
						mensagem = "";
						break;
					default:
						mensagem = "Opção inválida. Favor escolher de 0 a 2";
						break;
				}

			} while (opcao != "0");
		}

		static void MostrarCabecalho(string subCabecalho)
		{
			Console.Clear();
			string titulo = "Byte-Bank";
			Console.WriteLine(new string('=', titulo.Length + 4));
			Console.WriteLine($"| {titulo} |");
			Console.WriteLine(new string('=', subCabecalho.Length + 4));
			Console.WriteLine($"| {subCabecalho} |");
			Console.WriteLine(new string('=', subCabecalho.Length + 4));
			Console.WriteLine();
		}

		static void MostrarMenuPrincipal()
		{
			Console.WriteLine("1 - Cadastrar Usuários");
			Console.WriteLine("2 - Listar Usuários Cadastrados");
			Console.WriteLine("0 - Sair\n");
		}

		static void MostrarUsuarios(List<string> nomes)
		{
			MostrarCabecalho("Listar Usuários Cadastrados");

			foreach (string nome in nomes)
				Console.WriteLine(nome);

			Console.WriteLine("\nAperte Enter para voltar ao menu principal");
			Console.ReadLine();
		}

		static void CadastrarUsuario(List<string> nomes)
		{
			MostrarCabecalho("Cadastrar Usuário");

			Console.Write("Escreva o nome do usuário a ser cadastrado: ");
			string novoNome = Console.ReadLine();

			nomes.Add(novoNome);

			Console.WriteLine("\nUsuario Cadastrado com Sucesso");

			Console.WriteLine("\nAperte Enter para voltar ao menu principal");
			Console.ReadLine();
		}
	}
}
