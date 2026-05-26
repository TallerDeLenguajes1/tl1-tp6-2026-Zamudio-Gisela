using System.ComponentModel;

Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("Valor de a: " + a);

Console.WriteLine("Valor de b: " + b);

Console.WriteLine("Ingrese un numero mayor a 0 para invertirlo: ");

int numero;
bool esInt;

do
{
    esInt = int.TryParse(Console.ReadLine(), out numero);

    if (!esInt || numero <= 0)
    {
        if (!esInt)
        {
            Console.WriteLine("EL valor ingresado NO es un numero");
        }

        if (esInt && numero <= 0)
        {
            Console.WriteLine("El numero ingresado no es mayor a 0");
        }

        Console.WriteLine("Vuelva a ingresar el numero: ");
    }

} while (!esInt || numero <= 0);

int resto;
int invertido = 0;

while (numero != 0)
{
    resto = numero % 10;
    invertido = invertido * 10 + resto;
    numero = numero / 10;
}

Console.WriteLine($"El invertido del numemro ingresado es: {invertido}");