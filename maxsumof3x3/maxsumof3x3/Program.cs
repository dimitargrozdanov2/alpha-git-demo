using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxsumof3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] input2 = input.Split(' ');
            int N = int.Parse(input2[0]);
            int M = int.Parse(input2[1]);
            //Console.WriteLine(N);
            //Console.WriteLine(M);
            string[] matrix2 = new string[N];
            int sum = 0;
            int MaxSum = Int32.MinValue;
            int[,] matrix3 = new int[N, M];
           
            for (int i = 0; i < N; i++)
            {
                string matrix = Console.ReadLine();
                matrix2 = matrix.Split(' ', '\n');
                int[] matrix4 =  Array.ConvertAll(matrix2, int.Parse);
                for (int j = 0; j < M; j++)
                {
                    matrix3[i, j] = matrix4[j];
                }
            }
            // Имаме матрицата сега трябва да създадем подматрици и да сметнем сбора им
            // Взимаме най-големият сбор и го отпечатваме.

            for (int i = 0; i < N-2; i++)
            {
                for (int j = 0; j < M-2; j++)
                {
                    int r = 0;
                    int c = 0;
                    sum = 0;

                    if ((M - (j) >= 3) && (N - (i) >= 3))
                    {
                        for (int k = i; k < i + 3; k++)
                        {
                            c = 0;
                            for (int l = j; l < j + 3; l++)
                            {



                                sum += matrix3[k,l] ;

                                c++;
                            }
                            r++;
                        }

                    }
                    MaxSum = Math.Max(sum, MaxSum);

                }

            }
            Console.WriteLine(MaxSum);
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j   = 0; j < M; j++)
            //    {
            //        Console.Write(matrix[i,j] + " ");
            //    }
            //}
        }
    }
}
