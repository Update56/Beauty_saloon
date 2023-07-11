namespace Project4.Code
{
    partial class Start_menu
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
            EntryButton = new System.Windows.Forms.Button();
            label_seed = new System.Windows.Forms.Label();
            label_amount = new System.Windows.Forms.Label();
            trackBar_amount = new System.Windows.Forms.TrackBar();
            textBox_seed = new System.Windows.Forms.TextBox();
            label_trackBar_low = new System.Windows.Forms.Label();
            label_trackBar_high = new System.Windows.Forms.Label();
            label_qual1 = new System.Windows.Forms.Label();
            comboBox_qual1 = new System.Windows.Forms.ComboBox();
            label_prof1 = new System.Windows.Forms.Label();
            comboBox_prof1 = new System.Windows.Forms.ComboBox();
            label_qual2 = new System.Windows.Forms.Label();
            comboBox_qual2 = new System.Windows.Forms.ComboBox();
            label_prof2 = new System.Windows.Forms.Label();
            comboBox_prof2 = new System.Windows.Forms.ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label_qual3 = new System.Windows.Forms.Label();
            comboBox_qual3 = new System.Windows.Forms.ComboBox();
            label_qual4 = new System.Windows.Forms.Label();
            comboBox_qual4 = new System.Windows.Forms.ComboBox();
            label_prof3 = new System.Windows.Forms.Label();
            label_prof4 = new System.Windows.Forms.Label();
            comboBox_prof3 = new System.Windows.Forms.ComboBox();
            comboBox_prof4 = new System.Windows.Forms.ComboBox();
            label_qual5 = new System.Windows.Forms.Label();
            label_qual7 = new System.Windows.Forms.Label();
            comboBox_qual5 = new System.Windows.Forms.ComboBox();
            label_qual6 = new System.Windows.Forms.Label();
            comboBox_qual7 = new System.Windows.Forms.ComboBox();
            comboBox_qual6 = new System.Windows.Forms.ComboBox();
            label_qual8 = new System.Windows.Forms.Label();
            label_prof5 = new System.Windows.Forms.Label();
            comboBox_qual8 = new System.Windows.Forms.ComboBox();
            label_prof6 = new System.Windows.Forms.Label();
            label_prof7 = new System.Windows.Forms.Label();
            comboBox_prof5 = new System.Windows.Forms.ComboBox();
            label_prof8 = new System.Windows.Forms.Label();
            comboBox_prof6 = new System.Windows.Forms.ComboBox();
            comboBox_prof7 = new System.Windows.Forms.ComboBox();
            comboBox_prof8 = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            groupBox8 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)trackBar_amount).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // EntryButton
            // 
            EntryButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EntryButton.Location = new System.Drawing.Point(237, 632);
            EntryButton.Name = "EntryButton";
            EntryButton.Size = new System.Drawing.Size(71, 35);
            EntryButton.TabIndex = 1;
            EntryButton.Text = "Ввод";
            EntryButton.UseVisualStyleBackColor = true;
            EntryButton.Click += EntryButton_Click;
            // 
            // label_seed
            // 
            label_seed.AutoSize = true;
            label_seed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_seed.Location = new System.Drawing.Point(12, 9);
            label_seed.Name = "label_seed";
            label_seed.Size = new System.Drawing.Size(165, 32);
            label_seed.TabIndex = 2;
            label_seed.Text = "Введите ключ генератора \r\nслучайных чисел";
            // 
            // label_amount
            // 
            label_amount.AutoSize = true;
            label_amount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_amount.Location = new System.Drawing.Point(183, 9);
            label_amount.Name = "label_amount";
            label_amount.Size = new System.Drawing.Size(132, 32);
            label_amount.TabIndex = 2;
            label_amount.Text = "Введите количество \r\nмастеров\r\n";
            // 
            // trackBar_amount
            // 
            trackBar_amount.LargeChange = 1;
            trackBar_amount.Location = new System.Drawing.Point(183, 44);
            trackBar_amount.Maximum = 8;
            trackBar_amount.Minimum = 1;
            trackBar_amount.Name = "trackBar_amount";
            trackBar_amount.Size = new System.Drawing.Size(104, 45);
            trackBar_amount.TabIndex = 1;
            trackBar_amount.Value = 1;
            trackBar_amount.Scroll += trackBar_amount_Scroll;
            // 
            // textBox_seed
            // 
            textBox_seed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox_seed.Location = new System.Drawing.Point(12, 44);
            textBox_seed.Name = "textBox_seed";
            textBox_seed.Size = new System.Drawing.Size(153, 21);
            textBox_seed.TabIndex = 3;
            // 
            // label_trackBar_low
            // 
            label_trackBar_low.AutoSize = true;
            label_trackBar_low.Location = new System.Drawing.Point(191, 72);
            label_trackBar_low.Name = "label_trackBar_low";
            label_trackBar_low.Size = new System.Drawing.Size(13, 15);
            label_trackBar_low.TabIndex = 4;
            label_trackBar_low.Text = "1";
            // 
            // label_trackBar_high
            // 
            label_trackBar_high.AutoSize = true;
            label_trackBar_high.Location = new System.Drawing.Point(268, 72);
            label_trackBar_high.Name = "label_trackBar_high";
            label_trackBar_high.Size = new System.Drawing.Size(13, 15);
            label_trackBar_high.TabIndex = 4;
            label_trackBar_high.Text = "8";
            // 
            // label_qual1
            // 
            label_qual1.AutoSize = true;
            label_qual1.Location = new System.Drawing.Point(4, 28);
            label_qual1.Name = "label_qual1";
            label_qual1.Size = new System.Drawing.Size(88, 15);
            label_qual1.TabIndex = 6;
            label_qual1.Text = "Квалификация";
            // 
            // comboBox_qual1
            // 
            comboBox_qual1.FormattingEnabled = true;
            comboBox_qual1.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual1.Location = new System.Drawing.Point(4, 47);
            comboBox_qual1.Name = "comboBox_qual1";
            comboBox_qual1.Size = new System.Drawing.Size(121, 23);
            comboBox_qual1.TabIndex = 7;
            // 
            // label_prof1
            // 
            label_prof1.AutoSize = true;
            label_prof1.Location = new System.Drawing.Point(4, 75);
            label_prof1.Name = "label_prof1";
            label_prof1.Size = new System.Drawing.Size(112, 15);
            label_prof1.TabIndex = 6;
            label_prof1.Text = "Профессионализм";
            // 
            // comboBox_prof1
            // 
            comboBox_prof1.FormattingEnabled = true;
            comboBox_prof1.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof1.Location = new System.Drawing.Point(4, 94);
            comboBox_prof1.Name = "comboBox_prof1";
            comboBox_prof1.Size = new System.Drawing.Size(121, 23);
            comboBox_prof1.TabIndex = 7;
            // 
            // label_qual2
            // 
            label_qual2.AutoSize = true;
            label_qual2.Location = new System.Drawing.Point(4, 28);
            label_qual2.Name = "label_qual2";
            label_qual2.Size = new System.Drawing.Size(88, 15);
            label_qual2.TabIndex = 6;
            label_qual2.Text = "Квалификация";
            // 
            // comboBox_qual2
            // 
            comboBox_qual2.FormattingEnabled = true;
            comboBox_qual2.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual2.Location = new System.Drawing.Point(4, 47);
            comboBox_qual2.Name = "comboBox_qual2";
            comboBox_qual2.Size = new System.Drawing.Size(121, 23);
            comboBox_qual2.TabIndex = 7;
            // 
            // label_prof2
            // 
            label_prof2.AutoSize = true;
            label_prof2.Location = new System.Drawing.Point(4, 75);
            label_prof2.Name = "label_prof2";
            label_prof2.Size = new System.Drawing.Size(112, 15);
            label_prof2.TabIndex = 6;
            label_prof2.Text = "Профессионализм";
            // 
            // comboBox_prof2
            // 
            comboBox_prof2.FormattingEnabled = true;
            comboBox_prof2.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof2.Location = new System.Drawing.Point(4, 94);
            comboBox_prof2.Name = "comboBox_prof2";
            comboBox_prof2.Size = new System.Drawing.Size(121, 23);
            comboBox_prof2.TabIndex = 7;
            // 
            // label_qual3
            // 
            label_qual3.AutoSize = true;
            label_qual3.Location = new System.Drawing.Point(4, 28);
            label_qual3.Name = "label_qual3";
            label_qual3.Size = new System.Drawing.Size(88, 15);
            label_qual3.TabIndex = 6;
            label_qual3.Text = "Квалификация";
            // 
            // comboBox_qual3
            // 
            comboBox_qual3.FormattingEnabled = true;
            comboBox_qual3.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual3.Location = new System.Drawing.Point(4, 47);
            comboBox_qual3.Name = "comboBox_qual3";
            comboBox_qual3.Size = new System.Drawing.Size(121, 23);
            comboBox_qual3.TabIndex = 7;
            // 
            // label_qual4
            // 
            label_qual4.AutoSize = true;
            label_qual4.Location = new System.Drawing.Point(4, 28);
            label_qual4.Name = "label_qual4";
            label_qual4.Size = new System.Drawing.Size(88, 15);
            label_qual4.TabIndex = 6;
            label_qual4.Text = "Квалификация";
            // 
            // comboBox_qual4
            // 
            comboBox_qual4.FormattingEnabled = true;
            comboBox_qual4.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual4.Location = new System.Drawing.Point(4, 47);
            comboBox_qual4.Name = "comboBox_qual4";
            comboBox_qual4.Size = new System.Drawing.Size(121, 23);
            comboBox_qual4.TabIndex = 7;
            // 
            // label_prof3
            // 
            label_prof3.AutoSize = true;
            label_prof3.Location = new System.Drawing.Point(4, 75);
            label_prof3.Name = "label_prof3";
            label_prof3.Size = new System.Drawing.Size(112, 15);
            label_prof3.TabIndex = 6;
            label_prof3.Text = "Профессионализм";
            // 
            // label_prof4
            // 
            label_prof4.AutoSize = true;
            label_prof4.Location = new System.Drawing.Point(4, 75);
            label_prof4.Name = "label_prof4";
            label_prof4.Size = new System.Drawing.Size(112, 15);
            label_prof4.TabIndex = 6;
            label_prof4.Text = "Профессионализм";
            // 
            // comboBox_prof3
            // 
            comboBox_prof3.FormattingEnabled = true;
            comboBox_prof3.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof3.Location = new System.Drawing.Point(4, 94);
            comboBox_prof3.Name = "comboBox_prof3";
            comboBox_prof3.Size = new System.Drawing.Size(121, 23);
            comboBox_prof3.TabIndex = 7;
            // 
            // comboBox_prof4
            // 
            comboBox_prof4.FormattingEnabled = true;
            comboBox_prof4.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof4.Location = new System.Drawing.Point(4, 94);
            comboBox_prof4.Name = "comboBox_prof4";
            comboBox_prof4.Size = new System.Drawing.Size(121, 23);
            comboBox_prof4.TabIndex = 7;
            // 
            // label_qual5
            // 
            label_qual5.AutoSize = true;
            label_qual5.Location = new System.Drawing.Point(4, 28);
            label_qual5.Name = "label_qual5";
            label_qual5.Size = new System.Drawing.Size(88, 15);
            label_qual5.TabIndex = 6;
            label_qual5.Text = "Квалификация";
            // 
            // label_qual7
            // 
            label_qual7.AutoSize = true;
            label_qual7.Location = new System.Drawing.Point(4, 28);
            label_qual7.Name = "label_qual7";
            label_qual7.Size = new System.Drawing.Size(88, 15);
            label_qual7.TabIndex = 6;
            label_qual7.Text = "Квалификация";
            // 
            // comboBox_qual5
            // 
            comboBox_qual5.FormattingEnabled = true;
            comboBox_qual5.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual5.Location = new System.Drawing.Point(4, 47);
            comboBox_qual5.Name = "comboBox_qual5";
            comboBox_qual5.Size = new System.Drawing.Size(121, 23);
            comboBox_qual5.TabIndex = 7;
            // 
            // label_qual6
            // 
            label_qual6.AutoSize = true;
            label_qual6.Location = new System.Drawing.Point(4, 28);
            label_qual6.Name = "label_qual6";
            label_qual6.Size = new System.Drawing.Size(88, 15);
            label_qual6.TabIndex = 6;
            label_qual6.Text = "Квалификация";
            // 
            // comboBox_qual7
            // 
            comboBox_qual7.FormattingEnabled = true;
            comboBox_qual7.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual7.Location = new System.Drawing.Point(4, 47);
            comboBox_qual7.Name = "comboBox_qual7";
            comboBox_qual7.Size = new System.Drawing.Size(121, 23);
            comboBox_qual7.TabIndex = 7;
            // 
            // comboBox_qual6
            // 
            comboBox_qual6.FormattingEnabled = true;
            comboBox_qual6.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual6.Location = new System.Drawing.Point(4, 47);
            comboBox_qual6.Name = "comboBox_qual6";
            comboBox_qual6.Size = new System.Drawing.Size(121, 23);
            comboBox_qual6.TabIndex = 7;
            // 
            // label_qual8
            // 
            label_qual8.AutoSize = true;
            label_qual8.Location = new System.Drawing.Point(4, 28);
            label_qual8.Name = "label_qual8";
            label_qual8.Size = new System.Drawing.Size(88, 15);
            label_qual8.TabIndex = 6;
            label_qual8.Text = "Квалификация";
            // 
            // label_prof5
            // 
            label_prof5.AutoSize = true;
            label_prof5.Location = new System.Drawing.Point(4, 75);
            label_prof5.Name = "label_prof5";
            label_prof5.Size = new System.Drawing.Size(112, 15);
            label_prof5.TabIndex = 6;
            label_prof5.Text = "Профессионализм";
            // 
            // comboBox_qual8
            // 
            comboBox_qual8.FormattingEnabled = true;
            comboBox_qual8.Items.AddRange(new object[] { "Парикмахер", "Визажист", "Маникюрщик" });
            comboBox_qual8.Location = new System.Drawing.Point(4, 47);
            comboBox_qual8.Name = "comboBox_qual8";
            comboBox_qual8.Size = new System.Drawing.Size(121, 23);
            comboBox_qual8.TabIndex = 7;
            // 
            // label_prof6
            // 
            label_prof6.AutoSize = true;
            label_prof6.Location = new System.Drawing.Point(4, 75);
            label_prof6.Name = "label_prof6";
            label_prof6.Size = new System.Drawing.Size(112, 15);
            label_prof6.TabIndex = 6;
            label_prof6.Text = "Профессионализм";
            // 
            // label_prof7
            // 
            label_prof7.AutoSize = true;
            label_prof7.Location = new System.Drawing.Point(4, 75);
            label_prof7.Name = "label_prof7";
            label_prof7.Size = new System.Drawing.Size(112, 15);
            label_prof7.TabIndex = 6;
            label_prof7.Text = "Профессионализм";
            // 
            // comboBox_prof5
            // 
            comboBox_prof5.FormattingEnabled = true;
            comboBox_prof5.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof5.Location = new System.Drawing.Point(4, 94);
            comboBox_prof5.Name = "comboBox_prof5";
            comboBox_prof5.Size = new System.Drawing.Size(121, 23);
            comboBox_prof5.TabIndex = 7;
            // 
            // label_prof8
            // 
            label_prof8.AutoSize = true;
            label_prof8.Location = new System.Drawing.Point(4, 75);
            label_prof8.Name = "label_prof8";
            label_prof8.Size = new System.Drawing.Size(112, 15);
            label_prof8.TabIndex = 6;
            label_prof8.Text = "Профессионализм";
            // 
            // comboBox_prof6
            // 
            comboBox_prof6.FormattingEnabled = true;
            comboBox_prof6.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof6.Location = new System.Drawing.Point(4, 94);
            comboBox_prof6.Name = "comboBox_prof6";
            comboBox_prof6.Size = new System.Drawing.Size(121, 23);
            comboBox_prof6.TabIndex = 7;
            // 
            // comboBox_prof7
            // 
            comboBox_prof7.FormattingEnabled = true;
            comboBox_prof7.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof7.Location = new System.Drawing.Point(4, 94);
            comboBox_prof7.Name = "comboBox_prof7";
            comboBox_prof7.Size = new System.Drawing.Size(121, 23);
            comboBox_prof7.TabIndex = 7;
            // 
            // comboBox_prof8
            // 
            comboBox_prof8.FormattingEnabled = true;
            comboBox_prof8.Items.AddRange(new object[] { "Новичок", "Опытный", "Профессионал", "Мастер" });
            comboBox_prof8.Location = new System.Drawing.Point(4, 94);
            comboBox_prof8.Name = "comboBox_prof8";
            comboBox_prof8.Size = new System.Drawing.Size(121, 23);
            comboBox_prof8.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_prof1);
            groupBox1.Controls.Add(label_prof1);
            groupBox1.Controls.Add(comboBox_qual1);
            groupBox1.Controls.Add(label_qual1);
            groupBox1.Location = new System.Drawing.Point(10, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(130, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Мастер 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox_prof2);
            groupBox2.Controls.Add(label_prof2);
            groupBox2.Controls.Add(comboBox_qual2);
            groupBox2.Controls.Add(label_qual2);
            groupBox2.Enabled = false;
            groupBox2.Location = new System.Drawing.Point(165, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(130, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Мастер 2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox_prof3);
            groupBox3.Controls.Add(label_prof3);
            groupBox3.Controls.Add(comboBox_qual3);
            groupBox3.Controls.Add(label_qual3);
            groupBox3.Enabled = false;
            groupBox3.Location = new System.Drawing.Point(10, 230);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(130, 125);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Мастер 3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox_prof4);
            groupBox4.Controls.Add(label_prof4);
            groupBox4.Controls.Add(comboBox_qual4);
            groupBox4.Controls.Add(label_qual4);
            groupBox4.Enabled = false;
            groupBox4.Location = new System.Drawing.Point(165, 230);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(130, 125);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Мастер 4";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox_prof5);
            groupBox5.Controls.Add(label_prof5);
            groupBox5.Controls.Add(comboBox_qual5);
            groupBox5.Controls.Add(label_qual5);
            groupBox5.Enabled = false;
            groupBox5.Location = new System.Drawing.Point(10, 360);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(130, 125);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Мастер 5";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(comboBox_prof6);
            groupBox6.Controls.Add(label_prof6);
            groupBox6.Controls.Add(comboBox_qual6);
            groupBox6.Controls.Add(label_qual6);
            groupBox6.Enabled = false;
            groupBox6.Location = new System.Drawing.Point(165, 360);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(130, 125);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Мастер 6";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(comboBox_prof7);
            groupBox7.Controls.Add(label_prof7);
            groupBox7.Controls.Add(comboBox_qual7);
            groupBox7.Controls.Add(label_qual7);
            groupBox7.Enabled = false;
            groupBox7.Location = new System.Drawing.Point(10, 490);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(130, 125);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "Мастер 7";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(comboBox_prof8);
            groupBox8.Controls.Add(label_prof8);
            groupBox8.Controls.Add(comboBox_qual8);
            groupBox8.Controls.Add(label_qual8);
            groupBox8.Enabled = false;
            groupBox8.Location = new System.Drawing.Point(165, 490);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new System.Drawing.Size(130, 125);
            groupBox8.TabIndex = 15;
            groupBox8.TabStop = false;
            groupBox8.Text = "Мастер 8";
            // 
            // Start_menu
            // 
            AcceptButton = EntryButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(320, 679);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label_trackBar_high);
            Controls.Add(label_trackBar_low);
            Controls.Add(textBox_seed);
            Controls.Add(trackBar_amount);
            Controls.Add(label_amount);
            Controls.Add(label_seed);
            Controls.Add(EntryButton);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Start_menu";
            ShowInTaskbar = false;
            Text = "Start_menu";
            Load += Start_menu_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar_amount).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.Label label_seed;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TrackBar trackBar_amount;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Label label_trackBar_low;
        private System.Windows.Forms.Label label_trackBar_high;
        private System.Windows.Forms.Label label_qual1;
        private System.Windows.Forms.ComboBox comboBox_qual1;
        private System.Windows.Forms.Label label_prof1;
        private System.Windows.Forms.ComboBox comboBox_prof1;
        private System.Windows.Forms.Label label_qual2;
        private System.Windows.Forms.ComboBox comboBox_qual2;
        private System.Windows.Forms.Label label_prof2;
        private System.Windows.Forms.ComboBox comboBox_prof2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label_qual3;
        private System.Windows.Forms.ComboBox comboBox_qual3;
        private System.Windows.Forms.Label label_qual4;
        private System.Windows.Forms.ComboBox comboBox_qual4;
        private System.Windows.Forms.Label label_prof3;
        private System.Windows.Forms.Label label_prof4;
        private System.Windows.Forms.ComboBox comboBox_prof3;
        private System.Windows.Forms.ComboBox comboBox_prof4;
        private System.Windows.Forms.Label label_qual5;
        private System.Windows.Forms.Label label_qual7;
        private System.Windows.Forms.ComboBox comboBox_qual5;
        private System.Windows.Forms.Label label_qual6;
        private System.Windows.Forms.ComboBox comboBox_qual7;
        private System.Windows.Forms.ComboBox comboBox_qual6;
        private System.Windows.Forms.Label label_qual8;
        private System.Windows.Forms.Label label_prof5;
        private System.Windows.Forms.ComboBox comboBox_qual8;
        private System.Windows.Forms.Label label_prof6;
        private System.Windows.Forms.Label label_prof7;
        private System.Windows.Forms.ComboBox comboBox_prof5;
        private System.Windows.Forms.Label label_prof8;
        private System.Windows.Forms.ComboBox comboBox_prof6;
        private System.Windows.Forms.ComboBox comboBox_prof7;
        private System.Windows.Forms.ComboBox comboBox_prof8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}