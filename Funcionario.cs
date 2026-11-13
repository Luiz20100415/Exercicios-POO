using System;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; private set; }

    public Funcionario(string nome, string cargo, double salarioInicial)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salarioInicial;
    }

    public void AumentarSalario(double percentual)
    {
        if (percentual > 0)
        {
            Salario += Salario * (percentual / 100.0);
        }
    }

    public void ConsultarSalario()
    {
        Console.WriteLine($"Funcionário: {Nome} | Cargo: {Cargo} | Salário atual: R$ {Salario:F2}");
    }
}