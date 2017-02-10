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
        private PerfilDeUsuarioService PerfilService;
        private PerfilDeUsuarioDomain PerfilEdicao;
        private bool isEdicao;

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            PerfilService = new PerfilDeUsuarioService();
            isEdicao = false;
        }

        public NovoPerfilWindow(PerfilDeUsuarioDomain perfil)
        {
            //  Construtor de Edicao de Perfil
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            PerfilEdicao = perfil;
            textBoxNome.Text = perfil.Nome;
            isEdicao = true;
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            var nome = textBoxNome.Text;
            if (nome.Equals("")) return;

            if (isEdicao)
            {
                PerfilEdicao.Nome = nome;
                var perfilDto = AutoMapperConfig.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>(PerfilEdicao);
                PerfilService.Alterar(perfilDto);
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
