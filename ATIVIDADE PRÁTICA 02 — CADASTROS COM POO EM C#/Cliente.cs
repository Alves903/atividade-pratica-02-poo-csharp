using System;

class Cliente
{
    public string nome;
    public int idade;
    public string cidade;
    public string email;
    public string telefone;

    public void ApresentarCliente()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Telefone: " + telefone);
    }
}