using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Librarian.forms
{
    public partial class Catalog : Form
    {
        //Подключение БД
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;

        Add add = new Add();
        Edit edit = null;

        int id, row;

        public Catalog()
        {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            if (User.Status == "user")
            {
                buttonAdd.Visible = false;
                buttonEdit.Visible = false;
            }

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["librarianDatabase"].ConnectionString);
            sqlConnection.Open();

            dataAdapter = new SqlDataAdapter(
                "SELECT TOP 1000 Id, Name, Author, Publisher, Type, Genre, Year FROM Book",
                sqlConnection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            catalogView.DataSource = dataSet.Tables[0];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (catalogSearch.Text == "")
            {
                dataAdapter = new SqlDataAdapter(
                "SELECT TOP 1000 Id, Name, Author, Publisher, Type, Genre, Year FROM Book",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                catalogView.DataSource = dataSet.Tables[0];
            }
            else if (searchAuthor.Checked && catalogSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Author LIKE N'%{catalogSearch.Text}%'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                catalogView.DataSource = dataSet.Tables[0];
            }
            else if (searchName.Checked && catalogSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Name LIKE N'%{catalogSearch.Text}%'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                catalogView.DataSource = dataSet.Tables[0];
            }
            else if (searchGenre.Checked && catalogSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Genre LIKE N'%{catalogSearch.Text}%'",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                catalogView.DataSource = dataSet.Tables[0];
            }
            else if (searchYear.Checked && catalogSearch.Text != "")
            {
                dataAdapter = new SqlDataAdapter(
                $"SELECT TOP 50 Id, Name, Author, Publisher, Type, Genre, Year FROM Book where Year = {catalogSearch.Text}",
                sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                catalogView.DataSource = dataSet.Tables[0];
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            add.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            edit = new Edit(id, row, dataSet);
            edit.Show();
        }

        private void catalogView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = Convert.ToInt32(e.RowIndex);
            id = Convert.ToInt32(catalogView.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
