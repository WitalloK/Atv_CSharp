using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Especial conta = new Especial();
        conta.Consultar();

        double ReduzirLimite = conta.DiminuirLimite(200);
        if (ReduzirLimite >= 0)
        {
            Console.WriteLine("O limite após ser reduzido é: {0}", ReduzirLimite);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("O limite reduzido não pode ser inferior ao limite atual");
            Console.ReadLine();
        }

        double AumentarLimite = conta.AumentarLimite(100);
        Console.WriteLine("O limite após ser aumentado é: {0}", AumentarLimite);
        Console.ReadLine();

        Corrente banco = new Corrente();
        banco.ConsultarSaldo();

        double DepositarSaldo = banco.Depositar(300);
        Console.WriteLine("O saldo depositado é: {0}", DepositarSaldo);
        Console.ReadLine();

        double SacarSaldo = banco.Sacar(500);
        if (SacarSaldo >= 0)
        {
            Console.WriteLine("O saque foi de: {0}", SacarSaldo);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Não é possível sacar um valor maior que o depositado");
            Console.ReadLine();
        }

    }
}
