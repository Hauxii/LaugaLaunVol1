using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using LaugaLaunVol1.Calculator;
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
            calcNavPage.Icon = (FileImageSource) ImageSource.FromFile("calc.png");
            /*
            var shiftPage = new ShiftPlanPage();
            var shiftNavPage = new NavigationPage(shiftPage);
            shiftNavPage.Title = "Vaktaplan";

            var infoPage = new InfoPage();
            var infoNavPage = new NavigationPage(infoPage);
            infoNavPage.Title = "Upplýsingar";
            */
            var settingsPage = new SettingsPage();
            var settingsNavPage = new NavigationPage(settingsPage);
            settingsNavPage.Title = "Stillingar";
            settingsNavPage.Icon = (FileImageSource)ImageSource.FromFile("settings.png");

            Children.Add(calcNavPage);
            //Children.Add(shiftNavPage);
            //Children.Add(infoNavPage);
            Children.Add(settingsNavPage);
        }
    }
}
