using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace LaugaLaunVol1
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            var calcPage = new CalculatorPage();
            var calcNavPage = new NavigationPage(calcPage);
            calcNavPage.Title = "Reiknivél";

            var shiftPage = new ShiftPlanPage();
            var shiftNavPage = new NavigationPage(shiftPage);
            shiftNavPage.Title = "Vaktaplan";

            var infoPage = new InfoPage();
            var infoNavPage = new NavigationPage(infoPage);
            infoNavPage.Title = "Upplýsingar";

            Children.Add(calcNavPage);
            Children.Add(shiftNavPage);
            Children.Add(infoNavPage);
        }
    }
}
