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
using Ds3.BookDataSetTableAdapters; 

namespace Ds3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BooKsTableAdapter context = new BooKsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Ds3.ItemsSource = context.GDB();
        }
    }
}
