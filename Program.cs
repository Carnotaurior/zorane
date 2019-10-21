using System;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzivatel uz = new Uzivatel(25,'m',"654", 65482168765321);
            Uzivatel uzi = new Uzivatel();
            
            Console.WriteLine(uz.getVek());
            Console.WriteLine(uzi.getVek());
            Console.ReadKey();
        }
    }
}
