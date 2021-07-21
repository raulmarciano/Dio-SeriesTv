using System;
using Dio_SeriesTv.Entities;
using Dio_SeriesTv.Repositories;

namespace Dio_SeriesTv
{
    class Program
    {
        static Repository<Series> repository = new Repository<Series>();
        static void Main(string[] args)
        {
           string opcaoSelecionada = null;

           while(opcaoSelecionada != "S")
           {
                MenuMount();

                Console.Write("Digite a opção desejada: ");
                opcaoSelecionada = Console.ReadLine();

                switch(opcaoSelecionada)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "5":
                        ListSerieById();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "S":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
           }
        }

        private static void ListSerieById()
        {
            throw new NotImplementedException();
        }

        private static void DeleteSerie()
        {
            throw new NotImplementedException();
        }

        private static void UpdateSerie()
        {
            throw new NotImplementedException();
        }

        private static void InsertSerie()
        {
            throw new NotImplementedException();
        }

        private static void ListSeries()
        {
            foreach(var serie in repository.ListRepository())
            {
                Console.Write($"#{serie.Id}");
                Console.Write($" | Nome: {serie.Name}");
                Console.Write($" | Titulo: {serie.Title}");
                Console.Write($" | Descricao: {serie.Description}");
                Console.Write($" | Deletada: {(serie.Deleted ? "Sim" : "Nao")}");

                MessageDefault();
            }
        }

        private static void MessageDefault()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

        private static void MenuMount()
        {
            Console.WriteLine("Series TV");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("1 - Listar todas");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Visualizar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("S - Sair");
        }

        private void teste()
        {
            foreach (int g in System.Enum.GetValues(typeof(EGenero))) 
            {
               
            }
        }
    }
}
