using System;

class Persona
{
    public string Nombre { get; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void Presentarse()
    {
        Console.WriteLine("Hola, soy " + Nombre + ".");
    }
}

class Cliente : Persona
{
    public string Telefono { get; }

    public Cliente(string nombre, string telefono) : base(nombre)
    {
        Telefono = telefono;
    }
}

class Producto
{
    public string Nombre { get; }
    public double Precio { get; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class PedidoDetalle
{
    public Producto Producto { get; }
    public int Cantidad { get; }

    public PedidoDetalle(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }

    public double SubTotal()
    {
        return Producto.Precio * Cantidad;
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo de Persona y Cliente
        Console.WriteLine("=== DATOS DEL CLIENTE ===");

        Cliente cliente = new Cliente(
            "Leonel Caballero",
            "0981 123 456"
        );

        cliente.Presentarse();
        Console.WriteLine("Telefono: " + cliente.Telefono);

        // Ejemplo de Producto y PedidoDetalle
        Console.WriteLine("\n=== DETALLE DEL PEDIDO ===");

        Producto gaseosa = new Producto("Gaseosa 50ml", 6000);

        PedidoDetalle linea = new PedidoDetalle(gaseosa, 3);

        Console.WriteLine(
            linea.Cantidad + " x " +
            linea.Producto.Nombre + " = " +
            linea.SubTotal().ToString("N0") + " Gs"
        );

        Console.WriteLine(
            "El producto existe por si solo: " + gaseosa.Nombre
        );
    }
}