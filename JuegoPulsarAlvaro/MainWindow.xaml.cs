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

        private Button[] botones = [];

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);

            // Iniciar el temporizador
            timer.Start();
        }

        private void Lenta_Click(object sender, RoutedEventArgs e)
        {
            velocidad = VELOCIDAD_LENTA;
        }

        private void Media_Click(object sender, RoutedEventArgs e)
        {
            velocidad = VELOCIDAD_MEDIA;
        }

        private void Rapida_Click(object sender, RoutedEventArgs e)
        {
            velocidad = VELOCIDAD_RAPIDA;
        }
    }
}
