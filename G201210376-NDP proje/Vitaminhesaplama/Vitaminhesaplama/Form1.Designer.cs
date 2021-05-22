
namespace Vitaminhesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.textdosyasi = new System.Windows.Forms.RichTextBox();
            this.Ksikacak = new System.Windows.Forms.Button();
            this.Ssikacak = new System.Windows.Forms.Button();
            this.resim = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anlikislem = new System.Windows.Forms.RichTextBox();
            this.zaman = new System.Windows.Forms.Label();
            this.vitA = new System.Windows.Forms.Label();
            this.vitC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Moccasin;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(483, 362);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(231, 92);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Basla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // textdosyasi
            // 
            this.textdosyasi.BackColor = System.Drawing.SystemColors.Desktop;
            this.textdosyasi.ForeColor = System.Drawing.SystemColors.Window;
            this.textdosyasi.Location = new System.Drawing.Point(12, 12);
            this.textdosyasi.Name = "textdosyasi";
            this.textdosyasi.Size = new System.Drawing.Size(390, 195);
            this.textdosyasi.TabIndex = 3;
            this.textdosyasi.Text = "";
            // 
            // Ksikacak
            // 
            this.Ksikacak.BackColor = System.Drawing.Color.Moccasin;
            this.Ksikacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ksikacak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ksikacak.Location = new System.Drawing.Point(421, 280);
            this.Ksikacak.Name = "Ksikacak";
            this.Ksikacak.Size = new System.Drawing.Size(177, 76);
            this.Ksikacak.TabIndex = 4;
            this.Ksikacak.Text = "Katı Sıkacak";
            this.Ksikacak.UseVisualStyleBackColor = false;
            this.Ksikacak.Click += new System.EventHandler(this.Ksikacak_Click);
            // 
            // Ssikacak
            // 
            this.Ssikacak.BackColor = System.Drawing.Color.Moccasin;
            this.Ssikacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ssikacak.Location = new System.Drawing.Point(604, 280);
            this.Ssikacak.Name = "Ssikacak";
            this.Ssikacak.Size = new System.Drawing.Size(177, 76);
            this.Ssikacak.TabIndex = 5;
            this.Ssikacak.Text = "Sıvı Sıkacak";
            this.Ssikacak.UseVisualStyleBackColor = false;
            this.Ssikacak.Click += new System.EventHandler(this.Ssikacak_Click);
            // 
            // resim
            // 
            this.resim.Location = new System.Drawing.Point(10, 12);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(361, 214);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 6;
            this.resim.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.resim);
            this.panel1.Location = new System.Drawing.Point(408, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 242);
            this.panel1.TabIndex = 7;
            // 
            // anlikislem
            // 
            this.anlikislem.BackColor = System.Drawing.SystemColors.Desktop;
            this.anlikislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlikislem.ForeColor = System.Drawing.SystemColors.Window;
            this.anlikislem.Location = new System.Drawing.Point(96, 213);
            this.anlikislem.Name = "anlikislem";
            this.anlikislem.Size = new System.Drawing.Size(226, 185);
            this.anlikislem.TabIndex = 8;
            this.anlikislem.Text = "";
            // 
            // zaman
            // 
            this.zaman.AutoSize = true;
            this.zaman.BackColor = System.Drawing.Color.AliceBlue;
            this.zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman.Location = new System.Drawing.Point(389, 375);
            this.zaman.Name = "zaman";
            this.zaman.Size = new System.Drawing.Size(78, 55);
            this.zaman.TabIndex = 1;
            this.zaman.Text = "60";
            // 
            // vitA
            // 
            this.vitA.AutoSize = true;
            this.vitA.BackColor = System.Drawing.Color.AliceBlue;
            this.vitA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitA.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vitA.Location = new System.Drawing.Point(118, 436);
            this.vitA.Name = "vitA";
            this.vitA.Size = new System.Drawing.Size(35, 37);
            this.vitA.TabIndex = 9;
            this.vitA.Text = "0";
            // 
            // vitC
            // 
            this.vitC.AutoSize = true;
            this.vitC.BackColor = System.Drawing.Color.AliceBlue;
            this.vitC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitC.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vitC.Location = new System.Drawing.Point(283, 436);
            this.vitC.Name = "vitC";
            this.vitC.Size = new System.Drawing.Size(35, 37);
            this.vitC.TabIndex = 10;
            this.vitC.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(120, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "VitaminA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(285, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "VitaminC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(7, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOPLAM:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(812, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vitC);
            this.Controls.Add(this.vitA);
            this.Controls.Add(this.anlikislem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ssikacak);
            this.Controls.Add(this.Ksikacak);
            this.Controls.Add(this.textdosyasi);
            this.Controls.Add(this.zaman);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Vitamin Hesaplama";
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.RichTextBox textdosyasi;
        private System.Windows.Forms.Button Ksikacak;
        private System.Windows.Forms.Button Ssikacak;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox anlikislem;
        private System.Windows.Forms.Label zaman;
        private System.Windows.Forms.Label vitA;
        private System.Windows.Forms.Label vitC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

