using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Vraag
    {
        public string Tekst { get; set; }
        public string Antwoord { get; set; }
        public int Moeilijkheidsgraad { get; set; }
        public string Categorie { get; set; }
       
        public Vraag()
        {
        }

        public Boolean CheckAntwoord(String antwoord)
        {
            return this.Antwoord.Equals(antwoord);

        }

        public virtual void Display()
        {
            Console.WriteLine(Tekst);
        }
    }
}
