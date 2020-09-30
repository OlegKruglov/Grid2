using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grid2
{
    public partial class MainPage : ContentPage
    {
        bool first_player;
        BoxView box_clik;
        public MainPage()
        {
            InitializeComponent();
            new_game = new Button { Text = "Новая игра" };
            var boxTapHandler = new TapGestureRecognizer();
            boxTapHandler.Tapped += ChangeColor;
            myBox.GestureRecognizers.Add(boxTapHandler);
            new_game.Clicked += new EventHandler(New_game_Clicked);
        }

        private void ChangeColor(object sender, EventArgs args)
        {
            myBox.Color = Color.Red;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            {
                box_clik = sender as BoxView;
                if (box_clik.Color == Color.FromRgb(0, 0, 0) && first_player)
                {
                    box_clik.Color = Color.FromRgb(255, 0, 0);
                    first_player = false;
                }
                else if (box_clik.Color == Color.FromRgb(0, 0, 0) && !first_player)
                {
                    box_clik.Color = Color.FromRgb(0, 255, 0);
                    first_player = true;
                }
                else
                {
                    DisplayAlert("Сообщение", "Противник уже выбрал это поле", "Ok");
                }
            }

            Random rnd = new Random();
            private bool First_Player()
            {
                int player = rnd.Next(0, 2);
                if (player == 1)
                {
                    first_player = true;
                }
                else
                {
                    first_player = false;
                }
                return first_player;
            }
        }
    }
}
