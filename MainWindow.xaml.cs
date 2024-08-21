using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Tipos_Eventos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cont_burbuja_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Contenedor de evento burbuja");
        }

        private void Btn_burbuja_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Boton de evento burbuja");
        }

        private void Cont_tunelado_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("\nContenedor de evento tunelado");
        }

        private void Btn_tunelado_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Boton de evento tunelado");
        }

    }
}
