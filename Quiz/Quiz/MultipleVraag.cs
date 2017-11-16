using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class MultipleVraag : Vraag
    {
        public List<string> Keuzes;
        

        public MultipleVraag()
        {
        }


        public override void Display()
        {
            base.Display();
            for (int i = 0; i < Keuzes.Count; i++)
            {
                int keuzeNummer = i + 1;
                Console.WriteLine(keuzeNummer + ": " + Keuzes.ElementAt(i));
            }
       
        }
    }
}
