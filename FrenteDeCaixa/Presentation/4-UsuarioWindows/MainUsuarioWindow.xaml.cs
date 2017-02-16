using System.Windows;
using FrenteDeCaixa.Application.Service.Usuario;

namespace FrenteDeCaixa.Presentation._4_UsuarioWindows
{
    /// <summary>
    /// Interaction logic for MainUsuarioWindow.xaml
    /// </summary>
    public partial class MainUsuarioWindow : Window
    {
        public MainUsuarioWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AtualizarTabela();
        }

        private void ButtonNovo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAlterar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonExcluir_Click(object sender, RoutedEventArgs e)
        {

        }

        public void AtualizarTabela()
        {
            var usuarioService = new UsuarioService();
            DataGridUsuarios.ItemsSource = usuarioService.Listar();
        }
    }
}
