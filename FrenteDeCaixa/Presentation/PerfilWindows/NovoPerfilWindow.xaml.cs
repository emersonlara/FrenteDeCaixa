using FrenteDeCaixa.Application;
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
        private PerfilDeUsuarioApplication perfilApp;

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            perfilApp = new PerfilDeUsuarioApplication();
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
                perfilApp.Salvar(perfil);
                this.Close();
            }
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
