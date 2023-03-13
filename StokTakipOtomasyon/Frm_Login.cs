using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm frm=new AnaForm();
            frm.ShowDialog();
        }

        private void Btn_Ayar_Click(object sender, EventArgs e)
        {
            Frm_Ayar frm=new Frm_Ayar();
            frm.ShowDialog();
        }
    }
}