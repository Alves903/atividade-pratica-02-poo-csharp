using System;

class Livro
{
    public string titulo;
    public string autor;
    public int ano;
    public string categoria;
    public bool disponivel;

    public void MostrarLivro()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine(disponivel ? "DISPONÍVEL" : "EMPRESTADO");
    }
}