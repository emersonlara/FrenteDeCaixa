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
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private EntidadesContext Banco;

        public LoginWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Banco = new EntidadesContext();
        }

        private void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;

            int contem = Banco.Usuarios.
                Where(x => x.Login == login && x.Senha == senha).Count();

            if (contem > 0)
            {
                new CaixaWindow().Show();
                this.Close();
            }
        }
    }
}
