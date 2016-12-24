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
  

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string plakaYeri = null;

        public SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otopark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand komut = new SqlCommand();
        public SqlDataAdapter adaptor = new SqlDataAdapter();
        public DataSet dataset = new DataSet();

        public void comboDoldur() //comboboxa bosyer tablosundaki bos alanlari alfabetik olarak siraliyor.
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from bosyer WHERE durum=@dur1";
            komut.Parameters.AddWithValue("@dur1", "bos"); //@dur1 in bos oldugunu bildiriyor
            SqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                //oku.read olducakca comboboxi dolduruyor.
                comboBox1.Items.Add(oku["bosalan"].ToString());
                komut.Parameters.Clear();//comboboxta en son secilen kaliyor
                //Hep ayni sorgunun yapilmamasi icin eklendi.

            }
            baglanti.Close();
            oku.Dispose();
            comboBox1.Sorted = true;
        }

        public void AlanDurumu() //Databaseye bakarak yer bos ise lime rengi dolu ise red rengine boyuyor.
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from bosyer";
            SqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                switch (oku["bosalan"].ToString())
                {
                    case "A1":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationA1.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationA1.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationA2.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationA2.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationA3.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationA3.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationA4.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationA4.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationA5.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationA5.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B1":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationB1.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationB1.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationB2.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationB2.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationB3.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationB3.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationB4.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationB4.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationB5.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationB5.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C1":
                        {

                            if (oku["durum"].ToString() == "bos")
                            {
                                locationC1.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationC1.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationC2.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationC2.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationC3.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationC3.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationC4.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationC4.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationC5.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationC5.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D1":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationD1.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationD1.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationD2.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationD2.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationD3.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationD3.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationD4.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationD4.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                locationD5.BackColor = Color.Lime;
                            }
                            else
                            {
                                locationD5.BackColor = Color.Red;
                            }

                            break;
                        }
                }

            }
            baglanti.Close();
            oku.Dispose();
        }

        public int BosDoluAlanSayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from doluyer", baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            return kayitSayisi;

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboDoldur();
            AlanDurumu();
            doluAlanSayisi.Text = BosDoluAlanSayisi().ToString();
            bosAlanSayisi.Text = (20 - BosDoluAlanSayisi()).ToString();
            
            



        }
    }
}
