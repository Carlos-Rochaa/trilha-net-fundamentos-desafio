using DesafioFundamentos.Models;
using System.Globalization;


Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial, precoPorHora;

Estacionamento es = new Estacionamento();



try
{
    Console.Write("Seja bem vindo ao sistema de estacionamento!\n" +
              "Digite o preço inicial: ");
    while (!decimal.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out precoInicial))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        Console.Write("Digite o preço inicial: ");
    }
    Console.Write("Digite o preço por hora: ");
    while (!decimal.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out precoPorHora))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        Console.Write("Digite o preço por hora: ");
    }



    es = new Estacionamento(precoInicial, precoPorHora);
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida, insira valores válidos.");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro inesperado: " + e.Message);
}

bool exibirMenu = true;


while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine();

    Console.Write("Sua escolha: ");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
