//Nombre del estudiante: Daniela Guzman
//Grupo: 213022_386
//Numero y texto del programa: ejercicio 3 Se solicita la creación de una aplicación que elabore una matriz de 4 × 4 en la cual se almacenarán números entre el 3 y el 6 ambos incluidos que se deben capturar por teclado. Una vez obtenida la información se debe establecer cuantas veces se repiten cada uno de los números del 3 al 6 y hallar la potenciade ellos de acuerdo con las veces que se repita. Se debe mostrar por pantalla la matriz generada y las potencias de los 4 números.
//Codigo fuente:

using System;

class Program
{
    static void Main()
    {
        // Definir la matriz de 4x4
        int[,] matriz = new int[4, 4];

        // Definir contadores para los números del 3 al 6 y potencias
        int contador3 = 0, contador4 = 0, contador5 = 0, contador6 = 0;
        int potencia3 = 0, potencia4 = 0, potencia5 = 0, potencia6 = 0;

        // Capturar los números y llenar la matriz
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int numero;
                do
                {
                    Console.Write($"Ingrese un número entre 3 y 6 para la posición [{i}, {j}]: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                } while (numero < 3 || numero > 6);

                matriz[i, j] = numero;

                switch (numero)
                {
                    case 3:
                        contador3++;
                        potencia3 = (int)Math.Pow(3, contador3);
                        break;
                    case 4:
                        contador4++;
                        potencia4 = (int)Math.Pow(4, contador4);
                        break;
                    case 5:
                        contador5++;
                        potencia5 = (int)Math.Pow(5, contador5);
                        break;
                    case 6:
                        contador6++;
                        potencia6 = (int)Math.Pow(6, contador6);
                        break;
                }
            }
        }

        // Mostrar la matriz generada
        Console.WriteLine("\nMatriz generada:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Mostrar las potencias de los números del 3 al 6
        Console.WriteLine($"\nPotencia de 3: {potencia3}");
        Console.WriteLine($"Potencia de 4: {potencia4}");
        Console.WriteLine($"Potencia de 5: {potencia5}");
        Console.WriteLine($"Potencia de 6: {potencia6}");
    }
}

