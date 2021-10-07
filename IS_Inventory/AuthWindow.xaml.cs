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

namespace IS_Inventory
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            SignOn_Button.Focus();
        }
        //Обработчик для Enter
        private void AuthWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                SignOn_Button_OnClick(this, e);
        }
        //Обработчик нажатия на кнопку Входа. Берет входные данные введенные пользователем, ищет в базе, пускает в программу.
        private void SignOn_Button_OnClick(object sender, RoutedEventArgs e)
        {
            string login = textBox_Login.Text.Trim();
            string password = textBox_Password.Password.Trim();
            User user = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                user = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
            }
            if (user != null)
                MessageBox.Show("Вы вошли как пользователь: " + user.Login);
            else
                MessageBox.Show("Не верное имя пользователя или пароль.");
        }
        
    }
}
