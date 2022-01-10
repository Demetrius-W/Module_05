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
            int line, column, n;

            MatrixDimension(out line, out column, out n);
            MatrixCreation(line, column, n);
            Console.ReadLine();
        }

        /// <summary>
        /// Метод задания габаритов матрицы и числа
        /// </summary>
        /// <param name="line">Число строк матриц</param>
        /// <param name="column">Число столбцов матриц</param>
        /// <param name="n">Число</param>>
        static void MatrixDimension(out int line, out int column, out int n)
        {
            Console.Write("Введите число строк матриц: ");
            line = Int32.Parse(Console.ReadLine());
            Console.Write("Введите чиcло столбцов матриц: ");
            column = Int32.Parse(Console.ReadLine());
            Console.Write("Введите чиcло: ");
            n = Int32.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Метод создания матрицы и вывода произведения
        /// </summary>
        /// <param name="line">Строка матриц</param>
        /// <param name="column">Столбец матриц</param>
        /// <param name="n">Число</param>>
        /// <returns>Произведение матрицы на число</returns>
        static int[,] MatrixCreation(int line, int column, int n)
        {
            int[,] Matrix = new int[line, column];

            Random compiler = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Matrix[i, j] = compiler.Next(10);
                }
            }

            int[,] Result = new int[line, column];
            Console.WriteLine($"Матрица * {n}: ");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Result[i, j] = Matrix[i, j] * n;
                    Console.Write($"{Result[i, j]}\t");
                }
                Console.WriteLine();
            }

            return Result;
        }
    }
}

