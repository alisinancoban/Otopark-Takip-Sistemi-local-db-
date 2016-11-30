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

namespace Se_307_Car_Tracking_System
{
    public partial class Form1: Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otopark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand komut = new SqlCommand();
        public SqlDataAdapter adaptor = new SqlDataAdapter();
        public DataSet dataset = new DataSet();

        public void combo() //comboboxa bosyer tablosundaki bos alanlari alfabetik olarak siraliyor.
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
                            if (oku["durum"].ToString()=="bos")
                            {
                                button24.BackColor = Color.Lime;
                            }
                            else
                            {
                                button24.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button23.BackColor = Color.Lime;
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button22.BackColor = Color.Lime;
                            }
                            else
                            {
                                button22.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button21.BackColor = Color.Lime;
                            }
                            else
                            {
                                button21.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "A5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button5.BackColor = Color.Lime;
                            }
                            else
                            {
                                button5.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B1":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button6.BackColor = Color.Lime;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button4.BackColor = Color.Lime;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button8.BackColor = Color.Lime;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button9.BackColor = Color.Lime;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "B5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button10.BackColor = Color.Lime;
                            }
                            else
                            {
                                button10.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C1":
                        {

                            if (oku["durum"].ToString() == "bos")
                            {
                                button11.BackColor = Color.Lime;
                            }
                            else
                            {
                                button11.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button12.BackColor = Color.Lime;
                            }
                            else
                            {
                                button12.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button13.BackColor = Color.Lime;
                            }
                            else
                            {
                                button13.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button14.BackColor = Color.Lime;
                            }
                            else
                            {
                                button14.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "C5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button15.BackColor = Color.Lime;
                            }
                            else
                            {
                                button15.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D1":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button16.BackColor = Color.Lime;
                            }
                            else
                            {
                                button16.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D2":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button17.BackColor = Color.Lime;
                            }
                            else
                            {
                                button17.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D3":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button18.BackColor = Color.Lime;
                            }
                            else
                            {
                                button18.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D4":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button19.BackColor = Color.Lime;
                            }
                            else
                            {
                                button19.BackColor = Color.Red;
                            }

                            break;
                        }
                    case "D5":
                        {
                            if (oku["durum"].ToString() == "bos")
                            {
                                button20.BackColor = Color.Lime;
                            }
                            else
                            {
                                button20.BackColor = Color.Red;
                            }

                            break;
                        }
                }

            }
            baglanti.Close();
            oku.Dispose();
        }

        public void PlakaYaz() //Alanin ismini databaseye bakarak orda arac var ise plakasi ile degistiriyor.
        {


            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from doluyer";
            SqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                switch (oku["dolu"].ToString())
                {
                    case "A1":
                        {
                            button24.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "A2":
                        {
                            button23.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "A3":
                        {
                            button22.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "A4":
                        {
                            button21.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "A5":
                        {
                            button5.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "B1":
                        {
                            button6.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "B2":
                        {
                            button4.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "B3":
                        {
                            button8.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "B4":
                        {
                            button9.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "B5":
                        {
                            button10.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "C1":
                        {
                            button11.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "C2":
                        {
                            button12.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "C3":
                        {
                            button13.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "C4":
                        {
                            button14.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "C5":
                        {
                            button15.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "D1":
                        {
                            button16.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "D2":
                        {
                            button17.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "D3":
                        {
                            button18.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "D4":
                        {
                            button19.Text = oku["plaka"].ToString();
                            break;
                        }
                    case "D5":
                        {
                            button20.Text = oku["plaka"].ToString();
                            break;
                        }
                }

            }
            baglanti.Close();
            oku.Dispose();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Programdan cikisi sagliyor.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "") //textboxin ve comboboxin bos olup olmadigini kontrol ediyor.
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO doluyer(dolu,plaka) VALUES('" + comboBox1.Text + "','" + textBox1.Text + "') ";
                komut.ExecuteNonQuery(); //Combo box ve textboxtan gelen verileri doluyer tablosuna kaydediyor.
                
                komut.CommandText = "UPDATE bosyer SET durum=@dol WHERE bosalan=@bos"; //bosyer tablosundaki durumu dol olarak degistiyor.
                komut.Parameters.AddWithValue("@bos", comboBox1.Text);
                komut.Parameters.AddWithValue("@dol", "dol");
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                textBox1.Clear(); //textbox i temizliyoruz.
                comboBox1.Items.Clear(); //comboboxin itemlerini siliyor combo fonksiyonunda tekrar yazdircaz
                combo();
                AlanDurumu();
                PlakaYaz(); //Alan durumunu ve plakalari guncelliyoruz

                MessageBox.Show("Kayit Basari ile Eklendi");

            }

            else
            {
                MessageBox.Show("Bos alanlari doldurunuz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlanDurumu();
            PlakaYaz();
            combo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
