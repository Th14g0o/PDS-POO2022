﻿using System;
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
    /// Lógica interna para ListarMembrosWindow.xaml
    /// </summary>
    public partial class ListarMembrosWindow : Window
    {
        public ListarMembrosWindow()
        {
            InitializeComponent();
            todosMG1.ItemsSource = null;
            todosMG1.ItemsSource = NGrupo.Listar();
        }

        private void listarMG_Click(object sender, RoutedEventArgs e)
        {
            if (todosMG1.SelectedItem != null)
            {
                todosMG2.ItemsSource = null;
                todosMG2.ItemsSource = NMembro.Listar((Grupo)todosMG1.SelectedItem);
            }
            else
            {
                todosMG2.ItemsSource = null;
                todosMG2.ItemsSource = NMembro.Listar();
            }
        }

        private void removerMG_Click(object sender, RoutedEventArgs e)
        {
            if (todosMG2.SelectedItem != null)
            {
                Contato c = (Contato)todosMG2.SelectedItem;
                if(c!= null)
                {
                    NMembro.Excluir(c);
                    listarMG_Click(sender, e);
                }
               
            }
        }

        private void promoverMG_Click(object sender, RoutedEventArgs e)
        {
            if (todosMG2.SelectedItem != null)
            {
                NMembro.Promover((Membro)todosMG2.SelectedItem);
                listarMG_Click(sender, e);
            }
        }

        private void rebaixarMG_Click(object sender, RoutedEventArgs e)
        {
            if (todosMG2.SelectedItem != null)
            {
                NMembro.Rebaixar((Membro)todosMG2.SelectedItem);
                listarMG_Click(sender, e);
            }
        }
    }
}
