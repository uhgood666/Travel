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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // навигация по таблице поездки
        private void поездкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поездкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelDataSet.Поездки". При необходимости она может быть перемещена или удалена.
            this.поездкиTableAdapter.Fill(this.travelDataSet.Поездки);

        }
        // кнопка возвращения на Form1
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }
        // кнопка перехода на Form3 маршруты
        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
            this.Hide();
        }
        // кнопка поиска 
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            поездкиBindingSource.Filter = "КодПоездки=\'" + toolStripTextBox1.Text + "\'";
        }
        // кнопка сброса запроса
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            поездкиBindingSource.Filter = null;
        }
    }
}
