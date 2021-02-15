using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicUIBuilder
{
    //The below class is to demo the data passing into navigaton page
    public class DataPassingClass
    {
        private string[] arr = { "Ofer", "Tal", "Adi", "Racheli", "Smadar", "Hana", "Shirly", "Dana", "Galant" };
        public string Name
        {
            get
            {
                return arr[Index % 9];
            }
        }
        public int Index { get; set; }

    }
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            //Uncomment the below to demo BindingContext data passing to a page
            
            AnotherPage anotherPage = new AnotherPage();
            anotherPage.BindingContext = new DataPassingClass
            {
                Index = 0
            };
            
            MainPage = new NavigationPage(anotherPage);
            //MainPage = new AnotherPage();
            
            //Demo Navigaton page using MainPage
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
