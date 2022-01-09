using ConsultingDemo.Business.Abstract;
using ConsultingDemo.Business.Concrete;
using ConsultingDemo.DataAccess.Concrete.EntityFramework;
using ConsultingDemo.Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ConsultingDemo.WebFormsUI
{
    
    public partial class Form1 : Form
    {

        STIManager sTIManager = new STIManager(new EfSTIDal());
        STKManager sTKManager = new STKManager(new EfSTKDal());

        public Form1()
        {  
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRapor_Click(object sender, EventArgs e)
        { 
            int baslangicTarihi =  Convert.ToInt32((dtp_baslangic.Value).ToOADate());
            int bitisTarihi =  Convert.ToInt32((dtp_bitis.Value).ToOADate());
            string malKabul = txtMalKabul.Text;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;persist security info=True;user id=sqluser;password=123;MultipleActiveResultSets=True;");
            SqlCommand cmd = new SqlCommand("sp_GetRapor ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Malkodu", malKabul);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
            cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            dr.Fill(dt);

            Decimal stok = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item["IslemTur"].ToString() == "ÇIKIŞ")
                    stok += Convert.ToDecimal(item["CikisMiktar"]);
                else
                    stok -= Convert.ToDecimal(item["GirisMiktar"]);
                item["StokMiktar"] = stok;
            }
             
            gridControl1.DataSource = dt;
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                xtraSaveFileDialog1.ShowDialog();
                string FileName = xtraSaveFileDialog1.FileName + ".xlsx";
                gridControl1.ExportToXlsx(FileName);
            }
            else 
            {
                MessageBox.Show("Veri Çekmeden Excele Aktarım Yapamazsınız.");
            }
            
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                gridControl1.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Veri Çekmeden Yazıcıya Aktarım Yapamazsınız.");
            }
            
        }
    }
}
