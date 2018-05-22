namespace bazadanychcalosc
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name_texb = new System.Windows.Forms.TextBox();
            this.age_numUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pobierz_btn = new System.Windows.Forms.Button();
            this.aktualizuj_btn = new System.Windows.Forms.Button();
            this.wyczysc_btn = new System.Windows.Forms.Button();
            this.wyjscie_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista_lisb = new System.Windows.Forms.ListBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.usun_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age_numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name_texb);
            this.groupBox1.Controls.Add(this.age_numUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(216, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // name_texb
            // 
            this.name_texb.Location = new System.Drawing.Point(60, 48);
            this.name_texb.Name = "name_texb";
            this.name_texb.Size = new System.Drawing.Size(133, 22);
            this.name_texb.TabIndex = 3;
            // 
            // age_numUD
            // 
            this.age_numUD.Location = new System.Drawing.Point(60, 82);
            this.age_numUD.Name = "age_numUD";
            this.age_numUD.Size = new System.Drawing.Size(133, 22);
            this.age_numUD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wiek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Imię";
            // 
            // pobierz_btn
            // 
            this.pobierz_btn.Location = new System.Drawing.Point(12, 19);
            this.pobierz_btn.Name = "pobierz_btn";
            this.pobierz_btn.Size = new System.Drawing.Size(80, 28);
            this.pobierz_btn.TabIndex = 1;
            this.pobierz_btn.Text = "Pobierz";
            this.pobierz_btn.UseVisualStyleBackColor = true;
            this.pobierz_btn.Click += new System.EventHandler(this.pobierz_btn_Click);
            // 
            // aktualizuj_btn
            // 
            this.aktualizuj_btn.Location = new System.Drawing.Point(12, 53);
            this.aktualizuj_btn.Name = "aktualizuj_btn";
            this.aktualizuj_btn.Size = new System.Drawing.Size(80, 28);
            this.aktualizuj_btn.TabIndex = 2;
            this.aktualizuj_btn.Text = "Aktualizuj";
            this.aktualizuj_btn.UseVisualStyleBackColor = true;
            this.aktualizuj_btn.Click += new System.EventHandler(this.aktualizuj_btn_Click);
            // 
            // wyczysc_btn
            // 
            this.wyczysc_btn.Location = new System.Drawing.Point(12, 87);
            this.wyczysc_btn.Name = "wyczysc_btn";
            this.wyczysc_btn.Size = new System.Drawing.Size(80, 28);
            this.wyczysc_btn.TabIndex = 3;
            this.wyczysc_btn.Text = "Wyczyść";
            this.wyczysc_btn.UseVisualStyleBackColor = true;
            this.wyczysc_btn.Click += new System.EventHandler(this.wyczysc_btn_Click);
            // 
            // wyjscie_btn
            // 
            this.wyjscie_btn.Location = new System.Drawing.Point(12, 121);
            this.wyjscie_btn.Name = "wyjscie_btn";
            this.wyjscie_btn.Size = new System.Drawing.Size(80, 28);
            this.wyjscie_btn.TabIndex = 4;
            this.wyjscie_btn.Text = "Wyjście";
            this.wyjscie_btn.UseVisualStyleBackColor = true;
            this.wyjscie_btn.Click += new System.EventHandler(this.wyjscie_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista";
            // 
            // lista_lisb
            // 
            this.lista_lisb.FormattingEnabled = true;
            this.lista_lisb.ItemHeight = 16;
            this.lista_lisb.Location = new System.Drawing.Point(12, 185);
            this.lista_lisb.Name = "lista_lisb";
            this.lista_lisb.Size = new System.Drawing.Size(194, 180);
            this.lista_lisb.TabIndex = 7;
            this.lista_lisb.SelectedIndexChanged += new System.EventHandler(this.lista_lisb_SelectedIndexChanged);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(118, 124);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 23);
            this.dodaj_btn.TabIndex = 8;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // usun_btn
            // 
            this.usun_btn.Location = new System.Drawing.Point(118, 90);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(75, 23);
            this.usun_btn.TabIndex = 9;
            this.usun_btn.Text = "Usuń";
            this.usun_btn.UseVisualStyleBackColor = true;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 393);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.lista_lisb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyjscie_btn);
            this.Controls.Add(this.wyczysc_btn);
            this.Controls.Add(this.aktualizuj_btn);
            this.Controls.Add(this.pobierz_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age_numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name_texb;
        private System.Windows.Forms.NumericUpDown age_numUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pobierz_btn;
        private System.Windows.Forms.Button aktualizuj_btn;
        private System.Windows.Forms.Button wyczysc_btn;
        private System.Windows.Forms.Button wyjscie_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista_lisb;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button usun_btn;
    }
}

