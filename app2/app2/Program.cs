using System;

namespace app2
{
    class Program
    {
        /*
         Definirajte klasu KlasaB sa sljedećim članicama:
• metoda
string BezPrvogIZadnjeg(string) koja će vratiti proslijeñeni string bez prvog i
zadnjeg znaka.
Definirajte objekt tipa KlasaB, zatražite od korisnika da unese niz znakova, te taj niz znakova
proslijedite metodi BezPrvogIZadnjeg, a povratnu vrijednost ispišite. Osigurajte pritom da se
metoda pozove samo ako je korisnik unio više od 2 znaka.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:"); 
            
            string s = Console.ReadLine(); 
            
            KlasaB x = new KlasaB();
            if (s.Length > 2)
            {
                s = x.BezPrvogIZadnjeg(s); 
                Console.WriteLine(s);
            }
        }
    }
}
