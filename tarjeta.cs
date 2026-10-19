using System;

class Tarjeta
{
    private int _saldo;

    public string Titular { get; }

    public int Saldo
    {
        get { return _saldo; }
    }

    public Tarjeta(string titular)
    {
        Titular = titular;
        _saldo = 0;
    }

    public bool Recargar(int monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("monto invalido");
            return false;
        }

        _saldo += monto;
        return true;
    }

    public bool pagar(int monto)
    {
        if (monto > _saldo || monto <= 0)
        {
            Console.WriteLine("saldo insuficiente");
            return false;
        }

        _saldo -= monto;
        return true;
    }
}

class Program
{
    static void Main()
    {
        Tarjeta tarjeta = new Tarjeta("leonel caballero");

        tarjeta.Recargar(20000);
        tarjeta.pagar(3400);
        tarjeta.pagar(20000);

        Console.WriteLine("titular: " + tarjeta.Titular);
        Console.WriteLine("saldo: " + tarjeta.Saldo + "Gs");
    }
}