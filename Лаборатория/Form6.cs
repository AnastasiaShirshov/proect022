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
    public partial class Form6 : Form
    {
        int r = 0, s, p;
        public Form6()
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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet7.cooperati". При необходимости она может быть перемещена или удалена.
            this.cooperatiTableAdapter1.Fill(this._44П_2022_УП_ШиршоваDataSet7.cooperati);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string idCOP = textBox1.Text.ToString();
            string Name = textBox2.Text.ToString();
            string Login = textBox3.Text.ToString();
            string Password = textBox6.Text.ToString();
            string Analyzator = textBox7.Text.ToString();
            string Dol = textBox8.Text.ToString();




            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "INSERT INTO cooperati VALUES ('" + idCOP + "','" + Name + "', '" + Login + "','" + Password + "','" + Analyzator + "','" + Dol + "')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int index, n;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            string idCOP = dataGridView1[0, index].Value.ToString(); ;
            if (r == 0)
            {

                string Name = dataGridView1[1, index].Value.ToString();
                string Login = dataGridView1[2, index].Value.ToString();
                string Password = dataGridView1[3, index].Value.ToString();
                string Analyzator = dataGridView1[4, index].Value.ToString();
                string Dol = dataGridView1[5, index].Value.ToString();
                ;
                textBox1.Text = idCOP;
                textBox2.Text = Name;
                textBox3.Text = Login;
                textBox6.Text = Password;
                textBox7.Text = Analyzator;
                textBox8.Text = Dol;
                r = 1;
            }
            else if (r == 1)
            {
                string SqlText = "update [cooperati] set idCOP = \'" + textBox1.Text + "\', Name = \'" + textBox2.Text + "\', Login = \'" + textBox3.Text + "\', Password = \'" + textBox6.Text + "\', Analyzator = " + textBox7.Text + ", Dol = " + textBox7.Text + " where idCOP = " + idCOP;
                MyExecuteNonQuery(SqlText);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";



                r = 0;
                MessageBox.Show("Данные отредактированы !", "Внимание");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "SELECT * FROM [cooperati]";
            SqlDataAdapter da = new SqlDataAdapter(query, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[cooperati]");
            dataGridView1.DataSource = ds.Tables["[cooperati]"].DefaultView;
            dbConnection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string idCOP = textBox1.Text.ToString();
            //создаем соединение
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);

            // Выполняем запрос к базе данных

            dbConnection.Open();//открываем соединение

            string query = "DELETE FROM cooperati WHERE idCOP=" + idCOP;//строка запроса
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные удалены !", "Внимание");

            //Закрываем соединение с БД

            dbConnection.Close();
        }
    }
}

  
