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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet9.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this._44П_2022_УП_ШиршоваDataSet9.Users);

        }
    }
}
