using System.Globalization;
using Repositorio;

namespace AppClientes;

class Program
{
    static ClienteRepositorio _clienterepositorio = new ClienteRepositorio();
    static void Main(string[] args)
    {

        var cultura = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentCulture = cultura;
        Thread.CurrentThread.CurrentUICulture = cultura;

        _clienterepositorio.LerDadosCliente();
        
        while(true)
        {
            Menu();
            Console.ReadKey();
        }
    }

    static void Menu()
    {   
        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("----------------------");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Listar Clientes");
        Console.WriteLine("3 - Atualizar Cliente");
        Console.WriteLine("4 - Excluir Cliente");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("----------------------");

        EscolherOpcao();
    }

    static void EscolherOpcao()
    {
        Console.WriteLine("Escolha uma opção: ");

        var opcao = Console.ReadLine();

        switch (int.Parse(opcao))
        {
            case 1:
                _clienterepositorio.AdicionarCliente();
                Menu();
                break;
            case 2:
                _clienterepositorio.ListarCliente();
                Menu();
                break;
            case 3:
                _clienterepositorio.AtualizarCliente();
                Menu();
                break;
            case 4:
                _clienterepositorio.ExcluirCliente();
                Menu();
                break;
            case 5:
                _clienterepositorio.GravarDadosCliente();
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
