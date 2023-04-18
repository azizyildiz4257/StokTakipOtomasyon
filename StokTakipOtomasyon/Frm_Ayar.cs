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
    public partial class Frm_Ayar : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Ayar()
        {
            InitializeComponent();
        }

        private void Chck_YeniGiris_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Sunucu.Enabled = !Txt_Sunucu.Enabled;   //Bu işaret seçili olanın tersini alır.
            Txt_Database.Enabled = !Txt_Database.Enabled;   //Bu işaret seçili olanın tersini alır.
            Txt_UserID.Enabled = !Txt_UserID.Enabled;   //Bu işaret seçili olanın tersini alır.
            Txt_Password.Enabled = !Txt_Password.Enabled;   //Bu işaret seçili olanın tersini alır.
            Btn_AyarlarıKaydet.Enabled = !Btn_AyarlarıKaydet.Enabled;   //Bu işaret seçili olanın tersini alır.
        }

        private void Btn_AyarlarıKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Cs_Sunucu = Txt_Sunucu.Text.Trim() + ";";
            Properties.Settings.Default.Cs_Database = Txt_Database.Text.Trim() + ";";
            Properties.Settings.Default.Cs_UserID = Txt_UserID.Text.Trim() + ";";
            Properties.Settings.Default.Cs_Password = Txt_Password.Text.Trim() + ";";
            Properties.Settings.Default.Database = Txt_Database.Text.Trim();    //Sadece database'in ismini istiyorum.
            Properties.Settings.Default.Save();
            //Application.Restart();    Debug modda deneyeceğimiz için şimdilik devre dışı bırakıyoruz.  Ders 13 20:40
            this.Close();
        }

        private void Frm_Ayar_Load(object sender, EventArgs e)
        {
            labelControl1.Text = Properties.Settings.Default.Cs_1 + Properties.Settings.Default.Cs_Sunucu +                                     Properties.Settings.Default.Cs_2 + Properties.Settings.Default.Cs_Database +                                   Properties.Settings.Default.Cs_3 + Properties.Settings.Default.Cs_UserID +                                     Properties.Settings.Default.Cs_4 + Properties.Settings.Default.Cs_Password;
        }
    }
}