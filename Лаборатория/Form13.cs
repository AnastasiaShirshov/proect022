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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_2022_УП_ШиршоваDataSet12.Analyzator". При необходимости она может быть перемещена или удалена.
            this.analyzatorTableAdapter.Fill(this._44П_2022_УП_ШиршоваDataSet12.Analyzator);

        }
    }
}
