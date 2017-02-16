using System.Windows;
using FrenteDeCaixa.Presentation._4_UsuarioWindows;
using FrenteDeCaixa.Presentation._5_ClienteWindow;
using FrenteDeCaixa.Presentation._7_FormaDePagamentoWindow;

namespace FrenteDeCaixa.Presentation
{
    /// <summary>
    /// Interaction logic for CaixaWindow.xaml
    /// </summary>
    public partial class CaixaWindow
    {
        public CaixaWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            labelTotal.Content += "R$ 0,00";
        }

        private void buttonPerfis_Click(object sender, RoutedEventArgs e)
        {
            new MainPerfisWindow().ShowDialog();
        }

        private void buttonUsuarios_Click(object sender, RoutedEventArgs e)
        {
            new MainUsuarioWindow().ShowDialog();
        }

        private void buttonClientes_Click(object sender, RoutedEventArgs e)
        {
            new MainClientesWindow().ShowDialog();
        }

        private void buttonFormasDePagamento_Click(object sender, RoutedEventArgs e)
        {
            new MainFormaDePagamentoWindow();
        }
    }
}
