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
    /// Lógica interna para Acessorios.xaml
    /// </summary>
    public partial class Acessorios : Window
    {
        public Acessorios()
        {
            InitializeComponent();
        }

        private void dt_acessorio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clientes = new[]
            {
                new {Nome = "José Maria", Telefone = "3333-3333", Email = "josemaria@email.com"},
                new {Nome = "Antonio Carlos", Telefone = "4444-4444", Email = "antonio@email.com"},
                new {Nome = "Pedro Henrique", Telefone = "5555-5555", Email = "pedro@email.com"},
                new {Nome = "Augusto Cesar", Telefone = "6666-6666", Email = "augusto@email.com"},
                new {Nome = "Carlos Silva", Telefone = "7777-7777", Email = "carlos@email.com"}  
            };
            dt_acessorio.ItemsSource = clientes;
        }
    }
}
