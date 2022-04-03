using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Librarian.forms
{
    public partial class MakeRequest : Form
    {
        //Подключение БД
        SqlConnection sqlConnection = null;

        public MakeRequest()
        {
            InitializeComponent();
        }
        private void MakeRequest_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["librarianDatabase"].ConnectionString);
            sqlConnection.Open();
        }

        private void requestMake_Click(object sender, EventArgs e)
        {
            try
            {
                if (requestName.Text != "" || requestAuthor.Text != "" || requestDescription.Text != "")
                {
                    SqlCommand command = new SqlCommand(
                    $"INSERT INTO Request values ({User.ID}, N'{Convert.ToString(requestName.Text)}', N'{Convert.ToString(requestAuthor.Text)}', N'{Convert.ToString(requestDescription.Text)}');",
                    sqlConnection);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Ваш запрос был добавлен в базу данных", "Готово", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Введите хоть что-то!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
