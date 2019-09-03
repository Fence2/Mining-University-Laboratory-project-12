namespace ex12._1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.gradientButton = new System.Windows.Forms.Button();
            this.dots1000 = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.blackButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Button();
            this.colorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientTrackBar = new System.Windows.Forms.TrackBar();
            this.gradientPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.oneColorPanel = new System.Windows.Forms.Panel();
            this.oneColorPlayButton = new System.Windows.Forms.Button();
            this.radioButton_B = new System.Windows.Forms.RadioButton();
            this.radioButton_G = new System.Windows.Forms.RadioButton();
            this.radioButton_R = new System.Windows.Forms.RadioButton();
            this.circleOfLifeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientTrackBar)).BeginInit();
            this.gradientPanel.SuspendLayout();
            this.oneColorPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 507);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 525);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(271, 96);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(289, 525);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(263, 96);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // gradientButton
            // 
            this.gradientButton.Location = new System.Drawing.Point(3, 80);
            this.gradientButton.Name = "gradientButton";
            this.gradientButton.Size = new System.Drawing.Size(149, 53);
            this.gradientButton.TabIndex = 3;
            this.gradientButton.Text = "Конвертировать в ЧБ";
            this.gradientButton.UseVisualStyleBackColor = true;
            this.gradientButton.Click += new System.EventHandler(this.gradientButton_Click);
            // 
            // dots1000
            // 
            this.dots1000.Location = new System.Drawing.Point(558, 290);
            this.dots1000.Name = "dots1000";
            this.dots1000.Size = new System.Drawing.Size(293, 58);
            this.dots1000.TabIndex = 5;
            this.dots1000.Text = "Добавить 1000 рандомных точек";
            this.dots1000.UseVisualStyleBackColor = true;
            this.dots1000.Click += new System.EventHandler(this.dots1000_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.colorPanel.Controls.Add(this.blackButton);
            this.colorPanel.Controls.Add(this.whiteButton);
            this.colorPanel.Controls.Add(this.blueButton);
            this.colorPanel.Controls.Add(this.greenButton);
            this.colorPanel.Controls.Add(this.yellowButton);
            this.colorPanel.Controls.Add(this.label2);
            this.colorPanel.Controls.Add(this.redButton);
            this.colorPanel.Controls.Add(this.colorNumericUpDown);
            this.colorPanel.Controls.Add(this.label1);
            this.colorPanel.Location = new System.Drawing.Point(558, 12);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(229, 133);
            this.colorPanel.TabIndex = 0;
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blackButton.Location = new System.Drawing.Point(189, 91);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(30, 30);
            this.blackButton.TabIndex = 9;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.whiteButton.Location = new System.Drawing.Point(153, 91);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(30, 30);
            this.whiteButton.TabIndex = 8;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blueButton.Location = new System.Drawing.Point(117, 91);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(30, 30);
            this.blueButton.TabIndex = 7;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Lime;
            this.greenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.greenButton.Location = new System.Drawing.Point(81, 91);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(30, 30);
            this.greenButton.TabIndex = 6;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yellowButton.Location = new System.Drawing.Point(45, 91);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(30, 30);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цвет кисти";
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.redButton.Location = new System.Drawing.Point(9, 91);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(30, 30);
            this.redButton.TabIndex = 3;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // colorNumericUpDown
            // 
            this.colorNumericUpDown.Location = new System.Drawing.Point(6, 29);
            this.colorNumericUpDown.Name = "colorNumericUpDown";
            this.colorNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.colorNumericUpDown.TabIndex = 2;
            this.colorNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colorNumericUpDown.ValueChanged += new System.EventHandler(this.colorNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ширина кисти";
            // 
            // gradientTrackBar
            // 
            this.gradientTrackBar.Location = new System.Drawing.Point(6, 20);
            this.gradientTrackBar.Name = "gradientTrackBar";
            this.gradientTrackBar.Size = new System.Drawing.Size(119, 56);
            this.gradientTrackBar.TabIndex = 7;
            this.gradientTrackBar.Scroll += new System.EventHandler(this.gradientTrackBar_Scroll);
            // 
            // gradientPanel
            // 
            this.gradientPanel.Controls.Add(this.label3);
            this.gradientPanel.Controls.Add(this.gradientTrackBar);
            this.gradientPanel.Controls.Add(this.gradientButton);
            this.gradientPanel.Location = new System.Drawing.Point(558, 151);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Size = new System.Drawing.Size(155, 136);
            this.gradientPanel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Значение белого";
            // 
            // oneColorPanel
            // 
            this.oneColorPanel.Controls.Add(this.oneColorPlayButton);
            this.oneColorPanel.Controls.Add(this.radioButton_B);
            this.oneColorPanel.Controls.Add(this.radioButton_G);
            this.oneColorPanel.Controls.Add(this.radioButton_R);
            this.oneColorPanel.Location = new System.Drawing.Point(722, 151);
            this.oneColorPanel.Name = "oneColorPanel";
            this.oneColorPanel.Size = new System.Drawing.Size(129, 136);
            this.oneColorPanel.TabIndex = 11;
            // 
            // oneColorPlayButton
            // 
            this.oneColorPlayButton.Location = new System.Drawing.Point(4, 90);
            this.oneColorPlayButton.Name = "oneColorPlayButton";
            this.oneColorPlayButton.Size = new System.Drawing.Size(120, 43);
            this.oneColorPlayButton.TabIndex = 3;
            this.oneColorPlayButton.Text = "Оставить только 1 цвет";
            this.oneColorPlayButton.UseVisualStyleBackColor = true;
            this.oneColorPlayButton.Click += new System.EventHandler(this.oneColorPlayButton_Click);
            // 
            // radioButton_B
            // 
            this.radioButton_B.AutoSize = true;
            this.radioButton_B.Location = new System.Drawing.Point(4, 62);
            this.radioButton_B.Name = "radioButton_B";
            this.radioButton_B.Size = new System.Drawing.Size(57, 21);
            this.radioButton_B.TabIndex = 2;
            this.radioButton_B.Text = "Blue";
            this.radioButton_B.UseVisualStyleBackColor = true;
            // 
            // radioButton_G
            // 
            this.radioButton_G.AutoSize = true;
            this.radioButton_G.Location = new System.Drawing.Point(4, 35);
            this.radioButton_G.Name = "radioButton_G";
            this.radioButton_G.Size = new System.Drawing.Size(69, 21);
            this.radioButton_G.TabIndex = 1;
            this.radioButton_G.Text = "Green";
            this.radioButton_G.UseVisualStyleBackColor = true;
            // 
            // radioButton_R
            // 
            this.radioButton_R.AutoSize = true;
            this.radioButton_R.Checked = true;
            this.radioButton_R.Location = new System.Drawing.Point(4, 8);
            this.radioButton_R.Name = "radioButton_R";
            this.radioButton_R.Size = new System.Drawing.Size(55, 21);
            this.radioButton_R.TabIndex = 0;
            this.radioButton_R.TabStop = true;
            this.radioButton_R.Text = "Red";
            this.radioButton_R.UseVisualStyleBackColor = true;
            // 
            // circleOfLifeBtn
            // 
            this.circleOfLifeBtn.Location = new System.Drawing.Point(3, 52);
            this.circleOfLifeBtn.Name = "circleOfLifeBtn";
            this.circleOfLifeBtn.Size = new System.Drawing.Size(155, 50);
            this.circleOfLifeBtn.TabIndex = 12;
            this.circleOfLifeBtn.Text = "Создать окружность жизни";
            this.circleOfLifeBtn.UseVisualStyleBackColor = true;
            this.circleOfLifeBtn.Click += new System.EventHandler(this.circleOfLifeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circleNumericUpDown);
            this.panel1.Controls.Add(this.circleOfLifeBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(558, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 109);
            this.panel1.TabIndex = 13;
            // 
            // circleNumericUpDown
            // 
            this.circleNumericUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.circleNumericUpDown.Location = new System.Drawing.Point(6, 24);
            this.circleNumericUpDown.Maximum = new decimal(new int[] {
            253,
            0,
            0,
            0});
            this.circleNumericUpDown.Name = "circleNumericUpDown";
            this.circleNumericUpDown.Size = new System.Drawing.Size(69, 22);
            this.circleNumericUpDown.TabIndex = 11;
            this.circleNumericUpDown.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Радиус окружности";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.oneColorPanel);
            this.Controls.Add(this.gradientPanel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.dots1000);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientTrackBar)).EndInit();
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            this.oneColorPanel.ResumeLayout(false);
            this.oneColorPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button gradientButton;
        private System.Windows.Forms.Button dots1000;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.NumericUpDown colorNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar gradientTrackBar;
        private System.Windows.Forms.Panel gradientPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel oneColorPanel;
        private System.Windows.Forms.Button oneColorPlayButton;
        private System.Windows.Forms.RadioButton radioButton_B;
        private System.Windows.Forms.RadioButton radioButton_G;
        private System.Windows.Forms.RadioButton radioButton_R;
        private System.Windows.Forms.Button circleOfLifeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown circleNumericUpDown;
        private System.Windows.Forms.Label label4;
    }
}

