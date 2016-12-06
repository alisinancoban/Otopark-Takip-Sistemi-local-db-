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
using System.Threading;

namespace Se_307_Car_Tracking_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otopark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand komut = new SqlCommand();
        public SqlDataAdapter adaptor = new SqlDataAdapter();
        public DataSet dataset = new DataSet();

        DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
        DateTime tarih = new DateTime();
        

        public void UyeEkle()
        {
            
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO musteribilgi(plaka,ad,telefon,arac,uyelikbas,uyelikbit) VALUES(@plaka,@ad,@telefon,@arac,@uyelikbas,@uyelikbit); ";
            komut.Parameters.Add("@plaka", textBox1.Text);
            komut.Parameters.Add("@ad", textBox2.Text);
            komut.Parameters.Add("@telefon", textBox3.Text);
            komut.Parameters.Add("@arac", textBox4.Text);
            komut.Parameters.Add("@uyelikbas", dateTimePicker1.Value.ToString("M/d/yyyy"));
            komut.Parameters.Add("@uyelikbit", dateTimePicker2.Value.ToString("M/d/yyyy"));
            komut.ExecuteNonQuery();

            komut.Parameters.Clear();
            komut.Dispose();
            baglanti.Close();
        }
        
        public void VeriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM musteribilgi ORDER BY uyelikbit", baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            tarih = DateTime.Now;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                
                int result = DateTime.Compare(Convert.ToDateTime(dataGridView1.Rows[i].Cells[6].Value), tarih);

                label5.Text = tarih.ToString();
                label6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();


                if (result == 0)
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if(result <= 0)
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UyeEkle();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VeriGoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeriGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE musteribilgi SET uyelikbit=@tarih WHERE plaka=@plaka"; 
            komut.Parameters.AddWithValue("@tarih", dateTimePicker3.Value.ToString("M/d/yyyy"));
            komut.Parameters.AddWithValue("@plaka", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            komut.Dispose();
        }
    }
}
