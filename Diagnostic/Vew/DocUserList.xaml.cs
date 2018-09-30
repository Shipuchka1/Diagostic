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
using  System.IO;
using System.Windows.Markup;

namespace Diagnostic.Vew
{
    /// <summary>
    /// Interaction logic for DocUserList.xaml
    /// </summary>
    public partial class DocUserList : Page
    {
        Model1 db = new Model1();
        public DocUserList()
        {
            InitializeComponent();
            UserListView.ItemsSource = db.pn_tbl_user.ToList();
            //TextRange tr = new TextRange(UserDoc);
            

        }

        private void UserListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pn_tbl_user user = ((ListView) sender).SelectedItem as pn_tbl_user;

            TextRange documentTextRange = new TextRange(
                    UserDoc.Document.ContentStart,
                    UserDoc.Document.ContentEnd);
            using (FileStream fs = File.Open("file.rtf", FileMode.OpenOrCreate))
            {

                documentTextRange.Load(fs, DataFormats.Rtf);
            }

            TextRange documentTextRange2 = new TextRange(
                       UserDoc.Document.ContentStart,
                       UserDoc.Document.ContentEnd);
            documentTextRange2.Text = documentTextRange2.Text.Replace("{UserName}", user.name);

        }
    }
}
