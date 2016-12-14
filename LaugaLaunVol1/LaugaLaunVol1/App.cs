using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LaugaLaunVol1
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var moviePage = new ShiftPlanPage();
            var movieNavigationPage = new NavigationPage(moviePage);
            movieNavigationPage.Title = "Reiknivél";

            var otherPage = new ShiftPlanPage();
            var otherNavigationPage = new NavigationPage(otherPage);
            otherNavigationPage.Title = "Vaktaplan";

            var popularPage = new InfoPage();
            var popularNavigationPage = new NavigationPage(popularPage);
            popularNavigationPage.Title = "Upplýsingar";

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(movieNavigationPage);
            tabbedPage.Children.Add(otherNavigationPage);
            tabbedPage.Children.Add(popularNavigationPage);

            MainPage = new NavigationPage(tabbedPage);
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
