using System;

class Funcionario
{
    public string nome;
    public int idade;
    public string cargo;
    public double salario;
    public string setor;

    public void Apresentar()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário: R$ " + salario.ToString("F2"));
        Console.WriteLine("Setor: " + setor);
        Console.WriteLine("Salário Anual: R$ " + CalcularSalarioAnual().ToString("F2"));
    }

    public double CalcularSalarioAnual()
    {
        return salario * 12;
    }
}