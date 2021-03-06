﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaugaLaunVol1.Calculator.Model;

namespace LaugaLaunVol1.Calculator.Model
{
    class SalaryCalculator
    {
        private ObservableCollection<Shift> _shifts;
        private Paycheck _paycheck;
        private readonly double TAX_STEP_1 = 336035;
        private readonly double TAX_STEP_1_PERCENT = 0.3713;
        private readonly double TAX_STEP_2_PERCENT = 0.3835;

        public SalaryCalculator(ObservableCollection<Shift> shifts)
        {
            this._shifts = shifts;
        }

        public Paycheck CalculateSalary()
        {
            _paycheck = new Paycheck();
            GetTotalHours();
            _paycheck.MorningPay = _paycheck.TotalMorningHours * _paycheck.MorningPayRate;
            _paycheck.EveningPay = _paycheck.TotalEveningHours * _paycheck.EveningPayRate;
            _paycheck.OrlofBase = _paycheck.MorningPay + _paycheck.EveningPay;
            _paycheck.Orlof = _paycheck.OrlofProsenta * _paycheck.OrlofBase; //10,17% of morningpay + eveningpay
            _paycheck.OrlofBanki = (1 - (TAX_STEP_1_PERCENT + _paycheck.SereignaLifeyrirProsenta + 0.04))*_paycheck.Orlof;
            _paycheck.TotalPayPreDeduction = (int)(_paycheck.MorningPay + _paycheck.EveningPay + _paycheck.Orlof);
            
            _paycheck.Lifeyrir = 0.04 * _paycheck.TotalPayPreDeduction;
            _paycheck.SereignaLifeyrir = _paycheck.SereignaLifeyrirProsenta * _paycheck.TotalPayPreDeduction; 
            CalcTax();
            _paycheck.StRv = 0.01*_paycheck.TotalPayPreDeduction;
            _paycheck.TotalDeduction = _paycheck.Lifeyrir + _paycheck.SereignaLifeyrir + _paycheck.TaxTotal + _paycheck.StRv + _paycheck.OrlofBanki;
            _paycheck.TotalPay = _paycheck.TotalPayPreDeduction - _paycheck.TotalDeduction;
            
            return _paycheck;
        }

        private void CalcTax()
        {
            _paycheck.TaxBase = _paycheck.TotalPayPreDeduction - (_paycheck.Lifeyrir + _paycheck.SereignaLifeyrir); //heildarlaun - eigið iðgjald í lífeyrissjóð (4% skyldu lífeyrir, 4%/2% séreign)
            double leftOver = 0;

            if (_paycheck.TotalPayPreDeduction > TAX_STEP_1)
            {
                leftOver = _paycheck.TotalPayPreDeduction - TAX_STEP_1;
                if (leftOver < 0)
                {
                    leftOver = 0;
                }
            }

            _paycheck.TaxToPay += (TAX_STEP_1_PERCENT*_paycheck.TaxBase - leftOver); //Tax step 1, 37.13%
            _paycheck.TaxToPay += (TAX_STEP_2_PERCENT*leftOver); //Tax step 2, 38,35%
            _paycheck.TaxTotal = _paycheck.TaxToPay - _paycheck.TaxDiscount;
            if (_paycheck.TaxTotal < 0)
            {
                _paycheck.TaxTotal = 0;
            }
        }

        private void GetTotalHours()
        {
            foreach (var s in _shifts)
            {
                this._paycheck.TotalMorningHours += s.MorningHours;
                this._paycheck.TotalEveningHours += s.EveningHours;
            }
        }
    }
}
