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

namespace Figuras
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
            double numero1 = double.Parse(texto1.Text);
            double numero2 = double.Parse(texto2.Text);
            double resultado = numero1 * numero2;
            lblresultado.Text = resultado.ToString();

        }

        private void Calcular2_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(texto3.Text);
            double numero2 = double.Parse(texto4.Text);
            double resultado = (numero1 * numero2)/2;
            lblresultado1.Text = resultado.ToString();
        }

        private void Calcular3_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(texto5.Text);
            double resultado =  numero1 *numero1* 3.1416 ;
            lblresultado2.Text = resultado.ToString();
        }

        private void Calcular4_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(texto6.Text);
            double numero2 = double.Parse(texto7.Text);
            double numero3 = double.Parse(texto8.Text);
            double resultado = ((numero1 + numero2)*(numero3)) / 2;
            lblresultado3.Text = resultado.ToString();
        }

        
    }
}
