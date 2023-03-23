using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Demo
{
    public partial class frmTim : Form
    {
		public List<GiaoVien> dsGV = new List<GiaoVien>();
		public frmTim()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
			List<GiaoVien> gV = new List<GiaoVien>();
			if (this.rdMaGV.Checked)
				if (this.rdHoTen.Checked)
					gV = this.dsGV.FindAll(x => x.HoTen.Contains(this.txtTim.Text));
			gV = this.dsGV.FindAll(x => x.MaSo.Contains(this.txtTim.Text));
			if (this.rdSDT.Checked)
				gV = this.dsGV.FindAll(x => x.SoDT.Contains(this.txtTim.Text));
			if (gV != null)
			{
				string st = "";
				foreach (GiaoVien g in gV)
				{
					st += g.ToString() + "\n";

				}
				frmTBGiaoVien frmTB = new frmTBGiaoVien();
				frmTB.SetText(st);
				frmTB.ShowDialog();
			}
		}

        private void frmTim_Load(object sender, EventArgs e)
        {

        }
    }
}
