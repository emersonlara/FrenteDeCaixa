using System.Windows;
using FrenteDeCaixa.Application.Service.Cliente;

namespace FrenteDeCaixa.Presentation._5_ClienteWindow
{
    /// <summary>
    /// Interaction logic for MainClientesWindow.xaml
    /// </summary>
    public partial class MainClientesWindow : Window
    {
        public MainClientesWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            var clienteService = new ClienteService();
            dataGridClientes.ItemsSource = clienteService.Listar();
        }
    }
}
