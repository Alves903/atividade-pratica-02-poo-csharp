using System;

class Equipamento
{
    public string patrimonio;
    public string tipo;
    public string marca;
    public string modelo;
    public string numeroSerie;
    public string status;

    public void MostrarEquipamento()
    {
        Console.WriteLine("Número: " + patrimonio);
        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Número de Série: " + numeroSerie);
        Console.WriteLine("Status: " + status);
    }
}