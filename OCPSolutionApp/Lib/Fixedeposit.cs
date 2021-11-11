using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Lib
{
    class Fixedeposit
    {

        private string _name;
        private double _amount;
        private int _duration;
        private IFeastivalPolicy _Feastival;

        public Fixedeposit(string name, double amount, int duration, IFeastivalPolicy featival)
        {
            _name = name;
            _amount = amount;
            _duration = duration;
            _Feastival = featival;
        }
        public double SimpleIntest()
        {
            return _amount * _duration * _Feastival.CalculateRate();
        }
    }
}
