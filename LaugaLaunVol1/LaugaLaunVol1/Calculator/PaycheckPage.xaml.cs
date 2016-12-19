using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaugaLaunVol1.Calculator.Model;
using Xamarin.Forms;

namespace LaugaLaunVol1.Calculator
{
    public partial class PaycheckPage : ContentPage
    {
        //private Paycheck _paycheck;
        public PaycheckPage(Paycheck paycheck)
        {
            InitializeComponent();
            BindingContext = paycheck;
        }
    }
}
