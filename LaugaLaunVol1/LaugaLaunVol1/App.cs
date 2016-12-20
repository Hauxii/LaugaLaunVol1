using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaugaLaunVol1.Calculator;
using Xamarin.Forms;

namespace LaugaLaunVol1
{
    public class App : Application
    {
        public App()
        {
            /*
            // The root page of your application
            var calcPage = new CalculatorPage();
            var calcNavigationPage = new NavigationPage(calcPage);
            calcNavigationPage.Title = "Reiknivél";

            
            var shiftPage = new ShiftPlanPage();
            var otherNavigationPage = new NavigationPage(shiftPage);
            otherNavigationPage.Title = "Vaktaplan";

            var infoPage = new InfoPage();
            var popularNavigationPage = new NavigationPage(infoPage);
            popularNavigationPage.Title = "Upplýsingar";

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(calcNavigationPage);
            //tabbedPage.Children.Add(otherNavigationPage);
            //tabbedPage.Children.Add(popularNavigationPage);
            */
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
