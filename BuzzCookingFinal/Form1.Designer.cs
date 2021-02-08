
namespace BuzzCookingFinal
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HowTobt = new System.Windows.Forms.Button();
            this.Playbt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アマチュアToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(130, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let’s BuzzCook!";
            // 
            // HowTobt
            // 
            this.HowTobt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HowTobt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowTobt.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HowTobt.Location = new System.Drawing.Point(121, 343);
            this.HowTobt.Name = "HowTobt";
            this.HowTobt.Size = new System.Drawing.Size(150, 50);
            this.HowTobt.TabIndex = 1;
            this.HowTobt.Text = "遊び方";
            this.HowTobt.UseVisualStyleBackColor = false;
            this.HowTobt.Click += new System.EventHandler(this.HowTobt_Click);
            // 
            // Playbt
            // 
            this.Playbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Playbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Playbt.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbt.Location = new System.Drawing.Point(583, 343);
            this.Playbt.Name = "Playbt";
            this.Playbt.Size = new System.Drawing.Size(150, 50);
            this.Playbt.TabIndex = 2;
            this.Playbt.Text = "Enjoy Cook!";
            this.Playbt.UseVisualStyleBackColor = false;
            this.Playbt.Click += new System.EventHandler(this.Playbt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.アマチュアToolStripMenuItem,
            this.プロToolStripMenuItem});
            this.設定ToolStripMenuItem.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.設定ToolStripMenuItem.ForeColor = System.Drawing.Color.Magenta;
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.設定ToolStripMenuItem.Text = "難易度の設定";
            // 
            // アマチュアToolStripMenuItem
            // 
            this.アマチュアToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.アマチュアToolStripMenuItem.ForeColor = System.Drawing.Color.Magenta;
            this.アマチュアToolStripMenuItem.Name = "アマチュアToolStripMenuItem";
            this.アマチュアToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.アマチュアToolStripMenuItem.Text = "アマチュア（簡単）";
            this.アマチュアToolStripMenuItem.Click += new System.EventHandler(this.アマチュアToolStripMenuItem_Click);
            // 
            // プロToolStripMenuItem
            // 
            this.プロToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.プロToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.プロToolStripMenuItem.Name = "プロToolStripMenuItem";
            this.プロToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.プロToolStripMenuItem.Text = "プロ（難しい）";
            this.プロToolStripMenuItem.Click += new System.EventHandler(this.プロToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.titleimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 476);
            this.Controls.Add(this.Playbt);
            this.Controls.Add(this.HowTobt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HowTobt;
        private System.Windows.Forms.Button Playbt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アマチュアToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロToolStripMenuItem;
    }
}

