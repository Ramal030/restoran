using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Form1 : Form
    {
        private Button[] kabinetler;

        private string[] adSoyadlar;

        private DateTime[] bitmeVaxtlari;

        private int secilenKabinet = -1;

        public Form1()
        {
            InitializeComponent();

            kabinetler = new Button[]
            {
                btnKabinet1,
                btnKabinet2,
                btnKabinet3,
                btnKabinet4
            };

            adSoyadlar = new string[4];

            bitmeVaxtlari = new DateTime[4];

            // Kabinet düymələri
            for (int i = 0; i < 4; i++)
            {
                kabinetler[i].Tag = i;
                kabinetler[i].Click += Kabinet_Click;

                bitmeVaxtlari[i] = DateTime.MinValue;
            }

            // Enter
            txtAdSoyad.KeyDown += Enter_KeyDown;
            txtMuddet.KeyDown += Enter_KeyDown;

            // Timer
            timer1.Tick += Timer1_Tick;

            timer1.Start();
        }

        // KABİNET SEÇ
        private void Kabinet_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int index = (int)button.Tag;

            // Rezervdirsə
            if (bitmeVaxtlari[index] != DateTime.MinValue)
            {
                if (DateTime.Now < bitmeVaxtlari[index])
                {
                    MessageBox.Show(
                        "Bu kabinet artıq rezervdir!",
                        "Məlumat",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }

            // Əvvəlki seçimi qaytar
            for (int i = 0; i < 4; i++)
            {
                if (bitmeVaxtlari[i] == DateTime.MinValue)
                {
                    kabinetler[i].BackColor =
                        Color.LightGreen;
                }
            }

            // Yeni kabinet
            secilenKabinet = index;

            kabinetler[index].BackColor =
                Color.Yellow;
        }

        // ENTER
        private void Enter_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RezervEt();

                e.SuppressKeyPress = true;
            }
        }

        // REZERV ET
        private void RezervEt()
        {
            // Kabinet seçilməyib
            if (secilenKabinet == -1)
            {
                MessageBox.Show(
                    "Əvvəlcə kabinet seç!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Ad Soyad
            string adSoyad =
                txtAdSoyad.Text.Trim();

            if (adSoyad == "")
            {
                MessageBox.Show(
                    "Ad Soyad yaz!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAdSoyad.Focus();

                return;
            }

            // Müddət
            int muddet;

            if (!int.TryParse(
                txtMuddet.Text.Trim(),
                out muddet))
            {
                MessageBox.Show(
                    "Müddəti dəqiqə ilə yaz!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMuddet.Focus();

                return;
            }

            // Minimum 20 dəqiqə
            if (muddet < 20)
            {
                MessageBox.Show(
                    "Minimum müddət 20 dəqiqədir!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMuddet.Focus();

                return;
            }

            // Bitmə vaxtı
            bitmeVaxtlari[secilenKabinet] =
                DateTime.Now.AddMinutes(muddet);

            // Ad
            adSoyadlar[secilenKabinet] =
                adSoyad;

            // Qırmızı
            kabinetler[secilenKabinet].BackColor =
                Color.LightCoral;

            // Button məlumatı
            kabinetler[secilenKabinet].Text =
                "Kabinet " +
                (secilenKabinet + 1) +
                Environment.NewLine +
                Environment.NewLine +
                adSoyad +
                Environment.NewLine +
                "Qalan: " +
                muddet +
                " dəq";

            // Təmizlə
            txtAdSoyad.Clear();
            txtMuddet.Clear();

            // Seçimi sil
            secilenKabinet = -1;
        }

        // TIMER
        private void Timer1_Tick(
            object sender,
            EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                // Boş kabinet
                if (bitmeVaxtlari[i] ==
                    DateTime.MinValue)
                {
                    continue;
                }

                // Vaxt bitib
                if (DateTime.Now >=
                    bitmeVaxtlari[i])
                {
                    bitmeVaxtlari[i] =
                        DateTime.MinValue;

                    adSoyadlar[i] = "";

                    kabinetler[i].BackColor =
                        Color.LightGreen;

                    kabinetler[i].Text =
                        "Kabinet " + (i + 1);

                    continue;
                }

                // Qalan vaxt
                TimeSpan qalan =
                    bitmeVaxtlari[i] -
                    DateTime.Now;

                kabinetler[i].Text =
                    "Kabinet " +
                    (i + 1) +
                    Environment.NewLine +
                    Environment.NewLine +
                    adSoyadlar[i] +
                    Environment.NewLine +
                    "Qalan: " +
                    qalan.Hours.ToString("00") +
                    ":" +
                    qalan.Minutes.ToString("00") +
                    ":" +
                    qalan.Seconds.ToString("00");
            }
        }

        private void btnKabinet1_Click(object sender, EventArgs e)
        {

        }
    }
}
