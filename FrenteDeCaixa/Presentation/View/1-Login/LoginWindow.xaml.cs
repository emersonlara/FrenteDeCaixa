using System.Linq;
using System.Windows;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Presentation.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private EntidadesContext _context;

        public LoginWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _context = new EntidadesContext();
        }

        private void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            var login = textBoxLogin.Text;
            var senha = textBoxSenha.Text;

            int contem = _context.Usuarios.
                Where(x => x.Login == login && x.Senha == senha).Count();

            if (contem > 0)
            {
                new CaixaWindow().Show();
                this.Close();
            }
        }
    }
}
