
using System;

public class Calculadora
{
    // Métodos de instância
    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método estático
    public static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return 0;
        }
        return a / b;
    }
}