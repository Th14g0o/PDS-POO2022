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
    /// Lógica interna para ContatosWindow.xaml
    /// </summary>
    public partial class ContatosWindow : Window
    {
        public ContatosWindow()
        {
            InitializeComponent();
            todosC.ItemsSource = null;
            todosC.ItemsSource = NContato.Listar();
        }
        private void inserirC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Contato c = new Contato { Recado = recadoC.Text, Id = int.Parse(idC.Text), Nome = nomeC.Text, Telefone = telefoneC.Text };
                Contato c = new Contato { Recado = recadoC.Text, Nome = nomeC.Text, Telefone = telefoneC.Text };
                NContato.Inserir(c);
                listarC_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Digite um numero no ID");
            }
        }

        private void listarC_Click(object sender, RoutedEventArgs e)
        {
            todosC.ItemsSource = null;
            todosC.ItemsSource = NContato.Listar();
        }

        private void excluirC_Click(object sender, RoutedEventArgs e)
        {
            if (todosC.SelectedItem != null)
            {
                NContato.Excluir((Contato)todosC.SelectedItem);
                listarC_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione um contato");
            }
        }

        private void atualizarC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (todosC.SelectedItem != null)
                {
                    Contato cf = (Contato)todosC.SelectedItem;
                    Contato c = new Contato { Recado = recadoC.Text, Nome = nomeC.Text, Telefone = telefoneC.Text, Id = cf.Id };
                    NContato.Atualizar(c);
                    listarC_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Selecione um contato e digite um numero no ID");
            }
        }

        private void todosC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (todosC.SelectedItem != null)
            {
                Contato c = (Contato)todosC.SelectedItem;
                recadoC.Text = c.Recado.ToString();
                nomeC.Text = c.Nome;
                telefoneC.Text = c.Telefone;
            }
        }
    }
}
