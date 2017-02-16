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
using FrenteDeCaixa.Application.Service.FormaDePagamento;

namespace FrenteDeCaixa.Presentation._7_FormaDePagamentoWindow
{
    /// <summary>
    /// Interaction logic for MainFormaDePagamentoWindow.xaml
    /// </summary>
    public partial class MainFormaDePagamentoWindow : Window
    {
        public MainFormaDePagamentoWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            var clienteService = new FormaDePagamentoService();
            DataGridFormasDePagamento.ItemsSource = clienteService.Listar();
        }
    }
}
