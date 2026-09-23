using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kosteczkidesktop
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        bool dostepna1 = true;
        bool dostepna2 = true;
        bool dostepna3 = true;
        bool dostepna4 = true;
        bool dostepna5 = true;

        Random liczba = new Random();

        int l1 = 0;
        int l2 = 0;
        int l3 = 0;
        int l4 = 0;
        int l5 = 0;

        

        private void btn1_img_Click(object sender, RoutedEventArgs e)
        {
           
            if (dostepna1)
            {
                img_1.Opacity = 0.5;
                dostepna1 = !dostepna1;
            }
            else
            {
                img_1.Opacity = 1;
                dostepna1 = !dostepna1;
            }
        }

        private void btn2_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna2)
            {
                img_2.Opacity = 0.5;
                dostepna2 = !dostepna2;
            }
            else
            {
                img_2.Opacity = 1;
                dostepna2 = !dostepna2;
            }
        }
    
        

        private void btn3_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna3)
            {
                img_3.Opacity = 0.5;
                dostepna3 = !dostepna3;
            }
            else
            {
                img_3.Opacity = 1;
                dostepna3 = !dostepna3;
            }
        }
        

        private void btn4_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna4)
            {
                img_4.Opacity = 0.5;
                dostepna4 = !dostepna4;
            }
            else
            {
                img_4.Opacity = 1;
                dostepna4 = !dostepna4;
            }
        }

        private void btn5_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna5)
            {
                img_5.Opacity = 0.5;
                dostepna5 = !dostepna5;
            }
            else {
                img_5.Opacity = 1;
                dostepna5 = !dostepna5;
                
            }
        }

        private void rzuc_btn_Click(object sender, RoutedEventArgs e)
        {


            if (dostepna1)
            {
                l1 = liczba.Next(1, 7);
                img_1.Source = new BitmapImage(new Uri("images/kosc" + l1 + ".png", UriKind.Relative));
            }
            if (dostepna2)
            {
                l2 = liczba.Next(1, 7);
                img_2.Source = new BitmapImage(new Uri("images/kosc" + l2 + ".png", UriKind.Relative));
            }

            if (dostepna3)
            {
                l3 = liczba.Next(1, 7);
                img_3.Source = new BitmapImage(new Uri("images/kosc" + l3 + ".png", UriKind.Relative));
            }
            if (dostepna4)
            {
                l4 = liczba.Next(1, 7);
                img_4.Source = new BitmapImage(new Uri("images/kosc" + l4 + ".png", UriKind.Relative));
            }

            if (dostepna5)
            {
                l5 = liczba.Next(1, 7);
                img_5.Source = new BitmapImage(new Uri("images/kosc" + l5 + ".png", UriKind.Relative));
            }
            
            
            int suma = (l1 + l2 + l3 + l4 + l5);

            Wynik.Text = suma.ToString();


        }
    }
}
