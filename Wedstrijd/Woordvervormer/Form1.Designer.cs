
namespace Training___Array___Woordvervormer
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
            this.woord = new System.Windows.Forms.TextBox();
            this.flip = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.oneven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // woord
            // 
            this.woord.Location = new System.Drawing.Point(304, 117);
            this.woord.Name = "woord";
            this.woord.Size = new System.Drawing.Size(172, 22);
            this.woord.TabIndex = 0;
            this.woord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flip
            // 
            this.flip.Location = new System.Drawing.Point(304, 171);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(172, 63);
            this.flip.TabIndex = 1;
            this.flip.Text = "Omdraaien";
            this.flip.UseVisualStyleBackColor = true;
            this.flip.Click += new System.EventHandler(this.flip_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(304, 240);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(172, 67);
            this.plus.TabIndex = 2;
            this.plus.Text = "Plussen";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // oneven
            // 
            this.oneven.Location = new System.Drawing.Point(303, 313);
            this.oneven.Name = "oneven";
            this.oneven.Size = new System.Drawing.Size(173, 63);
            this.oneven.TabIndex = 3;
            this.oneven.Text = "Onevenen";
            this.oneven.UseVisualStyleBackColor = true;
            this.oneven.Click += new System.EventHandler(this.oneven_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oneven);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.flip);
            this.Controls.Add(this.woord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox woord;
        private System.Windows.Forms.Button flip;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button oneven;
    }
}

