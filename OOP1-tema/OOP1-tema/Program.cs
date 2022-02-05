using System;

namespace OOP1_tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("pana la ce numar sa se calculeze secventa fibonacii ;");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Calculul secventei fibonacci este: ");
            int [] vector = ArrayHelper.Fib(n);

            for(int j=0 ; j< vector.Length; j++)
            {
                
                    Console.WriteLine(vector[j] + " ");
            }


            Console.WriteLine("ne de elemente din vector= ");
            int nr = Int32.Parse(Console.ReadLine());
            int[] array2 = new int[nr];

            for(int i=0;i<array2.Length;i++)
            {
                Console.WriteLine($"elementul {array2[i]}=");
                array2[i] = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("elementul a carui secventa vreau sa o vad este: ");
            int numar = Int32.Parse(Console.ReadLine());
            ArrayHelper.Aparitii(array2,numar);

            Console.WriteLine("Numarul de linii: ");
            int row = Int32.Parse(Console.ReadLine());
           
            int[,] matrix = new int[row, row];

            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    Console.WriteLine($"elemtul {matrix[i, j]}= ");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            if (ArrayHelper.Identica(matrix) == true)
                Console.WriteLine("matricea este identica ");
            else
                Console.WriteLine("matricea nu este identica");





        }
    }
}
