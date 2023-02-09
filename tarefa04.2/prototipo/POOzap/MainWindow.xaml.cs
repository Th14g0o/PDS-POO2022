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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POOzap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            ContatosWindow Janela = new ContatosWindow();
            Janela.ShowDialog();
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            GruposWindow Janela = new GruposWindow();
            Janela.ShowDialog();
        }

        private void vcag_Click(object sender, RoutedEventArgs e)
        {
            VincularWindow Janela = new VincularWindow();
            Janela.ShowDialog();
        }

        private void lm_Click(object sender, RoutedEventArgs e)
        {
            ListarMembrosWindow janela = new ListarMembrosWindow();
            janela.ShowDialog();
        }

        private void lg_Click(object sender, RoutedEventArgs e)
        {
            ListarGruposWindow janela = new ListarGruposWindow();
            janela.ShowDialog();
        }
    }
}
