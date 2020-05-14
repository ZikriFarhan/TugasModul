using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Renmor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long biaya_per_hari;
        short hari;
        String motor;
        DateTime tanggal_pinjam;
        DateTime tanggal_kembali;
        string hasilnya; 
        
        public static object SetValueForText1 { get; internal set; }
        public static object SetValueForNama { get; internal set; }
        public static string SetValueFornama;
        public static object SetValueFortxtharga { get; internal set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            motor = Convert.ToString(cbmotor.SelectedItem);
            
            
                string[] tipe = { "CBR1000rr", "RSV4", "R1", "er6-n", "ZX-25R" };

                Console.WriteLine("Display the array:");
            foreach (string i in tipe) 
                {
                    Console.WriteLine(i);
                }

                           
            if (motor == tipe [0])
            {
                txtharga.Text = Convert.ToString(6000000);
            }
            else if (motor == tipe[1])
            {
                txtharga.Text = Convert.ToString(7000000);
            }
            else if (motor == tipe[2])
            {
                txtharga.Text = Convert.ToString(7500000);
            }
            else if (motor == tipe[3])
            {
                txtharga.Text = Convert.ToString(4000000);
            }
            else if (motor == tipe[4])
            {
                txtharga.Text = Convert.ToString(3000000);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e ){
            if (Int64.TryParse(txtharga.Text, out biaya_per_hari ) && Int16.TryParse(txtdurasi.Text, out hari))
            {
                hasilnya = "Rp. " + Convert.ToString(biaya_per_hari * hari) + ",-";

            }

             MessageBox.Show("Nama  ="  + nama.Text + "\n" + "Motor = " + motor + "\n" + "Harga Per Hari =" + txtharga.Text + "\n" + "Durasinya = " + txtdurasi.Text + " hari"+ "\n" + "Total Bayar = "  + hasilnya + "\n" );
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtdurasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void tmkembali_ValueChanged(object sender, EventArgs e)
        {
            tanggal_pinjam = tmpinjam.Value.Date ;
            tanggal_kembali = tmkembali.Value.Date ;

            if (tanggal_kembali < tanggal_pinjam)
            {
                MessageBox.Show("Tanggal yang anda masukan salah");
            }
            else
            {
                TimeSpan temp = tanggal_kembali - tanggal_pinjam;
                txtdurasi.Text = Convert.ToString(Math.Round(temp.TotalDays) );
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    
