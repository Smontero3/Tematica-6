using System;

class Program
{
    static void Main(string[] args)
    {
       
        int[] numeros = { 5, 2, 4, 1, 3, 9, 8, 7, 6, 10 };

      
        OrdenarBurbuja(numeros);
        Console.WriteLine("Números ordenados:");
        MostrarArreglo(numeros);

       
        int numeroABuscar = 7;
        int indice = BuscarNumero(numeros, numeroABuscar);
        if (indice != -1)
        {
            Console.WriteLine("El número {0} se encuentra en el índice {1}", numeroABuscar, indice);
        }
        else
        {
            Console.WriteLine("El número {0} no se encuentra en el conjunto", numeroABuscar);
        }

   
        int factorialIterativo = CalcularFactorialIterativo(5);
        int factorialRecursivo = CalcularFactorialRecursivo(5);
        Console.WriteLine("Factorial de 5 (iterativo): {0}", factorialIterativo);
        Console.WriteLine("Factorial de 5 (recursivo): {0}", factorialRecursivo);

        
        ProcesarConjuntosNumeros(numeros);
    }

  // Algoritmo de ordenamiento por burbuja
    static void OrdenarBurbuja(int[] numeros)
    {
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - i - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }
    }

   // Algoritmo de búsqueda binaria
    static int BuscarNumero(int[] numeros, int numeroABuscar)
    {
        int izq = 0;
        int der = numeros.Length - 1;

        while (izq <= der)
        {
            int medio = (izq + der) / 2;
            if (numeros[medio] == numeroABuscar)
            {
                return medio;
            }
            else if (numeros[medio] < numeroABuscar)
            {
                izq = medio + 1;
            }
            else
            {
                der = medio - 1;
            }
        }

        return -1;
    }

    // Función iterativa para calcular el factorial
    static int CalcularFactorialIterativo(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    // Función recursiva para calcular el factorial
    static int CalcularFactorialRecursivo(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * CalcularFactorialRecursivo(n - 1);
    }

        // Función para procesar conjuntos de números en grupos de cuatro

    static void ProcesarConjuntosNumeros(int[] numeros)
    {
        int baseLogaritmica = 2; 

        int casosExitosos = 0;
        int casosFallidos = 0;

        for (int i = 0; i < numeros.Length - 3; i += 4)
        {
            int a = numeros[i];
            int b = numeros[i + 1];
            int c = numeros[i + 2];
            int d = numeros[i + 3];

            int suma = a + d;
            int producto = b *c;

            if (producto == 0)
            {
                casosFallidos++;
                continue;
            }

            string ecuacion = $"{suma} = log_{baseLogaritmica}({producto})";
            Console.WriteLine(ecuacion);
            casosExitosos++;
        }

        Console.WriteLine("Casos exitosos:", casosExitosos);
        Console.WriteLine("Casos fallidos:", casosFallidos);
    }

     // Función para mostrar el contenido de un arreglo
    static void MostrarArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
    }
}