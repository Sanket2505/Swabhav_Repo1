using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    class FixeDeposite
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;

        public FixeDeposite(string name,double amount,int duration,FestivalType featival)
        {
            _name = name;
            _amount = amount;
            _duration = duration;
            _festival = featival;
        }
        public double SimpleIntest()
        {
            float interest = (float)(_amount * CalculateRate() * _duration / 100);
            return interest;
        }
        public double CalculateRate()
        {
            float interestRate = 7f;
            if (_festival == FestivalType.Diwali)
            {
                interestRate = 8f;
                return interestRate;
            }
            else if (_festival == FestivalType.EId)
            {
                interestRate = 8.5f;
                return interestRate;
            }
            else if (_festival == FestivalType.New_year)
            {
                interestRate = 9f;
                return interestRate;
            }
            else if (_festival == FestivalType.Normal)
            {
                interestRate = 7f;
                return interestRate;
            }
            return interestRate;
        }
    }
}
