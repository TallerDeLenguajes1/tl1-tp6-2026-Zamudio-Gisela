using System.ComponentModel;

// Console.WriteLine("Hello, World!");

// int a;

// int b;

// a = 10;

// b = a;

// Console.WriteLine("Valor de a: " + a);

// Console.WriteLine("Valor de b: " + b);

// Console.WriteLine("Ingrese un numero mayor a 0 para invertirlo: ");

// int numero;
// bool esInt;

// do
// {
//     esInt = int.TryParse(Console.ReadLine(), out numero);

//     if (!esInt || numero <= 0)
//     {
//         if (!esInt)
//         {
//             Console.WriteLine("EL valor ingresado NO es un numero");
//         }

//         if (esInt && numero <= 0)
//         {
//             Console.WriteLine("El numero ingresado no es mayor a 0");
//         }

//         Console.WriteLine("Vuelva a ingresar el numero: ");
//     }

// } while (!esInt || numero <= 0);

// int resto;
// int invertido = 0;

// while (numero != 0)
// {
//     resto = numero % 10;
//     invertido = invertido * 10 + resto;
//     numero = numero / 10;
// }

// Console.WriteLine($"El invertido del numemro ingresado es: {invertido}");


float num3, num4, num5, vAbs;
double cuadrado, raiz, seno, coseno;
int parteEntera;
bool esnum3float, esnum4float, esnum5float;

do
{
    Console.WriteLine("Ingrese un numero: ");
    esnum3float = float.TryParse(Console.ReadLine(), out num3);

    if (!esnum3float)
    {
        Console.WriteLine("El valor ingresado no es un numero");
    }
} while (!esnum3float);

double nume3 = Convert.ToDouble(num3);
double radianes = nume3 * Math.PI / 180;

if (esnum3float)
{
    // Valor absoluto:
    vAbs = Math.Abs(num3);
    Console.WriteLine($"Valor Absoluto de {num3} = {vAbs}");
    // Cuadrado de un numero:
    cuadrado = Math.Pow(nume3, 2);
    Console.WriteLine($"Cuadrado de {num3} = {cuadrado}");
    // Raiz Cuadrada:
    raiz = Math.Sqrt(nume3);
    Console.WriteLine($"Raiz Cuadrada de {num3} = {raiz}");
    // Seno:
    seno = Math.Sin(radianes);
    Console.WriteLine($"Seno de {num3} grados = {seno}");
    // Coseno:
    coseno = Math.Cos(radianes);
    Console.WriteLine($"Coseno de {num3} grados = {coseno}");
    // Parte entera de un Float:
    parteEntera = (int)num3;
    Console.WriteLine($"Parte entera de {num3} = {parteEntera}");
}


Console.WriteLine("Ingrese dos numeros");

do
{
    Console.WriteLine("  Primer numero: ");
    esnum4float = float.TryParse(Console.ReadLine(), out num4);

    if (!esnum4float)
    {
        Console.WriteLine("El Primer valor ingresado no es un numero");
    }
} while (!esnum4float);

do
{
    Console.WriteLine("  Segundo numero: ");
    esnum5float = float.TryParse(Console.ReadLine(), out num5);

    if (!esnum5float)
    {
        Console.WriteLine("El Segundo valor ingresado no es un numero");
    }
} while (!esnum5float);

if (esnum4float && esnum5float)
{
    // Maximo entre dos numeros:
    if (num4 == num5)
    {
        Console.WriteLine("Los dos numeros son iguales");
    }
    else if (num4 > num5)
    {
        Console.WriteLine($"El maximo entre los dos numeros es = {num4}");
        Console.WriteLine($"El minimo entre los dos numeros es = {num5}");
    }
    else
    {
        Console.WriteLine($"El maximo entre los dos numeros es = {num5}");
        Console.WriteLine($"El minimo entre los dos numeros es = {num4}");
    }
}

