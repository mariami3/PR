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
    /// Логика взаимодействия для comics.xaml
    /// </summary>
    public partial class comics : Window
    {
        ComicsShopEntities context = new ComicsShopEntities();

        public comics()
        {
            InitializeComponent();
            Comicses.ItemsSource = context.Comicses.ToList();
        }

        private void Smena(object sender, RoutedEventArgs e)
        {
            if (Comicses.SelectedItems != null)
            {
                var selected = Comicses.SelectedItem as Comicses;

                selected.Comics_Name = A.Text;
                selected.Athor = A1.Text;
                selected.Price = A2.Text;


                context.SaveChanges();
                Comicses.ItemsSource = context.Comicses.ToList();
            }
        }

        private void Dobavka(object sender, RoutedEventArgs e)
        {
            Comicses s = new Comicses();

            s.Comics_Name = A.Text;


            s.Athor = A1.Text;

            s.Price = A2.Text;

            context.Comicses.Add(s);

            context.SaveChanges();
            Comicses.ItemsSource = context.Comicses.ToList();
        }

        private void Ydalenie(object sender, RoutedEventArgs e)
        {
            if (Comicses.SelectedItems != null)
            {
                context.Comicses.Remove(Comicses.SelectedItem as Comicses);
                context.SaveChanges();
                Comicses.ItemsSource = context.Comicses.ToList();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
