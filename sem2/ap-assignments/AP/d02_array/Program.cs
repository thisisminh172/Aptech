using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d02_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix44();
            JaggedMatrix44();
        }

        //demo ve mang 2 chieu hinh chu nhat(4,4)
        static void Matrix44()
        {
            Random r = new Random();
            Console.WriteLine("Nhap so phan tu trong mang");
            int n = int.Parse(Console.ReadLine().Trim());
            int[,] a = new int[n, n];
            for (int i =0; i<n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(0, 100);//tao so ngau nhien tu 0-100
                }
            }
            //in ma tran vuong 4x4 ra man hinh
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ,");
                }
                Console.WriteLine();
            }
        }

        //demo ve mang jagged array(bac thang, rang cua)
        static void JaggedMatrix44()
        {
            Random r = new Random();
            Console.WriteLine("Nhap so phan tu trong mang");
            int n = int.Parse(Console.ReadLine().Trim());
            int m = 0;
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap so phan tu cua dong {i+1}: ");
                m = int.Parse(Console.ReadLine().Trim());
                a[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = r.Next(0, 100);//tao so ngau nhien tu 0-100
                }
            }

            //in ma tran vuong 4x4 ra man hinh
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]} ,");
                }
                Console.WriteLine();
            }
        }

    }
}
