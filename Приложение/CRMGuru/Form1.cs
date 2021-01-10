using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;



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
            using (var client = new WebClient())
            {               
                int population = 0;
                double area = 0;
                try
                {
                    string json = Encoding.UTF8.GetString(client.DownloadData("https://restcountries.eu/rest/v2/name/" + $"{ textBox1.Text}"));
                    List<Country> nameCountry = JsonConvert.DeserializeObject<List<Country>>(json);

                    foreach (var item in nameCountry)
                    {
                        textBox2.Text = item.name;
                        textBox3.Text = item.numericCode;
                        textBox4.Text = item.capital;
                        textBox5.Text =  item.area.ToString("N2");
                        textBox6.Text = item.population.ToString("N2");
                        textBox7.Text = item.region;                        
                        population = item.population;
                        area = item.area;                        
                    }
                    DialogResult result = MessageBox.Show($"Название: {textBox2.Text}\nКод страны: {textBox3.Text}\nСтолица:{textBox4.Text}\nПлощадь: {textBox5.Text}\nНаселение: {textBox6.Text}\nРегион: {textBox7.Text}",
                     "Сообщение",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1
                    );
                    if (result == DialogResult.Yes)
                    {
                        string conStr = ConfigurationManager.ConnectionStrings["CRMGuru.Properties.Settings.CRMGuruConnectionString"].ConnectionString;
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        listBox1.Items.Clear();
                        SqlCommand cmd = new SqlCommand("select * from dbo.Регионы where Название='" + textBox7.Text.ToString() + "'", con);
                        SqlDataReader drRegions = cmd.ExecuteReader();
                        string[] Country = new string[2];

                        if (drRegions.Read() == true)
                        {
                            listBox1.Items.Add(drRegions[0].ToString() + " " + drRegions[1].ToString());
                            Country[0] = drRegions[0].ToString();
                            drRegions.Close();
                        }
                        else
                        {
                            регионыTableAdapter.Insert(textBox7.Text);

                            регионыTableAdapter.Update(cRMGuruDataSet);
                            регионыTableAdapter.Fill(this.cRMGuruDataSet.Регионы);
                            drRegions.Close();
                            SqlCommand cmd2 = new SqlCommand("select * from dbo.Регионы where Название='" + textBox7.Text.ToString() + "'", con);
                            SqlDataReader drRegions2 = cmd2.ExecuteReader();
                            if (drRegions2.Read() == true)
                            {
                                Country[0] = drRegions2[0].ToString();
                            }
                            drRegions2.Close();
                        }
                        cmd = new SqlCommand("select * from dbo.Города where Название='" + textBox4.Text.ToString() + "'", con);
                        SqlDataReader drCity = cmd.ExecuteReader();
                        if (drCity.Read() == true)
                        {
                            listBox1.Items.Add(drCity[0].ToString() + " " + drCity[1].ToString());
                            Country[1] = drCity[0].ToString();
                            drCity.Close();
                        }
                        else
                        {
                            drCity.Close();
                            городаTableAdapter.Insert(textBox4.Text);
                            городаTableAdapter.Update(cRMGuruDataSet);
                            городаTableAdapter.Fill(this.cRMGuruDataSet.Города);
                            SqlCommand cmd2 = new SqlCommand("select * from dbo.Города where Название='" + textBox4.Text.ToString() + "'", con);
                            SqlDataReader drCity2 = cmd2.ExecuteReader();
                            if (drCity2.Read() == true)
                                Country[1] = drCity2[0].ToString();
                            drCity2.Close();
                        }
                        cmd = new SqlCommand("select * from dbo.Страны where Код_страны='" + textBox3.Text.ToString() + "'", con);
                        SqlDataReader drCountry = cmd.ExecuteReader();
                        if (drCountry.Read() == true)
                        {
                            drCountry.Close();
                            cmd = new SqlCommand("UPDATE dbo.Страны SET Название =@Название, Код_страны=@Код_страны, Столица=@Столица, Площадь=@Площадь, Население=@Население, Регион=@Регион WHERE Код_страны =@Код_страны", con);
                            cmd.Parameters.AddWithValue("@Название", textBox2.Text);
                            cmd.Parameters.AddWithValue("@Код_страны", textBox3.Text);
                            cmd.Parameters.AddWithValue("@Площадь", area);
                            cmd.Parameters.AddWithValue("@Население", population);
                            cmd.Parameters.AddWithValue("@Регион", Country[0]);
                            cmd.Parameters.AddWithValue("@Столица", Country[1]);
                            cmd.ExecuteNonQuery();
                            страныTableAdapter.Update(cRMGuruDataSet);
                            страныTableAdapter.Fill(this.cRMGuruDataSet.Страны);
                            //  listBox1.Items.Add(drCountry[0].ToString() + " " + drCountry[1].ToString() + " " +drCountry[2].ToString());

                        }
                        else
                        {
                             страныTableAdapter.Insert(textBox2.Text, textBox3.Text, Convert.ToInt32(Country[1].ToString()), area, population,Convert.ToInt32( Country[0].ToString()));
                             страныTableAdapter.Update(cRMGuruDataSet);
                             страныTableAdapter.Fill(this.cRMGuruDataSet.Страны);
                            drCountry.Close();
                        }
                        con.Close();
                    }
                }
                catch (WebException wex)
                {
                    if (((HttpWebResponse)wex.Response).StatusCode == HttpStatusCode.NotFound)
                    {
                        DialogResult resultErrors = MessageBox.Show($"Введеная страна <{textBox1.Text}> не найдена ",
                         "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information,
                          MessageBoxDefaultButton.Button1);
                    }
                }
            }
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
