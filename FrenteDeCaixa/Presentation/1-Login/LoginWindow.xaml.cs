using System.Linq;
using System.Windows;
using FrenteDeCaixa.Application.Mapper;
using FrenteDeCaixa.Application.Service.Usuario;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow
    {
        private UsuarioService UsuarioService { get; }
        private AutoMapperConfig AutoMapperConfig { get; }

        public LoginWindow()
        {
            AutoMapperConfig = new AutoMapperConfig();
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            UsuarioService = new UsuarioService();
        }
        
        private void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            var login = textBoxLogin.Text;
            var senha = textBoxSenha.Text;
            /*
            var conectar = UsuarioService.Listar().
                Any(x => x.Login == login && x.Senha == senha);
                
            if (!conectar) return;*/
            new CaixaWindow().Show();
            Close();
        }
    }
}
