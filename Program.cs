using System.Text;
using Projeto_Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria Hospedes e cadastra na lista
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// cria a suite

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// cria uma nova reserva, passando a suite e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);        

// exibe a quantidade de hoespedes e o valor da diaria
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria()}");