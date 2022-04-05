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

namespace Teste01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txt_login.Text;
            string senha = txt_senha.Password.ToString();

            if (usuario == "João Alexandre" && senha == "joaoalex123")
            {
                segunda_tela chama = new segunda_tela();
                chama.ShowDialog();
            }

        }
    }
}
