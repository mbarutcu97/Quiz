using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Vraag
    {
        public String Tekst { get; set; }
        public String Antwoord { get; set; }
        public int Moeilijkheidsgraad { get; set; }
        public String Categorie { get; set; }
       
        public Vraag()
        {
        }

        public Boolean CheckAntwoord(String antwoord)
        {
            return this.Antwoord.Equals(antwoord);

        }

        public void Display()
        {
            Console.WriteLine(Tekst);
        }
    }
}
