using System;
Console.WriteLine("ingrese su eded");
int edad = Convert.ToInt32(Console.ReadLine());
if (edad >=18) { Console.WriteLine("bievenido");
    if (edad >= 20)
    { Console.WriteLine("desea una bebida"); 
    }else {
        Console.WriteLine("desea coca");
    }
}
else { Console.WriteLine("acceso denegado");
}