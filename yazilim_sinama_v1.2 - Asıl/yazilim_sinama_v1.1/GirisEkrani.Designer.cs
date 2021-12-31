
namespace yazilim_sinama_v1._1
{
    partial class GirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciadialtbox = new System.Windows.Forms.TextBox();
            this.sifrealtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbuton = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciadialtbox
            // 
            this.kullaniciadialtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadialtbox.Location = new System.Drawing.Point(62, 180);
            this.kullaniciadialtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciadialtbox.Multiline = true;
            this.kullaniciadialtbox.Name = "kullaniciadialtbox";
            this.kullaniciadialtbox.Size = new System.Drawing.Size(232, 35);
            this.kullaniciadialtbox.TabIndex = 0;
            this.kullaniciadialtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sifrealtbox
            // 
            this.sifrealtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrealtbox.Location = new System.Drawing.Point(62, 260);
            this.sifrealtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifrealtbox.Multiline = true;
            this.sifrealtbox.Name = "sifrealtbox";
            this.sifrealtbox.Size = new System.Drawing.Size(232, 35);
            this.sifrealtbox.TabIndex = 1;
            this.sifrealtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE:";
            // 
            // loginbuton
            // 
            this.loginbuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.loginbuton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginbuton.FlatAppearance.BorderSize = 2;
            this.loginbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginbuton.ForeColor = System.Drawing.Color.White;
            this.loginbuton.Location = new System.Drawing.Point(62, 326);
            this.loginbuton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbuton.Name = "loginbuton";
            this.loginbuton.Size = new System.Drawing.Size(234, 51);
            this.loginbuton.TabIndex = 4;
            this.loginbuton.Text = "GİRİŞ YAP";
            this.loginbuton.UseVisualStyleBackColor = false;
            this.loginbuton.Click += new System.EventHandler(this.loginbuton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(193)))), ((int)(((byte)(174)))));
            this.metroPanel1.Controls.Add(this.loginbuton);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.kullaniciadialtbox);
            this.metroPanel1.Controls.Add(this.sifrealtbox);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 11;
            this.metroPanel1.Location = new System.Drawing.Point(0, 73);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(372, 435);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 508);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Movable = false;
            this.Name = "GirisEkrani";
            this.Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.girisekrani_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciadialtbox;
        private System.Windows.Forms.TextBox sifrealtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbuton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}