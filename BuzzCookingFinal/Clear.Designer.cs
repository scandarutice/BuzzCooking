
namespace BuzzCookingFinal
{
    partial class Clear
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
            this.GameResultLb = new System.Windows.Forms.Label();
            this.ResultTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultexTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GameResultLb
            // 
            this.GameResultLb.AutoSize = true;
            this.GameResultLb.BackColor = System.Drawing.Color.Black;
            this.GameResultLb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameResultLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GameResultLb.Location = new System.Drawing.Point(38, 43);
            this.GameResultLb.Name = "GameResultLb";
            this.GameResultLb.Size = new System.Drawing.Size(770, 51);
            this.GameResultLb.TabIndex = 0;
            this.GameResultLb.Text = "ゲームクリアおめでとうございます！";
            // 
            // ResultTb
            // 
            this.ResultTb.BackColor = System.Drawing.Color.Black;
            this.ResultTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTb.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTb.ForeColor = System.Drawing.Color.Red;
            this.ResultTb.Location = new System.Drawing.Point(171, 158);
            this.ResultTb.Multiline = true;
            this.ResultTb.Name = "ResultTb";
            this.ResultTb.Size = new System.Drawing.Size(500, 30);
            this.ResultTb.TabIndex = 1;
            this.ResultTb.Text = "○○を倒したことで世界は滅亡した・・・";
            this.ResultTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(218, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(604, 85);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thank you for Playing!!";
            // 
            // ResultexTb
            // 
            this.ResultexTb.BackColor = System.Drawing.Color.Black;
            this.ResultexTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultexTb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultexTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResultexTb.Location = new System.Drawing.Point(123, 272);
            this.ResultexTb.Multiline = true;
            this.ResultexTb.Name = "ResultexTb";
            this.ResultexTb.ReadOnly = true;
            this.ResultexTb.Size = new System.Drawing.Size(600, 65);
            this.ResultexTb.TabIndex = 4;
            this.ResultexTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.titleimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.ResultexTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultTb);
            this.Controls.Add(this.GameResultLb);
            this.Name = "Clear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clear";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Clear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameResultLb;
        private System.Windows.Forms.TextBox ResultTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultexTb;
    }
}