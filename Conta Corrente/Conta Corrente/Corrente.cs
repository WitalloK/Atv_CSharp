using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Corrente
{
    public string Usuario { get; set; }
    public int Senha { get; set; }
    public string Banco { get; set; }

    public double Saldo = 300;

    public double saldo { get => Saldo; set => Saldo = value; }

    public void ConsultarSaldo()
    {
        Console.WriteLine("O saldo atual é: {0}", saldo);
        Console.ReadLine();
    }

    public double Depositar(double valor)
    {
        double DepositarBanco = Saldo + valor;
        return DepositarBanco;
    }

    public double Sacar(double valor)
    {
        double SacarBanco = Saldo - valor;
        return SacarBanco;
    }


}
