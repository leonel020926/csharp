using System;
using System.Collections.Generic;

class Program
{
    static string FormatoGs(double precio)
    {
        return precio.ToString("N0") + " Gs.";
    }

    static void Main()
    {
        Dictionary<string, double> precios = new Dictionary<string, double>
        {
            {"MediaLuna", 2500},
            {"chipa", 3000},
            {"Pan por kilo", 12000},
            {"gaseosa", 8000},
            {"leche", 9500}
        };

        Dictionary<string, int> tasasIva = new Dictionary<string, int>
        {
            {"MediaLuna", 10},
            {"chipa", 10},
            {"Pan por kilo", 5},
            {"gaseosa", 10},
            {"leche", 5}
        };

        Console.WriteLine("=== Catalogo ===");

        foreach (string producto in precios.Keys)
        {
            Console.WriteLine(
                producto + ": " +
                FormatoGs(precios[producto]) +
                " (IVA " + tasasIva[producto] + "%)"
            );
        }
    }
}