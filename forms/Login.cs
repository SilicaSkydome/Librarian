using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Librarian.forms
{
    public partial class Login : Form
    {
        //Подключение БД
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;

        SignIn signin;

        public Login(SignIn signin)
        {
            InitializeComponent();
            this.signin = signin;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["librarianDatabase"].ConnectionString);
            sqlConnection.Open();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginLogin.Text != "" && loginPassword.Text != "")
            {
                if (dataSet != null) { dataSet.Clear(); }
                dataAdapter = new SqlDataAdapter(
                $"SELECT top 1 * FROM [User] where [Login] = N'{loginLogin.Text}' and [Password] = N'{loginPassword.Text}'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet != null)
                {
                    try
                    {
                        User.ID = Convert.ToInt32(dataSet.Tables[0].Rows[0].Field<object>(0));
                        User.Name = Convert.ToString(dataSet.Tables[0].Rows[0].Field<object>(1));
                        User.Login = Convert.ToString(dataSet.Tables[0].Rows[0].Field<object>(2));
                        User.Password = Convert.ToString(dataSet.Tables[0].Rows[0].Field<object>(3));
                        User.Status = Convert.ToString(dataSet.Tables[0].Rows[0].Field<object>(4));

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль", $"{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void openSignIn_Click(object sender, EventArgs e)
        {
            signin.ShowDialog();
        }
    }
}
