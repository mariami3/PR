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
using yu1.ComicsShopDataSetTableAdapters;

namespace yu1
{
    /// <summary>
    /// Логика взаимодействия для Comics.xaml
    /// </summary>
    public partial class Comics : Window
    {
        ComicsesTableAdapter comics = new ComicsesTableAdapter();
        public Comics()
        {
            InitializeComponent();
            comic.ItemsSource = comics.GetData();
        }

        private void Comics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            comics.InsertQuery(B.Text, B1.Text, B2.Text);
            comic.ItemsSource = comics.GetData();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (comic.SelectedItem as DataRowView).Row[0];
            comics.UpdateQuery(B.Text, Convert.ToInt32(id));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object Name = (comic.SelectedItem as DataRowView).Row[0];
            comics.DeleteQuery(Convert.ToString(Name));

            object Author = (comic.SelectedItem as DataRowView).Row[0];
            comics.DeleteQuery1(Convert.ToString(Author));

            object Price = (comic.SelectedItem as DataRowView).Row[0];
            comics.DeleteQuery2(Convert.ToString(Price));

            object id = (comic.SelectedItem as DataRowView).Row[0];
            comics.DeleteQuery3(Convert.ToInt32(id));

        }
    }
}
