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

namespace POOzap
{
    /// <summary>
    /// Lógica interna para ListarGruposWindow.xaml
    /// </summary>
    public partial class ListarGruposWindow : Window
    {
        public ListarGruposWindow()
        {
            InitializeComponent();
            conts.ItemsSource = null;
            conts.ItemsSource = NContato.Listar();
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            if (conts.SelectedItem != null)
            {
                Contato c = (Contato)conts.SelectedItem;
                if (c != null)
                {
                    grups.ItemsSource = null;
                    grups.ItemsSource = NMembro.Listar(c);
                }
            }
        }

        private void sair_Click(object sender, RoutedEventArgs e)
        {
            if (grups.SelectedItem != null && conts.SelectedItem != null)
            {
                Grupo g = (Grupo)grups.SelectedItem;
                Contato c = (Contato)conts.SelectedItem;
                if (g != null && c != null)
                {
                    NMembro.Excluir(g, c);
                    listar_Click(sender, e);
                }
            }
        }
    }
}
