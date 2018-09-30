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
    /// Interaction logic for CityPage.xaml
    /// </summary>
    public partial class CityPage : Page
    {
        Model1 db = new Model1();
        public CityPage()
        {
            InitializeComponent();
            ListCity.ItemsSource = db.pn_city.ToList();
        }
    }
}
