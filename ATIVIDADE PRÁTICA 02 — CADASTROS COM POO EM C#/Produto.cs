using System;

class Produto
{
    public string nome;
    public string categoria;
    public double preco;
    public int quantidade;

    public void MostrarProduto()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Preço: R$ " + preco.ToString("F2"));  //p duas casa dps da virgula
        Console.WriteLine("Quantidade: " + quantidade);
    }
}