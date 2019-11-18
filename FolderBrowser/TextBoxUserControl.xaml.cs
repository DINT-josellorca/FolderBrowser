using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para TextBoxUserControl.xaml
    /// </summary>
    public partial class TextBoxUserControl : System.Windows.Controls.UserControl
    {
        public string TextoTextBlock
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texto.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextoProperty =
            DependencyProperty.Register("TextoTextBlock", typeof(string), typeof(TextBoxUserControl), new PropertyMetadata(""));


        public string TextoTextBox
        {
            get { return (string)GetValue(TextoTextBoxProperty); }
            set { SetValue(TextoTextBoxProperty, value); }
        }



        public bool SoloLectura
        {
            get { return (bool)GetValue(SoloLecturaProperty); }
            set { SetValue(SoloLecturaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SoloLectura.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SoloLecturaProperty =
            DependencyProperty.Register("SoloLectura", typeof(bool), typeof(TextBoxUserControl), new PropertyMetadata(false));



        // Using a DependencyProperty as the backing store for TextoTextBox.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextoTextBoxProperty =
            DependencyProperty.Register("TextoTextBox", typeof(string), typeof(TextBoxUserControl), new PropertyMetadata(""));



        public TextBoxUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void SeleccionarButton_Click(object sender, RoutedEventArgs e)
        {
            //Es necesario incluir la referencia a System.Windows.Forms

            //Creamos un nuevo diálogo
            System.Windows.Forms.FolderBrowserDialog dialogo = new FolderBrowserDialog();

            //Mostramos el diálogo
            DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                string ruta = dialogo.SelectedPath;
                TextoTextBox = ruta;
            }
        }
    }
}
