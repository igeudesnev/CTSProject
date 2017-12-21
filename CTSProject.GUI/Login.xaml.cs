using CTSProject.Data.Model;
using CTSProject.UI;
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
using System.Windows.Shapes;

namespace CTSProject.GUI
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UnitOfWork _unit;

        public Login()
        {
            InitializeComponent();
        }

        private void ProductWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (_unit = new UnitOfWork())
            {

            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_unit.Users.IsUserExists(LoginBox.Text))
                {
                    MessageBox.Show("This username is allready exists. /nPlease try another one.", "Wrong username");
                }
                Close();
                Owner.IsHitTestVisible = true;
            }
            catch { MessageBox.Show("Data doesn`t exist!");
                Owner.IsHitTestVisible = true; ;
            }
        }

    }
}
