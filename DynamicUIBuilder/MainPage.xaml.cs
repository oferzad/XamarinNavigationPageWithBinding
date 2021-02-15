using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicUIBuilder
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private static int numOpened = 0;
        public MainPage()
        {
            InitializeComponent();
            this.Title = $"Main Page ({numOpened})";
            numOpened++;
        }

        protected override void OnAppearing()
        {
            lbl.Text += $"\n{DateTime.Now.ToString()}: Appearing()";
        }

        protected override void OnDisappearing()
        {
            lbl.Text += $"\n{DateTime.Now.ToString()}: Disappearing()";
        }

        private  async void btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
