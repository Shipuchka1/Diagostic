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
    /// Interaction logic for AddNewLaboratory.xaml
    /// </summary>
    public partial class AddNewLaboratory : Page
    {
        Model1 db= new Model1();
        public AddNewLaboratory()
        {
            InitializeComponent();
            CityLaboratoryTextBox.ItemsSource = db.pn_city.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameLaboratoryTextBox.Text))
            {
                NameLaboratoryLabel.Foreground = new SolidColorBrush(Colors.Black);

                if (!string.IsNullOrEmpty(CityLaboratoryTextBox.Text))
                {
                    CityIdLaboratoryLabel.Foreground = new SolidColorBrush(Colors.Black);

                    if (!string.IsNullOrEmpty(AddressLaboratoryTextBox.Text))
                    {
                        AddressIdLaboratoryLabel.Foreground = new SolidColorBrush(Colors.Black);


                        pn_laboratory lab = new pn_laboratory();

                        lab.address = AddressLaboratoryTextBox.Text;
                        lab.cityID = ((pn_city) CityLaboratoryTextBox.SelectedItem).CityId ;
                        lab.labeTimins = TimeLaboratoryTextBox.Text;
                        lab.name = NameLaboratoryTextBox.Text;
                        lab.phoneNo = PhoneNoLaboratoryTextBox.Text;

                        try
                        {
                            db.pn_laboratory.Add(lab);
                            db.SaveChanges();
                            MainWindow.mf.Source = new Uri("Vew/Laboratory.xaml", UriKind.RelativeOrAbsolute);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                    else
                    {
                        AddressIdLaboratoryLabel.Foreground = new SolidColorBrush(Colors.Red);
                    }
                }
                else
                {
                    CityIdLaboratoryLabel.Foreground = new SolidColorBrush(Colors.Red);
                }
            }

            else
            {
                NameLaboratoryLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
