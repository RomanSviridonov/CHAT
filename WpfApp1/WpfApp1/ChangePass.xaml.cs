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
    public partial class ChangePass : Window
    {
        bool temp = true;
        string name;
        string pass;
        public ChangePass(string nick)
        {    
            InitializeComponent();
            name = nick;

        }
		
        MySqlConnection mysql_dbc;

        Registration reg = new Registration();
        string host = "sql4.freemysqlhosting.net"; // Имя хоста
        string user = "sql4478918"; // Имя пользователя
        string database = "sql4478918"; // Имя базы данных
        string password = "fYi7Kpf7uh"; // Пароль
        DateTime myDateTime;



        private void ChangePassButton_Click(object sender, RoutedEventArgs e)
        {
            string con = "Database=" + database + ";Data Source=" + host + ";User=" + user + ";Password=" + password + ";convert zero datetime=True";
            myDateTime = DateTime.Now;


            mysql_dbc = new MySqlConnection(con);
            mysql_dbc.Open();
            string sql = "SELECT password FROM users WHERE name='" + name + "'";
            string sql_2 = "UPDATE users SET password='"+ NewPass.Text + "' WHERE name='" + name + "'";

            MySqlCommand cmd = new MySqlCommand(sql, mysql_dbc);
            MySqlCommand cmd_2 = new MySqlCommand(sql_2, mysql_dbc);

            pass = cmd.ExecuteScalar().ToString();
            //MessageBox.Show(pass);
            if (OldPass.Text != pass) MessageBox.Show("Вы ввели неправильный пароль");
            else
            {
                if (NewPass.Text == RepeatNewPass.Text)
                {
                    cmd_2.ExecuteNonQuery();
                    MessageBox.Show("Пароль успешно изменён!", "Успешно!");
                    this.Close();
                }
            }


           
            mysql_dbc.Close();
        }

      

    }
}
