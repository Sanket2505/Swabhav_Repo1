using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            var fixedeposit = new FixeDeposite("sanket", 10000, 5,FestivalType.Diwali);
            Console.WriteLine("simpleInterest : rs{0}",fixedeposit.SimpleIntest());
            Console.ReadLine();
        }
    }
}
