using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaugaLaunVol1.Calculator.Model
{
    public class Paycheck
    {
        //TODO: remove when Settings has been added
        public double MorningPayRate { get; set; }
        public double EveningPayRate { get; set; }
        public double TaxDiscount { get; set; }
        
        //Laun
        public double TotalMorningHours { get; set; }
        public double TotalEveningHours { get; set; }
        public double MorningPay { get; set; }
        public double EveningPay { get; set; }
        public double OrlofBase { get; set; }
        public double Orlof { get; set; }
        public double HolidayHours { get; set; }
        public double TotalPayPreDeduction { get; set; }
        public double TotalPay { get; set; }

        //Fradrattur
        public double TaxBase { get; set; }
        public double TaxTotal { get; set; }
        public double TaxToPay { get; set; }
        public double Lifeyrir { get; set; }
        public double SereignaLifeyrir { get; set; }
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

            //TODO: get values from Settings
            this.TaxDiscount = 50000;
            this.MorningPayRate = 1750;
            this.EveningPayRate = 2950;
        }
    }
}
