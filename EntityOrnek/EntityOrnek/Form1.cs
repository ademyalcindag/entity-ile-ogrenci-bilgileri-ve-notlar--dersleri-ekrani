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

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_enter(object sender, EventArgs e)
        {

        }


        private void btnderslistesi_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = db.TLBDERS.ToList();
        }

        private void btnogrencilistele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.TLBOGRENCİ.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnnotlistesi_Click(object sender, EventArgs e)
        {
            var quary = from item in db.TLBNOTLAR
                        select new
                        {
                            item.NotID,
                            item.Ogr,
                            item.Ders,
                            item.Sınav1,
                            item.Sınav2,
                            item.Sınav3,
                            item.Ortalama,
                            item.Durum
                        };
            dataGridView1.DataSource = quary.ToList();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TLBOGRENCİ t = new TLBOGRENCİ();

            t.Ad = txtAD.Text;
            t.Soyad = txtSOYAD.Text;
            db.TLBOGRENCİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("öğrenci listeye eklenmiştir.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrenciID.Text);
            var x = db.TLBOGRENCİ.Find(id);
            db.TLBOGRENCİ.Remove(x);
            db.SaveChanges();
            MessageBox.Show("ogrenci sistemden silinmiştir");


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrenciID.Text);
            var x = db.TLBOGRENCİ.Find(id);
            
            x.Ad = txtAD.Text;
            x.Soyad = txtSOYAD.Text;
            x.Fotograf = txtFOTO.Text;
            db.SaveChanges();
            MessageBox.Show("ogrenci bilgileri başarıyla güncellendi");
        }
    }
}
