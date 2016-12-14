using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LaugaLaunVol1
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
            List<DateTime> _dates = new List<DateTime>();
            _dates.Add(DateTime.Today);
            BindingContext = _dates;
            DatePicker.PropertyChanged += (sender, args) =>
            {
                _dates.Add(DatePicker.Date);
                BindingContext = _dates;
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
    }
}
