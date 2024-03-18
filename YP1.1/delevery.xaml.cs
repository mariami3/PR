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
    /// Логика взаимодействия для delevery.xaml
    /// </summary>
    public partial class delevery : Window
    { 
        private ComicsShopEntities context = new ComicsShopEntities();
        public delevery()
        {
            InitializeComponent();
            Delevery.ItemsSource = context.Delevery.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Delevery.SelectedItem != null)
            {
                var selected = Delevery.SelectedItem as Delevery;
                try
                {

                    selected.DateZakaza = T.Text;

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
                Delevery.ItemsSource = context.Delevery.ToList();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Delevery delevery = new Delevery();

            string DateZakaza = T.Text.Trim();

             if (string.IsNullOrEmpty(DateZakaza))
             {
                 MessageBox.Show($"Произошла ошибка: ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                 return;
             }




             context.Delevery.Add(delevery);
             context.SaveChanges();
             Delevery.ItemsSource = context.Delevery.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Delevery.SelectedItems != null)
            {
                context.Delevery.Remove(Delevery.SelectedItem as Delevery);
                context.SaveChanges();
                Delevery.ItemsSource = context.Genres.ToList();


            }
        }
    }
}
