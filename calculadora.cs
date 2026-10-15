using System;
double CalcularSubtotal (double precio,int cantidad)
{ return precio * cantidad; }
double AplicarDescuento(double monto, int perocentaje)
{
    return monto - monto * perocentaje / 100;
}

double Subtotal = CalcularSubtotal(1560000, 2);
double descuento;
descuento = AplicarDescuento(Subtotal, 5);
Console.WriteLine($"Subtotal = {Subtotal}");
Console.WriteLine($" con descuento del 5% = {descuento}");