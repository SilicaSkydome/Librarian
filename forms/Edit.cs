using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Librarian.forms
{
    public partial class Edit : Form
    {
        int ID, ROW;
        //Подключение БД
        SqlConnection sqlConnection = null;
        DataSet dataSet = null;

        public Edit(int id, int row, DataSet dataSet)
        {
            InitializeComponent();
            ID = id;
            ROW = row;
            this.dataSet = dataSet;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["librarianDatabase"].ConnectionString);
            sqlConnection.Open();

            editName.Text = Convert.ToString(dataSet.Tables[0].Rows[ROW].Field<object>(1));
            editAuthor.Text = Convert.ToString(dataSet.Tables[0].Rows[ROW].Field<object>(2));
            editPublisher.Text = Convert.ToString(dataSet.Tables[0].Rows[ROW].Field<object>(3));
            editType.Text = Convert.ToString(dataSet.Tables[0].Rows[ROW].Field<object>(4));
            editGenre.Text = Convert.ToString(dataSet.Tables[0].Rows[ROW].Field<object>(5));
            editYear.Text = Convert.ToString(dataSet.Tables[0].Rows[ROW].Field<object>(6));
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
        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "UPDATE Book " +
                $"SET  Name = N'{editName.Text}', Author = N'{editAuthor.Text}', Publisher = N'{editPublisher.Text}', Type = N'{editType.Text}', Genre = N'{editGenre.Text}', Year = {Convert.ToInt32(editYear.Text)} " +
                $"WHERE Book.ID = {ID}",
                sqlConnection);

            command.ExecuteNonQuery();
        }
    }
}
