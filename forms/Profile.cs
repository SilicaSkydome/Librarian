using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Librarian.forms
{
    public partial class Profile : Form
    {
        //Подключение БД
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Change_MouseDown(object sender, MouseEventArgs e)
        {
            Profile_Change.BackColor = Color.FromArgb(224, 158, 58);
        }

        private void Profile_Change_MouseUp(object sender, MouseEventArgs e)
        {
            Profile_Change.BackColor = Color.FromArgb(152, 22, 22);
        }

        private void Profile_Change_MouseEnter(object sender, EventArgs e)
        {
            Profile_Change.BackColor = Color.FromArgb(152, 22, 22);
        }

        private void Profile_Change_MouseLeave(object sender, EventArgs e)
        {
            Profile_Change.BackColor = Color.FromArgb(224, 58, 58);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["librarianDatabase"].ConnectionString);
            sqlConnection.Open();

            textName.Text = User.Name;
            textLogin.Text = User.Login;
            textPassword.Text = User.Password;
            textStatus.Text = User.Status;

            dataAdapter = new SqlDataAdapter(
                $"select ID, (select [Name] from Book where ID = Orders.BookID) as 'Book Name', DateGiven from Orders where UserID = {User.ID};",
                sqlConnection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            profileHistory.DataSource = dataSet.Tables[0];
        }

        private void Profile_Change_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"UPDATE [User] SET Name = N'{textName.Text}', Login = N'{textLogin.Text}', Password = N'{textPassword.Text}', Status = N'{textStatus.Text}' where ID = {User.ID}", 
                sqlConnection);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Данные изменены.", "Профиль", MessageBoxButtons.OK);
        }
    }
}
