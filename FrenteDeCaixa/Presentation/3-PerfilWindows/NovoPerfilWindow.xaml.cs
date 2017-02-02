using System.Windows;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for NovoPerfilWindow.xaml
    /// </summary>
    public partial class NovoPerfilWindow : Window
    {
        private PerfilDeUsuarioService perfilService;

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            perfilService = new PerfilDeUsuarioService();
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            if (!textBoxNome.Text.Equals(null))
            {
                /*
                PerfilDeUsuarioDomain perfil = new PerfilDeUsuarioDomain()
                {
                    Id = Guid.NewGuid(),
                    Nome = textBoxNome.Text
                };
                perfilService.Salvar(perfil);
                */
                this.Close();
            }
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
