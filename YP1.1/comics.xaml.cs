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
    /// Логика взаимодействия для comics.xaml
    /// </summary>
    public partial class comics : Window
    {
        private ComicsShopEntities context = new ComicsShopEntities();  
        public comics()
        {
            InitializeComponent();
            Comicses.ItemsSource = context.Comicses.ToList();
        }

        private void Smena(object sender, RoutedEventArgs e)
        {
            if (Comicses.SelectedItem != null)
            {
                var selected = Comicses.SelectedItem as Comicses;
                try
                {
                    selected.Comics_Name = A.Text;
                    selected.Athor = A1.Text;
                    selected.Price = A2.Text;

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
                Comicses.ItemsSource = context.Genres.ToList();

            }
        }

        private void Dobavka(object sender, RoutedEventArgs e)
        {
            Comicses comics = new Comicses();

             string Comics_Name = A.Text;
             string Author = A1.Text;
             string Price = A2.Text;

            if (string.IsNullOrEmpty(Comics_Name) || string.IsNullOrEmpty(Author) || string.IsNullOrEmpty(Price))
            {
                MessageBox.Show($"Произошла ошибка: ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            comics.Comics_Name = Comics_Name;
            comics.Athor = Author;
            comics.Price = Price;

            context.Comicses.Add(comics);
            context.SaveChanges();
            Comicses.ItemsSource = context.Genres.ToList();
        }

        private void Ydalenie(object sender, RoutedEventArgs e)
        {
            if (Comicses.SelectedItems != null)
            {
                context.Comicses.Remove(Comicses.SelectedItem as Comicses);
                context.SaveChanges();
                Comicses.ItemsSource = context.Genres.ToList();

            }
        }
    }
}
