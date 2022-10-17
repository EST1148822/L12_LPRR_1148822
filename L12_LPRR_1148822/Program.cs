using System;

class Program
{
    static void Main()
    {
        int[] notas = new int[14];

        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine("Ingrese nota ");
            notas[i] = int.Parse(Console.ReadLine());
        }

        double promedio = 0;
        double suma = 0;
        for (int i = 0; i < 14; i++)
        {
            suma = suma + notas[i];
        }

        promedio = suma / 14;
        Console.WriteLine("El promedio es " + promedio);
    }
}
