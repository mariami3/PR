using System;
using System.Collections.Generic;
using System.Data;
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
using DS4.BookDataSetTableAdapters;

namespace DS4
{
    /// <summary>
    /// Логика взаимодействия для Author.xaml
    /// </summary>
    public partial class Author : Window
    {
        private AuthorsTableAdapter context = new AuthorsTableAdapter();
        public Author()
        {
            InitializeComponent();
            Au.ItemsSource = context.GetData();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Au.ItemsSource = context.SearchByName(Search.Text);
            Au.ItemsSource = context.SearchByName1(Search.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Au.ItemsSource = context.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
