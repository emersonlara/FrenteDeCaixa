using System.Windows;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for NovoPerfilWindow.xaml
    /// </summary>
    public partial class NovoPerfilWindow
    {
        //private PerfilDeUsuarioService perfilService;

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //perfilService = new PerfilDeUsuarioService();
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
                Close();
            }
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
