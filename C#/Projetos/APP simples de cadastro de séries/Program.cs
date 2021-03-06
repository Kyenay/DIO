using System;

namespace APP_simples_de_cadastro_de_séries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main (string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0){
                Console.WriteLine("Não há série cadastrada...");
                return;
            }

            foreach (var serie in lista){
                var excluido = serie.retornaExcluido;
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido? "*Excluido*" : ""));
            }
        }

        private static void InserirSerie()
        {
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("#ID {0}: - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o Gênero entre as opções acima(Não pode deixar em branco): ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série(Não pode deixar em branco): ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento da Série(Não pode deixar em branco): ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série(Não pode deixar em branco): ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (Genero)entradaGenero,
            titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("#ID {0}: - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o Gênero entre as opções acima(Não pode deixar em branco): ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série(Não pode deixar em branco): ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento da Série(Não pode deixar em branco): ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série(Não pode deixar em branco): ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie, genero: (Genero)entradaGenero,
            titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o ID da Série(Não pode deixar em branco): ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o ID da série(Não pode deixar em branco): ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir novas Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}