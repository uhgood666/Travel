using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         // навигация по таблице маршруты
        private void маршрутыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.travelDataSet.Маршруты);

        }
        // кнопка возвращения на Form2
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }
        // кнопка поиска 
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            маршрутыBindingSource.Filter = "КодМрашрута=\'" + toolStripTextBox1.Text + "\'";
        }
        // кнопка сброса запроса
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            маршрутыBindingSource.Filter = null;
        }
    }
}
