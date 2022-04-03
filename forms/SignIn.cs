using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Librarian.forms
{
    public partial class SignIn : Form
    {
        //Подключение БД
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;
        SqlCommand command;

        public SignIn()
        {
            InitializeComponent();
        }
        private void SignIn_Load(object sender, EventArgs e)
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
            this.Close();
        }
        private void openLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (signInLogin.Text != "" && signInPassword.Text != "" && signInRepeatPassword.Text != "" && signInPassword.Text == signInRepeatPassword.Text)
                {
                    dataAdapter = new SqlDataAdapter(
                    $"SELECT top 1 * FROM [User] where [Login] = N'{signInLogin.Text}'",
                    sqlConnection);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count == 0)
                    {
                        command = new SqlCommand(
                            $"INSERT INTO [User] values (N'Пользователь', N'{signInLogin.Text}', N'{signInPassword.Text}', N'user')",
                            sqlConnection);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Аккаунт успешно создан.", "Регистрация", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Данный логин уже существует.", "Регистрация", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка", $"{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
