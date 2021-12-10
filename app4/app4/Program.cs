using System;

namespace app4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[] { 3, 2, 4, 0, 5, 1, 6, 7, 9, 8 };
            Sort.QuickSort(niz, 0, niz.Length- 1); 
            for (int i = 0; i < niz.Length; i++) 
                Console.WriteLine(niz[i]);
        }
    }
}
