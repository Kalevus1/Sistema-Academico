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

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Ingresant.xaml
    /// </summary>
    public partial class Ingresant : Window
    {
        public Ingresant()
        {
            InitializeComponent();
        }
        static CapaNegocio1.Ingresante ingresante = new CapaNegocio1.Ingresante();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            ingresante.Nombres = txtNombre.Text.Trim();
            ingresante.Apellidos = txtApellidos.Text.Trim();
            ingresante.Codigo = txtCodigo.Text.Trim();
            ingresante.Correo = txtCorreo.Text.Trim();
            ingresante.Domicilio = txtDomicilio.Text.Trim();
            ingresante.LugarNac = txtLugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            ingresante.FechaNac = FechaNac.Value;
            DateTime? FechaIng = dateFechaIng.SelectedDate;
            ingresante.Fechaing = FechaIng.Value;
            ingresante.Metodoingreso = txtMetIngre.Text.Trim();
            ingresante.Puesto = txtPuesto.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");
        }

        private void btnLeer_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres: " + ingresante.Nombres + "\nApellidos: " + ingresante.Apellidos +
                "\nCodigo: " + ingresante.Codigo + "\nCorreo: " + ingresante.Correo +
                "\nDomicilio: " + ingresante.Domicilio + "\nLugar de Nacimiento: " + ingresante.LugarNac +
                "\nFecha de Nacimiento: " + ingresante.FechaNac + "\nFecha Ingreso: " + ingresante.Fechaing +
                "\nMetodo de Ingreso: " + ingresante.Metodoingreso + "\nPuesto: " + ingresante.Puesto);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
