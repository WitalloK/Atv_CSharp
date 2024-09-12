using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Especial: Corrente
{
    private double Limite = 500;

    public double limite { get => Limite; set => Limite = value; }

    public void Consultar()
    {
        Console.WriteLine("O limite é: {0}", limite);
        Console.ReadLine();
    }

    public double DiminuirLimite(double valor)
    {
        double LimiteDiminuido = Limite - valor;
        return LimiteDiminuido;
    }

    public double AumentarLimite(double valor)
    {
        double LimiteAumentado = Limite + valor;
        return LimiteAumentado;
    }
}


