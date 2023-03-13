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
    }
}