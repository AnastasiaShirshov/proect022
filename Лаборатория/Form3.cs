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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Лаборатория
{
    public partial class Form3 : Form
    {
        int r = 0, s, p;
        private Form3 parent;
        public Form3()
            
        {
           
            InitializeComponent();
        }
        public void SendDataToGrid(params object[] data)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].SetValues(data);
            //Определяем индекс текущей строки, записываем в неё пришедшие значения 
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this._44П_2022_УП_ШиршоваDataSet.Services);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Code = textBox1.Text.ToString();
            string Service = textBox2.Text.ToString();
            string Price = textBox3.Text.ToString();

    

            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "INSERT INTO Services VALUES ('" + Code + "','" + Service + "', '" + Price + "')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string Code = textBox1.Text.ToString();
            //создаем соединение
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);

            // Выполняем запрос к базе данных

            dbConnection.Open();//открываем соединение

            string query = "DELETE FROM Services WHERE Code=" + Code;//строка запроса
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные удалены !", "Внимание");

            //Закрываем соединение с БД

            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           

            int index, n;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            string Code = dataGridView1[0, index].Value.ToString(); ;
            if (r == 0)
            {

                string Service = dataGridView1[1, index].Value.ToString();
                string Price = dataGridView1[2, index].Value.ToString();
                
                
                ;
                textBox1.Text = Code;
                textBox2.Text = Service;
                textBox3.Text = Price;
                
                r = 1;
            }
            else if (r == 1)
            {
                string SqlText = "update [Services] set Code = \'" + textBox1.Text + "\', Service = \'" + textBox2.Text + "\', Price = \'" + textBox3.Text + "\'  where Code = " + Code;
                MyExecuteNonQuery(SqlText);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                r = 0;
                MessageBox.Show("Данные отредактированы !", "Внимание");
            }
        }

        
        private void listUpdate()
        {
            throw new NotImplementedException();
        }

        private void FillServices()
        {
            throw new NotImplementedException();
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

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "SELECT * FROM [Services]";
            SqlDataAdapter da = new SqlDataAdapter(query, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Services]");
            dataGridView1.DataSource = ds.Tables["[Services]"].DefaultView;
            dbConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (dataGridView1[1, i].Value.ToString() != textBox4.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;

                }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
