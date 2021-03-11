using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcoloTariffe;
namespace TestTariffe
{
    [TestClass]
    public class Funsionamento
    {
        [TestMethod]
        public void Prova1()
        {
            int ore = 3;
            string risultato_effettivo = $"La migliore tariffa è la terza. Hai speso {2.40} euro";
            string risultato_aspettato = Operazioni.TariffaMigliore(ore);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void Prova2()
        {
            int ore = 24;
            string risultato_effettivo = $"La migliore tariffa è la prima. Hai speso {15} euro";
            string risultato_aspettato = Operazioni.TariffaMigliore(ore);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
    }
}
