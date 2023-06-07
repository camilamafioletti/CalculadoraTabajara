using System.Security.Permissions;

namespace CalculadoraTabajara.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            List<String> operacoes = new List<string>();

            while (true) 
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tajabara 1.0\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para Adição\n");

                Console.WriteLine("Digite 2 para Subtração\n");

                Console.WriteLine("Digite 3 para Multiplicação\n");

                Console.WriteLine("Diegite 4 para Divisão\n");

                Console.WriteLine("Digite 5 para Visualizar as operações\n");

                Console.WriteLine("Digite S para sair\n");

                Console.WriteLine("Opção: ");
                opcao = Console.ReadLine();


                #region calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                string operacao = "";

                switch (opcao)
                {
                    case "1": operacao = "Adição"; break;

                    case "2": operacao = "Subtração"; break;

                    case "3": operacao = "Multiplicação"; break;

                    case "4": operacao = "Divisão"; break;


                    case "5":
                        {
                            Console.WriteLine("Historico de operações");

                            Console.WriteLine("Visualizando operações realizadas: \n");

                            foreach (string op in operacoes)
                            {
                                Console.WriteLine(op);
                            }

                            Console.ReadLine();
                        };
                        continue;

                    default:
                        break;
                }

                #endregion

                #region resultado

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;

                    case "2": resultado = primeiroNumero - segundoNumero; break;

                    case "3": resultado = primeiroNumero * segundoNumero; break;
                        
                    case "4": resultado = primeiroNumero / segundoNumero; break;

                    default:
                        break;
                }

                Console.Clear();

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");

                string simbolo = "";
                switch (opcao)
                {
                    case "1": simbolo = "+"; break;

                    case "2": simbolo = "-"; break;

                    case "3": simbolo = "*"; break;

                    case "4": simbolo = "/"; break;

                    default:
                        break;
                }

                string descricaoOperacao = $"{primeiroNumero} {simbolo} {segundoNumero} = {resultado}";

                operacoes.Add(descricaoOperacao);

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

                #endregion
            }


        }
    }
}