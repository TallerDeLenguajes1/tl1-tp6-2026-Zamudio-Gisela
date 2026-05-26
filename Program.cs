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

// // Console.WriteLine($"El invertido del numemro ingresado es: {invertido}");


int opcion, repetir = 0;
float num1, num2, resultado;
bool esopInt, esnum1float, esnum2float, esrepInt;

do
{
    Console.WriteLine("************************  CALCULADORA  ****************************");

    do
    {
        Console.WriteLine("Ingrese el numero que coresponda a la operacion que desea realizar");
        Console.WriteLine("         SUMAR ---------------->   1");
        Console.WriteLine("         RESTAR --------------->   2");
        Console.WriteLine("         MULTIPLICAR ---------->   3");
        Console.WriteLine("         DIVIDIR -------------->   4");

        esopInt = int.TryParse(Console.ReadLine(), out opcion);

        if (!esopInt)
        {
            Console.WriteLine("El valor ingresado no es un numero");
        }

    } while (!esopInt || (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4));

    do
    {
        Console.WriteLine("Ingrese en primer numero: ");
        esnum1float = float.TryParse(Console.ReadLine(), out num1);

        if (!esnum1float)
        {
            Console.WriteLine("El valor ingresado no es un numero");
        }
    } while (!esnum1float);

    do
    {
        Console.WriteLine("Ingrese el segundo numero: ");
        esnum2float = float.TryParse(Console.ReadLine(), out num2);

        if (!esnum2float)
        {
            Console.WriteLine("El valor ingresado no es un numero");
        }
    } while (!esnum2float);


    switch (opcion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"El resultado de la SUMA es: {resultado}");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"El resultado de la RESTA es: {resultado}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"El resultado de la MULTIPLICACION es: {resultado}");
            break;
        case 4:
            resultado = num1 / num2;
            Console.WriteLine($"El resultado de la DIVISION es: {resultado}");
            break;
        default:
            break;
    }

    do
    {
        Console.WriteLine("Desea realizar otro calculo?: ");
        Console.WriteLine("  'SI', presione ----->  1");
        Console.WriteLine("  'NO', presione ----->  0");
        esrepInt = int.TryParse(Console.ReadLine(), out repetir);

        if (!esrepInt)
        {
            Console.WriteLine("El valor ingresado no es un numero");
        }
    } while (!esrepInt || (repetir != 1 && repetir != 0));

    if (repetir == 0)
    {
        Console.WriteLine("************************  FIN  ****************************");
    }
} while (repetir == 1);




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

