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

namespace ExamenSegundoParcial
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

       private bool Validacion()
        {
            bool ok = true;
            if(txtNombre.Text == "")
            {
                ok = false;
                txtRespuesta.Text = "Ingesa Nombre";
            }

            return ok;
        }

        private bool validacion2()
        {
            bool ok = true;
            if(txtApellidoP.Text == "")
            {
                ok = false;
                txtRespuesta.Text = "Ingresa apellido";
            }
            return ok;
        }

        private bool validacion3()
        {
            bool ok = true;
            if (txtApellidoM.Text == "")
            {
                ok = false;
                txtRespuesta.Text = "Ingresa apellido";
            }
            return ok;
        }

        private void CbTipo_SelectionChanged(object sender, RoutedEventArgs e)
        {
            panelTipo.Children.Clear();

            switch (CbTipo.SelectedIndex)
            {
                case 0:
                    panelTipo.Children.Add(new ControlContacto());
                    break;
                case 1:
                    panelTipo.Children.Add(new ControlInformacion());
                    break;
                
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Validacion();
            validacion2();
            validacion3();
          switch(CbTipo.SelectedIndex)
            {
                case 0:
                    
                    break;
            }
        }

    }
}
