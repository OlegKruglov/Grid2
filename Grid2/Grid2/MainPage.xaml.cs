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
        public MainPage()
        {
            InitializeComponent();
            var boxTapHandler = new TapGestureRecognizer();
            boxTapHandler.Tapped += ChangeColor;
            myBox.GestureRecognizers.Add(boxTapHandler);
        }

        private void ChangeColor(object sender, EventArgs args)
        {
            myBox.Color = Color.Red;
        }
    }
}
