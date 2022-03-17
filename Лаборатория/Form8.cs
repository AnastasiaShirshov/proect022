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
    public partial class Form8 : Form
    {
        int r = 0, s, p;
        public Form8()
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
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet8.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter1.Fill(this._44П_2022_УП_ШиршоваDataSet8.Orders);
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
    SqlConnection dbConnection = new SqlConnection(ConnStr);
    dbConnection.Open();
    string query = "SELECT * FROM [Orders]";
    SqlDataAdapter da = new SqlDataAdapter(query, ConnStr);
    DataSet ds = new DataSet();
    da.Fill(ds, "[Orders]");
    dataGridView1.DataSource = ds.Tables["[Orders]"].DefaultView;
    dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
 string idORD = textBox1.Text.ToString();
    //создаем соединение
    string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
    SqlConnection dbConnection = new SqlConnection(ConnStr);

    // Выполняем запрос к базе данных

    dbConnection.Open();//открываем соединение

    string query = "DELETE FROM Orders WHERE idORD=" + idORD;//строка запроса
    SqlCommand dbCommand = new SqlCommand(query, dbConnection);//команда

    //Выполняем запрос
    if (dbCommand.ExecuteNonQuery() != 1)

        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

    else

        MessageBox.Show("Данные удалены !", "Внимание");

    //Закрываем соединение с БД

    dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    string idORD = textBox1.Text.ToString();
    string idUS = textBox2.Text.ToString();
    string idCOP = textBox3.Text.ToString();
    string Code = textBox6.Text.ToString();
    string data = textBox5.Text.ToString();
    string result = textBox4.Text.ToString();




    string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";

    SqlConnection dbConnection = new SqlConnection(ConnStr);
    dbConnection.Open();
    string query = "INSERT INTO Orders VALUES ('" + idORD + "','" + idUS + "', '" + idCOP + "','" + Code + "','" + data + "','" + result + "')";

    SqlCommand dbCommand = new SqlCommand(query, dbConnection);

    if (dbCommand.ExecuteNonQuery() != 1)

        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

    else

        MessageBox.Show("Данные добавлены!", "Внимание!");

    dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
                string IdORD = textBox1.Text.ToString();
                string IdUS = textBox2.Text.ToString();
                string IdCOP = textBox3.Text.ToString();
                string code = textBox6.Text.ToString();
                string Data = textBox5.Text.ToString();
                string Result = textBox4.Text.ToString();

                int index, n;
                n = dataGridView1.Rows.Count;
                if (n == 1) return;
                index = dataGridView1.CurrentRow.Index;
                string idORD = dataGridView1[0, index].Value.ToString(); ;
                if (r == 0)
                {

                    string idUS = dataGridView1[1, index].Value.ToString();
                    string idCOP = dataGridView1[2, index].Value.ToString();
                    string Code = dataGridView1[3, index].Value.ToString();
                    string data = dataGridView1[4, index].Value.ToString();
                    string result = dataGridView1[5, index].Value.ToString();
                    ;
                    textBox1.Text = idORD;
                    textBox2.Text = idUS;
                    textBox3.Text = idCOP;
                    textBox6.Text = Code;
                    textBox5.Text = data;
                    textBox4.Text = result;
                    r = 1;
                }
                else if (r == 1)
                {
                string SqlText = "update [Orders] set idORD = \'" + textBox1.Text + "\', idUS = " + textBox2.Text + ", idCOP = " + textBox3.Text + ", Code = " + textBox6.Text + ", data = \' " + textBox5.Text + "\', result = \'" + textBox4.Text +" \' where idORD = " + idORD;
                    MyExecuteNonQuery(SqlText);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox6.Text = "";
                    textBox5.Text = "";
                    textBox4.Text = "";

                    r = 0;
                MessageBox.Show("Данные отредактированы !", "Внимание");
            }
            }
        }
    }
   
