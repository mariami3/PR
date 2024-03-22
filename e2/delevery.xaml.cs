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
    /// Логика взаимодействия для delevery.xaml
    /// </summary>
    public partial class delevery : Window
    {
        ComicsShopEntities context = new ComicsShopEntities();

        public delevery()
        {
            InitializeComponent();  
            Delevery.ItemsSource = context.Delevery.ToList();
            TT.ItemsSource = context.Genres.ToList();
            TT.DisplayMemberPath = "GenresName";
            VV.ItemsSource = context.Comicses.ToList();
            VV.DisplayMemberPath = "Comics_Name";

        }

        private void Button_Click(object sender, RoutedEventArgs e)//изменение
        {

            if (Delevery.SelectedItems != null)
            {
                var selected = Delevery.SelectedItem as Delevery;

                selected.DateZakaza = T.Text;
                selected.Genres_ID = (TT.SelectedItem as Genres).ID_Genres;
                selected.Comicses_ID = (VV.SelectedItem as Comicses).ID_Comicses;

                context.SaveChanges();
                Delevery.ItemsSource = context.Delevery.ToList();
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//добавление
        {
            
            
            Delevery s = new Delevery();

            s.DateZakaza = T.Text;
            

            s.Genres_ID =(TT.SelectedItem as Genres).ID_Genres;

           
            s.Comicses_ID = (VV.SelectedItem as Comicses).ID_Comicses;
            
            context.Delevery.Add(s);

            context.SaveChanges();
            Delevery.ItemsSource = context.Delevery.ToList();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//удаление
        {

          

            if (Delevery.SelectedItems != null)
            {

                Delevery selectDelevery = (Delevery)Delevery.SelectedItem;

                context.Delevery.Remove(selectDelevery);

                context.SaveChanges();
                Delevery.ItemsSource = context.Delevery.ToList();

            }

            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
