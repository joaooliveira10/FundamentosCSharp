namespace Cadastro;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public decimal Telefone { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateOnly DataNascimento { get; set; }
    public decimal Desconto { get; set; }
}