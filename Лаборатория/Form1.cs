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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dolgnost, name, parol, login;
            login = textBox1.Text;
            SqlCommand cmd;
            string ConnStr = @"Data Source=sql;Initial Catalog=44П-2022-УП-Ширшова;Integrated Security=True";
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();//открываем соединение
            cmd = cn.CreateCommand();
            cmd.CommandText = "select Dol from [cooperati] where" +
            " \'" + login + "\' = Login";
            dolgnost = (string)cmd.ExecuteScalar();
            cmd.CommandText = "select Name from [cooperati] where \'" + login + "\' = Login";
            name = (string)cmd.ExecuteScalar();
            cmd.CommandText = "select Password from [cooperati] where \'" + login + "\' = Login";
            parol = (string)cmd.ExecuteScalar();
            cn.Close();

            if ((dolgnost == null) || (parol != textBox2.Text))
                MessageBox.Show("Неправильно введён логин или пароль, повторите ввод.", "Внимание!");
            else
            {   Form10 f = new Form10();
                
                Form2 r = new Form2();
                
                if (dolgnost == "Lab       ")
                {
                    f.Show();
                    f.label4.Text = name;

                    if (name == "Lauretta K                                        ")
                    { f.pictureBox1.Image = Image.FromFile("X:/ШиршоваПРактика 2022/Лаборатория/laborant_2.png"); }
                    if (name == "Michael Ha                                        ")                                                                    
                    { f.pictureBox1.Image = Image.FromFile("X:/ШиршоваПРактика 2022/Лаборатория/laborant_1.jpg"); }

                } 
               
                else if (dolgnost == "Admin     ")
                {
                    r.label4.Text = name;
                    r.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
