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
    /// Lógica interna para VincularWindow.xaml
    /// </summary>
    public partial class VincularWindow : Window
    {
        public VincularWindow()
        {
            InitializeComponent();
            grupos.ItemsSource = null;
            grupos.ItemsSource = NGrupo.Listar();
            contatos.ItemsSource = null;
            contatos.ItemsSource = NContato.Listar();
        }
        private void vincular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                Grupo g = (Grupo) grupos.SelectedItem;
                Contato c = (Contato) contatos.SelectedItem;
                if (g!=null && c!=null)
                    NMembro.Adicionar(c, g);
            }
            catch
            {
                MessageBox.Show("Selecione um grupo e um contato");
            }
        }
    }
}
