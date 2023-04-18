using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1:
            int numTotalItens = 0;
            double valorTotalCompra = 0;
            while (true)
            {
                Console.Write("Digite a quantidade de itens adquiridos, ou 0 para sair");
                int qtdItens = int.Parse(Console.ReadLine());
                if (qtdItens <= 0)
                {
                    break;
                }
                Console.Write("Digite o preço do produto");
                double preco = double.Parse(Console.ReadLine());
                double valorTotalProduto = qtdItens * preco;
                numTotalItens += qtdItens;
                valorTotalCompra += valorTotalProduto;
            }
            Console.WriteLine("Total de itens adquiridos: " + numTotalItens);
            Console.WriteLine("Valor total da compra" + valorTotalCompra.ToString("F2"));
            Console.ReadKey();
            */

            /*
            2:
            string nomeProduto, nomeProdutoMaisCaro = "", nomeProdutoMaisBarato = "";
            int quantidade, maiorQuantidade = 0, menorQuantidade = int.MaxValue;
            double preco, total;
            while (true)
            {
                Console.WriteLine("Digite o nome do produto (ou 'fim' para encerrar):");
                nomeProduto = Console.ReadLine();
                if (nomeProduto.ToLower() == "fim")
                {
                    break; 
                }
                Console.WriteLine("Digite a quantidade:");
                quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço:");
                preco = double.Parse(Console.ReadLine());
                total = quantidade * preco;
                if (total > maiorQuantidade)
                {
                    maiorQuantidade = (int)total;
                    nomeProdutoMaisCaro = nomeProduto;
                }
                if (total < menorQuantidade)
                {
                    menorQuantidade = (int)total;
                    nomeProdutoMaisBarato = nomeProduto;
                }
            }
            Console.WriteLine("Produto com maior investimento:");
            Console.WriteLine(nomeProdutoMaisCaro + " - R$ " + maiorQuantidade);
            Console.WriteLine("Produto com menor investimento:");
            Console.WriteLine(nomeProdutoMaisBarato + " - R$ " + menorQuantidade);
            Console.ReadKey();
            */

            /*
            3:
            Console.Write("Digite o número de avaliações: ");
            int numAvaliacoes = int.Parse(Console.ReadLine());
            double totalPesos = 0;
            for (int i = 1; i <= numAvaliacoes; i++)
            {
                Console.Write($"Digite o peso da avaliação {i}: ");
                double peso = double.Parse(Console.ReadLine());
                totalPesos += peso;
            }
            if (totalPesos < 100)
            {
                Console.WriteLine("A soma dos pesos é insuficiente.");
            }
            else if (totalPesos > 100)
            {
                Console.WriteLine("A soma dos pesos é excedente.");
            }
            else
            {
                Console.WriteLine("A soma dos pesos é adequada.");
                Console.ReadKey();
            }
            */

            /*
           4:
                 Console.Write("Digite a sigla do estado: ");
            string sigla = Console.ReadLine();

            string estado;
            switch (sigla.ToUpper())
            {
                case "AC":
                    estado = "Acre";
                    break;
                case "AL":
                    estado = "Alagoas";
                    break;
                case "AP":
                    estado = "Amapá";
                    break;
                case "AM":
                    estado = "Amazonas";
                    break;
                case "BA":
                    estado = "Bahia";
                    break;
                case "CE":
                    estado = "Ceará";
                    break;
                case "DF":
                    estado = "Distrito Federal";
                    break;
                case "ES":
                    estado = "Espírito Santo";
                    break;
                case "GO":
                    estado = "Goiás";
                    break;
                case "MA":
                    estado = "Maranhão";
                    break;
                case "MT":
                    estado = "Mato Grosso";
                    break;
                case "MS":
                    estado = "Mato Grosso do Sul";
                    break;
                case "MG":
                    estado = "Minas Gerais";
                    break;
                case "PA":
                    estado = "Pará";
                    break;
                case "PB":
                    estado = "Paraíba";
                    break;
                case "PR":
                    estado = "Paraná";
                    break;
                case "PE":
                    estado = "Pernambuco";
                    break;
                case "PI":
                    estado = "Piauí";
                    break;
                case "RJ":
                    estado = "Rio de Janeiro";
                    break;
                case "RN":
                    estado = "Rio Grande do Norte";
                    break;
                case "RS":
                    estado = "Rio Grande do Sul";
                    break;
                case "RO":
                    estado = "Rondônia";
                    break;
                case "RR":
                    estado = "Roraima";
                    break;
                case "SC":
                    estado = "Santa Catarina";
                    break;
                case "SP":
                    estado = "São Paulo";
                    break;
                case "SE":
                    estado = "Sergipe";
                    break;
                case "TO":
                    estado = "Tocantins";
                    break;
                default:
                    Console.WriteLine("Sigla de estado inválida.");
                    return;
            }

            Console.WriteLine("Estado correspondente à sigla: " +estado);
            Console.ReadKey();
            */

            /*
           5:
            Console.Write("Digite um número inteiro entre 1 e 12: ");
            int mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Estação: Verão");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Estação: Outono");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Estação: Inverno");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Estação: Primavera");
                    break;
                default:
                    Console.WriteLine("Mês inválido.");
                    break;
            }
            Console.ReadKey();
            */

            /*
            6:
            Console.Write("Digite o seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            Console.Write("Seu IMC é: " + imc.ToString("F2") + ". ");
            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc < 25.0)
            {
                Console.WriteLine("Você está com peso normal.");
            }
            else if (imc < 30.0)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else if (imc < 35.0)
            {
                Console.WriteLine("Você está com obesidade grau 1.");
            }
            else if (imc < 40.0)
            {
                Console.WriteLine("Você está com obesidade grau 2.");
            }
            else
            {
                Console.WriteLine("Você está com obesidade grau 3.");
            }
            Console.ReadKey();
            */

            /*
            7:
            Console.Write("Informe um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Divisores de {n}: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            */
        }
        }
    }
