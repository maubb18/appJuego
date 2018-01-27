using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuegoBomba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public static string bomb = new Random().Next(1, 4).ToString();
        public static int scores = 0;

        public Inicio()
        {
            InitializeComponent();
            iconoBomba.Source = ImageSource.FromFile("bomba.png");
        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //juego finalizado
            if (button.Text == bomb)
            {
                await DisplayAlert("HAS MUERTO", "JUEGO FINALIZADO,PUNTUACIÓ=" + scores, "REINTENTAR");
                bomb = new Random().Next(1, 4).ToString();
                scores = 0;
            }
            else
            {
                scores += 1;
                await DisplayAlert("TE HAS SALVADO", "PUNTUACIÓN=" + scores, "CONTINUAR!!");
                bomb = new Random().Next(1, 4).ToString();

            }
        }
    }
}