using System.Windows;
using System.Windows.Controls;


namespace Ejercicio4
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

        private void cajaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(cajaTextBox.Text.Length == 141)
            {
                cajaTextBox.IsReadOnly = true;
            }
            else
            {
                contadorTextBlock.Text = cajaTextBox.Text.Length + "/140";
            }
            
        }
    }
}
