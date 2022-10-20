
namespace Training_Blackjack__light_
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
            this.Deal = new System.Windows.Forms.Button();
            this.Hit = new System.Windows.Forms.Button();
            this.Stand = new System.Windows.Forms.Button();
            this.CardVallue = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Deal
            // 
            this.Deal.Location = new System.Drawing.Point(88, 91);
            this.Deal.Name = "Deal";
            this.Deal.Size = new System.Drawing.Size(75, 23);
            this.Deal.TabIndex = 0;
            this.Deal.Text = "Deal";
            this.Deal.UseVisualStyleBackColor = true;
            this.Deal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // Hit
            // 
            this.Hit.Location = new System.Drawing.Point(162, 120);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(75, 23);
            this.Hit.TabIndex = 1;
            this.Hit.Text = "Hit";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Visible = false;
            this.Hit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // Stand
            // 
            this.Stand.Location = new System.Drawing.Point(14, 120);
            this.Stand.Name = "Stand";
            this.Stand.Size = new System.Drawing.Size(75, 23);
            this.Stand.TabIndex = 2;
            this.Stand.Text = "Stand";
            this.Stand.UseVisualStyleBackColor = true;
            this.Stand.Visible = false;
            this.Stand.Click += new System.EventHandler(this.Stand_Click);
            // 
            // CardVallue
            // 
            this.CardVallue.AutoSize = true;
            this.CardVallue.Location = new System.Drawing.Point(117, 9);
            this.CardVallue.Name = "CardVallue";
            this.CardVallue.Size = new System.Drawing.Size(16, 17);
            this.CardVallue.TabIndex = 3;
            this.CardVallue.Text = "0";
            this.CardVallue.Click += new System.EventHandler(this.CardVallue_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(88, 159);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 4;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 202);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.CardVallue);
            this.Controls.Add(this.Stand);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.Deal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deal;
        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.Button Stand;
        private System.Windows.Forms.Label CardVallue;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Restart;
    }
}

