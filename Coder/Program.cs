using System;

namespace Coder
{
    class Program
    {
        static void SumMn(int[] M1, int[] M2, int[] M3, int N)
        {
            int i;
            for (i = 0; i < N; i++)
            {
                if (M1[i] == M2[i])
                    M3[i] = 0;
                else
                    M3[i] = 1;
            }
        }

        static void MultMn(int[] M1, int St, int[] M2, int N)
        {
            int i;
            for (i = 0; i < St; i++)
                M2[i] = 0;
            for (i = St; i < N; i++)
                M2[i] = M1[i - St];
        }

        static int St(int[] M1, int N)
        {
            int i, Res = -1;
            for (i = 0; i < N; i++)
            {
                if (M1[i] == 1)
                    Res = i;
            }
            return Res;
        }

        static void CopyMn(int[] M1, int[] M2, int N)
        {
            int i;
            for (i = 0; i < N; i++)
                M2[i] = M1[i];
        }

        static void DivMn(int[] Delim, int[] Delit, int[] Res, int N)
        {
            int k;
            int[] Tempmass = new int[15];
            int[] Tempmass2 = new int[15];
            while (St(Delim, N) >= St(Delit, N))
            {
                k = St(Delim, N) - St(Delit, N);
                MultMn(Delit, k, Tempmass, N);
                SumMn(Delim, Tempmass, Tempmass2, N);
                CopyMn(Tempmass2, Delim, N);
            }
            CopyMn(Delim, Res, N);
        }

        static void Main(string[] args)
        {
            int i, n = 15, k = 5;
            int[] G = { 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0 };
            int[] A = { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] V = new int[15];
            int[] T1 = new int[15];
            int[] R = new int[15];
            int[] T2 = new int[15];
            Console.WriteLine(" Informanionni vector A:");
            for (i = 0; i < 15; i++)
                Console.Write($"{A[i]} ");
            Console.WriteLine("\nPorojdayushi mnogochlen G:");
            for (i = 0; i < 15; i++)
                Console.Write($"{G[i]} ");
            MultMn(A, n - k, T1, n);
            CopyMn(T1, T2, n);
            DivMn(T2, G, R, n);
            SumMn(T1, R, V, n);
            Console.WriteLine("\nKodovi vector V:");
            for (i = 0; i < 15; i++)
                Console.Write($"{V[i]} ");
            Console.WriteLine("");
        }
    }
}
