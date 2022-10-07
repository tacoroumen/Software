
namespace Emmer_vol_laten_lopen
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.emmer_size = new System.Windows.Forms.TextBox();
            this.beker_size = new System.Windows.Forms.TextBox();
            this.emmer_grote = new System.Windows.Forms.Label();
            this.beker_grote = new System.Windows.Forms.Label();
            this.fill_bucket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 199);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // emmer_size
            // 
            this.emmer_size.Location = new System.Drawing.Point(372, 154);
            this.emmer_size.Name = "emmer_size";
            this.emmer_size.Size = new System.Drawing.Size(100, 22);
            this.emmer_size.TabIndex = 1;
            this.emmer_size.TextChanged += new System.EventHandler(this.emmer_size_TextChanged);
            // 
            // beker_size
            // 
            this.beker_size.Location = new System.Drawing.Point(372, 209);
            this.beker_size.Name = "beker_size";
            this.beker_size.Size = new System.Drawing.Size(100, 22);
            this.beker_size.TabIndex = 2;
            this.beker_size.TextChanged += new System.EventHandler(this.beker_size_TextChanged);
            // 
            // emmer_grote
            // 
            this.emmer_grote.AutoSize = true;
            this.emmer_grote.Location = new System.Drawing.Point(234, 154);
            this.emmer_grote.Name = "emmer_grote";
            this.emmer_grote.Size = new System.Drawing.Size(132, 17);
            this.emmer_grote.TabIndex = 3;
            this.emmer_grote.Tag = "";
            this.emmer_grote.Text = "Emmer Grootte (lit):";
            this.emmer_grote.Click += new System.EventHandler(this.label1_Click);
            // 
            // beker_grote
            // 
            this.beker_grote.AutoSize = true;
            this.beker_grote.Location = new System.Drawing.Point(234, 209);
            this.beker_grote.Name = "beker_grote";
            this.beker_grote.Size = new System.Drawing.Size(118, 17);
            this.beker_grote.TabIndex = 4;
            this.beker_grote.Tag = "";
            this.beker_grote.Text = "Beker grootte (cl)";
            // 
            // fill_bucket
            // 
            this.fill_bucket.Location = new System.Drawing.Point(237, 27);
            this.fill_bucket.Name = "fill_bucket";
            this.fill_bucket.Size = new System.Drawing.Size(115, 82);
            this.fill_bucket.TabIndex = 5;
            this.fill_bucket.Text = "vullen met water";
            this.fill_bucket.UseVisualStyleBackColor = true;
            this.fill_bucket.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 336);
            this.Controls.Add(this.fill_bucket);
            this.Controls.Add(this.beker_grote);
            this.Controls.Add(this.emmer_grote);
            this.Controls.Add(this.beker_size);
            this.Controls.Add(this.emmer_size);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label emmer_grote;
        private System.Windows.Forms.TextBox beker_size;
        private System.Windows.Forms.TextBox emmer_size;
        private System.Windows.Forms.Button fill_bucket;
        private System.Windows.Forms.Label beker_grote;
    }
}

