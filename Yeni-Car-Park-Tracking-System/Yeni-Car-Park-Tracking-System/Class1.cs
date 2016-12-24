using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yeni_Car_Park_Tracking_System
{
    public class Car
    {
        private string plaka { get; set; }
        private DateTime girisSaati { get; set; }
        private DateTime cikisSaati { get; set; }
        private DateTime durduguSure { get; set; }

        public Car(string PLAKA, DateTime GIRISSAATI, DateTime CIKISSAATI, DateTime DURDUGUSURE)
        {
            this.plaka = PLAKA;
            this.girisSaati = GIRISSAATI;
            this.cikisSaati = CIKISSAATI;
            this.durduguSure = DURDUGUSURE;
        }
    }

    public class Uye
    {
        private int uyeNo { get; set; }
        private string aracPlaka { get; set; }
        private DateTime uyelikBaslangicTrh { get; set; }
        private DateTime uyelikBitisTrh { get; set; }

        public Uye(int UYENO, string ARACPLAKA, DateTime UYELIKBSLNG, DateTime UYELIKBTS)
        {
            uyeNo = UYENO;
            aracPlaka = ARACPLAKA;
            uyelikBaslangicTrh = UYELIKBSLNG;
            uyelikBitisTrh = UYELIKBTS;
        }
    }

    /*public class DataBaseConnection
    {
        public SqlDataAdapter adapter { get; set; }
        private string strCon;
        public string STRCON
        {
            set { strCon = value; }
        }

        private string komut;
        public string KOMUT
        {
            set { komut = value; }
        }



        public DataSet GetConnection
        {
            get { return MyDataSet(); }
        }

        private DataSet MyDataSet()
        {
            SqlConnection baglanti = new SqlConnection(strCon);
            baglanti.Open();
            adapter = new SqlDataAdapter(komut, baglanti);

            DataSet da_Set = new DataSet();
            adapter.Fill(da_Set, "Table_Data_1");
            baglanti.Close();

            return da_Set;
        }
        
    }*/
}
