namespace Pujcovna
{
    partial class Pujcka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pujcka));
            this.tb_cena = new System.Windows.Forms.TextBox();
            this.lb_cena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsb_filmy = new System.Windows.Forms.ListBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.lsb_pujceny = new System.Windows.Forms.ListBox();
            this.tb_penale = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_cena
            // 
            this.tb_cena.BackColor = System.Drawing.SystemColors.Window;
            this.tb_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_cena.Location = new System.Drawing.Point(146, 245);
            this.tb_cena.Name = "tb_cena";
            this.tb_cena.ReadOnly = true;
            this.tb_cena.Size = new System.Drawing.Size(119, 20);
            this.tb_cena.TabIndex = 55;
            this.tb_cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_cena
            // 
            this.lb_cena.AutoSize = true;
            this.lb_cena.Location = new System.Drawing.Point(9, 248);
            this.lb_cena.Name = "lb_cena";
            this.lb_cena.Size = new System.Drawing.Size(79, 13);
            this.lb_cena.TabIndex = 17;
            this.lb_cena.Text = "Cena + penále:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stanovené datum vrácení:";
            // 
            // lsb_filmy
            // 
            this.lsb_filmy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_filmy.FormattingEnabled = true;
            this.lsb_filmy.Location = new System.Drawing.Point(12, 14);
            this.lsb_filmy.Name = "lsb_filmy";
            this.lsb_filmy.Size = new System.Drawing.Size(120, 199);
            this.lsb_filmy.TabIndex = 3;
            this.lsb_filmy.SelectedIndexChanged += new System.EventHandler(this.lsb_filmy_SelectedIndexChanged);
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_ok.Location = new System.Drawing.Point(12, 271);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(120, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "Potvrdit";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_close
            // 
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(146, 271);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(120, 23);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "Zrušit";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lsb_pujceny
            // 
            this.lsb_pujceny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_pujceny.FormattingEnabled = true;
            this.lsb_pujceny.Location = new System.Drawing.Point(146, 14);
            this.lsb_pujceny.Name = "lsb_pujceny";
            this.lsb_pujceny.Size = new System.Drawing.Size(120, 199);
            this.lsb_pujceny.TabIndex = 22;
            this.lsb_pujceny.SelectedIndexChanged += new System.EventHandler(this.lsb_pujceny_SelectedIndexChanged);
            // 
            // tb_penale
            // 
            this.tb_penale.BackColor = System.Drawing.SystemColors.Window;
            this.tb_penale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_penale.Location = new System.Drawing.Point(146, 245);
            this.tb_penale.Name = "tb_penale";
            this.tb_penale.ReadOnly = true;
            this.tb_penale.Size = new System.Drawing.Size(120, 20);
            this.tb_penale.TabIndex = 56;
            this.tb_penale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "";
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(146, 219);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(120, 20);
            this.dtp_date.TabIndex = 57;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // Pujcka
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(277, 299);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tb_penale);
            this.Controls.Add(this.lsb_pujceny);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lsb_filmy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_cena);
            this.Controls.Add(this.tb_cena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pujcka";
            this.Text = "Pujcka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_cena;
        private System.Windows.Forms.Label lb_cena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsb_filmy;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ListBox lsb_pujceny;
        private System.Windows.Forms.TextBox tb_penale;
        private System.Windows.Forms.DateTimePicker dtp_date;
    }
}