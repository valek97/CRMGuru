using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CRMGuru.CRMGuruDataSetTableAdapters;

namespace CRMGuru
{

    class DB : Form1
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["CRMGuru.Properties.Settings.CRMGuruConnectionString"].ConnectionString;
        SqlConnection connnectionDB = new SqlConnection(connectionString);
        string[] Country = new string[2];
        SqlCommand commandRead = null;
       
        public string  Regions(string Regions)
        {
            connnectionDB.Open();
            commandRead = new SqlCommand("select * from dbo.Регионы where Название='" + Regions + "'", connnectionDB);
            SqlDataReader dataReaderRegions = commandRead.ExecuteReader();
            if (dataReaderRegions.Read() == true)
            {
                Country[0] = dataReaderRegions[0].ToString();
                dataReaderRegions.Close();
            }
            else
            {
                регионыTableAdapter.Insert(Regions);
                dataReaderRegions.Close();
                SqlCommand commandAfterCreate = new SqlCommand("select * from dbo.Регионы where Название='" + Regions + "'", connnectionDB);
                SqlDataReader drRegions = commandAfterCreate.ExecuteReader();
                if (drRegions.Read() == true)
                {
                    Country[0] = drRegions[0].ToString();
                }
                drRegions.Close();
            }
            connnectionDB.Close();
            return Country[0];
        }

        public string City(string City)
        {
            connnectionDB.Open();
            commandRead = new SqlCommand("select * from dbo.Города where Название='" + City + "'", connnectionDB);
            SqlDataReader dataReaderCity = commandRead.ExecuteReader();
            
            if (dataReaderCity.Read() == true)
            {
                Country[1] = dataReaderCity[0].ToString();
                dataReaderCity.Close();
            }
            else
            {
                dataReaderCity.Close();
                городаTableAdapter.Insert(City);
                SqlCommand commandAfterCreate = new SqlCommand("select * from dbo.Города where Название='" + City + "'", connnectionDB);
                SqlDataReader dataReaderCity2 = commandAfterCreate.ExecuteReader();
                if (dataReaderCity2.Read() == true)
                    Country[1] = dataReaderCity2[0].ToString();
                dataReaderCity2.Close();
            }
            connnectionDB.Close();
            return Country[1];
        }
        public void  Countrys(string name, string idCountry, string idCity, double area, int population, string idRegoins)
        {
            connnectionDB.Open();
            commandRead = new SqlCommand("select * from dbo.Страны where Код_страны='" + idCountry + "'", connnectionDB);
            SqlDataReader drCountry = commandRead.ExecuteReader();
            
            if (drCountry.Read() == true)
            {
                drCountry.Close();
                updateCountry(name, idCountry, idCity, area, population, idRegoins);
            }
            else
            {
                createCountry(name, idCountry, idCity, area, population, idRegoins);
                drCountry.Close();
            }
            connnectionDB.Close();
            return;
        }
        public void createCountry(string name, string idCountry, string idCity, double area, int population, string idRegoins)
        {
            страныTableAdapter.Insert(name, idCountry, Convert.ToInt32(idCity.ToString()), area, population, Convert.ToInt32(idRegoins.ToString()));
            return;
        }

        public void updateCountry(string name, string idCountry, string idCity, double area, int population, string idRegoins)
        {
            commandRead = new SqlCommand("UPDATE dbo.Страны SET Название =@Название, Код_страны=@Код_страны, Столица=@Столица, Площадь=@Площадь, Население=@Население, Регион=@Регион WHERE Код_страны =@Код_страны", connnectionDB);
            commandRead.Parameters.AddWithValue("@Название", name);
            commandRead.Parameters.AddWithValue("@Код_страны", idCountry);
            commandRead.Parameters.AddWithValue("@Площадь", area);
            commandRead.Parameters.AddWithValue("@Население", population);
            commandRead.Parameters.AddWithValue("@Регион", idRegoins);
            commandRead.Parameters.AddWithValue("@Столица", idCity);
            commandRead.ExecuteNonQuery();
        }
    }
}
