using System;
using System.Windows;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for NovoPerfilWindow.xaml
    /// </summary>
    public partial class NovoPerfilWindow
    {
        private PerfilDeUsuarioService PerfilService;
        private Guid Id;
        private string Nome;
        private bool Excluido;
        private bool isEdicao;

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            PerfilService = new PerfilDeUsuarioService();
            isEdicao = false;
        }

        public NovoPerfilWindow(Guid id, string nome, bool excluido)
        {
            //  Construtor de Edicao de Perfil
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            textBoxNome.Text = nome;

            PerfilService = new PerfilDeUsuarioService();
            Id = id;
            Nome = nome;
            Excluido = excluido;
            isEdicao = true;
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            var nome = textBoxNome.Text;
            if (nome.Equals("")) return;

            if (isEdicao)
            {
                var perfil = new PerfilDeUsuarioBuilder()
                    .WithId(Id)
                    .WithNome(nome)
                    .WithExcluido(Excluido)
                    .Build();

                var perfilDto = AutoMapper.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>(perfil);

                PerfilService.Alterar(perfilDto);
            }
            else
            {
                var perfil = new PerfilDeUsuarioBuilder()
                    .WithId(Guid.NewGuid())
                    .WithNome(nome)
                    .WithExcluido(false)
                    .Build();

                var perfilDto = AutoMapper.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>(perfil);

                PerfilService.Salvar(perfilDto);
            }
            Close();
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
