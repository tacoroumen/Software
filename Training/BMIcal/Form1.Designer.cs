
namespace WindowsFormsApp1
{
    partial class Tortar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tortar));
            this.Weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.SystemColors.Window;
            this.Weight.Location = new System.Drawing.Point(12, 12);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 22);
            this.Weight.TabIndex = 0;
            this.Weight.Tag = "";
            this.Weight.Text = "Weight in KG";
            this.Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(127, 12);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 22);
            this.height.TabIndex = 1;
            this.height.Text = "Height in cm ";
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(63, 40);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(110, 31);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate BMI";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tortar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(239, 82);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.height);
            this.Controls.Add(this.Weight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tortar";
            this.Text = "Tortar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Button calculate;
    }
}

