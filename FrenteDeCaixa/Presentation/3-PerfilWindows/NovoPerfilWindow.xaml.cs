using System;
using System.Windows;
using FrenteDeCaixa.Application.Mapper;
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
        private PerfilDeUsuarioService perfilService;
        private PerfilDeUsuarioDomain perfilEdicao;
        private bool isEdicao;

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            perfilService = new PerfilDeUsuarioService();
            isEdicao = false;
        }

        public NovoPerfilWindow(PerfilDeUsuarioDomain perfil)
        {
            //  Construtor de Edicao de Perfil
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            perfilEdicao = perfil;
            textBoxNome.Text = perfil.Nome;
            isEdicao = true;
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            var nome = textBoxNome.Text;
            if (nome.Equals("")) return;

            if (isEdicao)
            {
                perfilEdicao.Nome = nome;
                var perfilDto = AutoMapperConfig.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>(perfilEdicao);
                perfilService.Alterar(perfilDto);
            }
            else
            {
                var perfil = new PerfilDeUsuarioBuilder()
                    .WithId(Guid.NewGuid())
                    .WithNome(nome)
                    .WithExcluido(false)
                    .Build();

                var perfilDto = AutoMapperConfig.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>(perfil);

                Console.WriteLine("Id: " + perfil.Id + "\nNome:" + perfil.Nome + "\n" +
                                  "Dto\nId:" + perfilDto.Id + "\nNome:" + perfilDto.Nome);

                perfilService.Salvar(perfilDto);
            }
            Close();
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
