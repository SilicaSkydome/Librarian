using Librarian.forms;
using System;
using System.Windows;
using System.Windows.Input;

namespace Librarian
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Форма логина
        Login login;
        SignIn signin = new SignIn();

        //Форма профиля
        Profile profile = new Profile();
        
        //Форма каталога
        Catalog catalog = new Catalog();

        //Форма заказов
        Orders orders = new Orders();

        //Форма запросов
        MakeRequest request = new MakeRequest();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void onLoad(object sender, RoutedEventArgs e)
        {
            login = new Login(signin);
            login.ShowDialog();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);

            profile.Hide();
            catalog.Hide();
            orders.Hide();
            request.Hide();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            catalog.Hide();
            orders.Hide();
            request.Hide();

            profile.Show();
            profile.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            profile.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            profile.TopMost = true;


        }
        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            profile.Hide();
            orders.Hide();
            request.Hide();

            catalog.Show();
            catalog.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            catalog.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            catalog.TopMost = true;

        }

        private void Place_order_Click(object sender, RoutedEventArgs e)
        {
            catalog.Hide();
            profile.Hide();
            request.Hide();

            orders.Show();
            orders.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            orders.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            orders.TopMost = true;
        }
        private void Make_request_Click(object sender, RoutedEventArgs e)
        {
            catalog.Hide();
            profile.Hide();
            orders.Hide();

            request.Show();
            request.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            request.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            request.TopMost = true;
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            if (profile.Visible)
            {
                profile.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            }
            if (catalog.Visible)
            {
                catalog.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            }
            if (orders.Visible)
            {
                orders.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            }
            if (request.Visible)
            {
                request.Location = new System.Drawing.Point(Convert.ToInt32(Left) + 230, Convert.ToInt32(Top) + 215);
            }

        }

        
    }
}
