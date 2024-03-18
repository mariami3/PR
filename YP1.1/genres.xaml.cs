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

namespace YP1._1
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
            if (genre.SelectedItem != null)
            {
                var selected = genre.SelectedItem as Genres;
                try
                {
                    selected.GenresName = A.Text;
                    selected.Contry = A1.Text;

                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;

                }
                context.SaveChanges();
                genre.ItemsSource = context.Genres.ToList();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Genres genres = new Genres();

            string GenresName = A.Text.Trim();
            string Contry = A.Text.Trim();

            if (string.IsNullOrEmpty(GenresName) || string.IsNullOrEmpty(Contry))
            {
                MessageBox.Show($"Произошла ошибка: ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            genres.GenresName = GenresName;
            genres.Contry = Contry;

            context.Genres.Add(genres);
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
    }
}
