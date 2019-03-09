using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 5, n = 6;
            int [,] mas=new int[m,n];
            Random r = new Random();
            for (int i= 0; i < m; i++)
            
            {
                
                //Console.WriteLine(i);
                for (int j = 0; j < n; j++)
                {
                    mas [i,j] = r.Next(-100, 100);
                    Console.Write(mas[i,j]+"\t");
                }
                Console.WriteLine();
                
            }

            int max = m, min = n;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (min > mas[i, j]) min = mas[i, j];
                    if (max < mas[i, j]) max = mas[i, j];
                }
            Console.WriteLine($"\nmin: {min}\tmax: {max}");

            int sum = 0;
            for (int i = 0; i<m; i++)
                for (int j =0; j <=n; j++)
                {
                    if(i==j)
                    sum += mas[i,j];
                       
                }

            Console.WriteLine($"\nсумма диагонали: {sum}");

            int x = 0, y = 0;
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] < max)
                    {
                        max = mas[i, j];
                        x = i + 1;
                        y = j + 1;
                    }
                    //else if (mas[i, j] == mas[0, 0])
                    //{
                    //    x= 1;
                    // }
                }
            }

            Console.Write($"номер строки: {x},номер столбца: {y}\n");
            



        }

    }
}