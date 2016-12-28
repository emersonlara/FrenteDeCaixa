using FrenteDeCaixa.Application;
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
            MontaTabela();
        }

        public void MontaTabela()
        {
            PerfilDeUsuarioApplication perfilApp = new PerfilDeUsuarioApplication();
            dataGridPerfis.ItemsSource = perfilApp.Listar();

            
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            new NovoPerfilWindow().ShowDialog();
        }
    }
}
