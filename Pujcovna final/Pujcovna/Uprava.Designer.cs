namespace Pujcovna
{
    partial class Uprava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uprava));
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.tb_nazev = new System.Windows.Forms.TextBox();
            this.tb_rezie = new System.Windows.Forms.TextBox();
            this.tb_zanr = new System.Windows.Forms.TextBox();
            this.nud_rok = new System.Windows.Forms.NumericUpDown();
            this.nud_pocet = new System.Windows.Forms.NumericUpDown();
            this.lb_nazev = new System.Windows.Forms.Label();
            this.lb_rezie = new System.Windows.Forms.Label();
            this.lb_zanr = new System.Windows.Forms.Label();
            this.lb_rok = new System.Windows.Forms.Label();
            this.lb_pocet = new System.Windows.Forms.Label();
            this.nud_cena = new System.Windows.Forms.NumericUpDown();
            this.l_cena = new System.Windows.Forms.Label();
            this.nud_celkem = new System.Windows.Forms.NumericUpDown();
            this.lb_celkem = new System.Windows.Forms.Label();
            this.bt_n = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pocet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_celkem)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Enabled = false;
            this.bt_ok.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.ForeColor = System.Drawing.Color.Green;
            this.bt_ok.Location = new System.Drawing.Point(5, 44);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(256, 23);
            this.bt_ok.TabIndex = 55;
            this.bt_ok.Text = "Potvrdit";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_close
            // 
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.Color.Crimson;
            this.bt_close.Location = new System.Drawing.Point(273, 45);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(256, 23);
            this.bt_close.TabIndex = 66;
            this.bt_close.Text = "Cancel";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // tb_nazev
            // 
            this.tb_nazev.Location = new System.Drawing.Point(5, 18);
            this.tb_nazev.Name = "tb_nazev";
            this.tb_nazev.Size = new System.Drawing.Size(100, 20);
            this.tb_nazev.TabIndex = 2;
            this.tb_nazev.TextChanged += new System.EventHandler(this.tb_nazev_TextChanged);
            // 
            // tb_rezie
            // 
            this.tb_rezie.Location = new System.Drawing.Point(111, 18);
            this.tb_rezie.Name = "tb_rezie";
            this.tb_rezie.Size = new System.Drawing.Size(100, 20);
            this.tb_rezie.TabIndex = 3;
            this.tb_rezie.TextChanged += new System.EventHandler(this.tb_rezie_TextChanged);
            // 
            // tb_zanr
            // 
            this.tb_zanr.Location = new System.Drawing.Point(217, 18);
            this.tb_zanr.Name = "tb_zanr";
            this.tb_zanr.Size = new System.Drawing.Size(100, 20);
            this.tb_zanr.TabIndex = 4;
            this.tb_zanr.TextChanged += new System.EventHandler(this.tb_zanr_TextChanged);
            // 
            // nud_rok
            // 
            this.nud_rok.Location = new System.Drawing.Point(323, 19);
            this.nud_rok.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nud_rok.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.nud_rok.Name = "nud_rok";
            this.nud_rok.Size = new System.Drawing.Size(47, 20);
            this.nud_rok.TabIndex = 5;
            this.nud_rok.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // nud_pocet
            // 
            this.nud_pocet.Location = new System.Drawing.Point(376, 19);
            this.nud_pocet.Name = "nud_pocet";
            this.nud_pocet.Size = new System.Drawing.Size(47, 20);
            this.nud_pocet.TabIndex = 6;
            this.nud_pocet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pocet.ValueChanged += new System.EventHandler(this.nud_pocet_ValueChanged);
            // 
            // lb_nazev
            // 
            this.lb_nazev.AutoSize = true;
            this.lb_nazev.Location = new System.Drawing.Point(2, 2);
            this.lb_nazev.Name = "lb_nazev";
            this.lb_nazev.Size = new System.Drawing.Size(62, 13);
            this.lb_nazev.TabIndex = 7;
            this.lb_nazev.Text = "Název filmu";
            // 
            // lb_rezie
            // 
            this.lb_rezie.AutoSize = true;
            this.lb_rezie.Location = new System.Drawing.Point(108, 2);
            this.lb_rezie.Name = "lb_rezie";
            this.lb_rezie.Size = new System.Drawing.Size(34, 13);
            this.lb_rezie.TabIndex = 8;
            this.lb_rezie.Text = "Režie";
            // 
            // lb_zanr
            // 
            this.lb_zanr.AutoSize = true;
            this.lb_zanr.Location = new System.Drawing.Point(214, 2);
            this.lb_zanr.Name = "lb_zanr";
            this.lb_zanr.Size = new System.Drawing.Size(29, 13);
            this.lb_zanr.TabIndex = 9;
            this.lb_zanr.Text = "Žánr";
            // 
            // lb_rok
            // 
            this.lb_rok.AutoSize = true;
            this.lb_rok.Location = new System.Drawing.Point(320, 2);
            this.lb_rok.Name = "lb_rok";
            this.lb_rok.Size = new System.Drawing.Size(27, 13);
            this.lb_rok.TabIndex = 10;
            this.lb_rok.Text = "Rok";
            // 
            // lb_pocet
            // 
            this.lb_pocet.AutoSize = true;
            this.lb_pocet.Location = new System.Drawing.Point(373, 2);
            this.lb_pocet.Name = "lb_pocet";
            this.lb_pocet.Size = new System.Drawing.Size(35, 13);
            this.lb_pocet.TabIndex = 11;
            this.lb_pocet.Text = "Počet";
            // 
            // nud_cena
            // 
            this.nud_cena.Location = new System.Drawing.Point(482, 19);
            this.nud_cena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_cena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cena.Name = "nud_cena";
            this.nud_cena.Size = new System.Drawing.Size(47, 20);
            this.nud_cena.TabIndex = 12;
            this.nud_cena.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // l_cena
            // 
            this.l_cena.AutoSize = true;
            this.l_cena.Location = new System.Drawing.Point(479, 3);
            this.l_cena.Name = "l_cena";
            this.l_cena.Size = new System.Drawing.Size(32, 13);
            this.l_cena.TabIndex = 13;
            this.l_cena.Text = "Cena";
            // 
            // nud_celkem
            // 
            this.nud_celkem.Location = new System.Drawing.Point(429, 19);
            this.nud_celkem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_celkem.Name = "nud_celkem";
            this.nud_celkem.Size = new System.Drawing.Size(47, 20);
            this.nud_celkem.TabIndex = 11;
            this.nud_celkem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_celkem
            // 
            this.lb_celkem.AutoSize = true;
            this.lb_celkem.Location = new System.Drawing.Point(426, 2);
            this.lb_celkem.Name = "lb_celkem";
            this.lb_celkem.Size = new System.Drawing.Size(42, 13);
            this.lb_celkem.TabIndex = 15;
            this.lb_celkem.Text = "Celkem";
            // 
            // bt_n
            // 
            this.bt_n.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_n.Cursor = System.Windows.Forms.Cursors.Help;
            this.bt_n.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_n.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bt_n.Location = new System.Drawing.Point(234, 44);
            this.bt_n.Name = "bt_n";
            this.bt_n.Size = new System.Drawing.Size(27, 23);
            this.bt_n.TabIndex = 67;
            this.bt_n.Text = "?";
            this.bt_n.UseVisualStyleBackColor = false;
            this.bt_n.Click += new System.EventHandler(this.bt_n_Click);
            // 
            // Uprava
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(535, 71);
            this.Controls.Add(this.bt_n);
            this.Controls.Add(this.lb_celkem);
            this.Controls.Add(this.nud_celkem);
            this.Controls.Add(this.l_cena);
            this.Controls.Add(this.nud_cena);
            this.Controls.Add(this.lb_pocet);
            this.Controls.Add(this.lb_rok);
            this.Controls.Add(this.lb_zanr);
            this.Controls.Add(this.lb_rezie);
            this.Controls.Add(this.lb_nazev);
            this.Controls.Add(this.nud_pocet);
            this.Controls.Add(this.nud_rok);
            this.Controls.Add(this.tb_zanr);
            this.Controls.Add(this.tb_rezie);
            this.Controls.Add(this.tb_nazev);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uprava";
            this.Text = "Uprava";
            ((System.ComponentModel.ISupportInitialize)(this.nud_rok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pocet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_celkem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.TextBox tb_nazev;
        private System.Windows.Forms.TextBox tb_rezie;
        private System.Windows.Forms.TextBox tb_zanr;
        private System.Windows.Forms.NumericUpDown nud_rok;
        private System.Windows.Forms.NumericUpDown nud_pocet;
        private System.Windows.Forms.Label lb_nazev;
        private System.Windows.Forms.Label lb_rezie;
        private System.Windows.Forms.Label lb_zanr;
        private System.Windows.Forms.Label lb_rok;
        private System.Windows.Forms.Label lb_pocet;
        private System.Windows.Forms.NumericUpDown nud_cena;
        private System.Windows.Forms.Label l_cena;
        private System.Windows.Forms.NumericUpDown nud_celkem;
        private System.Windows.Forms.Label lb_celkem;
        private System.Windows.Forms.Button bt_n;
    }
}