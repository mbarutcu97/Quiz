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
                new Vraag {Tekst = "Welke zoogdier wordt met uitsterven bedreigd?", Antwoord = "Reuzenpanda", Moeilijkheidsgraad = 3, Categorie = "Natuur"},
                new MultipleVraag {Tekst = "Hoe heet de maker van Java?", Antwoord = "1", Keuzes = new List<string> { "James Gosling", "Mark Rutte", "Donald Trump" }, Moeilijkheidsgraad = 1, Categorie = "Algemeen"},
                new MultipleVraag {Tekst = "Hoe heet de president van China?", Antwoord = "2", Keuzes = new List<string> { "Hoe Lang", "Xi Jinping", "Jackie Chan" }, Moeilijkheidsgraad = 2, Categorie = "Algemeen"},
                new MultipleVraag {Tekst = "Welk dier heeft het dodelijkste gif ter wereld?", Antwoord = "3", Keuzes = new List<string> { "Cobra", "Mug", "Kwal" }, Moeilijkheidsgraad = 3, Categorie = "Natuur"}

             };
            var GesorteerdeVragen = Vragen.OrderBy(a => a.Moeilijkheidsgraad);
            int MGraad = 0;
            string categorie = "";
            Console.WriteLine("WELKOM");
            Console.WriteLine("Kies uit MOEILIJKHEIDSGRAAD (type M)" + " OF \n" + "Kies uit CATEGORIE (type C)");
            string keuze = Console.ReadLine();
            if (keuze.Equals("M"))
            {
                Console.WriteLine("Kies MOEILIJKHEIDSGRAAD (1, 2, 3)");
                string MGraadString = Console.ReadLine();
                Int32.TryParse(MGraadString, out MGraad);

            } else if (keuze.Equals("C"))
            {
                Console.WriteLine("Kies CATEGORIE (Algemeen, Natuur)");
                categorie = Console.ReadLine();
            }
            int count = 0;
            GesorteerdeVragen.Where(x => x.Moeilijkheidsgraad == MGraad || x.Categorie.Equals(categorie)).ToList().ForEach(
                  x =>
                  {
                      count++;
                      Console.Write("Vraag " + count + ": ");
                      x.Display();
                      Console.Write("Uw antwoord: ");
                      string antw = Console.ReadLine();
                      Console.WriteLine(x.CheckAntwoord(antw));
                  }
                  );
            Console.WriteLine("EINDE");
            Console.ReadLine();

        }
    }
}
