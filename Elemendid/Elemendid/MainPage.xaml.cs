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
            Button Tbl_btn = new Button { Text = "Table Page" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Content = st;
            Tbl_btn.Clicked += Tbl_btn_Clicked;

            InitializeComponent();
            Button Tbl_btn2 = new Button { Text = "Soonputru" };
            StackLayout st2 = new StackLayout();
            st2.Children.Add(Tbl_btn2);
            Content = st2;
            Tbl_btn2.Clicked += Tbl_btn2_Clicked;

            InitializeComponent();
            Button Tbl_btn3 = new Button { Text = "Jalutan" };
            StackLayout st3 = new StackLayout();
            st3.Children.Add(Tbl_btn3);
            Content = st3;
            Tbl_btn3.Clicked += Tbl_btn3_Clicked;

            InitializeComponent();
            Button Tbl_btn4 = new Button { Text = "Tegelen spordiga" };
            StackLayout st4 = new StackLayout();
            st4.Children.Add(Tbl_btn4);
            Content = st4;
            Tbl_btn4.Clicked += Tbl_btn4_Clicked;

            InitializeComponent();
            Button Tbl_btn5 = new Button { Text = "Söön" };
            StackLayout st5 = new StackLayout();
            st5.Children.Add(Tbl_btn5);
            Content = st5;
            Tbl_btn5.Clicked += Tbl_btn5_Clicked;



        }

        private async void Tbl_btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Soon());
        }

        private async void Tbl_btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tegelenspordiga());
        }

        private async void Tbl_btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Jalutan());
        }

        private async void Tbl_btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Soonputru());
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabelPage());
        }
        
        
        

    }
}
