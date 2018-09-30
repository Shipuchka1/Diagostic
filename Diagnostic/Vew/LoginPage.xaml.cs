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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Model1 db = new Model1();
       
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonLoginClick(object sender, RoutedEventArgs e)
        {

            pn_tbl_user user = db.pn_tbl_user.FirstOrDefault(a => a.login == LoginTextBox.Text
                                                   && a.password == PasswordTextBox.Password);


            if (user!=null)
            {
               if(user.userRoleId == 0)//если заходит админ

                    MainWindow.mm.Visibility = Visibility.Visible;

               else if (user.userRoleId == 1)//если заходит пользователь
               {

               }

               else if (user.userRoleId == 2)//если заходит лаборант
               {
                   
               }
                MainWindow.LoadAfterlogin();
                
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
