using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityframework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        personelverileriEntities ent = new personelverileriEntities();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.pertablo.ToList();
        }
       

        private void button2_Click(object sender, EventArgs e) // ekle butonu
        {
            pertablo tbl = new pertablo();

            tbl.Perid = Convert.ToInt16(txtid.Text);
            tbl.PerAd = txtAD.Text;
            tbl.PerSoyad = txtSoyad.Text;
            tbl.PerSehir = txtSehir.Text;
            tbl.PerMaas = Convert.ToInt16(txtMaas.Text);
            ent.pertablo.Add(tbl);
            ent.SaveChanges();

            dataGridView1.DataSource = ent.pertablo.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(txtid.Text);

            pertablo tbl = ent.pertablo.First(f=> f.Perid == id);

            ent.pertablo.Remove(tbl);
            ent.SaveChanges();

            dataGridView1.DataSource = ent.pertablo.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtid.Text);

            pertablo tbl = ent.pertablo.First(f=> f.Perid == id);
            
            tbl.PerAd = txtAD.Text;
            tbl.PerSoyad = txtSoyad.Text;
            tbl.PerSehir = txtSehir.Text;
            tbl.PerMaas = Convert.ToInt16(txtMaas.Text);

            ent.SaveChanges();

            dataGridView1.DataSource = ent.pertablo.ToList();
        }
    }
}
