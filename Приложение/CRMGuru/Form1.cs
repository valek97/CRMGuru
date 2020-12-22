using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


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
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;

            }
            else
            {
                radioButton1.Checked = false;

            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRMGuruDataSet.Страны". При необходимости она может быть перемещена или удалена.
            this.страныTableAdapter.Fill(this.cRMGuruDataSet.Страны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRMGuruDataSet.Регионы". При необходимости она может быть перемещена или удалена.
            this.регионыTableAdapter.Fill(this.cRMGuruDataSet.Регионы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRMGuruDataSet.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.cRMGuruDataSet.Города);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            страныDataGridView.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            страныDataGridView.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string json = (new WebClient()).DownloadString("https://restcountries.eu/rest/v2/name/" + $"{ textBox1.Text}");

            using (var client = new WebClient())
            {
                try
                {
                    string json = client.DownloadString(("https://restcountries.eu/rest/v2/name/" + $"{ textBox1.Text}"));
                    List<Class1> nameCountry = JsonConvert.DeserializeObject<List<Class1>>(json);

                    foreach (var item in nameCountry)
                    {

                        textBox2.Text = item.name;
                        textBox3.Text = item.numericCode;
                        textBox4.Text = item.capital;
                        textBox5.Text =  item.area.ToString("N2");
                        textBox6.Text = item.population.ToString("N2");
                        textBox7.Text = item.region;
                    }
                    DialogResult result = MessageBox.Show($"Название: {textBox2.Text}\nКод страны: {textBox3.Text}\nСтолица:{textBox4.Text}\nПлощадь: {textBox5.Text}\nНаселение: {textBox6.Text}\nРегион: {textBox7.Text}",
       "Сообщение",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (WebException wex)
                {
                    if (((HttpWebResponse)wex.Response).StatusCode == HttpStatusCode.NotFound)
                    {
                        DialogResult resultErrors = MessageBox.Show($"Номер ошибки: {404}, ресурс не найден ",
        "Ошибка",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
            }



            // var temp = (MyArray)JsonConvert.DeserializeObject(json, typeof(MyArray));
            // string nameCountry = country.name;



            // dynamic stuff = JsonConvert.DeserializeObject("{ 'Name': 'Jon Smith', 'Address': { 'City': 'New York', 'State': 'NY' }, 'Age': 42 }");
            // string name = stuff.Name;
            // string address = stuff.Address.City;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
        }
    }
}
