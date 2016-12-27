using FrenteDeCaixa.Application;
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
    public partial class PerfisWindow : Window
    {
        public PerfisWindow()
        {
            InitializeComponent();
            MontaTabela();
        }

        public void MontaTabela()
        {
            PerfilDeUsuarioApplication perfilApp = new PerfilDeUsuarioApplication();
            dataGridPerfis.ItemsSource = perfilApp.Listar();

            
        }
    }
}
