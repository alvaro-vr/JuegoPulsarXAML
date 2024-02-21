using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace JuegoPulsarAlvaro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer;

        private const int VELOCIDAD_LENTA = 3000;
        private const int VELOCIDAD_MEDIA = 2000;
        private const int VELOCIDAD_RAPIDA = 1000;
        private int velocidad = VELOCIDAD_LENTA;

        private Button[] botones;

        public MainWindow()
        {
            InitializeComponent();

            botones = new Button[] { Boton1, Boton2, Boton3, Boton4, Boton5, Boton6 };

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(velocidad);

            // Iniciar el temporizador
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Button boton in botones)
            {
                boton.Opacity = 0.5;
            }
            Random random = new Random();
            int indiceAleatorio = random.Next(botones.Length);
            botones[indiceAleatorio].Opacity = 1;
        }

        private void Lenta_Click(object sender, RoutedEventArgs e)
        {
            velocidad = VELOCIDAD_LENTA;
            timer.Stop();
            timer.Interval = TimeSpan.FromMilliseconds(velocidad);
            timer.Start();
        }

        private void Media_Click(object sender, RoutedEventArgs e)
        {
            velocidad = VELOCIDAD_MEDIA;
            timer.Stop();
            timer.Interval = TimeSpan.FromMilliseconds(velocidad);
            timer.Start();
        }

        private void Rapida_Click(object sender, RoutedEventArgs e)
        {
            velocidad = VELOCIDAD_RAPIDA;
            timer.Stop();
            timer.Interval = TimeSpan.FromMilliseconds(velocidad);
            timer.Start();
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Button botonPulsado = sender as Button;
            if (botonPulsado != null && botonPulsado.Opacity == 1)
            {
                timer.Stop();

                botonPulsado.Opacity = 0.5;

                Random random = new Random();
                int indiceAleatorio = random.Next(botones.Length);
                botones[indiceAleatorio].Opacity = 1;

                timer.Interval = TimeSpan.FromMilliseconds(velocidad);
                timer.Start();
            }
        }

        private void Boton1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
