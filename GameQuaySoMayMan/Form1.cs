using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameQuaySoMayMan
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        int tienMay = 30000;
        int tienNguoi = 150;
        Random rd = new Random();
        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            int so1 = rd.Next(9);
            int so2 = rd.Next(10);
            int so3 = rd.Next(11);
            lbl1.Text = so1 + "";
            lbl2.Text = so2 + "";
            lbl3.Text = so3 + "";

            int rdQuay = rd.Next(20, 50);
            if(count > rdQuay)
            {
                if(so1 == 7 && so2 == 7 && so3 == 7)
                {
                    tienNguoi = 30150;
                    tienMay = 0;
                }
                if (so2 == 7 && so3 == 7)
                {
                    tienNguoi = tienNguoi + 3000;
                    tienMay = tienMay - 3000;
                }
                if (so3 == 7)
                {
                    tienNguoi = tienNguoi + 300;
                    tienMay = tienMay - 300;
                }
                lblTienMay.Text = tienMay + "";
                lblTienNguoiChoi.Text = tienNguoi + "";
                timer1.Stop();
            }
            count++;
        }
        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            
            if (tienNguoi < 30)
            {
                MessageBox.Show("Bạn lỗ sặc máu rồi, ko được chơi");
                return;
            }
            if (tienMay <= 0)
            {
                MessageBox.Show("Bạn đã chiến thắng, xin chúc mừng!");
                return;
            }
            tienNguoi = tienNguoi - 30;
            tienMay = tienMay + 30;
            count = 0;
            timer1.Start();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            tienMay = 3000;
            tienNguoi = 150;
            lblTienMay.Text = 3000+"";
            lblTienNguoiChoi.Text = 150+"";
        }

        private void lblTienMay_Click(object sender, EventArgs e)
        {

        }
    }
}
