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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diagnostic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame mf;
        public static Menu mm;
        
        //public static MenuItem miu;
        //public static MenuItem dictMI;
     
        public MainWindow()
         {
            InitializeComponent();
            mf = MainFrame;
            mm = MainMenu;
            
            
            MainFrame.Source = new Uri("Vew/LoginPage.xaml",UriKind.RelativeOrAbsolute);
        }

        public static void LoadAfterlogin()
        {
            mf.Source = new Uri("Vew/AfterLogin.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/CityPage.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/Laboratory.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/UserList.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/TestPage.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/AddNewUser.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/AddNewCity.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/AddNewLaboratory.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/AddNewTest.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            mf.Source = new Uri("Vew/DocUserList.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
