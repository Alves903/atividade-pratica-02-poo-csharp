using System;

class Veiculo
{
    public string marca;
    public string modelo;
    public int ano;
    public string cor;
    public string placa;

    public void MostrarVeiculo()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Cor: " + cor);
        Console.WriteLine("Placa: " + placa);
    }
}