using System.Windows;

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
    }
}
