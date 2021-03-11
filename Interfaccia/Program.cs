using System;
using CalcoloTariffe;

namespace Interfaccia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ci sono tre tariffe che puoi utilizzare, questo software ti aiuta a scegliere quella più economica");
            Console.WriteLine("     Tariffa A: 15 euro per l'intera giornata");
            Console.WriteLine("     Tariffa B: 1 euro l'ora");
            Console.WriteLine("     Tariffa C: la prima ora gratis e 1,20 euro per ogni ora successiva");
            Console.WriteLine("Il veicolo parcheggiato può risiedere nel parcheggio ad un massimo di 48 ore");
            Console.WriteLine("ATTENZIONE!!! Il numero inserito verrà preso in considerazione in ore");
            Console.WriteLine("Inserisci il periodo di tempo in ore, in cui vuoi parcheggiare la macchina");
            int ore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Operazioni.TariffaMigliore(ore));
        }
    }
}
