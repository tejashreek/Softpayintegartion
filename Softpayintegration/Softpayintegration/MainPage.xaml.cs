using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Softpayintegration
{
    public partial class MainPage : ContentPage
    {

        string packageName_sandbox;
        string packageName_Sampletestapp;
        public MainPage()
        {
            InitializeComponent();
            packageName_sandbox = "io.softpay.sandbox";
            packageName_Sampletestapp = "io.softpay.pos.softpay_merchant_sample_app";


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var rresult = DependencyService.Get<IAppHandler>().LaunchApp(packageName_sandbox).Result; 
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var rresult = DependencyService.Get<IAppHandler>().LaunchApp(packageName_Sampletestapp).Result;
        }
    }
}
