using System.Linq;
using System.Windows;
using FrenteDeCaixa.Application.Service.Usuario;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Presentation.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UsuarioService UsuarioService { get; }

        public LoginWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            UsuarioService = new UsuarioService();
        }
        
        private void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            var login = textBoxLogin.Text;
            var senha = textBoxSenha.Text;
            var conectar = UsuarioService.Listar().
                Any(x => x.Login == login && x.Senha == senha);

            if (!conectar) return;
            new CaixaWindow().Show();
            this.Close();
        }
    }
}
