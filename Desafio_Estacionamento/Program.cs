using Desafio_Estacionamento.Models;

Console.WriteLine("\nBem vindo ao Sitema de Estacionamento!\n");

Estacionamento est = new Estacionamento();

Console.WriteLine("Digite o valor cobrado para entrar no estacionamento:");
est.ValorInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor cobrado por hora:");
est.ValorHora = decimal.Parse(Console.ReadLine());

string cont;

while (true)
{
    Console.WriteLine("\n===== MENU ======\n");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Retirar veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar sistema");

    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        est.Cadastrar();
        cont = Console.ReadLine();
    }
    else if (opcao == 2)
    {
        est.Remover();
        cont = Console.ReadLine();
    }
    else if (opcao == 3)
    {
        est.Listar();
        cont = Console.ReadLine();
    }
    else if (opcao == 4) 
    {
        Console.WriteLine("Encerrando sistema...");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente!");
        cont = Console.ReadLine();
    }
}

