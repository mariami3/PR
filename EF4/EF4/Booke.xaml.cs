using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Booke.xaml
    /// </summary>
    public partial class Booke : Window
    {
        private BookEntities booke = new BookEntities();
        public Booke()
        {
            InitializeComponent();
            bk.ItemsSource = booke.BooKs.ToList();
            Cb.ItemsSource = booke.Authors.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bk.ItemsSource = booke.BooKs.ToList().Where(item => item.BooksName.Contains(Search.Text));
            bk.ItemsSource = booke.BooKs.ToList().Where(item => item.DateCriation.Contains(Search.Text));
            bk.ItemsSource = booke.BooKs.ToList().Where(item => item.TypeLit.Contains(Search.Text));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bk.ItemsSource = booke.BooKs.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bk.ItemsSource != null)
            {
                var selected = Cb.SelectedItem as Authors;
                bk.ItemsSource = booke.BooKs.ToList().Where(item => item.Authors == selected);

            }
        }
    }
}
