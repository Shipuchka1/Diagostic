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
    /// Interaction logic for AddNewTest.xaml
    /// </summary>
    public partial class AddNewTest : Page
    {
        Model1 db = new Model1();
        public AddNewTest()
        {
            InitializeComponent();
            LaboratoryTestComboBox.ItemsSource = db.pn_laboratory.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTestTextBox.Text))
            {
                NameTestLabel.Foreground = new SolidColorBrush(Colors.Black);
                if (!string.IsNullOrEmpty(PriceTestTextBox.Text))
                {
                    PriceTestLabel.Foreground = new SolidColorBrush(Colors.Black);

                    pn_tests test = new pn_tests();

                    test.name = NameTestTextBox.Text;
                    test.price = Int32.Parse(PriceTestTextBox.Text);
                    test.laboratoryId = ((pn_laboratory)LaboratoryTestComboBox.SelectedItem).laboratoryID;

                    try
                    {
                        db.pn_tests.Add(test);
                        db.SaveChanges();
                        MainWindow.mf.Source = new Uri("Vew/TestPage.xaml", UriKind.RelativeOrAbsolute);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else
                {
                    PriceTestLabel.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
            else
            {
                NameTestLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
