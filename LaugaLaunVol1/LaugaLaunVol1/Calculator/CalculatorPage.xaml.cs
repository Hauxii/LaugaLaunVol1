using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaugaLaunVol1.Model;
using Xamarin.Forms;

namespace LaugaLaunVol1.Calculator
{
    public partial class CalculatorPage : ContentPage
    {
        private ObservableCollection<Shift> shifts;
        private SalaryCalculator salaryCalculator;

        public CalculatorPage()
        {
            InitializeComponent();
            shifts = new ObservableCollection<Shift>();
            salaryCalculator = new SalaryCalculator();

            //Sets the content for the listview
            BindingContext = shifts;

            MorningButton.Clicked += (sender, args) =>
            {
                shifts.Add(new Shift(ShiftDatePicker.Date, true));
            };
            EveningButton.Clicked += (sender, args) =>
            {
                shifts.Add(new Shift(ShiftDatePicker.Date, false));
            };
            CalcButton.Clicked += (sender, args) =>
            {
                this.Navigation.PushAsync(new PaycheckPage());
            };

        }

    }
}
