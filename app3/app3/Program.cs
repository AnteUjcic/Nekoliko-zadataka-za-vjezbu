using System;

namespace app3
{
    /*
     Definirajte klasu Sort sa sljedećim članicama:
• metoda
void QuickSort(int[] arr, int left, int right) koja će sortirati
proslijeñeni niz u uzlaznom redoslijedu
Definirajte objekt tipa Sort, deklarirajte i definirajte niz arr tipa int s proizvoljnim vrijednostima
elemenata, te uz pomoće metode QuickSort sortirajte niz tako da prvi i zadnji član niza bez
obzira na njihovu vrijednost ostanu na svojim mjestima.
Ispišite sve elemente niza. 
     */
    class Program
    {
        static void Main(string[] args)
        {
          int[] niz = new int[] { 3, 2, 4, 0, 5, 1, 6, 7, 9, 8}; 
          Sort x = new Sort(); 
          x.QuickSort(niz, 1, niz.Length-2); 
            for (int i = 0; i < niz.Length; i++) 
                Console.WriteLine(niz[i]); 
        }
    }
}

