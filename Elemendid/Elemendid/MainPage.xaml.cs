using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 

            BackgroundColor = Color.White;
            Button tblp_btn = new Button { Text = "Õnne", 
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5, Padding = 10 };
            StackLayout st = new StackLayout();
            st.Children.Add(tblp_btn);
            Content = st;
            tblp_btn.Clicked += tblp_btn_Clicked;

            Button jalutan_btn = new Button { Text = "jalutan",
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(jalutan_btn);
            Content = st;
            jalutan_btn.Clicked += jalutan_btn_Clicked;

            Button Lahenlounale_btn = new Button { Text = "Lähen lõunale", 
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(Lahenlounale_btn);
            Content = st;
            Lahenlounale_btn.Clicked += Lahenlounale_btn_Clicked;

            Button Magan_btn = new Button { Text = "Magan", 
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(Magan_btn);
            Content = st;
            Magan_btn.Clicked += Magan_btn_Clicked;

            Button Soon_btn = new Button { Text = "Söön",
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(Soon_btn);
            Content = st;
            Soon_btn.Clicked += Soon_btn_Clicked;

            Button Soonputru_btn = new Button { Text = "Söön putru", 
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(Soonputru_btn);
            Content = st;
            Soonputru_btn.Clicked += Soonputru_btn_Clicked;

            Button Tegelenspordiga_btn = new Button { Text = "Tegelen spordiga",
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(Tegelenspordiga_btn);
            Content = st;
            Tegelenspordiga_btn.Clicked += Tegelenspordiga_btn_Clicked;

            Button Tousenpusti_btn = new Button { Text = "Tõusen püsti", 
            BackgroundColor = Color.FromRgb(0, 149, 248), Margin = 5 };
            st.Children.Add(Tousenpusti_btn);
            Content = st;
            Tousenpusti_btn.Clicked += Tousenpusti_btn_Clicked;
        }

        private async void Tegelenspordiga_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tegelenspordiga());
        }

        private async void Magan_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Magan());
        }

        private async void Tousenpusti_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tousenpusti());
        }

        private async void Soonputru_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Soonputru());
        }

        private async void jalutan_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Jalutan());
        }

        private async void Lahenlounale_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lahenlounale());
        }

        private async void Soon_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Soon());
        }

        private async void tblp_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Onne());
        }
    }
}