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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(LoginExists(LoginBox.Text))
            {

            }
            //if (LoginBox.Text = УНИКАЛЬНОСТЬ ПОИСКОМ ПО БД)
            // ЗАПИСАТЬ ЛОГИН В БД
            Close();
            Owner.IsHitTestVisible = true;
        }

        private bool LoginExists(string text)
        {
            using(var context = new OnlineShopContext())
            {
                var query = from r in context.User
                            where r.Name == text
                            select r.Name;

                if(query == null)
                {

                }
            }
        }
    }
}
