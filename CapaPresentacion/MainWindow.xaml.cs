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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Regularr regular = new Mantenimiento.Regularr();
            regular.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Ingresant ingresante = new Mantenimiento.Ingresant();
            ingresante.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Admini administrativo = new Mantenimiento.Admini();
            administrativo.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Docent docente = new Mantenimiento.Docent();
            docente.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnUniver_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnAdmi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnPregra_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta pagina se encuentra en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnYou_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Redes sociales en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnFb_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Redes sociales en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnTwi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Redes sociales en mantenimiento", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El buscador se encuentra en mantenimiento", "Lo sentimos",
                 MessageBoxButton.OK, MessageBoxImage.Hand);
        }

        private void btnAula_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aula Virtual en mantenimiento", "Lo sentimos",
                 MessageBoxButton.OK, MessageBoxImage.Hand);
        }

        private void btnErp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ERP University en mantenimiento", "Lo sentimos",
                 MessageBoxButton.OK, MessageBoxImage.Hand);
        }
    }
}
