using System;

class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }
        return a / b;
    }
}

class CalculadoraCientifica : Calculadora
{
    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
    }

    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a)
    {
        return Math.Sqrt(a);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double a, double newBase)
    {
        return Math.Log(a, newBase);
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Calculadora miCalculadora = new Calculadora("Casio", "12345");

        
        CalculadoraCientifica miCalculadoraCientifica = new CalculadoraCientifica("HP", "67890");

        Console.WriteLine("Operaciones con la Calculadora:");
        Console.WriteLine("Suma: " + miCalculadora.Sumar(5, 3));
        Console.WriteLine("Resta: " + miCalculadora.Restar(10, 4));
        Console.WriteLine("Multiplicación: " + miCalculadora.Multiplicar(6, 7));
        Console.WriteLine("División: " + miCalculadora.Dividir(20, 5));

        Console.WriteLine("\nOperaciones con la Calculadora Científica:");
        Console.WriteLine("Potencia: " + miCalculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada: " + miCalculadoraCientifica.Raiz(25));
        Console.WriteLine("Módulo: " + miCalculadoraCientifica.Modulo(10, 3));
        Console.WriteLine("Logaritmo base 10: " + miCalculadoraCientifica.Logaritmo(100, 10));
    }
}
