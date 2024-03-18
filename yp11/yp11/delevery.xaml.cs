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
    /// Логика взаимодействия для delevery.xaml
    /// </summary>
    public partial class delevery : Window
    {
        private DeleveryTableAdapter dlv = new DeleveryTableAdapter();

        public delevery()
        {
            InitializeComponent();
            dv.ItemsSource = dlv.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dlv.InsertQuery1(T.Text);
            dv.ItemsSource = dlv.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (dv.SelectedItem as DataRowView).Row[0];
            dlv.UpdateQuery(T.Text, Convert.ToString(id));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (dv.SelectedItem as DataRowView).Row[0];
            dlv.DeleteQuery(Convert.ToInt32(id));
        }
    }
}
