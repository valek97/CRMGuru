using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMGuru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void городаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.городаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMGuruDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRMGuruDataSet.Страны". При необходимости она может быть перемещена или удалена.
            this.страныTableAdapter.Fill(this.cRMGuruDataSet.Страны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRMGuruDataSet.Регионы". При необходимости она может быть перемещена или удалена.
            this.регионыTableAdapter.Fill(this.cRMGuruDataSet.Регионы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRMGuruDataSet.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.cRMGuruDataSet.Города);

        }
    }
}
