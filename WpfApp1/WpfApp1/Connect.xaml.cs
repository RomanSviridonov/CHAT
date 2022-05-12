using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Connect.xaml
    /// </summary>
    public partial class Connect : Window
    {
        bool temp = true;
        public Connect()
        {    
            InitializeComponent();
        }
		
        MySqlConnection mysql_dbc;

        Registration reg = new Registration();
        string host = "sql4.freemysqlhosting.net"; // Имя хоста
        string user = "sql4478918"; // Имя пользователя
        string database = "sql4478918"; // Имя базы данных
        string password = "fYi7Kpf7uh"; // Пароль
        DateTime myDateTime;



        private void joinButton_Click(object sender, RoutedEventArgs e)
        {
            string con = "Database=" + database + ";Data Source=" + host + ";User=" + user + ";Password=" + password + ";convert zero datetime=True";
            myDateTime = DateTime.Now;


            mysql_dbc = new MySqlConnection(con);
            mysql_dbc.Open();
            string sql = "SELECT * FROM users WHERE name='" + LoginBox.Text + "' AND password='" + passwordBox.Password + "'";

            string sql_2 = "UPDATE users SET Activity = 'Online' WHERE name = '" + LoginBox.Text + "'";
            string sql_3 = "UPDATE users SET LastLogin = '" + myDateTime + "' WHERE name = '" + LoginBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mysql_dbc);
            MySqlCommand cmd_2 = new MySqlCommand(sql_2, mysql_dbc);
            MySqlCommand cmd_3 = new MySqlCommand(sql_3, mysql_dbc);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if(reader.Read())
                {
                    reader.Close();
                    cmd_2.ExecuteNonQuery();
                    cmd_3.ExecuteNonQuery();
                    MainWindow main = new MainWindow();
                    main.Owner = this;
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Такого логина или пароля не существует: \n\n1) Проверьте правильность ввода\n\n2) Обратитесь к администартору", "Ошибка авторизации");
                    reader.Close();
                }
            }
            finally
            {
                
                reader.Close();
            }        
            mysql_dbc.Close();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            reg.Show();
        }


        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            passwordTXTBox.Text = passwordBox.Password;
            passwordBox.Visibility = Visibility.Collapsed;
            passwordTXTBox.Visibility = Visibility.Visible;
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = passwordTXTBox.Text;
            passwordTXTBox.Visibility = Visibility.Collapsed;
            passwordBox.Visibility = Visibility.Visible;
        }

        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (temp)
            {
                LoginBox.Text = string.Empty;
                LoginBox.Foreground = new SolidColorBrush(Colors.Black);
                temp = false;
            }
        }

        private void LoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginBox.Text) && !temp)
            {
                LoginBox.Text = "Введите логин";
                LoginBox.Foreground = new SolidColorBrush(Colors.Gray);
                temp = true;
                
            }
        }


        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //string con = "Database=" + database + ";Data Source=" + host + ";User=" + user + ";Password=" + password;
            //mysql_dbc = new MySqlConnection(con);
            //mysql_dbc.Open();
            //string sql = "UPDATE users SET Activity = 'Offline' WHERE name = '" + LoginBox.Text + "'";
            //MySqlCommand cmd = new MySqlCommand(sql, mysql_dbc);
            //cmd.ExecuteNonQuery();
            //mysql_dbc.Close();
            Process.GetCurrentProcess().Kill();
        }
    }
}
