using System;

class Jogo
{
    public string nome;
    public string genero;
    public string plataforma;
    public int ano;
    public double nota;

    public void MostrarJogo()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Plataforma: " + plataforma);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Nota: " + nota);
    }
}