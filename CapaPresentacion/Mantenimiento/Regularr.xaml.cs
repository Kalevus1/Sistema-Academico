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
    /// Lógica de interacción para Regularr.xaml
    /// </summary>
    public partial class Regularr : Window
    {
        public Regularr()
        {
            InitializeComponent();
        }
        static CapaNegocio1.Regular regular = new CapaNegocio1.Regular();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            regular.Nombres = txtNombre.Text.Trim();
            regular.Apellidos = txtApellidos.Text.Trim();
            regular.Codigo = txtCodigo.Text.Trim();
            regular.Correo = txtCorreo.Text.Trim();
            regular.Domicilio = txtDomicilio.Text.Trim();
            regular.LugarNac = txtLugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            regular.FechaNac = FechaNac.Value;
            regular.Creditos = txtCreditos.Text.Trim();
            regular.Cursos = txtCursos.Text.Trim();
            regular.Notas = txtNotas.Text.Trim();
            regular.Semestre = txtSemestre.Text.Trim();
            MessageBox.Show("Se ingresaron los datos correctamente");
        }

        private void btnLeer_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres: " + regular.Nombres + "\nApellidos: " + regular.Apellidos +
                "\nCodigo: " + regular.Codigo + "\nCorreo: " + regular.Correo +
                "\nDomicilio: " + regular.Domicilio + "\nLugar de Nacimiento: " + regular.LugarNac +
                "\nFecha de Nacimiento: " + regular.FechaNac + "\nCreditos: " + regular.Creditos +
                "\nCursos: " + regular.Cursos + "\nNotas: " + regular.Notas +
                "\nSemestre: " + regular.Semestre);
        }

        private void btnMetodo1_Click_1(object sender, RoutedEventArgs e)
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
