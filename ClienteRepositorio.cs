using Cadastro;

namespace Repositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void GravarDadosCliente()
    {
        var jason = System.Text.Json.JsonSerializer.Serialize(clientes);
        File.WriteAllText("clientes.txt", jason);
    }

    public void LerDadosCliente()
    {
        if(File.Exists("clientes.txt"))
        {
            var dados = File.ReadAllText("clientes.txt");
            var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);
            clientes.AddRange(clientesArquivo);
        }

    }

    public void AdicionarCliente()
    {
        Console.Clear();

        Console.WriteLine("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("Email do Cliente: ");
        var email = Console.ReadLine();
        Console.Write(Environment.NewLine);
        
        Console.WriteLine("Telefone do Cliente: ");
        var telefone = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);
        
        Console.WriteLine("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);
        
        Console.WriteLine("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);
        
        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1;
        cliente.Nome = nome;
        cliente.Email = email;
        cliente.Telefone = telefone;
        cliente.DataCadastro = DateTime.Now;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso!");
        ImprimirClientes(cliente);
        Console.ReadKey();
    }

    public void ImprimirClientes(Cliente cliente)
    {
        Console.WriteLine("ID.............:" + cliente.Id);
        Console.WriteLine("Nome...........:" + cliente.Nome);
        Console.WriteLine("Email..........:" + cliente.Email);
        Console.WriteLine("Telefone.......:" + cliente.Telefone);
        Console.WriteLine("Data Cadastro..:" + cliente.DataCadastro);
        Console.WriteLine("Data Nascimento:" + cliente.DataNascimento);
        Console.WriteLine("Desconto.......:" + cliente.Desconto.ToString("0.00"));
        Console.WriteLine("----------------------");

    }

    public void ListarCliente()
    {
        Console.Clear();
        foreach (var cliente in clientes)
        {
            ImprimirClientes(cliente);
        }
        Console.ReadKey();

    }

    public void AtualizarCliente()
    {
        Console.Clear();
        Console.WriteLine("Informe o codigo do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(c => c.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado!");
            Console.ReadKey();
            return;
        }

        ImprimirClientes(cliente);

        Console.WriteLine("Nome do Cliente: ");
        cliente.Nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("Email do Cliente: ");
        cliente.Email = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("Telefone do Cliente: ");
        cliente.Telefone = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        
        Console.WriteLine("Data de Nascimento: ");
        cliente.DataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("Desconto: ");
        cliente.Desconto = decimal.Parse(Console.ReadLine());

        cliente.Nome = cliente.Nome;
        cliente.Email = cliente.Email;
        cliente.Telefone = cliente.Telefone;
        cliente.DataNascimento = cliente.DataNascimento;
        cliente.Desconto = cliente.Desconto;

        Console.WriteLine("Cliente atualizado com sucesso!");
        ImprimirClientes(cliente);
        Console.ReadKey();
    }

    public void ExcluirCliente()
    {
        Console.Clear();
        Console.WriteLine("Informe o codigo do cliente: ");
        var codigo = Console.ReadLine();
        
        var cliente = clientes.FirstOrDefault(c => c.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado!");
            Console.ReadKey();
            return;
        }

        ImprimirClientes(cliente);
        clientes.Remove(cliente);
        Console.WriteLine("Cliente excluído com sucesso!");
        Console.ReadKey();
    }
}