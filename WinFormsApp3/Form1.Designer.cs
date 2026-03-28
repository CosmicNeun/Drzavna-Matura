namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewUcenici = new DataGridView();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            buttonobrisi = new Button();
            comboBoxnaziv1 = new ComboBox();
            comboBoxnaziv3 = new ComboBox();
            comboBoxnaziv2 = new ComboBox();
            buttonsacuvaj = new Button();
            label7 = new Label();
            comboBoxskola = new ComboBox();
            comboBoxodeljenje = new ComboBox();
            label3 = new Label();
            comboBoxtip = new ComboBox();
            comboBoxjezik = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            textBoxime = new TextBox();
            textBoxprezime = new TextBox();
            label5 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridViewProfil = new DataGridView();
            buttonprofilsacuvaj = new Button();
            buttonprofilobrisi = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            comboBoxprofilnaziv2 = new ComboBox();
            comboBoxprofilnaziv3 = new ComboBox();
            comboBoxprofilnaziv1 = new ComboBox();
            labelprofilnaziv = new Label();
            comboBoxprofiljezik = new ComboBox();
            label9 = new Label();
            comboBoxprofiltip = new ComboBox();
            label8 = new Label();
            textBoxprofil = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcenici).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfil).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(97, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(888, 498);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewUcenici);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(buttonobrisi);
            tabPage1.Controls.Add(comboBoxnaziv1);
            tabPage1.Controls.Add(comboBoxnaziv3);
            tabPage1.Controls.Add(comboBoxnaziv2);
            tabPage1.Controls.Add(buttonsacuvaj);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(comboBoxskola);
            tabPage1.Controls.Add(comboBoxodeljenje);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBoxtip);
            tabPage1.Controls.Add(comboBoxjezik);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxime);
            tabPage1.Controls.Add(textBoxprezime);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(880, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Škola";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUcenici
            // 
            dataGridViewUcenici.AllowUserToAddRows = false;
            dataGridViewUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUcenici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUcenici.Location = new Point(51, 281);
            dataGridViewUcenici.Name = "dataGridViewUcenici";
            dataGridViewUcenici.ReadOnly = true;
            dataGridViewUcenici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUcenici.Size = new Size(775, 170);
            dataGridViewUcenici.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 226);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 20;
            label6.Text = "Drugi predmet";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 197);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 19;
            label11.Text = "Prvi predmet";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 255);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 21;
            label12.Text = "Treci predmet";
            // 
            // buttonobrisi
            // 
            buttonobrisi.Location = new Point(613, 235);
            buttonobrisi.Name = "buttonobrisi";
            buttonobrisi.Size = new Size(103, 40);
            buttonobrisi.TabIndex = 18;
            buttonobrisi.Text = "Obriši";
            buttonobrisi.UseVisualStyleBackColor = true;
            buttonobrisi.Click += buttonobrisi_Click;
            // 
            // comboBoxnaziv1
            // 
            comboBoxnaziv1.FormattingEnabled = true;
            comboBoxnaziv1.Location = new Point(145, 194);
            comboBoxnaziv1.Name = "comboBoxnaziv1";
            comboBoxnaziv1.Size = new Size(188, 23);
            comboBoxnaziv1.TabIndex = 17;
            comboBoxnaziv1.Text = "Prvi predmet";
            // 
            // comboBoxnaziv3
            // 
            comboBoxnaziv3.FormattingEnabled = true;
            comboBoxnaziv3.Location = new Point(145, 252);
            comboBoxnaziv3.Name = "comboBoxnaziv3";
            comboBoxnaziv3.Size = new Size(188, 23);
            comboBoxnaziv3.TabIndex = 16;
            comboBoxnaziv3.Text = "Treci predmet";
            // 
            // comboBoxnaziv2
            // 
            comboBoxnaziv2.FormattingEnabled = true;
            comboBoxnaziv2.Location = new Point(145, 223);
            comboBoxnaziv2.Name = "comboBoxnaziv2";
            comboBoxnaziv2.Size = new Size(188, 23);
            comboBoxnaziv2.TabIndex = 15;
            comboBoxnaziv2.Text = "Drugi predmet";
            // 
            // buttonsacuvaj
            // 
            buttonsacuvaj.Location = new Point(723, 235);
            buttonsacuvaj.Name = "buttonsacuvaj";
            buttonsacuvaj.Size = new Size(103, 40);
            buttonsacuvaj.TabIndex = 14;
            buttonsacuvaj.Text = "Sačuvaj";
            buttonsacuvaj.UseVisualStyleBackColor = true;
            buttonsacuvaj.Click += buttonpotvrdi_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 37);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 13;
            label7.Text = "Škola";
            // 
            // comboBoxskola
            // 
            comboBoxskola.FormattingEnabled = true;
            comboBoxskola.Location = new Point(112, 29);
            comboBoxskola.Name = "comboBoxskola";
            comboBoxskola.Size = new Size(572, 23);
            comboBoxskola.TabIndex = 12;
            // 
            // comboBoxodeljenje
            // 
            comboBoxodeljenje.FormattingEnabled = true;
            comboBoxodeljenje.Location = new Point(486, 70);
            comboBoxodeljenje.Name = "comboBoxodeljenje";
            comboBoxodeljenje.Size = new Size(198, 23);
            comboBoxodeljenje.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 102);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Prezime";
            // 
            // comboBoxtip
            // 
            comboBoxtip.FormattingEnabled = true;
            comboBoxtip.Location = new Point(145, 128);
            comboBoxtip.Name = "comboBoxtip";
            comboBoxtip.Size = new Size(188, 23);
            comboBoxtip.TabIndex = 7;
            comboBoxtip.SelectedIndexChanged += comboBoxtip_SelectedIndexChanged;
            // 
            // comboBoxjezik
            // 
            comboBoxjezik.FormattingEnabled = true;
            comboBoxjezik.Location = new Point(486, 99);
            comboBoxjezik.Name = "comboBoxjezik";
            comboBoxjezik.Size = new Size(198, 23);
            comboBoxjezik.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 73);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 131);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Tip  mature";
            // 
            // textBoxime
            // 
            textBoxime.Location = new Point(145, 70);
            textBoxime.Name = "textBoxime";
            textBoxime.Size = new Size(188, 23);
            textBoxime.TabIndex = 10;
            // 
            // textBoxprezime
            // 
            textBoxprezime.Location = new Point(145, 99);
            textBoxprezime.Name = "textBoxprezime";
            textBoxprezime.Size = new Size(188, 23);
            textBoxprezime.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 102);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Jezik";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 73);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Odeljenje";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewProfil);
            tabPage2.Controls.Add(buttonprofilsacuvaj);
            tabPage2.Controls.Add(buttonprofilobrisi);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(comboBoxprofilnaziv2);
            tabPage2.Controls.Add(comboBoxprofilnaziv3);
            tabPage2.Controls.Add(comboBoxprofilnaziv1);
            tabPage2.Controls.Add(labelprofilnaziv);
            tabPage2.Controls.Add(comboBoxprofiljezik);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(comboBoxprofiltip);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxprofil);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(880, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Učenik";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProfil
            // 
            dataGridViewProfil.AllowUserToAddRows = false;
            dataGridViewProfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfil.Location = new Point(50, 280);
            dataGridViewProfil.Name = "dataGridViewProfil";
            dataGridViewProfil.ReadOnly = true;
            dataGridViewProfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProfil.Size = new Size(775, 170);
            dataGridViewProfil.TabIndex = 27;
            // 
            // buttonprofilsacuvaj
            // 
            buttonprofilsacuvaj.Location = new Point(722, 217);
            buttonprofilsacuvaj.Name = "buttonprofilsacuvaj";
            buttonprofilsacuvaj.Size = new Size(103, 40);
            buttonprofilsacuvaj.TabIndex = 26;
            buttonprofilsacuvaj.Text = "Sačuvaj";
            buttonprofilsacuvaj.UseVisualStyleBackColor = true;
            buttonprofilsacuvaj.Click += buttonprofilsacuvaj_Click;
            // 
            // buttonprofilobrisi
            // 
            buttonprofilobrisi.Location = new Point(613, 217);
            buttonprofilobrisi.Name = "buttonprofilobrisi";
            buttonprofilobrisi.Size = new Size(103, 40);
            buttonprofilobrisi.TabIndex = 25;
            buttonprofilobrisi.Text = "Obriši";
            buttonprofilobrisi.UseVisualStyleBackColor = true;
            buttonprofilobrisi.Click += buttonprofilobrisi_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(50, 208);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 23;
            label13.Text = "Drugi predmet";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(50, 179);
            label14.Name = "label14";
            label14.Size = new Size(75, 15);
            label14.TabIndex = 22;
            label14.Text = "Prvi predmet";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 237);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 24;
            label15.Text = "Treci predmet";
            // 
            // comboBoxprofilnaziv2
            // 
            comboBoxprofilnaziv2.FormattingEnabled = true;
            comboBoxprofilnaziv2.Location = new Point(147, 205);
            comboBoxprofilnaziv2.Name = "comboBoxprofilnaziv2";
            comboBoxprofilnaziv2.Size = new Size(189, 23);
            comboBoxprofilnaziv2.TabIndex = 15;
            // 
            // comboBoxprofilnaziv3
            // 
            comboBoxprofilnaziv3.FormattingEnabled = true;
            comboBoxprofilnaziv3.Location = new Point(147, 234);
            comboBoxprofilnaziv3.Name = "comboBoxprofilnaziv3";
            comboBoxprofilnaziv3.Size = new Size(189, 23);
            comboBoxprofilnaziv3.TabIndex = 14;
            // 
            // comboBoxprofilnaziv1
            // 
            comboBoxprofilnaziv1.FormattingEnabled = true;
            comboBoxprofilnaziv1.Location = new Point(147, 176);
            comboBoxprofilnaziv1.Name = "comboBoxprofilnaziv1";
            comboBoxprofilnaziv1.Size = new Size(189, 23);
            comboBoxprofilnaziv1.TabIndex = 13;
            // 
            // labelprofilnaziv
            // 
            labelprofilnaziv.AutoSize = true;
            labelprofilnaziv.Location = new Point(50, 28);
            labelprofilnaziv.Name = "labelprofilnaziv";
            labelprofilnaziv.Size = new Size(73, 15);
            labelprofilnaziv.TabIndex = 12;
            labelprofilnaziv.Text = "Naziv profila";
            // 
            // comboBoxprofiljezik
            // 
            comboBoxprofiljezik.FormattingEnabled = true;
            comboBoxprofiljezik.Location = new Point(147, 107);
            comboBoxprofiljezik.Name = "comboBoxprofiljezik";
            comboBoxprofiljezik.Size = new Size(189, 23);
            comboBoxprofiljezik.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 113);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 10;
            label9.Text = "Jezik";
            // 
            // comboBoxprofiltip
            // 
            comboBoxprofiltip.FormattingEnabled = true;
            comboBoxprofiltip.Location = new Point(147, 76);
            comboBoxprofiltip.Name = "comboBoxprofiltip";
            comboBoxprofiltip.Size = new Size(189, 23);
            comboBoxprofiltip.TabIndex = 9;
            comboBoxprofiltip.SelectedIndexChanged += comboBoxprofiltip_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 82);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 8;
            label8.Text = "Tip mature";
            // 
            // textBoxprofil
            // 
            textBoxprofil.Location = new Point(147, 25);
            textBoxprofil.Name = "textBoxprofil";
            textBoxprofil.Size = new Size(189, 23);
            textBoxprofil.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 607);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Drzavna matura";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcenici).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfil).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBoxnaziv1;
        private ComboBox comboBoxnaziv3;
        private ComboBox comboBoxnaziv2;
        private Button buttonsacuvaj;
        private Label label7;
        private ComboBox comboBoxskola;
        private ComboBox comboBoxodeljenje;
        private Label label3;
        private ComboBox comboBoxtip;
        private ComboBox comboBoxjezik;
        private Label label2;
        private Label label4;
        private TextBox textBoxime;
        private TextBox textBoxprezime;
        private Label label5;
        private Label label1;
        private Button buttonobrisi;
        private TextBox textBoxprofil;
        private ComboBox comboBoxprofiltip;
        private Label label8;
        private ComboBox comboBoxprofiljezik;
        private Label label9;
        private Label labelprofilnaziv;
        private ComboBox comboBoxprofilnaziv2;
        private ComboBox comboBoxprofilnaziv3;
        private ComboBox comboBoxprofilnaziv1;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button buttonprofilsacuvaj;
        private Button buttonprofilobrisi;
        private DataGridView dataGridViewUcenici;
        private DataGridView dataGridViewProfil;
    }
}
