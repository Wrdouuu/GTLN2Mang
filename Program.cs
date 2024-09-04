using System;

namespace MAX2CHIEU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so hang cua mang: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot cua mang: ");
            int y = int.Parse(Console.ReadLine());

            int[,] arr= new int[x,y];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu arr[{0}, {1}] = ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int MAX;
    
            MAX = arr[0, 0];

            for(int a=0; a<x; a++)
            {
                for (int b=0; b<y; b++)
                {
                    if(arr[a,b]>MAX)
                    {
                        MAX=arr[a,b];
                    }
                }
            }
            Console.WriteLine("MAX ="+ MAX );

        }
    }
}
