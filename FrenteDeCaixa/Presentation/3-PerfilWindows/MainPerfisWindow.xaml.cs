using System.Windows;
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
