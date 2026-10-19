using System;

class Jugador
{
    public string Nombre;
    public int vida;

    public Jugador(string nombre, int vida)
    {
        Nombre = nombre;
        this.vida = vida;
    }

    public void RecibirAtaque(int puntos)
    {
        vida -= puntos;

        if (vida < 0)
        {
            vida = 0;
        }
    }

    public void Curar(int puntos)
    {
        vida += puntos;
    }

    public void Mostrar()
    {
        Console.WriteLine($"{Nombre}: {vida} puntos de vida");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Jugador j1 = new Jugador("fio", 50);
        Jugador j2 = new Jugador("tito", 50);

        j1.RecibirAtaque(30);
        j2.RecibirAtaque(15);

        j1.Mostrar();
        j2.Mostrar();

        Console.WriteLine("15 minutos de descanso");

        j1.Curar(15);
        j2.Curar(5);

        j1.Mostrar();
        j2.Mostrar();

        Console.ReadKey();
    }
}