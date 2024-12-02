using CreditApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CreditCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FindByName("userLine").ToString()) || string.IsNullOrWhiteSpace(this.FindByName("passLine").ToString()))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, заполните все поля.", "OK");
            }
            else
            {
                string name = this.FindByName("userLine").ToString();
                await Navigation.PushModalAsync(new NavigationPage(new TabbedPage1(name)));
            }
        }
    }
}
