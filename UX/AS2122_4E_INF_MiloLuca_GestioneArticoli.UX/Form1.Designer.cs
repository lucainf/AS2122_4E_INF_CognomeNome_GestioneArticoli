namespace AS2122_4E_INF_MiloLuca_GestioneArticoli.UX
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_unitamisura = new System.Windows.Forms.ComboBox();
            this.txt_codice = new System.Windows.Forms.TextBox();
            this.txt_descrizione = new System.Windows.Forms.TextBox();
            this.txt_prezzo = new System.Windows.Forms.TextBox();
            this.cmb_visualizza = new System.Windows.Forms.ComboBox();
            this.btn_visualizza = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_narticoli = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_prezzo);
            this.groupBox1.Controls.Add(this.txt_descrizione);
            this.groupBox1.Controls.Add(this.txt_codice);
            this.groupBox1.Controls.Add(this.cmb_unitamisura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli Articolo";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(142, 291);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(216, 48);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Aggiungi/modifica articolo";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unità di misura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezzo";
            // 
            // cmb_unitamisura
            // 
            this.cmb_unitamisura.FormattingEnabled = true;
            this.cmb_unitamisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmb_unitamisura.Location = new System.Drawing.Point(142, 120);
            this.cmb_unitamisura.Name = "cmb_unitamisura";
            this.cmb_unitamisura.Size = new System.Drawing.Size(100, 23);
            this.cmb_unitamisura.TabIndex = 6;
            // 
            // txt_codice
            // 
            this.txt_codice.Location = new System.Drawing.Point(142, 24);
            this.txt_codice.Name = "txt_codice";
            this.txt_codice.Size = new System.Drawing.Size(100, 23);
            this.txt_codice.TabIndex = 7;
            // 
            // txt_descrizione
            // 
            this.txt_descrizione.Location = new System.Drawing.Point(142, 72);
            this.txt_descrizione.Name = "txt_descrizione";
            this.txt_descrizione.Size = new System.Drawing.Size(100, 23);
            this.txt_descrizione.TabIndex = 8;
            // 
            // txt_prezzo
            // 
            this.txt_prezzo.Location = new System.Drawing.Point(142, 167);
            this.txt_prezzo.Name = "txt_prezzo";
            this.txt_prezzo.Size = new System.Drawing.Size(100, 23);
            this.txt_prezzo.TabIndex = 9;
            // 
            // cmb_visualizza
            // 
            this.cmb_visualizza.FormattingEnabled = true;
            this.cmb_visualizza.Items.AddRange(new object[] {
            "Visualizza articoli"});
            this.cmb_visualizza.Location = new System.Drawing.Point(507, 12);
            this.cmb_visualizza.Name = "cmb_visualizza";
            this.cmb_visualizza.Size = new System.Drawing.Size(121, 23);
            this.cmb_visualizza.TabIndex = 1;
            // 
            // btn_visualizza
            // 
            this.btn_visualizza.Location = new System.Drawing.Point(634, 11);
            this.btn_visualizza.Name = "btn_visualizza";
            this.btn_visualizza.Size = new System.Drawing.Size(75, 23);
            this.btn_visualizza.TabIndex = 2;
            this.btn_visualizza.Text = "...";
            this.btn_visualizza.UseVisualStyleBackColor = true;
            this.btn_visualizza.Click += new System.EventHandler(this.btn_visualizza_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(507, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 394);
            this.listBox1.TabIndex = 3;
            // 
            // lbl_narticoli
            // 
            this.lbl_narticoli.AutoSize = true;
            this.lbl_narticoli.Location = new System.Drawing.Point(12, 403);
            this.lbl_narticoli.Name = "lbl_narticoli";
            this.lbl_narticoli.Size = new System.Drawing.Size(62, 15);
            this.lbl_narticoli.TabIndex = 4;
            this.lbl_narticoli.Text = "Articoli (0)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lbl_narticoli);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_visualizza);
            this.Controls.Add(this.cmb_visualizza);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_prezzo;
        private TextBox txt_descrizione;
        private TextBox txt_codice;
        private ComboBox cmb_unitamisura;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_update;
        private ComboBox cmb_visualizza;
        private Button btn_visualizza;
        private ListBox listBox1;
        private Label lbl_narticoli;
    }
}