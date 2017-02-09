using System;
using System.Windows;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using AutoMapper;

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
                .Build();

            var perfilDto = Mapper.Map<PerfilDeUsuarioDomain, PerfilDeUsuarioDto> (perfil);
            perfilService.Salvar(perfilDto);
                
            Close();
        }

        private void buttonFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
