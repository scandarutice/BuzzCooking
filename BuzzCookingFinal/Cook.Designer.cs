
namespace BuzzCookingFinal
{
    partial class Cook
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
            this.MenuCb = new System.Windows.Forms.ComboBox();
            this.menuDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuDataSet = new BuzzCookingFinal.MenuDataSet();
            this.MenuPb = new System.Windows.Forms.PictureBox();
            this.MainFoodCb = new System.Windows.Forms.ComboBox();
            this.mainFoodDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFoodDataSet = new BuzzCookingFinal.MainFoodDataSet();
            this.SubCb2 = new System.Windows.Forms.ComboBox();
            this.subFoodDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subFoodDataSet = new BuzzCookingFinal.SubFoodDataSet();
            this.SubCb3 = new System.Windows.Forms.ComboBox();
            this.subFoodDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SubCb1 = new System.Windows.Forms.ComboBox();
            this.subFoodDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BzckBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EnemyPb = new System.Windows.Forms.PictureBox();
            this.AtkstLb = new System.Windows.Forms.Label();
            this.HlstLb = new System.Windows.Forms.Label();
            this.AstLb = new System.Windows.Forms.Label();
            this.HstLb = new System.Windows.Forms.Label();
            this.EnemyTb = new System.Windows.Forms.TextBox();
            this.HellnumLb = new System.Windows.Forms.Label();
            this.HappynumLb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFoodDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPb)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuCb
            // 
            this.MenuCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MenuCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuCb.DataSource = this.menuDataTableBindingSource;
            this.MenuCb.DisplayMember = "料理名";
            this.MenuCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuCb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuCb.FormattingEnabled = true;
            this.MenuCb.Location = new System.Drawing.Point(315, 40);
            this.MenuCb.Name = "MenuCb";
            this.MenuCb.Size = new System.Drawing.Size(225, 36);
            this.MenuCb.TabIndex = 0;
            this.MenuCb.ValueMember = "料理名";
            this.MenuCb.SelectedIndexChanged += new System.EventHandler(this.MenuCb_SelectedIndexChanged);
            // 
            // menuDataTableBindingSource
            // 
            this.menuDataTableBindingSource.DataMember = "MenuDataTable";
            this.menuDataTableBindingSource.DataSource = this.menuDataSet;
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "MenuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MenuPb
            // 
            this.MenuPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MenuPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuPb.Image = global::BuzzCookingFinal.Properties.Resources.domecover_close;
            this.MenuPb.Location = new System.Drawing.Point(240, 85);
            this.MenuPb.Name = "MenuPb";
            this.MenuPb.Size = new System.Drawing.Size(300, 300);
            this.MenuPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPb.TabIndex = 1;
            this.MenuPb.TabStop = false;
            // 
            // MainFoodCb
            // 
            this.MainFoodCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MainFoodCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainFoodCb.DataSource = this.mainFoodDataTableBindingSource;
            this.MainFoodCb.DisplayMember = "食材分類";
            this.MainFoodCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainFoodCb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainFoodCb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainFoodCb.FormattingEnabled = true;
            this.MainFoodCb.Location = new System.Drawing.Point(678, 99);
            this.MainFoodCb.Name = "MainFoodCb";
            this.MainFoodCb.Size = new System.Drawing.Size(101, 26);
            this.MainFoodCb.TabIndex = 2;
            this.MainFoodCb.ValueMember = "食材分類";
            this.MainFoodCb.SelectedIndexChanged += new System.EventHandler(this.MainFoodCb_SelectedIndexChanged);
            // 
            // mainFoodDataTableBindingSource
            // 
            this.mainFoodDataTableBindingSource.DataMember = "MainFoodDataTable";
            this.mainFoodDataTableBindingSource.DataSource = this.mainFoodDataSet;
            // 
            // mainFoodDataSet
            // 
            this.mainFoodDataSet.DataSetName = "MainFoodDataSet";
            this.mainFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubCb2
            // 
            this.SubCb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubCb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubCb2.DataSource = this.subFoodDataTableBindingSource;
            this.SubCb2.DisplayMember = "食材名";
            this.SubCb2.DropDownHeight = 200;
            this.SubCb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCb2.DropDownWidth = 125;
            this.SubCb2.Enabled = false;
            this.SubCb2.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SubCb2.FormattingEnabled = true;
            this.SubCb2.IntegralHeight = false;
            this.SubCb2.Location = new System.Drawing.Point(659, 213);
            this.SubCb2.Name = "SubCb2";
            this.SubCb2.Size = new System.Drawing.Size(120, 23);
            this.SubCb2.TabIndex = 3;
            this.SubCb2.ValueMember = "食材名";
            this.SubCb2.SelectedIndexChanged += new System.EventHandler(this.SubCb2_SelectedIndexChanged);
            // 
            // subFoodDataTableBindingSource
            // 
            this.subFoodDataTableBindingSource.DataMember = "SubFoodDataTable";
            this.subFoodDataTableBindingSource.DataSource = this.subFoodDataSet;
            // 
            // subFoodDataSet
            // 
            this.subFoodDataSet.DataSetName = "SubFoodDataSet";
            this.subFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubCb3
            // 
            this.SubCb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubCb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubCb3.DataSource = this.subFoodDataTableBindingSource1;
            this.SubCb3.DisplayMember = "食材名";
            this.SubCb3.DropDownHeight = 200;
            this.SubCb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCb3.DropDownWidth = 125;
            this.SubCb3.Enabled = false;
            this.SubCb3.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SubCb3.FormattingEnabled = true;
            this.SubCb3.IntegralHeight = false;
            this.SubCb3.Location = new System.Drawing.Point(659, 268);
            this.SubCb3.Name = "SubCb3";
            this.SubCb3.Size = new System.Drawing.Size(120, 23);
            this.SubCb3.TabIndex = 4;
            this.SubCb3.ValueMember = "食材名";
            this.SubCb3.SelectedIndexChanged += new System.EventHandler(this.SubCb3_SelectedIndexChanged);
            // 
            // subFoodDataTableBindingSource1
            // 
            this.subFoodDataTableBindingSource1.DataMember = "SubFoodDataTable";
            this.subFoodDataTableBindingSource1.DataSource = this.subFoodDataSet;
            // 
            // SubCb1
            // 
            this.SubCb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubCb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubCb1.DataSource = this.subFoodDataTableBindingSource2;
            this.SubCb1.DisplayMember = "食材名";
            this.SubCb1.DropDownHeight = 200;
            this.SubCb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCb1.DropDownWidth = 125;
            this.SubCb1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SubCb1.FormattingEnabled = true;
            this.SubCb1.IntegralHeight = false;
            this.SubCb1.Location = new System.Drawing.Point(659, 157);
            this.SubCb1.Name = "SubCb1";
            this.SubCb1.Size = new System.Drawing.Size(120, 23);
            this.SubCb1.TabIndex = 5;
            this.SubCb1.ValueMember = "食材名";
            this.SubCb1.SelectedIndexChanged += new System.EventHandler(this.SubCb1_SelectedIndexChanged);
            // 
            // subFoodDataTableBindingSource2
            // 
            this.subFoodDataTableBindingSource2.DataMember = "SubFoodDataTable";
            this.subFoodDataTableBindingSource2.DataSource = this.subFoodDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(187, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "料理名";
            // 
            // BzckBt
            // 
            this.BzckBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BzckBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BzckBt.Enabled = false;
            this.BzckBt.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BzckBt.ForeColor = System.Drawing.Color.Black;
            this.BzckBt.Location = new System.Drawing.Point(240, 399);
            this.BzckBt.Name = "BzckBt";
            this.BzckBt.Size = new System.Drawing.Size(300, 50);
            this.BzckBt.TabIndex = 7;
            this.BzckBt.Text = "BuzzCook!";
            this.BzckBt.UseMnemonic = false;
            this.BzckBt.UseVisualStyleBackColor = false;
            this.BzckBt.Click += new System.EventHandler(this.BzckBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(552, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "メイン食材";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(553, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "サブ食材１";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(553, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "サブ食材２";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(553, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "サブ食材３";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(82, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "が来店しています。";
            // 
            // EnemyPb
            // 
            this.EnemyPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EnemyPb.Location = new System.Drawing.Point(57, 240);
            this.EnemyPb.Name = "EnemyPb";
            this.EnemyPb.Size = new System.Drawing.Size(150, 145);
            this.EnemyPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyPb.TabIndex = 14;
            this.EnemyPb.TabStop = false;
            // 
            // AtkstLb
            // 
            this.AtkstLb.AutoSize = true;
            this.AtkstLb.BackColor = System.Drawing.Color.Transparent;
            this.AtkstLb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AtkstLb.Location = new System.Drawing.Point(600, 325);
            this.AtkstLb.Name = "AtkstLb";
            this.AtkstLb.Size = new System.Drawing.Size(67, 22);
            this.AtkstLb.TabIndex = 18;
            this.AtkstLb.Text = "攻撃力";
            // 
            // HlstLb
            // 
            this.HlstLb.AutoSize = true;
            this.HlstLb.BackColor = System.Drawing.Color.Transparent;
            this.HlstLb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HlstLb.Location = new System.Drawing.Point(600, 360);
            this.HlstLb.Name = "HlstLb";
            this.HlstLb.Size = new System.Drawing.Size(67, 22);
            this.HlstLb.TabIndex = 19;
            this.HlstLb.Text = "回復力";
            // 
            // AstLb
            // 
            this.AstLb.AutoSize = true;
            this.AstLb.BackColor = System.Drawing.Color.Transparent;
            this.AstLb.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AstLb.Location = new System.Drawing.Point(684, 318);
            this.AstLb.Name = "AstLb";
            this.AstLb.Size = new System.Drawing.Size(29, 33);
            this.AstLb.TabIndex = 20;
            this.AstLb.Text = "0";
            // 
            // HstLb
            // 
            this.HstLb.AutoSize = true;
            this.HstLb.BackColor = System.Drawing.Color.Transparent;
            this.HstLb.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HstLb.Location = new System.Drawing.Point(684, 353);
            this.HstLb.Name = "HstLb";
            this.HstLb.Size = new System.Drawing.Size(29, 33);
            this.HstLb.TabIndex = 21;
            this.HstLb.Text = "0";
            // 
            // EnemyTb
            // 
            this.EnemyTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EnemyTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnemyTb.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EnemyTb.ForeColor = System.Drawing.Color.Blue;
            this.EnemyTb.Location = new System.Drawing.Point(57, 175);
            this.EnemyTb.Name = "EnemyTb";
            this.EnemyTb.ReadOnly = true;
            this.EnemyTb.Size = new System.Drawing.Size(150, 25);
            this.EnemyTb.TabIndex = 22;
            this.EnemyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HellnumLb
            // 
            this.HellnumLb.AutoSize = true;
            this.HellnumLb.BackColor = System.Drawing.Color.Transparent;
            this.HellnumLb.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HellnumLb.ForeColor = System.Drawing.Color.Black;
            this.HellnumLb.Location = new System.Drawing.Point(180, 85);
            this.HellnumLb.Name = "HellnumLb";
            this.HellnumLb.Size = new System.Drawing.Size(29, 33);
            this.HellnumLb.TabIndex = 23;
            this.HellnumLb.Text = "0";
            // 
            // HappynumLb
            // 
            this.HappynumLb.AutoSize = true;
            this.HappynumLb.BackColor = System.Drawing.Color.Transparent;
            this.HappynumLb.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HappynumLb.Location = new System.Drawing.Point(178, 112);
            this.HappynumLb.Name = "HappynumLb";
            this.HappynumLb.Size = new System.Drawing.Size(29, 33);
            this.HappynumLb.TabIndex = 24;
            this.HappynumLb.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(54, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "昇天させた客数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(54, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "卒倒させた客数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(600, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "集客力";
            // 
            // ExpLb
            // 
            this.ExpLb.AutoSize = true;
            this.ExpLb.BackColor = System.Drawing.Color.Transparent;
            this.ExpLb.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpLb.Location = new System.Drawing.Point(684, 388);
            this.ExpLb.Name = "ExpLb";
            this.ExpLb.Size = new System.Drawing.Size(29, 33);
            this.ExpLb.TabIndex = 28;
            this.ExpLb.Text = "0";
            // 
            // Cook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuzzCookingFinal.Properties.Resources.cookimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.ExpLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HappynumLb);
            this.Controls.Add(this.HellnumLb);
            this.Controls.Add(this.EnemyTb);
            this.Controls.Add(this.HstLb);
            this.Controls.Add(this.AstLb);
            this.Controls.Add(this.HlstLb);
            this.Controls.Add(this.AtkstLb);
            this.Controls.Add(this.EnemyPb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BzckBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubCb1);
            this.Controls.Add(this.SubCb3);
            this.Controls.Add(this.SubCb2);
            this.Controls.Add(this.MainFoodCb);
            this.Controls.Add(this.MenuPb);
            this.Controls.Add(this.MenuCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFoodDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFoodDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MenuCb;
        private System.Windows.Forms.PictureBox MenuPb;
        private System.Windows.Forms.ComboBox MainFoodCb;
        private System.Windows.Forms.ComboBox SubCb2;
        private System.Windows.Forms.ComboBox SubCb3;
        private System.Windows.Forms.ComboBox SubCb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BzckBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox EnemyPb;
        private System.Windows.Forms.BindingSource menuDataTableBindingSource;
        private MenuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource mainFoodDataTableBindingSource;
        private MainFoodDataSet mainFoodDataSet;
        private System.Windows.Forms.BindingSource subFoodDataTableBindingSource;
        private SubFoodDataSet subFoodDataSet;
        private System.Windows.Forms.BindingSource subFoodDataTableBindingSource1;
        private System.Windows.Forms.BindingSource subFoodDataTableBindingSource2;
        private System.Windows.Forms.Label AtkstLb;
        private System.Windows.Forms.Label HlstLb;
        private System.Windows.Forms.Label AstLb;
        private System.Windows.Forms.Label HstLb;
        private System.Windows.Forms.TextBox EnemyTb;
        private System.Windows.Forms.Label HellnumLb;
        private System.Windows.Forms.Label HappynumLb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ExpLb;
    }
}