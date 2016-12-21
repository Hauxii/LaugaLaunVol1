using System;
using System.Collections.Generic;
using System.Globalization;
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

            //Formatting digits from 1234 to 1,234
            TotalPayPreDeduction.Text = double.Parse(paycheck.TotalPayPreDeduction.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            TotalPayPreDeduction1.Text = double.Parse(paycheck.TotalPayPreDeduction.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            MorningPay.Text = double.Parse(paycheck.MorningPay.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            EveningPay.Text = double.Parse(paycheck.EveningPay.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            Orlof.Text = double.Parse(paycheck.Orlof.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            OrlofBanki.Text = double.Parse(paycheck.OrlofBanki.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            OrlofBase.Text = double.Parse(paycheck.OrlofBase.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            MorningPayRate.Text = double.Parse(paycheck.MorningPayRate.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            EveningPayRate.Text = double.Parse(paycheck.EveningPayRate.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            TotalPay.Text = double.Parse(paycheck.TotalPay.ToString()).ToString("##,###", CultureInfo.CurrentCulture);

            TaxToPay.Text = double.Parse(paycheck.TaxToPay.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            TaxTotal.Text = double.Parse(paycheck.TaxTotal.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            TaxDiscount.Text = double.Parse(paycheck.TaxDiscount.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            Lifeyrir.Text = double.Parse(paycheck.Lifeyrir.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            SereignaLifeyrir.Text = double.Parse(paycheck.SereignaLifeyrir.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            StRv.Text = double.Parse(paycheck.StRv.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            TotalDeduction.Text = double.Parse(paycheck.TotalDeduction.ToString()).ToString("##,###", CultureInfo.CurrentCulture);
            TotalDeduction1.Text = double.Parse(paycheck.TotalDeduction.ToString()).ToString("##,###", CultureInfo.CurrentCulture);


        }
    }
}
