namespace HeartMath
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Create = new System.Windows.Forms.Button();
            this.Kol = new System.Windows.Forms.Label();
            this.ModBut = new System.Windows.Forms.Button();
            this.Mnoj = new System.Windows.Forms.Label();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MnojText = new System.Windows.Forms.NumericUpDown();
            this.KolText = new System.Windows.Forms.NumericUpDown();
            this.Fat = new System.Windows.Forms.NumericUpDown();
            this.StartPosition = new System.Windows.Forms.NumericUpDown();
            this.Fatl = new System.Windows.Forms.Label();
            this.PositL = new System.Windows.Forms.Label();
            this.StartPoint = new System.Windows.Forms.TextBox();
            this.NacPointL = new System.Windows.Forms.Label();
            this.Colorb = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.CheckBox();
            this.Dinamic = new System.Windows.Forms.CheckBox();
            this.Colorl = new System.Windows.Forms.Label();
            this.ModGroup = new System.Windows.Forms.GroupBox();
            this.ColorRandom = new System.Windows.Forms.CheckBox();
            this.KonMnoj = new System.Windows.Forms.NumericUpDown();
            this.Km = new System.Windows.Forms.Label();
            this.UpMnoj = new System.Windows.Forms.NumericUpDown();
            this.DLFile = new System.Windows.Forms.Button();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.Speed = new System.Windows.Forms.Label();
            this.MnojPlus = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Prov = new System.Windows.Forms.ProgressBar();
            this.pb = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Mn = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveScreen = new System.Windows.Forms.CheckBox();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MnojText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPosition)).BeginInit();
            this.ModGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KonMnoj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpMnoj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.Info;
            this.Create.Location = new System.Drawing.Point(12, 213);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(171, 39);
            this.Create.TabIndex = 0;
            this.Create.Text = "Старт";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Create_MouseClick);
            // 
            // Kol
            // 
            this.Kol.AutoSize = true;
            this.Kol.Location = new System.Drawing.Point(0, 19);
            this.Kol.Name = "Kol";
            this.Kol.Size = new System.Drawing.Size(97, 13);
            this.Kol.TabIndex = 3;
            this.Kol.Text = "Количество точек";
            // 
            // ModBut
            // 
            this.ModBut.Location = new System.Drawing.Point(12, 287);
            this.ModBut.Name = "ModBut";
            this.ModBut.Size = new System.Drawing.Size(140, 30);
            this.ModBut.TabIndex = 6;
            this.ModBut.Text = "Модификатор поворота";
            this.ModBut.UseVisualStyleBackColor = true;
            this.ModBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModBut_MouseClick);
            // 
            // Mnoj
            // 
            this.Mnoj.AutoSize = true;
            this.Mnoj.Location = new System.Drawing.Point(0, 58);
            this.Mnoj.Name = "Mnoj";
            this.Mnoj.Size = new System.Drawing.Size(65, 13);
            this.Mnoj.TabIndex = 7;
            this.Mnoj.Text = "Множитель";
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.MnojText);
            this.MainGroup.Controls.Add(this.KolText);
            this.MainGroup.Controls.Add(this.Fat);
            this.MainGroup.Controls.Add(this.StartPosition);
            this.MainGroup.Controls.Add(this.Fatl);
            this.MainGroup.Controls.Add(this.PositL);
            this.MainGroup.Controls.Add(this.StartPoint);
            this.MainGroup.Controls.Add(this.NacPointL);
            this.MainGroup.Controls.Add(this.Colorb);
            this.MainGroup.Controls.Add(this.Number);
            this.MainGroup.Controls.Add(this.Dinamic);
            this.MainGroup.Controls.Add(this.Colorl);
            this.MainGroup.Controls.Add(this.Mnoj);
            this.MainGroup.Controls.Add(this.Kol);
            this.MainGroup.Location = new System.Drawing.Point(12, 24);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(0);
            this.MainGroup.Size = new System.Drawing.Size(207, 183);
            this.MainGroup.TabIndex = 8;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Основа";
            // 
            // MnojText
            // 
            this.MnojText.Location = new System.Drawing.Point(4, 74);
            this.MnojText.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.MnojText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MnojText.Name = "MnojText";
            this.MnojText.Size = new System.Drawing.Size(71, 20);
            this.MnojText.TabIndex = 18;
            this.MnojText.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // KolText
            // 
            this.KolText.Location = new System.Drawing.Point(4, 36);
            this.KolText.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.KolText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KolText.Name = "KolText";
            this.KolText.Size = new System.Drawing.Size(56, 20);
            this.KolText.TabIndex = 11;
            this.KolText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Fat
            // 
            this.Fat.Location = new System.Drawing.Point(119, 156);
            this.Fat.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Fat.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Fat.Name = "Fat";
            this.Fat.Size = new System.Drawing.Size(77, 20);
            this.Fat.TabIndex = 17;
            this.Fat.UseWaitCursor = true;
            this.Fat.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // StartPosition
            // 
            this.StartPosition.Location = new System.Drawing.Point(106, 78);
            this.StartPosition.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.StartPosition.Name = "StartPosition";
            this.StartPosition.Size = new System.Drawing.Size(75, 20);
            this.StartPosition.TabIndex = 8;
            this.StartPosition.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            // 
            // Fatl
            // 
            this.Fatl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fatl.AutoSize = true;
            this.Fatl.Location = new System.Drawing.Point(113, 136);
            this.Fatl.Name = "Fatl";
            this.Fatl.Size = new System.Drawing.Size(86, 13);
            this.Fatl.TabIndex = 16;
            this.Fatl.Text = "Толщина линий";
            // 
            // PositL
            // 
            this.PositL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PositL.AutoSize = true;
            this.PositL.Location = new System.Drawing.Point(103, 58);
            this.PositL.Name = "PositL";
            this.PositL.Size = new System.Drawing.Size(107, 13);
            this.PositL.TabIndex = 13;
            this.PositL.Text = "Начальная позиция";
            // 
            // StartPoint
            // 
            this.StartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPoint.Location = new System.Drawing.Point(106, 35);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(73, 20);
            this.StartPoint.TabIndex = 12;
            this.StartPoint.Text = "0";
            this.StartPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BedasVvodom_KeyPress);
            // 
            // NacPointL
            // 
            this.NacPointL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NacPointL.AutoSize = true;
            this.NacPointL.Location = new System.Drawing.Point(103, 19);
            this.NacPointL.Name = "NacPointL";
            this.NacPointL.Size = new System.Drawing.Size(94, 13);
            this.NacPointL.TabIndex = 11;
            this.NacPointL.Text = "Начальное число";
            // 
            // Colorb
            // 
            this.Colorb.BackColor = System.Drawing.Color.Red;
            this.Colorb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Colorb.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Colorb.FlatAppearance.BorderSize = 0;
            this.Colorb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Colorb.ForeColor = System.Drawing.SystemColors.Control;
            this.Colorb.Location = new System.Drawing.Point(40, 149);
            this.Colorb.Name = "Colorb";
            this.Colorb.Size = new System.Drawing.Size(60, 23);
            this.Colorb.TabIndex = 10;
            this.Colorb.UseVisualStyleBackColor = false;
            this.Colorb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_MouseClick);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(3, 123);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(104, 17);
            this.Number.TabIndex = 9;
            this.Number.Text = "Числа на круге";
            this.Number.UseVisualStyleBackColor = true;
            // 
            // Dinamic
            // 
            this.Dinamic.AutoSize = true;
            this.Dinamic.Location = new System.Drawing.Point(3, 100);
            this.Dinamic.Name = "Dinamic";
            this.Dinamic.Size = new System.Drawing.Size(164, 17);
            this.Dinamic.TabIndex = 8;
            this.Dinamic.Text = "Динамическое построение";
            this.Dinamic.UseVisualStyleBackColor = true;
            // 
            // Colorl
            // 
            this.Colorl.AutoSize = true;
            this.Colorl.Location = new System.Drawing.Point(0, 151);
            this.Colorl.Name = "Colorl";
            this.Colorl.Size = new System.Drawing.Size(32, 13);
            this.Colorl.TabIndex = 8;
            this.Colorl.Text = "Цвет";
            // 
            // ModGroup
            // 
            this.ModGroup.Controls.Add(this.SaveScreen);
            this.ModGroup.Controls.Add(this.ColorRandom);
            this.ModGroup.Controls.Add(this.KonMnoj);
            this.ModGroup.Controls.Add(this.Km);
            this.ModGroup.Controls.Add(this.UpMnoj);
            this.ModGroup.Controls.Add(this.DLFile);
            this.ModGroup.Controls.Add(this.SpeedBar);
            this.ModGroup.Controls.Add(this.Speed);
            this.ModGroup.Controls.Add(this.MnojPlus);
            this.ModGroup.Controls.Add(this.Exit);
            this.ModGroup.Location = new System.Drawing.Point(12, 323);
            this.ModGroup.Name = "ModGroup";
            this.ModGroup.Size = new System.Drawing.Size(171, 189);
            this.ModGroup.TabIndex = 9;
            this.ModGroup.TabStop = false;
            this.ModGroup.Text = "Модификация";
            this.ModGroup.Visible = false;
            // 
            // ColorRandom
            // 
            this.ColorRandom.AutoSize = true;
            this.ColorRandom.Location = new System.Drawing.Point(8, 13);
            this.ColorRandom.Name = "ColorRandom";
            this.ColorRandom.Size = new System.Drawing.Size(93, 17);
            this.ColorRandom.TabIndex = 11;
            this.ColorRandom.Text = "Random Color";
            this.ColorRandom.UseVisualStyleBackColor = true;
            // 
            // KonMnoj
            // 
            this.KonMnoj.Location = new System.Drawing.Point(9, 92);
            this.KonMnoj.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.KonMnoj.Name = "KonMnoj";
            this.KonMnoj.Size = new System.Drawing.Size(85, 20);
            this.KonMnoj.TabIndex = 10;
            this.KonMnoj.ValueChanged += new System.EventHandler(this.KonMnoj_ValueChanged);
            // 
            // Km
            // 
            this.Km.AutoSize = true;
            this.Km.Location = new System.Drawing.Point(6, 73);
            this.Km.Name = "Km";
            this.Km.Size = new System.Drawing.Size(88, 13);
            this.Km.TabIndex = 9;
            this.Km.Text = "Конечный множ";
            // 
            // UpMnoj
            // 
            this.UpMnoj.Location = new System.Drawing.Point(9, 50);
            this.UpMnoj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpMnoj.Name = "UpMnoj";
            this.UpMnoj.Size = new System.Drawing.Size(85, 20);
            this.UpMnoj.TabIndex = 8;
            this.UpMnoj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DLFile
            // 
            this.DLFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DLFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DLFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DLFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.DLFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DLFile.Location = new System.Drawing.Point(125, 9);
            this.DLFile.Name = "DLFile";
            this.DLFile.Size = new System.Drawing.Size(23, 22);
            this.DLFile.TabIndex = 7;
            this.DLFile.UseVisualStyleBackColor = false;
            this.DLFile.Click += new System.EventHandler(this.DLFile_Click);
            // 
            // SpeedBar
            // 
            this.SpeedBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SpeedBar.LargeChange = 1;
            this.SpeedBar.Location = new System.Drawing.Point(6, 141);
            this.SpeedBar.Maximum = 50;
            this.SpeedBar.Minimum = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(147, 45);
            this.SpeedBar.TabIndex = 6;
            this.SpeedBar.Value = 10;
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(5, 115);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(55, 13);
            this.Speed.TabIndex = 5;
            this.Speed.Text = "Скорость";
            // 
            // MnojPlus
            // 
            this.MnojPlus.AutoSize = true;
            this.MnojPlus.Location = new System.Drawing.Point(6, 34);
            this.MnojPlus.Name = "MnojPlus";
            this.MnojPlus.Size = new System.Drawing.Size(143, 13);
            this.MnojPlus.TabIndex = 3;
            this.MnojPlus.Text = "Увеличение множителя на";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit.BackgroundImage = global::HeartMath.Properties.Resources.Exit2;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(148, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 22);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseClick);
            // 
            // Prov
            // 
            this.Prov.BackColor = System.Drawing.SystemColors.Control;
            this.Prov.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Prov.Location = new System.Drawing.Point(12, 258);
            this.Prov.Maximum = 2;
            this.Prov.Name = "Prov";
            this.Prov.Size = new System.Drawing.Size(170, 23);
            this.Prov.Step = 50;
            this.Prov.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Prov.TabIndex = 10;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.Location = new System.Drawing.Point(225, 25);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(501, 501);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.Red;
            this.colorDialog.FullOpen = true;
            // 
            // Mn
            // 
            this.Mn.AutoSize = true;
            this.Mn.Location = new System.Drawing.Point(15, 259);
            this.Mn.Name = "Mn";
            this.Mn.Size = new System.Drawing.Size(22, 13);
            this.Mn.TabIndex = 11;
            this.Mn.Text = "Mn";
            this.Mn.Visible = false;
            // 
            // SaveScreen
            // 
            this.SaveScreen.AutoSize = true;
            this.SaveScreen.Location = new System.Drawing.Point(73, 118);
            this.SaveScreen.Name = "SaveScreen";
            this.SaveScreen.Size = new System.Drawing.Size(88, 17);
            this.SaveScreen.TabIndex = 12;
            this.SaveScreen.Text = "Save Screen";
            this.SaveScreen.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Mn);
            this.Controls.Add(this.Prov);
            this.Controls.Add(this.ModGroup);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.ModBut);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Таблица умножения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MnojText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPosition)).EndInit();
            this.ModGroup.ResumeLayout(false);
            this.ModGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KonMnoj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpMnoj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label Kol;
        private System.Windows.Forms.Button ModBut;
        private System.Windows.Forms.Label Mnoj;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label Colorl;
        private System.Windows.Forms.GroupBox ModGroup;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ProgressBar Prov;
        private System.Windows.Forms.CheckBox Dinamic;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label MnojPlus;
        private System.Windows.Forms.Button Colorb;
        private System.Windows.Forms.CheckBox Number;
        private System.Windows.Forms.Button DLFile;
        private System.Windows.Forms.Label PositL;
        private System.Windows.Forms.TextBox StartPoint;
        private System.Windows.Forms.Label NacPointL;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label Fatl;
        private System.Windows.Forms.NumericUpDown Fat;
        private new System.Windows.Forms.NumericUpDown StartPosition;
        private System.Windows.Forms.NumericUpDown UpMnoj;
        private System.Windows.Forms.NumericUpDown MnojText;
        private System.Windows.Forms.NumericUpDown KolText;
        private System.Windows.Forms.NumericUpDown KonMnoj;
        private System.Windows.Forms.Label Km;
        private System.Windows.Forms.Label Mn;
        private System.Windows.Forms.CheckBox ColorRandom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox SaveScreen;
    }
}

