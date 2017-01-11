using FrenteDeCaixa.Application;
using FrenteDeCaixa.Application.Service;
using FrenteDeCaixa.Presentation.PerfilWindows;
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
using FrenteDeCaixa.Application.Service.PerfilDeUsuario;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for PerfisWindow.xaml
    /// </summary>
    public partial class MainPerfisWindow : Window
    {
        public MainPerfisWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AtualizaTabela();
        }

        public void AtualizaTabela()
        {
            PerfilDeUsuarioService perfilService = new PerfilDeUsuarioService();
            DataGridPerfis.ItemsSource = perfilService.Listar();
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            new NovoPerfilWindow().ShowDialog();
            AtualizaTabela();
        }
    }
}
