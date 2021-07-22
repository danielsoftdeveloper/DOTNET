using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						//ListarSeries();
                        Console.WriteLine(" entrou no case 1");
						break;
					case "2":
						//InserirSerie();
                         Console.WriteLine(" entrou no case 2");
						break;
					case "3":
						//AtualizarSerie();
                         Console.WriteLine(" entrou no case 3");
						break;
					case "4":
						//ExcluirSerie();
                         Console.WriteLine(" entrou no case 4");
						break;
					case "5":
						//VisualizarSerie();
                         Console.WriteLine(" entrou no case 5");
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado atualizar nossos cadastro de serviços.");
			Console.ReadLine();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("CADASTRAR SÉRIES");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }


    }
}
