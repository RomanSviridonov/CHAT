using System;
using System.Timers;
using System.IO;
using System.Net;
using System.Diagnostics;
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
using MySql.Data.MySqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MySqlConnection mysql_dbc;
        bool temp = true;
        int chislo;
        public MainWindow()
        {

            InitializeComponent();
            update();

        }
        bool updater = true;
        private async void update()
        {
            while (updater == true)
            {
                chatBox.Clear();
                LoadTextDocument();
                await Task.Delay(1000);
            }

        }


        private void Form1_Load(object sender)
        {
            
            LoadTextDocument();
            
        }


        
        WebClient wc = new WebClient();
        string nick;
        string sql1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Connect frm = (Connect)this.Owner;
            nick = frm.LoginBox.Text;
            mysql_dbc = new MySqlConnection(con);
            mysql_dbc.Open();
            sql1 = "INSERT INTO group_chat(`login`, `message`) VALUES ('" + nick + "', '" + DateTime.Now + " | " + nick + ": " + message.Text + "')";
            MySqlCommand sql1_cmd = new MySqlCommand(sql1, mysql_dbc);
            sql1_cmd.ExecuteNonQuery();

            message.Clear();
            chatBox.ScrollToEnd();
            mysql_dbc.Close();
        }
        string con = "Database=sql4478918;Data Source=sql4.freemysqlhosting.net;User=sql4478918;Password=fYi7Kpf7uh;convert zero datetime=True;Charset=UTF8";

        private void LoadTextDocument()
        {

            mysql_dbc = new MySqlConnection(con);
            mysql_dbc.Open();
            string sql = "SELECT message FROM group_chat";
            MySqlCommand cmd = new MySqlCommand(sql, mysql_dbc);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chatBox.Text += reader["message"].ToString() + "\n";
            }
            mysql_dbc.Close();


        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
            
        }

        private void Form1_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            updater = false;
            mysql_dbc = new MySqlConnection(con);
            mysql_dbc.Open();
            string sql = "UPDATE users SET Activity = 'Offline' WHERE name = '" + nick + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mysql_dbc);
            cmd.ExecuteNonQuery();
            mysql_dbc.Close();
        }

        private void Form1_Loaded(object sender, RoutedEventArgs e)
        {
            Connect frm = (Connect)this.Owner;
            //LoginLabel.Content = frm.LoginBox.Text;
            chatBox.ScrollToEnd();
            if (frm.LoginBox.Text == "admin") DeleteButton.Visibility = Visibility.Visible;
        }

        private void message_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(message.Text) && !temp)
            {
                message.Text = "Введите текст";
                message.Foreground = new SolidColorBrush(Colors.Gray);
                temp = true;

            }
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (temp)
            {
                message.Text = string.Empty;
                message.Foreground = new SolidColorBrush(Colors.Black);
                temp = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            updater = false;
            Connect frm = (Connect)this.Owner;
            nick = frm.LoginBox.Text;
            Personal pers = new Personal(nick);
            pers.Owner = this.Owner;
            this.Close();
            pers.Show();
        }
        string sql;
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            mysql_dbc = new MySqlConnection(con);
            mysql_dbc.Open();
            sql = "DELETE FROM group_chat ORDER BY id DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(sql, mysql_dbc);
            cmd.ExecuteNonQuery();
            mysql_dbc.Close();
        }

        private void LKButton_Click(object sender, RoutedEventArgs e)
        {
            //updater = false;
            Connect frm = (Connect)this.Owner;
            nick = frm.LoginBox.Text;
            PersonalArea person = new PersonalArea(nick);
            person.Show();
            //this.Hide();
        }
    }
}
