using System;

class Pedido
{
    public int numero;
    public string cliente;
    public string produto;
    public int quantidade;
    public double valorUnitario;

    public void MostrarPedido()
    {
        Console.WriteLine("Número: " + numero);
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Produto: " + produto);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Valor Unitário: " + valorUnitario);
        Console.WriteLine("Total: R$ " + CalcularTotal().ToString("F2"));
    }

    public double CalcularTotal()
    {
        return quantidade * valorUnitario;
    }

}