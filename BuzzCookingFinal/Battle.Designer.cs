
namespace BuzzCookingFinal
{
    partial class Battle
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
            this.label4 = new System.Windows.Forms.Label();
            this.DishPb = new System.Windows.Forms.PictureBox();
            this.ReactPb = new System.Windows.Forms.PictureBox();
            this.BattlePb = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ActBt = new System.Windows.Forms.Button();
            this.MenuTb = new System.Windows.Forms.TextBox();
            this.EnemyTb = new System.Windows.Forms.TextBox();
            this.ReactTb = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DishPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReactPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattlePb)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(713, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "を提供中";
            // 
            // DishPb
            // 
            this.DishPb.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.dish;
            this.DishPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DishPb.Image = global::BuzzCookingFinal.Properties.Resources.domecover_close;
            this.DishPb.Location = new System.Drawing.Point(142, 304);
            this.DishPb.Name = "DishPb";
            this.DishPb.Size = new System.Drawing.Size(275, 100);
            this.DishPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DishPb.TabIndex = 6;
            this.DishPb.TabStop = false;
            // 
            // ReactPb
            // 
            this.ReactPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ReactPb.Location = new System.Drawing.Point(581, 141);
            this.ReactPb.Name = "ReactPb";
            this.ReactPb.Size = new System.Drawing.Size(200, 200);
            this.ReactPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReactPb.TabIndex = 5;
            this.ReactPb.TabStop = false;
            this.ReactPb.Paint += new System.Windows.Forms.PaintEventHandler(this.reactpb_Paint);
            // 
            // BattlePb
            // 
            this.BattlePb.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.tennnai;
            this.BattlePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BattlePb.Location = new System.Drawing.Point(55, 141);
            this.BattlePb.Name = "BattlePb";
            this.BattlePb.Size = new System.Drawing.Size(468, 263);
            this.BattlePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BattlePb.TabIndex = 0;
            this.BattlePb.TabStop = false;
            this.BattlePb.Paint += new System.Windows.Forms.PaintEventHandler(this.reactpb_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(651, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "反応";
            // 
            // ActBt
            // 
            this.ActBt.BackColor = System.Drawing.Color.Black;
            this.ActBt.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ActBt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ActBt.Location = new System.Drawing.Point(581, 373);
            this.ActBt.Name = "ActBt";
            this.ActBt.Size = new System.Drawing.Size(200, 31);
            this.ActBt.TabIndex = 8;
            this.ActBt.Text = "反応を見る";
            this.ActBt.UseVisualStyleBackColor = false;
            this.ActBt.Click += new System.EventHandler(this.ActBt_Click);
            // 
            // MenuTb
            // 
            this.MenuTb.BackColor = System.Drawing.Color.Black;
            this.MenuTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuTb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MenuTb.Location = new System.Drawing.Point(581, 40);
            this.MenuTb.Name = "MenuTb";
            this.MenuTb.ReadOnly = true;
            this.MenuTb.Size = new System.Drawing.Size(200, 28);
            this.MenuTb.TabIndex = 9;
            this.MenuTb.Text = "料理名";
            this.MenuTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnemyTb
            // 
            this.EnemyTb.BackColor = System.Drawing.Color.Black;
            this.EnemyTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnemyTb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EnemyTb.ForeColor = System.Drawing.Color.Blue;
            this.EnemyTb.Location = new System.Drawing.Point(142, 37);
            this.EnemyTb.Name = "EnemyTb";
            this.EnemyTb.ReadOnly = true;
            this.EnemyTb.Size = new System.Drawing.Size(275, 32);
            this.EnemyTb.TabIndex = 10;
            this.EnemyTb.Text = "客名";
            this.EnemyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReactTb
            // 
            this.ReactTb.BackColor = System.Drawing.Color.Black;
            this.ReactTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReactTb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReactTb.ForeColor = System.Drawing.SystemColors.Info;
            this.ReactTb.Location = new System.Drawing.Point(55, 75);
            this.ReactTb.Multiline = true;
            this.ReactTb.Name = "ReactTb";
            this.ReactTb.ReadOnly = true;
            this.ReactTb.Size = new System.Drawing.Size(468, 60);
            this.ReactTb.TabIndex = 11;
            this.ReactTb.Text = "セリフ";
            this.ReactTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tm
            // 
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.battleimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.ReactTb);
            this.Controls.Add(this.EnemyTb);
            this.Controls.Add(this.MenuTb);
            this.Controls.Add(this.ActBt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DishPb);
            this.Controls.Add(this.ReactPb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BattlePb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DishPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReactPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattlePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BattlePb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ReactPb;
        private System.Windows.Forms.PictureBox DishPb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ActBt;
        private System.Windows.Forms.TextBox MenuTb;
        private System.Windows.Forms.TextBox EnemyTb;
        private System.Windows.Forms.TextBox ReactTb;
        private System.Windows.Forms.Timer tm;
    }
}