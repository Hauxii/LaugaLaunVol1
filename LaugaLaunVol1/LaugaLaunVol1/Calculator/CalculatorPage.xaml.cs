﻿using System;
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
        private ObservableCollection<Shift> _shifts;
        private SalaryCalculator _salaryCalculator;

        public CalculatorPage()
        {
            InitializeComponent();
            _shifts = new ObservableCollection<Shift>();
            _salaryCalculator = new SalaryCalculator(_shifts);

            //Sets the content for the listview
            BindingContext = _shifts;

            MorningButton.Clicked += (sender, args) =>
            {
                _shifts.Add(new Shift(ShiftDatePicker.Date, true));
            };
            EveningButton.Clicked += (sender, args) =>
            {
                _shifts.Add(new Shift(ShiftDatePicker.Date, false));
            };
            CalcButton.Clicked += (sender, args) =>
            {
                this.Navigation.PushAsync(new PaycheckPage());
            };

        }

    }
}