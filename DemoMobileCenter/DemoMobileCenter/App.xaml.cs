using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace DemoMobileCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoMobileCenter.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start("ios=3e833b46-ea80-482c-9023-50913544ae46;android=55a9299e-3780-45d5-acb4-f25278667a54", typeof(Analytics), typeof(Crashes));


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
