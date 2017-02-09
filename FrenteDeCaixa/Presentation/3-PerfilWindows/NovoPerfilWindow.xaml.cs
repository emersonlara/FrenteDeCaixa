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

        public NovoPerfilWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            perfilService = new PerfilDeUsuarioService();
        }

        private void buttonNovo_Click(object sender, RoutedEventArgs e)
        {
            var nome = textBoxNome.Text;
            if (nome.Equals("")) return;
            var perfil = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome(nome)
                .WithExcluido(false)
                .Build();

            var perfilDto = AutoMapperConfig.Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto> (perfil);
            Console.WriteLine("Id: " + perfil.Id + "\nNome:" + perfil.Nome+ "\nDto\nId:" + perfilDto.Id + "\nNome:" + perfilDto.Nome);
            perfilService.Salvar(perfilDto);
                
            Close();
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
