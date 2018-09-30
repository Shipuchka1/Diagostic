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
using Diagnostic.DAL.Model;

namespace Diagnostic.Vew
{
    /// <summary>
    /// Interaction logic for AddNewCity.xaml
    /// </summary>
    public partial class AddNewCity : Page
    {
        Model1 db = new Model1();
        public AddNewCity()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameCitytextBox.Text))
            {
                CityNameLabel.Foreground = new SolidColorBrush(Colors.Black);

                pn_city city = new pn_city();
                city.name = NameCitytextBox.Text;

                try
                {
                    db.pn_city.Add(city);
                    db.SaveChanges();
                    
                    MainWindow.mf.Source = new Uri("Vew/CityPage.xaml", UriKind.RelativeOrAbsolute);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                CityNameLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
