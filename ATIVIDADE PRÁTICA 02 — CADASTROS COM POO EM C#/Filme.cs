using System;

class Filme
{
    public string titulo;
    public string genero;
    public int ano;
    public int duracao;
    public double nota;

    public void ExibirInformacoes()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Duração: " + duracao + " minutos");
        Console.WriteLine("Nota: " + nota);
    }
}