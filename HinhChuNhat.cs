using System.Runtime.CompilerServices;

namespace Csharp_TinhChuViDienTich_WinForm
{
    public partial class HinhChuNhat : Form
    {
        public HinhChuNhat()
        {
            InitializeComponent();
        }
        double a, b;
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tcv_Click(object sender, EventArgs e)
        {

            a = Convert.ToDouble(dai.Text);
            b = Convert.ToDouble(rong.Text);
            kqcv.Text = tinhchuvi(a, b).ToString();
        }

        private void Laythongtin()
        {
            try
            {
                a = Convert.ToDouble(dai.Text);
                b = Convert.ToDouble(rong.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số");
                return;
            }

        }
        private void tdt_Click(object sender, EventArgs e)
        {
            Laythongtin();
            kqdt.Text = tinhdientich(a, b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double tinhchuvi(double a, double b)
        {
            return (a + b) * 2;
        }

        private double tinhdientich(double a, double b)
        {
            return (a * b);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laythongtin();
            if (rbocv.Checked) kqcv.Text = tinhchuvi(a, b).ToString();
            if (rbodt.Checked) kqdt.Text = tinhdientich(a, b).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dai.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            rong.Text = numericUpDown2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            dai.Text = trackBar1.Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbtnew2_Click(object sender, EventArgs e)
        {
            Laythongtin();
                    if (chkdt.Checked)
                    kqdt.Text = "Diện tích: " + tinhdientich(a, b);
            
                if (chkcv.Checked)            
                kqcv.Text = "Chu vi: " + tinhchuvi(a, b);
                if (chkcv.Checked && chkdt.Checked)
            {
                kqcv.Text = "Chu vi: " + tinhchuvi(a,b) + Environment.NewLine;
                kqdt.Text += "Diện tích: " + tinhdientich(a, b);
            }
                         
        }
    }
}





