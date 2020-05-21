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

namespace Placucci.Gabriele._4H.Rubrica

{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persona p;
            try
            {
                p = new Persona("Martina;Pasquinelli;Rimini;4050;3892996813;5/8/2002");

                MessageBox.Show(p.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Button_Click_add(object sender, RoutedEventArgs e)
        {

        }
    }   

}
