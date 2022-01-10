using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int line, column;

            MatrixDimension(out line, out column);
            MatrixCreation(line, column);
            Console.ReadLine();
        }

        /// <summary>
        /// Метод задания габаритов матриц
        /// </summary>
        /// <param name="line">Число строк матриц</param>
        /// <param name="column">Число столбцов матриц</param>
        static void MatrixDimension(out int line, out int column)
        {
            Console.Write("Введите число строк матриц: ");
            line = Int32.Parse(Console.ReadLine());
            Console.Write("Введите чиcло столбцов матриц: ");
            column = Int32.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Метод создания матриц и вывод произведения
        /// </summary>
        /// <param name="line">Строка матриц</param>
        /// <param name="column">Столбец матриц</param>
        /// <returns>Произведение матриц</returns>
        static int[,] MatrixCreation(int line, int column)
        {
            int[,] FirstMatrix = new int[line, column];
            int[,] SecondMatrix = new int[line, column];

            Random compiler = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    FirstMatrix[i, j] = compiler.Next(10);
                    SecondMatrix[i, j] = compiler.Next(10);
                }
            }

            int[,] MultiplicationMatrix = new int[line, column];
            Console.WriteLine("Произведение матриц: ");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    MultiplicationMatrix[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
                    Console.Write($"{MultiplicationMatrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            return MultiplicationMatrix;
        }
    }
}
