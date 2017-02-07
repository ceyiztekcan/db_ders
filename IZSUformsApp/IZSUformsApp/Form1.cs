using IZSUformsApp.DataLayer.DBCon;
using IZSUformsApp.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSUformsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tarih.Format = DateTimePickerFormat.Custom;
            Tarih.CustomFormat = "MM-yyyy";
            Tarih.ShowUpDown = true;

            btnKaydet.Enabled = false;
            GroupBoxFaturaBilgileri.Enabled = false;

            using (IzsuDBContext context = new IzsuDBContext())
            {
                var result = context.AboneTuru.ToList();

                foreach (var item in result)
                {
                    cBoxAboneTuru.Items.Add(item);
                }

                //int yeniAboneNo = context.Abone.OrderByDescending(a => a.AboneNo).FirstOrDefault().AboneNo++;

                Abone _abone = context.Abone.OrderByDescending(a => a.AboneNo).FirstOrDefault();
                int yeniAbeneNo = _abone.AboneNo;
                yeniAbeneNo++;

                txtAdoneNo.Text = yeniAbeneNo.ToString();
            }
        }

        private void txtAdoneNo_Leave(object sender, EventArgs e)
        {
            using (IzsuDBContext context = new IzsuDBContext())
            {
                int _aboneNo = int.Parse(txtAdoneNo.Text);

                var result = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo);

                if (result != null)
                {
                    txtAdoneNo.Enabled = false;
                    txtAdSoyad.Enabled = false;
                    cBoxAboneTuru.Enabled = false;
                    GroupBoxFaturaBilgileri.Enabled = true;

                    txtAdSoyad.Text = result.AboneAdSoyad;
                    cBoxAboneTuru.SelectedIndex = result.AboneTuruID - 1;

                    txtFaturaAboneNo.Text = result.AboneNo.ToString();
                    txtFaturaAdSoyad.Text = result.AboneAdSoyad;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı!");
                    btnKaydet.Enabled = true;
                    txtAdSoyad.Enabled = true;
                    cBoxAboneTuru.Enabled = true;
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Abone a = new Abone();
            a.AboneNo = int.Parse(txtAdoneNo.Text);
            a.AboneAdSoyad = txtAdSoyad.Text;

            AboneTuru at = (AboneTuru)cBoxAboneTuru.SelectedItem;
            a.AboneTuruID = at.AboneTuruID;
            at.AboneTuruAd = "hususi";

            using (IzsuDBContext context = new IzsuDBContext())
            {
                context.Abone.Add(a);
                context.SaveChanges();
            }

        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in GroupBoxAboneBilgileri.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }

            txtAdoneNo.Enabled = true;
        }
    }
}
