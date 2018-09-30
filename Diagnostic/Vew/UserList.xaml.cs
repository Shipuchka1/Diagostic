using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Page
    {
        Model1 db = new Model1();
        public UserList()
        {
            InitializeComponent();
            RoleEditComboBox.ItemsSource = db.pn_roles.ToList();
            UserListView.ItemsSource = db.pn_tbl_user.ToList();
            //GenderComboBox.ItemsSource = db.pn_tbl_user.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pn_tbl_user user =  (pn_tbl_user) EditUserWrapPanel.DataContext;

            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Изменения сохранены");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
