//CONVERTIR DATOS
using System;

int numeroEntero;
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("1. Convertir entero a decimal");

Console.WriteLine("Ingrese un número entero:");
numeroEntero = int.Parse(s: Console.ReadLine());

decimal numeroDecimal = (decimal)numeroEntero;

Console.WriteLine("El número decimal equivalente es: {0}", numeroDecimal);
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("2. Convertir decimal a flotante");
// Declarar variable decimal

// Convertir a flotante usando la clase Convert
float numeroFlotante = Convert.ToSingle(numeroDecimal);

// Mostrar el resultado
Console.WriteLine("Número decimal: " + numeroDecimal);
Console.WriteLine("Número flotante: " + numeroFlotante);

Console.WriteLine("El número decimal equivalente es: {0}", numeroDecimal);
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("3. Convertir decimal a flotante");
// Declarar variable flotante

// Convertir a entero usando la clase Convert
Convert.ToInt32(numeroFlotante);

// Mostrar el resultado
Console.WriteLine("Número flotante: " + numeroFlotante);
Console.WriteLine("Número entero: " + numeroEntero);
{
    Console.WriteLine("**Conversor de tipos de datos**");
    Console.WriteLine("--------------------------");
    Console.WriteLine("4. Convertir en un caracter a entero ");
    // Declarar variable caracter

    // Convertir a entero usando la clase Char
    int valorEntero = (int)char.GetNumericValue('A');

    // Mostrar el resultado
    Console.WriteLine("Caracter: " + 'A');
    Console.WriteLine("Valor entero: " + valorEntero);
}
// Declarar variable entero
Console.WriteLine("**Conversor de tipos de datos**");
Console.WriteLine("--------------------------");
Console.WriteLine("5. Convertir en un entero a caracte");
int _ = 65;

        // Convertir a caracter usando la clase Char
        char caracter = (char)numeroEntero;

        // Mostrar el resultado
        Console.WriteLine("Número entero: " + numeroEntero);
        Console.WriteLine("Caracter: " + caracter);
