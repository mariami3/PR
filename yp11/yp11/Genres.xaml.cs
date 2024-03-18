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
using yp11.ComicsShopDataSetTableAdapters;

namespace yp11
{
    /// <summary>
    /// Логика взаимодействия для Genres.xaml
    /// </summary>
    public partial class Genres : Window
    {
        GenresTableAdapter genre = new GenresTableAdapter();
        public Genres()
        {
            InitializeComponent();
            Genre.ItemsSource = genre.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            genre.InsertQuery(A.Text, A1.Text);
            Genre.ItemsSource = genre.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (Genre.SelectedItem as DataRowView).Row[0];
            genre.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (Genre.SelectedItem as DataRowView).Row[0];
            genre.DeleteQuery(Convert.ToInt32(id));

            object Name = (Genre.SelectedItem as DataRowView).Row[0];
            genre.DeleteQuery1(Convert.ToString(Name));

            object Country = (Genre.SelectedItem as DataRowView).Row[0];
            genre.DeleteQuery2(Convert.ToString(Country));

        }
    }
}
