using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаборатория
{
    public partial class Form4 : Form
    {
        int r = 0, s, p;
        public Form4()
        {
            InitializeComponent();
        }
        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn;
            SqlCommand cmd;
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlText;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet6.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter2.Fill(this._44П_2022_УП_ШиршоваDataSet6.Users);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idUS = textBox1.Text.ToString();
            string Name = textBox2.Text.ToString();
            string Login = textBox3.Text.ToString();
            string password = textBox6.Text.ToString();
            string ip = textBox4.Text.ToString();



            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "INSERT INTO Users VALUES ('" + idUS + "','" + Name + "', '" + Login + "','" + password + "','" + ip + "')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string idUS = textBox1.Text.ToString();
            //создаем соединение
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);

            // Выполняем запрос к базе данных

            dbConnection.Open();//открываем соединение

            string query = "DELETE FROM Users WHERE idUS=" + idUS;//строка запроса
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные удалены !", "Внимание");

            //Закрываем соединение с БД

            dbConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "SELECT * FROM [Users]";
            SqlDataAdapter da = new SqlDataAdapter(query, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Users]");
            dataGridView1.DataSource = ds.Tables["[Users]"].DefaultView;
            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            string IdUS = textBox1.Text.ToString();
            string name = textBox2.Text.ToString();
            string login = textBox3.Text.ToString();
            string Password = textBox6.Text.ToString();
            string Ip = textBox4.Text.ToString();

            int index, n;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            string idUS = dataGridView1[0, index].Value.ToString(); ;
            if (r == 0)
            {

                string Name = dataGridView1[1, index].Value.ToString();
                string Login = dataGridView1[2, index].Value.ToString();
                string password = dataGridView1[3, index].Value.ToString();
                string ip = dataGridView1[4, index].Value.ToString();
               ;
                textBox1.Text = idUS;
                textBox2.Text = Name;
                textBox3.Text = Login;
                textBox6.Text = password;
                textBox4.Text = ip;
                r = 1;
            }
            else if (r == 1)
            {
                string SqlText = "update [Users] set idUS = \'" + textBox1.Text + "\', Name = \'" + textBox2.Text + "\', Login = \'" + textBox3.Text + "\', password = \'" + textBox6.Text + "\', ip = " + textBox4.Text + " where idUS = " + idUS;
                MyExecuteNonQuery(SqlText);
                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox4.Text = "";
                
                r = 0;
                MessageBox.Show("Данные отредактированы !", "Внимание");
            }
        }
    }
}
