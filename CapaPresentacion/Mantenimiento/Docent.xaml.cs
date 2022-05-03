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
    /// Lógica de interacción para Docent.xaml
    /// </summary>
    public partial class Docent : Window
    {
        public Docent()
        {
            InitializeComponent();
        }
        static CapaNegocio1.Docente docente = new CapaNegocio1.Docente();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            docente.Nombres = txtNombre.Text.Trim();
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.LugarNac = txtLugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            docente.FechaNac = FechaNac.Value;
            docente.Afp = txtAFP.Text.Trim();
            docente.Profesion = txtProfesion.Text.Trim();
            docente.Cursos = txtCursos.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");
        }

        private void btnLeer_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres: " + docente.Nombres + "\nApellidos: " + docente.Apellidos +
                "\nCodigo: " + docente.Codigo + "\nCorreo: " + docente.Correo +
                "\nDomicilio: " + docente.Domicilio + "\nLugar de Nacimiento: " + docente.LugarNac +
                "\nFecha de Nacimiento: " + docente.FechaNac + "\nAFP: " + docente.Afp +
                "\nProfesion: " + docente.Profesion + "\nCursos: " + docente.Cursos);
        }

        private void btnMetodo1_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo2_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Metodo_3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo4_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo5_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMetodo6_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Metodo en implementación", "Lo sentimos",
                MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
