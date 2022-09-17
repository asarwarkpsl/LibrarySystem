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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibrarySystem
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

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnReplaceBooks_Click(object sender, RoutedEventArgs e)
        {
            ReplacingBooks frmReplaceBooks = new ReplacingBooks();
            frmReplaceBooks.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IdentifyAreas frmIdentifyAreas = new IdentifyAreas();
            frmIdentifyAreas.ShowDialog();
        }
    }
}
