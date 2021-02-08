
namespace BuzzCookingFinal
{
    partial class HowToForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Purposelb = new System.Windows.Forms.Label();
            this.Ppxplb = new System.Windows.Forms.Label();
            this.HowTolb = new System.Windows.Forms.Label();
            this.Htxplb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(387, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Purposelb
            // 
            this.Purposelb.BackColor = System.Drawing.Color.Black;
            this.Purposelb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Purposelb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Purposelb.ForeColor = System.Drawing.Color.Red;
            this.Purposelb.Location = new System.Drawing.Point(0, 0);
            this.Purposelb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Purposelb.Name = "Purposelb";
            this.Purposelb.Size = new System.Drawing.Size(834, 50);
            this.Purposelb.TabIndex = 1;
            this.Purposelb.Text = "ゲームの目的";
            this.Purposelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ppxplb
            // 
            this.Ppxplb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ppxplb.AutoSize = true;
            this.Ppxplb.BackColor = System.Drawing.Color.Black;
            this.Ppxplb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ppxplb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ppxplb.Location = new System.Drawing.Point(4, 65);
            this.Ppxplb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Ppxplb.Name = "Ppxplb";
            this.Ppxplb.Size = new System.Drawing.Size(143, 22);
            this.Ppxplb.TabIndex = 2;
            this.Ppxplb.Text = "ストーリー説明";
            this.Ppxplb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowTolb
            // 
            this.HowTolb.AutoSize = true;
            this.HowTolb.BackColor = System.Drawing.Color.Black;
            this.HowTolb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HowTolb.ForeColor = System.Drawing.Color.Red;
            this.HowTolb.Location = new System.Drawing.Point(385, 230);
            this.HowTolb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HowTolb.Name = "HowTolb";
            this.HowTolb.Size = new System.Drawing.Size(102, 34);
            this.HowTolb.TabIndex = 3;
            this.HowTolb.Text = "遊び方";
            this.HowTolb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Htxplb
            // 
            this.Htxplb.AutoSize = true;
            this.Htxplb.BackColor = System.Drawing.Color.Black;
            this.Htxplb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Htxplb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Htxplb.Location = new System.Drawing.Point(85, 275);
            this.Htxplb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Htxplb.Name = "Htxplb";
            this.Htxplb.Size = new System.Drawing.Size(105, 22);
            this.Htxplb.TabIndex = 4;
            this.Htxplb.Text = "遊び方説明";
            this.Htxplb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.battleimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Htxplb);
            this.Controls.Add(this.HowTolb);
            this.Controls.Add(this.Ppxplb);
            this.Controls.Add(this.Purposelb);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HowToForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HowToForm";
            this.Load += new System.EventHandler(this.HowToForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Purposelb;
        private System.Windows.Forms.Label Ppxplb;
        private System.Windows.Forms.Label HowTolb;
        private System.Windows.Forms.Label Htxplb;
    }
}