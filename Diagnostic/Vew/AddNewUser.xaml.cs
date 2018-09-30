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
    /// Interaction logic for AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Page
    {
        Model1 db = new Model1();
        public AddNewUser()
        {
            InitializeComponent();

            RoleListBox.ItemsSource = db.pn_roles.ToList();

            //foreach (pn_roles roles in db.pn_roles)
            //{
            //    ComboBoxItem cbi = new ComboBoxItem();
            //    cbi.Content = roles.name;
            //    RoleListBox.Items.Add(cbi);
            //}
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LoginuserTextBox.Text))
            {
                LoginuserLabel.Foreground = new SolidColorBrush(Colors.Black);
                if (!string.IsNullOrEmpty(PassworduserTextBox.Text))
                {
                    PassworduserLabel.Foreground = new SolidColorBrush(Colors.Black);

                    if (!string.IsNullOrEmpty(AddressuserTextBox.Text))
                    {
                        AddressuserLabel.Foreground = new SolidColorBrush(Colors.Black);
                        if (!string.IsNullOrEmpty(NameuserTextBox.Text))
                        {
                            NameuserLabel.Foreground = new SolidColorBrush(Colors.Black);

                            pn_tbl_user user = new pn_tbl_user();
                            user.login = LoginuserTextBox.Text;
                            user.password = PassworduserTextBox.Text;
                            user.address = AddressuserTextBox.Text;
                            user.age = Int32.Parse(AgeuseTextBox.Text);
                            user.gender = (bool)GenderuserTextBox0.IsChecked ? 0 : 1;
                            user.name = NameuserTextBox.Text;
                            user.phoneNo = PhoneNouserTextBox.Text;

                            pn_roles lbi = RoleListBox.SelectedItem as pn_roles;
                            user.userRoleId = lbi.roleId;

                            try
                            {
                                db.pn_tbl_user.Add(user);
                                db.SaveChanges();
                                MessageBox.Show("Пользователь добавлен");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            


                        }
                        else
                        {
                            NameuserLabel.Foreground = new SolidColorBrush(Colors.Red);
                        }
                    }

                    else
                    {
                        AddressuserLabel.Foreground = new SolidColorBrush(Colors.Red);
                    }
                }
                else
                {
                    PassworduserLabel.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
            else
            {
               LoginuserLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
