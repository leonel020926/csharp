Cosole.WriteLine("conversion de gs a dolares");
Console.WriteLine("--------------------------)";
Console.WriteLine("escriba la cotizacion actual";
double cotizacion = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("montos en guaranies a convertir: ");
double guaranies = Convert.ToDouble(Console.ReadLine());
double dolares;
dolares = guaranies / cotizacion;
Colsole.WriteLine($"Son dolares {dolares:N2} dolares");