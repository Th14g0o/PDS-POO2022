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
    /// Lógica interna para GruposWindow.xaml
    /// </summary>
    public partial class GruposWindow : Window
    {
        public GruposWindow()
        {
            InitializeComponent();
            todosG.ItemsSource = null;
            todosG.ItemsSource = NGrupo.Listar();
        }

        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Grupo g = new Grupo { Descricao = descG.Text, Id = int.Parse(idG.Text), Nome = nomeG.Text };
                NGrupo.Inserir(g);
                listar_Click(sender, e) ;
            }
            catch
            {
                MessageBox.Show("Digite um numero no ID");
            }
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            todosG.ItemsSource = null;
            todosG.ItemsSource = NGrupo.Listar();
        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            if (todosG.SelectedItem != null)
            {
                NGrupo.Excluir((Grupo)todosG.SelectedItem);
                listar_Click(sender, e);
            }
            else
                MessageBox.Show("Selecione um grupo!");
        }

        private void atualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Grupo g = new Grupo { Descricao = descG.Text, Id = int.Parse(idG.Text), Nome = nomeG.Text };
                NGrupo.Atualizar(g);
                listar_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Digite as informações!");
            }
        }

        private void todosG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Grupo x = (Grupo) todosG.SelectedItem;
            if (x != null)
            {
                descG.Text = x.Descricao;
                idG.Text = x.Id.ToString();
                nomeG.Text = x.Nome;
            }
            
        }
    }
}
