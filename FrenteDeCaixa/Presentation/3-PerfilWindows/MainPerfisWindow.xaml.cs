using System.Windows;
using FrenteDeCaixa.Application.Mapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Resources;

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

        private void ButtonExcluir_Click(object sender, RoutedEventArgs e)
        {
            var coluna = (PerfilDeUsuarioDomain)DataGridPerfis.SelectedItem;

            var perfil = new PerfilDeUsuarioBuilder()
                .WithId(coluna.Id)
                .WithNome(coluna.Nome)
                .WithExcluido(coluna.Excluido)
                .Build();

            var result = MessageBox.Show(Strings.RemoverRegistro + " " + coluna.Nome + "?",
                Strings.RemoverRegistroTittle, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No) return;

            var perfilDeUsuarioService = new PerfilDeUsuarioService();

            var perfilDto = AutoMapperConfig.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>(perfil);
            perfilDeUsuarioService.Excluir(perfilDto);
        }
    }
}
