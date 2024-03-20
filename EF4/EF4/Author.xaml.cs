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

namespace EF4
{
    /// <summary>
    /// Логика взаимодействия для Author.xaml
    /// </summary>
    public partial class Author : Window
    {
        private BookEntities context = new BookEntities();
        public Author()
        {
            InitializeComponent();
            Au.ItemsSource = context.Authors.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Au.ItemsSource = context.Authors.ToList().Where(item => item.AuthorName.Contains(Search.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Au.ItemsSource = context.Authors.ToList();
        }
    }
}
