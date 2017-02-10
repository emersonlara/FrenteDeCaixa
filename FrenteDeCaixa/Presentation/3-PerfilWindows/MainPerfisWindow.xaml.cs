using System;
using System.Collections.Generic;
using System.Windows;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for PerfisWindow.xaml
    /// </summary>
    public partial class MainPerfisWindow
    {
        public MainPerfisWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AtualizaTabela();
        }

        public void AtualizaTabela()
        {
            var perfilService = new PerfilDeUsuarioService();
            DataGridPerfis.ItemsSource = perfilService.Listar();
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            new NovoPerfilWindow().ShowDialog();
            AtualizaTabela();
        }

        private void ButtonAlterar_Click(object sender, RoutedEventArgs e)
        {
            var coluna = (PerfilDeUsuarioDomain) DataGridPerfis.SelectedItem;

            var perfil = new PerfilDeUsuarioBuilder()
                .WithId(coluna.Id)
                .WithNome(coluna.Nome)
                .WithExcluido(coluna.Excluido)
                .Build();

            new NovoPerfilWindow(perfil).ShowDialog();
            AtualizaTabela();
        }
    }
}
