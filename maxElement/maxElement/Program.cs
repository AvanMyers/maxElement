using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int MassMaxSize = 10;
            int MassMaxSpace = 10;
            int massCell = 0;
            int[,] array = new int[MassMaxSize, MassMaxSpace];

            Console.WriteLine("Массив до изменнения: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("]");
            }

            Console.WriteLine("Массив после изменения: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int maxElement = 0;
                int massElementLine = i;
                massCell = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                        massCell = j;
                    }
                }
                array[massElementLine, massCell] = 0;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("]");
            }
            Console.ReadKey();
        }
    }
}
