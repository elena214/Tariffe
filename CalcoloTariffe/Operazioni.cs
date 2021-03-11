using System;

namespace CalcoloTariffe
{
    public class Operazioni
    {
        public static double CalcoloPrimaTariffa(int ore)
        {
            double prezzo = 15;
            if(ore>24)
            {
                return prezzo * 2;
            }
            else
            {
                return prezzo;
            }
        }
        public static double CalcoloSecondaTariffa(int ore)
        {
            double all_ora = 1;
            double prezzo = all_ora * ore;
            return prezzo;
        }
        public static double CalcoloTerzaTariffa(int ore)
        {
            double prezzo;
            int oreTot = ore - 1;
            double all_ora = 1.20;
            prezzo = all_ora * oreTot;
            return prezzo;
        }
        public static string TariffaMigliore(int ore)
        {
            double prezzo1 = CalcoloPrimaTariffa(ore);
            double prezzo2 = CalcoloSecondaTariffa(ore);
            double prezzo3 = CalcoloTerzaTariffa(ore);
            double minimo = prezzo1;
            minimo = Math.Min(minimo, prezzo2);
            if (ore > 1)
            {
                minimo = Math.Min(minimo, prezzo3);
                if (minimo == prezzo1)
                {
                    return $"La migliore tariffa è la prima. Hai speso {prezzo1} euro";
                }
                else if (minimo == prezzo2)
                {
                    return $"La migliore tariffa è la seconda. Hai speso {prezzo2} euro";
                }
                else
                {
                    return $"La migliore tariffa è la terza. Hai speso {prezzo3} euro";
                }
            }
            else 
            {
                if (minimo == prezzo1)
                {
                    return $"La migliore tariffa è la prima. Hai speso {prezzo1} euro";
                }
                else
                {
                    return $"La migliore tariffa è la seconda. Hai speso {prezzo2} euro";
                }
            }
        }
    }
}
