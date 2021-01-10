namespace Magazine_muzica
{
    partial class Vanzari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vanzari));
            this.Back = new System.Windows.Forms.PictureBox();
            this.Vânzare = new System.Windows.Forms.Label();
            this.Albume_vandute = new System.Windows.Forms.Button();
            this.Partituri_vandute = new System.Windows.Forms.Button();
            this.Accesorii_vandute = new System.Windows.Forms.Button();
            this.Info_albume = new System.Windows.Forms.LinkLabel();
            this.info_sup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(59, 40);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 50);
            this.Back.TabIndex = 70;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Vânzare
            // 
            this.Vânzare.AutoSize = true;
            this.Vânzare.BackColor = System.Drawing.Color.Transparent;
            this.Vânzare.Font = new System.Drawing.Font("Gabriola", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vânzare.Location = new System.Drawing.Point(411, 9);
            this.Vânzare.Name = "Vânzare";
            this.Vânzare.Size = new System.Drawing.Size(255, 147);
            this.Vânzare.TabIndex = 0;
            this.Vânzare.Text = "Vânzări";
            // 
            // Albume_vandute
            // 
            this.Albume_vandute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Albume_vandute.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Albume_vandute.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Albume_vandute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.Albume_vandute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Albume_vandute.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albume_vandute.Location = new System.Drawing.Point(216, 333);
            this.Albume_vandute.Name = "Albume_vandute";
            this.Albume_vandute.Size = new System.Drawing.Size(198, 52);
            this.Albume_vandute.TabIndex = 2;
            this.Albume_vandute.Text = "Albume vândute";
            this.Albume_vandute.UseVisualStyleBackColor = false;
            this.Albume_vandute.Click += new System.EventHandler(this.Albume_vandute_Click);
            // 
            // Partituri_vandute
            // 
            this.Partituri_vandute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Partituri_vandute.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Partituri_vandute.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Partituri_vandute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.Partituri_vandute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Partituri_vandute.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partituri_vandute.Location = new System.Drawing.Point(732, 195);
            this.Partituri_vandute.Name = "Partituri_vandute";
            this.Partituri_vandute.Size = new System.Drawing.Size(198, 52);
            this.Partituri_vandute.TabIndex = 5;
            this.Partituri_vandute.Text = "Partituri vândute";
            this.Partituri_vandute.UseVisualStyleBackColor = false;
            this.Partituri_vandute.Click += new System.EventHandler(this.Partituri_vandute_Click);
            // 
            // Accesorii_vandute
            // 
            this.Accesorii_vandute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Accesorii_vandute.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Accesorii_vandute.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Accesorii_vandute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.Accesorii_vandute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Accesorii_vandute.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accesorii_vandute.Location = new System.Drawing.Point(110, 195);
            this.Accesorii_vandute.Name = "Accesorii_vandute";
            this.Accesorii_vandute.Size = new System.Drawing.Size(198, 52);
            this.Accesorii_vandute.TabIndex = 1;
            this.Accesorii_vandute.Text = "Accesorii_vandute";
            this.Accesorii_vandute.UseVisualStyleBackColor = false;
            this.Accesorii_vandute.Click += new System.EventHandler(this.Accesorii_vandute_Click);
            // 
            // Info_albume
            // 
            this.Info_albume.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.Info_albume.AutoSize = true;
            this.Info_albume.BackColor = System.Drawing.Color.Transparent;
            this.Info_albume.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_albume.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_albume.Location = new System.Drawing.Point(182, 372);
            this.Info_albume.Name = "Info_albume";
            this.Info_albume.Size = new System.Drawing.Size(0, 23);
            this.Info_albume.TabIndex = 145;
            this.Info_albume.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            // 
            // info_sup
            // 
            this.info_sup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_sup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.info_sup.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.info_sup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.info_sup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.info_sup.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_sup.Location = new System.Drawing.Point(385, 464);
            this.info_sup.Name = "info_sup";
            this.info_sup.Size = new System.Drawing.Size(269, 52);
            this.info_sup.TabIndex = 3;
            this.info_sup.Text = "Informații suplimentare";
            this.info_sup.UseVisualStyleBackColor = false;
            this.info_sup.Click += new System.EventHandler(this.info_sup_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(610, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Total vânzări";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(960, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Vanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info_sup);
            this.Controls.Add(this.Info_albume);
            this.Controls.Add(this.Accesorii_vandute);
            this.Controls.Add(this.Partituri_vandute);
            this.Controls.Add(this.Albume_vandute);
            this.Controls.Add(this.Vânzare);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vanzari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanzari";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label Vânzare;
        private System.Windows.Forms.Button Albume_vandute;
        private System.Windows.Forms.Button Partituri_vandute;
        private System.Windows.Forms.Button Accesorii_vandute;
        private System.Windows.Forms.LinkLabel Info_albume;
        private System.Windows.Forms.Button info_sup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}