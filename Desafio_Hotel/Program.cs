using Desafio_Hotel.models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

p1.Nome = "Fernando";
p2.Nome = "Henrique";

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite();
suite.TipoSuite = "Premium";
suite.Capacidade = 3;
suite.ValorDiaria = 90;

Reserva reserva = new Reserva();
reserva.DiasReservados = 10;
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de hospedes: {reserva.ObterQntdHospedes()}");
Console.WriteLine($"Valor total: {reserva.CalcularValorTotal()}");