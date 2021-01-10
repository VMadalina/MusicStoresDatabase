namespace Magazine_muzica
{
    partial class Vanzari_totale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vanzari_totale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.TotalVanzari = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Valoare_suma = new System.Windows.Forms.TextBox();
            this.Cauta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalVanzari)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(976, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 143;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // TotalVanzari
            // 
            this.TotalVanzari.AllowUserToAddRows = false;
            this.TotalVanzari.AllowUserToDeleteRows = false;
            this.TotalVanzari.AllowUserToResizeColumns = false;
            this.TotalVanzari.AllowUserToResizeRows = false;
            this.TotalVanzari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TotalVanzari.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalVanzari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalVanzari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TotalVanzari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalVanzari.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalVanzari.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalVanzari.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalVanzari.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TotalVanzari.Location = new System.Drawing.Point(12, 102);
            this.TotalVanzari.Name = "TotalVanzari";
            this.TotalVanzari.ReadOnly = true;
            this.TotalVanzari.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalVanzari.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TotalVanzari.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.NullValue = "0";
            this.TotalVanzari.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TotalVanzari.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalVanzari.RowTemplate.Height = 24;
            this.TotalVanzari.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalVanzari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TotalVanzari.Size = new System.Drawing.Size(726, 503);
            this.TotalVanzari.TabIndex = 2;
            this.TotalVanzari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TotalVanzari_CellContentClick);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Cambria", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(430, 40);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(218, 40);
            this.Total.TabIndex = 146;
            this.Total.Text = "Total vânzări";
            this.Total.Click += new System.EventHandler(this.Case_discuri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(808, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 23);
            this.label2.TabIndex = 148;
            this.label2.Text = "Pentru a vedea doar datele ce ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 23);
            this.label3.TabIndex = 149;
            this.label3.Text = "depășesc o anumită sumă,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 23);
            this.label4.TabIndex = 150;
            this.label4.Text = "completați căsuța de mai jos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(744, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 151;
            this.label5.Text = "cu valoarea dorită:";
            // 
            // Valoare_suma
            // 
            this.Valoare_suma.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valoare_suma.Location = new System.Drawing.Point(744, 351);
            this.Valoare_suma.Name = "Valoare_suma";
            this.Valoare_suma.Size = new System.Drawing.Size(250, 31);
            this.Valoare_suma.TabIndex = 0;
            // 
            // Cauta
            // 
            this.Cauta.BackColor = System.Drawing.Color.White;
            this.Cauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cauta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cauta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cauta.Location = new System.Drawing.Point(744, 388);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(97, 42);
            this.Cauta.TabIndex = 1;
            this.Cauta.Text = "Căutare";
            this.Cauta.UseVisualStyleBackColor = false;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Vanzari_totale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 617);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Valoare_suma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalVanzari);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vanzari_totale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanzari_totale";
            this.Load += new System.EventHandler(this.Vanzari_totale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalVanzari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DataGridView TotalVanzari;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Valoare_suma;
        private System.Windows.Forms.Button Cauta;
    }
}