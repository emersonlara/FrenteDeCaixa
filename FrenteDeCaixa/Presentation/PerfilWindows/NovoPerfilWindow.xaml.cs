using FrenteDeCaixa.Application;
using FrenteDeCaixa.Application.Service;
using FrenteDeCaixa.Domain;
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

namespace FrenteDeCaixa.Presentation.PerfilWindows
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
                PerfilDeUsuario perfil = new PerfilDeUsuario()
                {
                    Id = Guid.NewGuid(),
                    Nome = textBoxNome.Text
                };
                perfilService.Salvar(perfil);
                this.Close();
            }
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
