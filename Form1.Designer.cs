namespace Restoran
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnKabinet1;
        private System.Windows.Forms.Button btnKabinet2;
        private System.Windows.Forms.Button btnKabinet3;
        private System.Windows.Forms.Button btnKabinet4;

        private System.Windows.Forms.Label lblTimer1;
        private System.Windows.Forms.Label lblTimer2;
        private System.Windows.Forms.Label lblTimer3;
        private System.Windows.Forms.Label lblTimer4;

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblMuddet;
        private System.Windows.Forms.Label lblMelumat;

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtMuddet;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.btnKabinet1 = new System.Windows.Forms.Button();
            this.btnKabinet2 = new System.Windows.Forms.Button();
            this.btnKabinet3 = new System.Windows.Forms.Button();
            this.btnKabinet4 = new System.Windows.Forms.Button();

            this.lblTimer1 = new System.Windows.Forms.Label();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.lblTimer3 = new System.Windows.Forms.Label();
            this.lblTimer4 = new System.Windows.Forms.Label();

            this.lblBasliq = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblMuddet = new System.Windows.Forms.Label();
            this.lblMelumat = new System.Windows.Forms.Label();

            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMuddet = new System.Windows.Forms.TextBox();

            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // =====================================================
            // FORM
            // =====================================================

            this.ClientSize = new System.Drawing.Size(850, 620);

            this.Text = "Restoran - Kabinet Rezervasiyası";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            // =====================================================
            // BAŞLIQ
            // =====================================================

            this.lblBasliq.AutoSize = true;

            this.lblBasliq.Font =
                new System.Drawing.Font(
                    "Arial",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.lblBasliq.ForeColor =
                System.Drawing.Color.DarkBlue;

            this.lblBasliq.Location =
                new System.Drawing.Point(250, 20);

            this.lblBasliq.Text =
                "RESTORAN KABİNETLƏRİ";

            // =====================================================
            // TIMER 1 LABEL
            // =====================================================

            this.lblTimer1.AutoSize = true;

            this.lblTimer1.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblTimer1.ForeColor =
                System.Drawing.Color.Red;

            this.lblTimer1.Location =
                new System.Drawing.Point(190, 78);

            this.lblTimer1.Text =
                "00:00:00";

            // =====================================================
            // TIMER 2 LABEL
            // =====================================================

            this.lblTimer2.AutoSize = true;

            this.lblTimer2.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblTimer2.ForeColor =
                System.Drawing.Color.Red;

            this.lblTimer2.Location =
                new System.Drawing.Point(550, 78);

            this.lblTimer2.Text =
                "00:00:00";

            // =====================================================
            // TIMER 3 LABEL
            // =====================================================

            this.lblTimer3.AutoSize = true;

            this.lblTimer3.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblTimer3.ForeColor =
                System.Drawing.Color.Red;

            this.lblTimer3.Location =
                new System.Drawing.Point(190, 228);

            this.lblTimer3.Text =
                "00:00:00";

            // =====================================================
            // TIMER 4 LABEL
            // =====================================================

            this.lblTimer4.AutoSize = true;

            this.lblTimer4.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblTimer4.ForeColor =
                System.Drawing.Color.Red;

            this.lblTimer4.Location =
                new System.Drawing.Point(550, 228);

            this.lblTimer4.Text =
                "00:00:00";

            // =====================================================
            // KABİNET 1
            // =====================================================

            this.btnKabinet1.BackColor =
                System.Drawing.Color.LightGreen;

            this.btnKabinet1.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnKabinet1.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.btnKabinet1.Location =
                new System.Drawing.Point(100, 100);

            this.btnKabinet1.Size =
                new System.Drawing.Size(280, 120);

            this.btnKabinet1.Text =
                "Kabinet 1";

            this.btnKabinet1.UseVisualStyleBackColor = false;

            this.btnKabinet1.Tag = 0;

            // =====================================================
            // KABİNET 2
            // =====================================================

            this.btnKabinet2.BackColor =
                System.Drawing.Color.LightGreen;

            this.btnKabinet2.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnKabinet2.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.btnKabinet2.Location =
                new System.Drawing.Point(460, 100);

            this.btnKabinet2.Size =
                new System.Drawing.Size(280, 120);

            this.btnKabinet2.Text =
                "Kabinet 2";

            this.btnKabinet2.UseVisualStyleBackColor = false;

            this.btnKabinet2.Tag = 1;

            // =====================================================
            // KABİNET 3
            // =====================================================

            this.btnKabinet3.BackColor =
                System.Drawing.Color.LightGreen;

            this.btnKabinet3.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnKabinet3.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.btnKabinet3.Location =
                new System.Drawing.Point(100, 250);

            this.btnKabinet3.Size =
                new System.Drawing.Size(280, 120);

            this.btnKabinet3.Text =
                "Kabinet 3";

            this.btnKabinet3.UseVisualStyleBackColor = false;

            this.btnKabinet3.Tag = 2;

            // =====================================================
            // KABİNET 4
            // =====================================================

            this.btnKabinet4.BackColor =
                System.Drawing.Color.LightGreen;

            this.btnKabinet4.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnKabinet4.Font =
                new System.Drawing.Font(
                    "Arial",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.btnKabinet4.Location =
                new System.Drawing.Point(460, 250);

            this.btnKabinet4.Size =
                new System.Drawing.Size(280, 120);

            this.btnKabinet4.Text =
                "Kabinet 4";

            this.btnKabinet4.UseVisualStyleBackColor = false;

            this.btnKabinet4.Tag = 3;

            // =====================================================
            // AD SOYAD LABEL
            // =====================================================

            this.lblAdSoyad.AutoSize = true;

            this.lblAdSoyad.Font =
                new System.Drawing.Font(
                    "Arial",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblAdSoyad.Location =
                new System.Drawing.Point(100, 405);

            this.lblAdSoyad.Text =
                "Ad Soyad:";

            // =====================================================
            // AD SOYAD TEXTBOX
            // =====================================================

            this.txtAdSoyad.Font =
                new System.Drawing.Font(
                    "Arial",
                    11F);

            this.txtAdSoyad.Location =
                new System.Drawing.Point(200, 400);

            this.txtAdSoyad.Size =
                new System.Drawing.Size(280, 29);

            this.txtAdSoyad.Name =
                "txtAdSoyad";

            // =====================================================
            // MÜDDƏT LABEL
            // =====================================================

            this.lblMuddet.AutoSize = true;

            this.lblMuddet.Font =
                new System.Drawing.Font(
                    "Arial",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblMuddet.Location =
                new System.Drawing.Point(100, 450);

            this.lblMuddet.Text =
                "Müddət (dəq):";

            // =====================================================
            // MÜDDƏT TEXTBOX
            // =====================================================

            this.txtMuddet.Font =
                new System.Drawing.Font(
                    "Arial",
                    11F);

            this.txtMuddet.Location =
                new System.Drawing.Point(200, 445);

            this.txtMuddet.Size =
                new System.Drawing.Size(280, 29);

            this.txtMuddet.Name =
                "txtMuddet";

            // =====================================================
            // MƏLUMAT
            // =====================================================

            this.lblMelumat.AutoSize = true;

            this.lblMelumat.Font =
                new System.Drawing.Font(
                    "Arial",
                    10F,
                    System.Drawing.FontStyle.Italic);

            this.lblMelumat.ForeColor =
                System.Drawing.Color.Gray;

            this.lblMelumat.Location =
                new System.Drawing.Point(100, 495);

            this.lblMelumat.Text =
                "Kabinet seç → Ad Soyad → Müddət → Enter";

            // =====================================================
            // TIMERLƏR
            // =====================================================

            this.timer1.Interval = 1000;
            this.timer2.Interval = 1000;
            this.timer3.Interval = 1000;
            this.timer4.Interval = 1000;

            // =====================================================
            // CONTROLS
            // =====================================================

            this.Controls.Add(this.lblBasliq);

            this.Controls.Add(this.lblTimer1);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer3);
            this.Controls.Add(this.lblTimer4);

            this.Controls.Add(this.btnKabinet1);
            this.Controls.Add(this.btnKabinet2);
            this.Controls.Add(this.btnKabinet3);
            this.Controls.Add(this.btnKabinet4);

            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAdSoyad);

            this.Controls.Add(this.lblMuddet);
            this.Controls.Add(this.txtMuddet);

            this.Controls.Add(this.lblMelumat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
