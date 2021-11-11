using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Client;
using OCPSolutionApp.Lib;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fixeDeposite = new Fixedeposit("sanket", 50000, 5, new New_YearFeastivalPolicy());
            Console.WriteLine("SimpleIntest :{0}",fixeDeposite.SimpleIntest());
            Console.ReadLine();
        }
    }
}
