using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Quiz
{
    // Alleen open vragen
    class Program
    {
        static void Main(string[] args)
        {
            List<Vraag> Vragen = new List<Vraag>
            {
                new Vraag {Tekst = "Welke kleur heeft een aardbei?", Antwoord = "Rood", Moeilijkheidsgraad = 1, Categorie = "Algemeen"},
                new Vraag {Tekst = "Wat is de hoofdstad van Nederland?", Antwoord = "Amsterdam", Moeilijkheidsgraad = 2, Categorie = "Algemeen"},
                new Vraag {Tekst = "Hoeveel snaren heeft een mandoline?", Antwoord = "8", Moeilijkheidsgraad = 3, Categorie = "Algemeen"},
                new Vraag {Tekst = "Hoe noem je een mannelijke schaap?", Antwoord = "Ram", Moeilijkheidsgraad = 1, Categorie = "Natuur"},
                new Vraag {Tekst = "In welk werelddeel komt de Hyena voor?", Antwoord = "Afrika", Moeilijkheidsgraad = 2, Categorie = "Natuur"},
                new Vraag {Tekst = "Welke zoogdier wordt met uitsterven bedreigd?", Antwoord = "Reuzenpanda", Moeilijkheidsgraad = 3, Categorie = "Natuur"}

             };
            var GesorteerdeVragen = Vragen.OrderBy(a => a.Moeilijkheidsgraad);
            int MGraad = 0;
            String categorie = "";

            Console.WriteLine("Kiezen uit MOEILIJKHEIDSGRAAD (type M)" + "\n" + "Kiezen uit CATEGORIE (type C)");
            String keuze = Console.ReadLine();
            if (keuze.Equals("M"))
            {
                Console.WriteLine("Kies MOEILIJKHEIDSGRAAD (1, 2, 3)");
                String MGraadString = Console.ReadLine();
                Int32.TryParse(MGraadString, out MGraad);

            } else if (keuze.Equals("C"))
            {
                Console.WriteLine("Kies CATEGORIE (Algemeen, Natuur)");
                categorie = Console.ReadLine();
            }

            GesorteerdeVragen.Where(x => x.Moeilijkheidsgraad == MGraad || x.Categorie.Equals(categorie)).ToList().ForEach(
                  x =>
                  {
                      x.Display();
                      Console.Write("Uw antwoord: ");
                      String antw = Console.ReadLine();
                      Console.WriteLine(x.CheckAntwoord(antw));
                  }
                  );

            Console.ReadLine();

        }
    }
}
