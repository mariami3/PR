using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using yu1.ComicsShopDataSetTableAdapters;

namespace yu1
{
    /// <summary>
    /// Логика взаимодействия для delever.xaml
    /// </summary>
    public partial class delever : Window
    {
        private DeleveryTableAdapter dlv = new DeleveryTableAdapter();
        public delever()
        {
            InitializeComponent();
            dv.ItemsSource = dlv.GetData();
        }

        private void dv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dlv.InsertQuery(T.Text);
            dv.ItemsSource = dlv.GetData();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                object id = (dv.SelectedItem as DataRowView).Row[0];
                dlv.UpdateQuery(T.Text, Convert.ToString(id));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            object id = (dv.SelectedItem as DataRowView).Row[0];
            dlv.DeleteQuery(Convert.ToInt32(id));

        }
    }
}
