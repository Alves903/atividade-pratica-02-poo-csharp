using System;

class Curso
{
    public string nome;
    public int cargaHoraria;
    public string professor;
    public string modalidade;
    public int quantidadeVagas;

    public void MostrarCurso()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Carga Horária: " + cargaHoraria);
        Console.WriteLine("Professor: " + professor);
        Console.WriteLine("Modalidade: " + modalidade);
        Console.WriteLine("Quantidade de Vagas: " + quantidadeVagas);
    }
}