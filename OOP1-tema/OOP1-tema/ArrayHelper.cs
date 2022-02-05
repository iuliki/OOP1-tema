using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1_tema
{
    static  class ArrayHelper
    {
       public static int [] Fib(int n)
        {
            int[] array = new int[n];
            array[0] = 0;
            if (n == 0)
                return array;

            array[1] = 1;
            if (n == 1)
                return array;

            int i = 1;
            while(i<n-1)
            {
                i++;
                array[i] = array[i - 1] + array[i - 2];

            }
            return array;


        }

        public static void Aparitii(int [] array,int element)
        {
            int nr = 0;
            if(array!= null)
            {
                    for(int i=0;i<array.Length;i++)
                                {
                                    if (array[i] == element)
                                        nr++;
                                }
            }
            

            Console.WriteLine($"elementul {element} apare de {nr} ori in vector ");
        }

        public static bool Identica(int[,] matrix)
        {
            bool isIdentica = true;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        if (matrix[i, j] != 0)
                            isIdentica = false;
                    }
                    else

                        if (matrix[i, j] != 1)
                        isIdentica = false;

                }
            }
            if (isIdentica == true)
                return true;
            else
                return false;

        }
    }
}
