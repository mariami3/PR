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

namespace e2
{
    /// <summary>
    /// Логика взаимодействия для genres.xaml
    /// </summary>
    public partial class genres : Window
    {
        private ComicsShopEntities context = new ComicsShopEntities();
        public genres()
        {
            InitializeComponent();
            genre.ItemsSource = context.Genres.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (genre.SelectedItems != null)
            {
                var selected = genre.SelectedItem as Genres;

                selected.GenresName = T.Text;
                selected.Contry = A.Text;

                context.SaveChanges();
                genre.ItemsSource = context.Genres.ToList();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Genres s = new Genres();

            s.GenresName = T.Text;


            s.Contry = A.Text;



            context.Genres.Add(s);

            context.SaveChanges();
            genre.ItemsSource = context.Genres.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (genre.SelectedItems != null)
            {
                context.Genres.Remove(genre.SelectedItem as Genres);
                context.SaveChanges();
                genre.ItemsSource = context.Genres.ToList();


            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
