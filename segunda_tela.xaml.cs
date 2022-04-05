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
using System.Windows.Shapes;

namespace Teste01
{
    /// <summary>
    /// Lógica interna para segunda_tela.xaml
    /// </summary>
    public partial class segunda_tela : Window
    {
        public segunda_tela()
        {
            InitializeComponent();
        }

        private void bt_acessorios_Click(object sender, RoutedEventArgs e)
        {
                Acessorios acesse = new Acessorios();
                acesse.ShowDialog();
        }

        private void bt_calcas_Click(object sender, RoutedEventArgs e)
        {
            Calcas cal = new Calcas();
            cal.ShowDialog();
        }

        private void bt_camisetas_Click(object sender, RoutedEventArgs e)
        {
            Camisetas camis = new Camisetas();
            camis.ShowDialog();
        }

        private void bt_tenis_Click(object sender, RoutedEventArgs e)
        {
            
            Tenis ten = new Tenis();
            ten.ShowDialog();
        }
    }
}
