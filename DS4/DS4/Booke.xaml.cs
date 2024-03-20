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
using static System.Net.Mime.MediaTypeNames;

namespace DS4
{
    /// <summary>
    /// Логика взаимодействия для Booke.xaml
    /// </summary>
    public partial class Booke : Window
    {
        BooKsTableAdapter boo = new BooKsTableAdapter();
        AuthorsTableAdapter auth = new AuthorsTableAdapter();
        public Booke()
        {
            InitializeComponent();
            bk.ItemsSource = boo.GetData();
            Cb.ItemsSource = auth.GetData();
            Cb.DisplayMemberPath = "Author";
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bk.ItemsSource = boo.SearchByName(Search.Text);
            bk.ItemsSource = boo.SearchByName1(Search.Text);
            bk.ItemsSource = boo.SearchByName2(Search.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bk.ItemsSource = boo.GetData();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb.SelectedItem != null)
            {
                var id = (int)(Cb.SelectedItem as DataRowView).Row[0];
                bk.ItemsSource = boo.FilterByAuthors(id);
            }
        }
    }
}
