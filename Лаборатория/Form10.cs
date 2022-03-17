using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаборатория
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 newForm = new Form13();
            newForm.Show();
        }

       

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
