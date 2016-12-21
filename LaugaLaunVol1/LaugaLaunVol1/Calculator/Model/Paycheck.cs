using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LaugaLaunVol1.Helpers;

namespace LaugaLaunVol1.Calculator.Model
{
    public class Paycheck
    {
        public double MorningPayRate
        {
            get { return Settings.MorningPayRate; }
        }

        public double EveningPayRate
        {
            get { return Settings.EveningPayRate; }
        }

        public double TaxDiscount
        {
            get { return Settings.TaxDiscount; }
        }

        //Laun
        public double TotalMorningHours { get; set; }
        public double TotalEveningHours { get; set; }
        public double MorningPay { get; set; }
        public double EveningPay { get; set; }
        public double OrlofBase { get; set; }
        public double Orlof { get; set; }
        public double OrlofBanki { get; set; }
        public double OrlofProsenta { get { return ((Double)Settings.OrlofProsenta / 100); } }
        public double HolidayHours { get; set; }
        public double TotalPayPreDeduction { get; set; }
        public double TotalPay { get; set; }

        //Fradrattur
        public double TaxBase { get; set; }
        public double TaxTotal { get; set; }
        public double TaxToPay { get; set; }
        public double Lifeyrir { get; set; }
        public double SereignaLifeyrir { get; set; }
        public double SereignaLifeyrirProsenta
        {
            get { return ((Double)Settings.SereignaLifeyrirProsenta / 100); }
        }
        public double TotalDeduction { get; set; }
        public double StRv { get; set; }
        

        public Paycheck()
        {
            this.TotalEveningHours = 0;
            this.TotalMorningHours = 0;
            this.HolidayHours = 0;
            this.Orlof = 0;
            this.TaxBase = 0;
            this.TaxToPay = 0;
            this.TaxTotal = 0;
            this.TotalPayPreDeduction = 0;
            this.TotalDeduction = 0;
        }

        
    }
}
