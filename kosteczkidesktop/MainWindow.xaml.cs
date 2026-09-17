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

        Random liczba_1 = new Random();
        Random liczba_2 = new Random();
        Random liczba_3 = new Random();
        Random liczba_4 = new Random();
        Random liczba_5 = new Random();

    
        private void btn1_img_Click(object sender, RoutedEventArgs e)
        {
           
            if (dostepna1)
            {
                img_1.Opacity = 0.5;
                dostepna1 = false;
            }
            else
            {
                img_1.Opacity = 1;
                dostepna1 = true;
            }
        }

        private void btn2_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna2)
            {
                img_2.Opacity = 0.5;
                dostepna2 = false;
            }
            else
            {
                img_2.Opacity = 1;
                dostepna2 = true;
            }
        }
    
        

        private void btn3_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna3)
            {
                img_3.Opacity = 0.5;
                dostepna3 = false;
            }
            else
            {
                img_3.Opacity = 1;
                dostepna3 = true;
            }
        }
        

        private void btn4_img_Click(object sender, RoutedEventArgs e)
        {
            
            if (dostepna4)
            {
                img_4.Opacity = 0.5;
                dostepna4 = false;
            }
            else
            {
                img_4.Opacity = 1;
                dostepna4 = true;
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

            int l1 = liczba_1.Next(1, 7);
            int l2 = liczba_2.Next(1, 7);
            int l3 = liczba_3.Next(1, 7);
            int l4 = liczba_4.Next(1, 7);
            int l5 = liczba_5.Next(1, 7);

            int suma = (l1 + l2 + l3 + l4 + l5);

            Wynik.Text = suma.ToString();


        }
    }
}
