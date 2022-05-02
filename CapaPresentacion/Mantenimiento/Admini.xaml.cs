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
    /// Lógica de interacción para Admini.xaml
    /// </summary>
    public partial class Admini : Window
    {
        public Admini()
        {
            InitializeComponent();
        }
        static CapaNegocio1.Administrativo administrativo = new CapaNegocio1.Administrativo();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Nombres = txtNombre.Text.Trim();
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.LugarNac = txtLugarNac.Text.Trim();
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            administrativo.FechaNac = FechaNac.Value;
            administrativo.Cargo = txtApellidos.Text.Trim();
            administrativo.Especialidad = txtEspecialidad.Text.Trim();
            administrativo.Puesto = txtPuesto.Text.Trim();
            administrativo.Sueldo = txtSueldo.Text.Trim();
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\nNombres: " + administrativo.Nombres + "Apellidos: " + administrativo.Apellidos +
                "\nCodigo: " + administrativo.Codigo + "\nCorreo: " + administrativo.Correo +
                "\nDomicilio: " + administrativo.Domicilio + "\nLugar de Nacimiento: " + administrativo.LugarNac +
                "\nFecha de Nacimiento: " + administrativo.FechaNac + "\nCargo: " + administrativo.Cargo +
                "\nEspecialidad: " + administrativo.Especialidad + "\nPuesto: " + administrativo.Puesto +
                "\nSueldo: " + administrativo.Sueldo);
        }
        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }
    }
}
