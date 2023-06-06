using System.Security.Cryptography;

namespace Alarm_WinForm
{
    public partial class Form1 : Form
    {
        private DateTime hedef;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            lblKalanSure.ForeColor = Color.LawnGreen;
            int dakika = (int)nudDakika.Value;
            int saniye = (int)nudSaniye.Value;
            hedef = DateTime.Now.AddMinutes(dakika).AddSeconds(saniye);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan kalan = hedef - DateTime.Now;
            lblKalanSure.Text = kalan.ToString(@"hh\:mm\:ss");

            if ((int)kalan.TotalSeconds == 0)
            {
                timer1.Stop();
                lblKalanSure.ForeColor = Color.Red;
                MessageBox.Show("Alarm Caliyor...");
            }
        }
    }
}