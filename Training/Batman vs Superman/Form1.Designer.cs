
namespace Batman_vs_Superman
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
            this.batarang = new System.Windows.Forms.RadioButton();
            this.Kungfu = new System.Windows.Forms.RadioButton();
            this.laser = new System.Windows.Forms.RadioButton();
            this.Superkracht = new System.Windows.Forms.RadioButton();
            this.Super_aanvallen = new System.Windows.Forms.Button();
            this.batman_aanvallen = new System.Windows.Forms.Button();
            this.Batman = new System.Windows.Forms.Label();
            this.Superman = new System.Windows.Forms.Label();
            this.krackt_over_superman = new System.Windows.Forms.Label();
            this.kracht_over_batman = new System.Windows.Forms.Label();
            this.kracht_batman = new System.Windows.Forms.Label();
            this.kracht_superman = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // batarang
            // 
            this.batarang.AutoSize = true;
            this.batarang.Location = new System.Drawing.Point(79, 88);
            this.batarang.Name = "batarang";
            this.batarang.Size = new System.Drawing.Size(87, 21);
            this.batarang.TabIndex = 0;
            this.batarang.TabStop = true;
            this.batarang.Text = "Batarang";
            this.batarang.UseVisualStyleBackColor = true;
            // 
            // Kungfu
            // 
            this.Kungfu.AutoSize = true;
            this.Kungfu.Location = new System.Drawing.Point(79, 124);
            this.Kungfu.Name = "Kungfu";
            this.Kungfu.Size = new System.Drawing.Size(83, 21);
            this.Kungfu.TabIndex = 1;
            this.Kungfu.TabStop = true;
            this.Kungfu.Text = "Kung-Fu";
            this.Kungfu.UseVisualStyleBackColor = true;
            // 
            // laser
            // 
            this.laser.AutoSize = true;
            this.laser.Location = new System.Drawing.Point(371, 88);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(65, 21);
            this.laser.TabIndex = 2;
            this.laser.TabStop = true;
            this.laser.Text = "Laser";
            this.laser.UseVisualStyleBackColor = true;
            // 
            // Superkracht
            // 
            this.Superkracht.AutoSize = true;
            this.Superkracht.Location = new System.Drawing.Point(371, 124);
            this.Superkracht.Name = "Superkracht";
            this.Superkracht.Size = new System.Drawing.Size(106, 21);
            this.Superkracht.TabIndex = 3;
            this.Superkracht.TabStop = true;
            this.Superkracht.Text = "Superkracht";
            this.Superkracht.UseVisualStyleBackColor = true;
            // 
            // Super_aanvallen
            // 
            this.Super_aanvallen.Location = new System.Drawing.Point(371, 192);
            this.Super_aanvallen.Name = "Super_aanvallen";
            this.Super_aanvallen.Size = new System.Drawing.Size(122, 23);
            this.Super_aanvallen.TabIndex = 4;
            this.Super_aanvallen.Text = "Aanvallen";
            this.Super_aanvallen.UseVisualStyleBackColor = true;
            this.Super_aanvallen.Click += new System.EventHandler(this.button1_Click);
            // 
            // batman_aanvallen
            // 
            this.batman_aanvallen.Location = new System.Drawing.Point(79, 192);
            this.batman_aanvallen.Name = "batman_aanvallen";
            this.batman_aanvallen.Size = new System.Drawing.Size(119, 23);
            this.batman_aanvallen.TabIndex = 5;
            this.batman_aanvallen.Text = "Aanvallen";
            this.batman_aanvallen.UseVisualStyleBackColor = true;
            this.batman_aanvallen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Batman
            // 
            this.Batman.AutoSize = true;
            this.Batman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batman.Location = new System.Drawing.Point(73, 54);
            this.Batman.Name = "Batman";
            this.Batman.Size = new System.Drawing.Size(113, 31);
            this.Batman.TabIndex = 6;
            this.Batman.Text = "Batman";
            this.Batman.Click += new System.EventHandler(this.label1_Click);
            // 
            // Superman
            // 
            this.Superman.AutoSize = true;
            this.Superman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Superman.Location = new System.Drawing.Point(365, 54);
            this.Superman.Name = "Superman";
            this.Superman.Size = new System.Drawing.Size(146, 31);
            this.Superman.TabIndex = 7;
            this.Superman.Text = "Superman";
            this.Superman.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // krackt_over_superman
            // 
            this.krackt_over_superman.AutoSize = true;
            this.krackt_over_superman.Location = new System.Drawing.Point(372, 164);
            this.krackt_over_superman.Name = "krackt_over_superman";
            this.krackt_over_superman.Size = new System.Drawing.Size(85, 17);
            this.krackt_over_superman.TabIndex = 8;
            this.krackt_over_superman.Text = "Kracht over:";
            this.krackt_over_superman.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // kracht_over_batman
            // 
            this.kracht_over_batman.AutoSize = true;
            this.kracht_over_batman.Location = new System.Drawing.Point(76, 164);
            this.kracht_over_batman.Name = "kracht_over_batman";
            this.kracht_over_batman.Size = new System.Drawing.Size(85, 17);
            this.kracht_over_batman.TabIndex = 9;
            this.kracht_over_batman.Text = "Kracht over:";
            // 
            // kracht_batman
            // 
            this.kracht_batman.AutoSize = true;
            this.kracht_batman.Location = new System.Drawing.Point(162, 164);
            this.kracht_batman.Name = "kracht_batman";
            this.kracht_batman.Size = new System.Drawing.Size(24, 17);
            this.kracht_batman.TabIndex = 10;
            this.kracht_batman.Text = "20";
            // 
            // kracht_superman
            // 
            this.kracht_superman.AutoSize = true;
            this.kracht_superman.Location = new System.Drawing.Point(453, 164);
            this.kracht_superman.Name = "kracht_superman";
            this.kracht_superman.Size = new System.Drawing.Size(24, 17);
            this.kracht_superman.TabIndex = 11;
            this.kracht_superman.Text = "20";
            this.kracht_superman.Click += new System.EventHandler(this.kracht_superman_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(244, 239);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 12;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.kracht_superman);
            this.Controls.Add(this.kracht_batman);
            this.Controls.Add(this.kracht_over_batman);
            this.Controls.Add(this.krackt_over_superman);
            this.Controls.Add(this.Superman);
            this.Controls.Add(this.Batman);
            this.Controls.Add(this.batman_aanvallen);
            this.Controls.Add(this.Super_aanvallen);
            this.Controls.Add(this.Superkracht);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.Kungfu);
            this.Controls.Add(this.batarang);
            this.Name = "Form1";
            this.Text = "Batman vs Superman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton batarang;
        private System.Windows.Forms.RadioButton Kungfu;
        private System.Windows.Forms.RadioButton laser;
        private System.Windows.Forms.RadioButton Superkracht;
        private System.Windows.Forms.Button Super_aanvallen;
        private System.Windows.Forms.Button batman_aanvallen;
        private System.Windows.Forms.Label Batman;
        private System.Windows.Forms.Label Superman;
        private System.Windows.Forms.Label krackt_over_superman;
        private System.Windows.Forms.Label kracht_over_batman;
        private System.Windows.Forms.Label kracht_batman;
        private System.Windows.Forms.Label kracht_superman;
        private System.Windows.Forms.Button restart;
    }
}

