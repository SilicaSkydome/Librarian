using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Librarian.forms
{
    public partial class Orders : Form
    {
        //Подключение БД
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;

        int bookID;

        public Orders()
        {
            InitializeComponent();
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            orderName.Text = User.Name;
            orderLogin.Text = User.Login;

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["librarianDatabase"].ConnectionString);
            sqlConnection.Open();

            dataAdapter = new SqlDataAdapter(
                "SELECT TOP 1000 Id, Name, Author, Publisher, Type, Genre, Year FROM Book",
                sqlConnection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            orderView.DataSource = dataSet.Tables[0];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (orderSearch.Text == "")
            {
                dataAdapter = new SqlDataAdapter(
                "SELECT TOP 1000 Id, Name, Author, Publisher, Type, Genre, Year FROM Book",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                orderView.DataSource = dataSet.Tables[0];
            }
            else if (searchAuthor.Checked && orderSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Author LIKE N'%{orderSearch.Text}%'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                orderView.DataSource = dataSet.Tables[0];
            }
            else if (searchName.Checked && orderSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Name LIKE N'%{orderSearch.Text}%'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                orderView.DataSource = dataSet.Tables[0];
            }
            else if (searchGenre.Checked && orderSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Genre LIKE N'%{orderSearch.Text}%'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                orderView.DataSource = dataSet.Tables[0];
            }
            else if (searchYear.Checked && orderSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Year = {orderSearch.Text}",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                orderView.DataSource = dataSet.Tables[0];
            }
        }

        private void orderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID = Convert.ToInt32(orderView.Rows[e.RowIndex].Cells[0].Value);
        }

        private void orderCreate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO Orders values ({bookID}, {User.ID}, GETDATE());", 
                sqlConnection);

            command.ExecuteNonQuery();
        }


    }
}
