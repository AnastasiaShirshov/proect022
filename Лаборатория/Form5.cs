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
    public partial class Form5 : Form
    {
        int r = 0, s, p;
        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet2.Analyzator". При необходимости она может быть перемещена или удалена.
            this.analyzatorTableAdapter.Fill(this._44П_2022_УП_ШиршоваDataSet2.Analyzator);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Analizator = textBox1.Text.ToString();
            string name = textBox2.Text.ToString();
            string Description = textBox3.Text.ToString();



            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "INSERT INTO Analyzator VALUES ('" + Analizator + "','" + name + "', '" + Description + "')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Analizator = textBox1.Text.ToString();
            //создаем соединение
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);

            // Выполняем запрос к базе данных

            dbConnection.Open();//открываем соединение

            string query = "DELETE FROM Analyzator WHERE Analyzator=" + Analizator;//строка запроса
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
            string query = "SELECT * FROM [Analyzator]";
            SqlDataAdapter da = new SqlDataAdapter(query, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Analyzator]");
            dataGridView1.DataSource = ds.Tables["[Analyzator]"].DefaultView;
            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            int index, n;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            string Analyzator = dataGridView1[0, index].Value.ToString(); ;
            if (r == 0)
            {

                string name = dataGridView1[1, index].Value.ToString();
                string Description = dataGridView1[2, index].Value.ToString();
                
                ;
                textBox1.Text = Analyzator;
                textBox2.Text = name;
                textBox3.Text = Description;
        
                r = 1;
            }
            else if (r == 1)
            {
                string SqlText = "update [Analyzator] set Analyzator = \'" + textBox1.Text + "\', name = \'" + textBox2.Text + "\', Description = \'" + textBox3.Text + "\' where Analyzator = " + Analyzator;
                MyExecuteNonQuery(SqlText);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
              
                r = 0;
                MessageBox.Show("Данные отредактированы!", "Внимание");
            }
        }
    }
}
