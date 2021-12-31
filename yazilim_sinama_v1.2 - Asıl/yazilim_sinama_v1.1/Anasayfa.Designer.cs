
namespace yazilim_sinama_v1._1
{
    partial class Anasayfa
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
            this.metinkutusu1 = new System.Windows.Forms.RichTextBox();
            this.metinkutusu2 = new System.Windows.Forms.RichTextBox();
            this.spnradiobuton = new System.Windows.Forms.RadioButton();
            this.sharadiobuton = new System.Windows.Forms.RadioButton();
            this.sifrelebuton = new System.Windows.Forms.Button();
            this.cözbuton = new System.Windows.Forms.Button();
            this.keyaltbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oturumyaz = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_chat = new System.Windows.Forms.RichTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metinkutusu1
            // 
            this.metinkutusu1.Location = new System.Drawing.Point(31, 53);
            this.metinkutusu1.Name = "metinkutusu1";
            this.metinkutusu1.Size = new System.Drawing.Size(332, 162);
            this.metinkutusu1.TabIndex = 0;
            this.metinkutusu1.Text = "";
            // 
            // metinkutusu2
            // 
            this.metinkutusu2.Location = new System.Drawing.Point(31, 273);
            this.metinkutusu2.Name = "metinkutusu2";
            this.metinkutusu2.Size = new System.Drawing.Size(332, 164);
            this.metinkutusu2.TabIndex = 1;
            this.metinkutusu2.Text = "";
            // 
            // spnradiobuton
            // 
            this.spnradiobuton.AutoSize = true;
            this.spnradiobuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.spnradiobuton.ForeColor = System.Drawing.Color.White;
            this.spnradiobuton.Location = new System.Drawing.Point(449, 132);
            this.spnradiobuton.Name = "spnradiobuton";
            this.spnradiobuton.Size = new System.Drawing.Size(47, 17);
            this.spnradiobuton.TabIndex = 2;
            this.spnradiobuton.TabStop = true;
            this.spnradiobuton.Text = "SPN";
            this.spnradiobuton.UseVisualStyleBackColor = false;
            // 
            // sharadiobuton
            // 
            this.sharadiobuton.AutoSize = true;
            this.sharadiobuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.sharadiobuton.ForeColor = System.Drawing.Color.White;
            this.sharadiobuton.Location = new System.Drawing.Point(544, 133);
            this.sharadiobuton.Name = "sharadiobuton";
            this.sharadiobuton.Size = new System.Drawing.Size(68, 17);
            this.sharadiobuton.TabIndex = 3;
            this.sharadiobuton.TabStop = true;
            this.sharadiobuton.Text = "SHA-256";
            this.sharadiobuton.UseVisualStyleBackColor = false;
            // 
            // sifrelebuton
            // 
            this.sifrelebuton.BackColor = System.Drawing.Color.Aquamarine;
            this.sifrelebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelebuton.Location = new System.Drawing.Point(431, 273);
            this.sifrelebuton.Name = "sifrelebuton";
            this.sifrelebuton.Size = new System.Drawing.Size(231, 61);
            this.sifrelebuton.TabIndex = 4;
            this.sifrelebuton.Text = "ŞİFRELEME";
            this.sifrelebuton.UseVisualStyleBackColor = false;
            this.sifrelebuton.Click += new System.EventHandler(this.sifrelebuton_Click);
            // 
            // cözbuton
            // 
            this.cözbuton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cözbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cözbuton.Location = new System.Drawing.Point(431, 377);
            this.cözbuton.Name = "cözbuton";
            this.cözbuton.Size = new System.Drawing.Size(231, 60);
            this.cözbuton.TabIndex = 5;
            this.cözbuton.Text = "ÇÖZ";
            this.cözbuton.UseVisualStyleBackColor = false;
            this.cözbuton.Click += new System.EventHandler(this.cözbuton_Click);
            // 
            // keyaltbox
            // 
            this.keyaltbox.Location = new System.Drawing.Point(498, 175);
            this.keyaltbox.Name = "keyaltbox";
            this.keyaltbox.Size = new System.Drawing.Size(145, 20);
            this.keyaltbox.TabIndex = 6;
            this.keyaltbox.Text = "security";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "plain text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "cipher text";
            // 
            // oturumyaz
            // 
            this.oturumyaz.AutoSize = true;
            this.oturumyaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.oturumyaz.Cursor = System.Windows.Forms.Cursors.No;
            this.oturumyaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oturumyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oturumyaz.ForeColor = System.Drawing.Color.White;
            this.oturumyaz.Location = new System.Drawing.Point(565, 64);
            this.oturumyaz.Name = "oturumyaz";
            this.oturumyaz.Size = new System.Drawing.Size(51, 20);
            this.oturumyaz.TabIndex = 11;
            this.oturumyaz.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(460, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "OTURUM :";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Location = new System.Drawing.Point(533, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 60);
            this.btnConnect.TabIndex = 25;
            this.btnConnect.Text = "Sunucuya Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(533, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 283);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Açık Oturumlar";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(133, 251);
            this.listBox1.TabIndex = 0;
            // 
            // txt_text
            // 
            this.txt_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_text.Location = new System.Drawing.Point(23, 345);
            this.txt_text.Multiline = true;
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(364, 30);
            this.txt_text.TabIndex = 22;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.Location = new System.Drawing.Point(399, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(122, 33);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.rb_chat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 297);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelen Mesaj :";
            // 
            // rb_chat
            // 
            this.rb_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_chat.Location = new System.Drawing.Point(3, 17);
            this.rb_chat.Name = "rb_chat";
            this.rb_chat.Size = new System.Drawing.Size(498, 277);
            this.rb_chat.TabIndex = 1;
            this.rb_chat.Text = "";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(1, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(718, 509);
            this.metroTabControl1.TabIndex = 11;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.oturumyaz);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.sifrelebuton);
            this.metroTabPage1.Controls.Add(this.cözbuton);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.sharadiobuton);
            this.metroTabPage1.Controls.Add(this.metinkutusu1);
            this.metroTabPage1.Controls.Add(this.keyaltbox);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.spnradiobuton);
            this.metroTabPage1.Controls.Add(this.metinkutusu2);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(710, 470);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Şifreleme Ve Çözme";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnConnect);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.txt_text);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.btnSend);
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(710, 470);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Mesaj Sayfası";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 19);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(718, 455);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(-4, 8);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(718, 455);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel2.TabIndex = 26;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 563);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Anasayfa";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Kullanıcı Ekranı";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox metinkutusu1;
        private System.Windows.Forms.RichTextBox metinkutusu2;
        private System.Windows.Forms.RadioButton spnradiobuton;
        private System.Windows.Forms.RadioButton sharadiobuton;
        private System.Windows.Forms.Button sifrelebuton;
        private System.Windows.Forms.Button cözbuton;
        private System.Windows.Forms.TextBox keyaltbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oturumyaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rb_chat;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}

