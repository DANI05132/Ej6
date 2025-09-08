using System;

class Program {
    static void Main() {
        int[,] matriz = {
            {1, 3, 4},
            {9, 6, 7},
            {5, 8, 2}
        };

        Console.WriteLine("El recorrido del arreglo por Renglón es:");
        for (int z = 0; z < 3; z++) {
            for (int x = 0; x < 3; x++) {
                Console.Write(matriz[z, x] + " ");
            }
        }
        Console.WriteLine("\n");

        Console.WriteLine("El recorrido del arreglo por Columna es:");
        for (int x = 0; x < 3; x++) {
            for (int z = 0; z < 3; z++) {
                Console.Write(matriz[z, x] + " ");
            }
        }
        Console.WriteLine();
    }
}
