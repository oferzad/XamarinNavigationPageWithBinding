using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicUIBuilder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnotherPage : ContentPage
    {
        public AnotherPage()
        {
            InitializeComponent();
           
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            AnotherPage newPage = new AnotherPage();
            DataPassingClass obj = (DataPassingClass)this.BindingContext;
            obj.Index++;
            newPage.BindingContext = obj;
            await Navigation.PushAsync(newPage);
        }
    }

    
}