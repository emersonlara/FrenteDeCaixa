using System.Windows;
using FrenteDeCaixa.Presentation.View.PerfilWindows;

namespace FrenteDeCaixa.Presentation.View
{
    /// <summary>
    /// Interaction logic for CaixaWindow.xaml
    /// </summary>
    public partial class CaixaWindow : Window
    {
        public CaixaWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            labelTotal.Content += "R$ 0,00";
        }

        private void buttonPerfis_Click(object sender, RoutedEventArgs e)
        {
            new MainPerfisWindow().ShowDialog();
        }
    }
}
