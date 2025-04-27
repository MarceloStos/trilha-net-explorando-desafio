using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// bool exibirMenu = true;
// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Melhorar no futuro
/* while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Bem-vindo ao sistema de gerenciamento!");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Suítes");
    Console.WriteLine("2 - Cadastrar Hospedes");
    Console.WriteLine("3 - Efetuar Reserva");
    Console.WriteLine("4 - Consultar Reserva");
    Console.WriteLine("5 - Encerrar Reserva");
    Console.WriteLine("6 - Encerrar");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar Suíte");
            break;

        case "2":
            Console.WriteLine("Cadastrar Hospedes");
            Console.WriteLine("Digite o nome do hóspede:");
            var nomeHospede = Console.ReadLine();
            var sobrenomeHospede = Console.ReadLine();
            Pessoa hospede = new Pessoa(nome: nomeHospede, sobrenome: sobrenomeHospede);
            hospedes.Add(hospede);

            
            break;

        case "3":
            Console.WriteLine("Efetuar Reserva");
            break;

        case "4":
            Console.WriteLine("Consultar Reserva");
            break;

        case "5":
            Console.WriteLine("Encerrar Reserva");
            break;

        case "6":
            Console.WriteLine("Encerrando o sistema...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} */

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");