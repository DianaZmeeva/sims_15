namespace sims_15
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
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_dt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.numericUpDown_dhr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_dur = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_air = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_drr = new System.Windows.Forms.NumericUpDown();
            this.label_ssr = new System.Windows.Forms.Label();
            this.label_uor = new System.Windows.Forms.Label();
            this.label_iar = new System.Windows.Forms.Label();
            this.label_rrr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dhr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_air)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_drr)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(236, 6);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(56, 19);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown_dt
            // 
            this.numericUpDown_dt.DecimalPlaces = 1;
            this.numericUpDown_dt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_dt.Location = new System.Drawing.Point(47, 34);
            this.numericUpDown_dt.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_dt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dt.Name = "numericUpDown_dt";
            this.numericUpDown_dt.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_dt.TabIndex = 1;
            this.numericUpDown_dt.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DT";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(10, 12);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(42, 13);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "Time: 0";
            // 
            // numericUpDown_dhr
            // 
            this.numericUpDown_dhr.DecimalPlaces = 1;
            this.numericUpDown_dhr.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_dhr.Location = new System.Drawing.Point(47, 58);
            this.numericUpDown_dhr.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_dhr.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dhr.Name = "numericUpDown_dhr";
            this.numericUpDown_dhr.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_dhr.TabIndex = 4;
            this.numericUpDown_dhr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DHR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DUR";
            // 
            // numericUpDown_dur
            // 
            this.numericUpDown_dur.DecimalPlaces = 1;
            this.numericUpDown_dur.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_dur.Location = new System.Drawing.Point(47, 82);
            this.numericUpDown_dur.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_dur.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dur.Name = "numericUpDown_dur";
            this.numericUpDown_dur.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_dur.TabIndex = 6;
            this.numericUpDown_dur.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "AIR";
            // 
            // numericUpDown_air
            // 
            this.numericUpDown_air.DecimalPlaces = 1;
            this.numericUpDown_air.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_air.Location = new System.Drawing.Point(47, 106);
            this.numericUpDown_air.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_air.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_air.Name = "numericUpDown_air";
            this.numericUpDown_air.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_air.TabIndex = 8;
            this.numericUpDown_air.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DRR";
            // 
            // numericUpDown_drr
            // 
            this.numericUpDown_drr.DecimalPlaces = 1;
            this.numericUpDown_drr.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_drr.Location = new System.Drawing.Point(47, 130);
            this.numericUpDown_drr.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_drr.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_drr.Name = "numericUpDown_drr";
            this.numericUpDown_drr.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_drr.TabIndex = 10;
            this.numericUpDown_drr.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label_ssr
            // 
            this.label_ssr.AutoSize = true;
            this.label_ssr.Location = new System.Drawing.Point(174, 60);
            this.label_ssr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ssr.Name = "label_ssr";
            this.label_ssr.Size = new System.Drawing.Size(32, 13);
            this.label_ssr.TabIndex = 12;
            this.label_ssr.Text = "SSR:";
            // 
            // label_uor
            // 
            this.label_uor.AutoSize = true;
            this.label_uor.Location = new System.Drawing.Point(172, 84);
            this.label_uor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_uor.Name = "label_uor";
            this.label_uor.Size = new System.Drawing.Size(34, 13);
            this.label_uor.TabIndex = 13;
            this.label_uor.Text = "UOR:";
            // 
            // label_iar
            // 
            this.label_iar.AutoSize = true;
            this.label_iar.Location = new System.Drawing.Point(174, 108);
            this.label_iar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_iar.Name = "label_iar";
            this.label_iar.Size = new System.Drawing.Size(28, 13);
            this.label_iar.TabIndex = 14;
            this.label_iar.Text = "IAR:";
            // 
            // label_rrr
            // 
            this.label_rrr.AutoSize = true;
            this.label_rrr.Location = new System.Drawing.Point(172, 34);
            this.label_rrr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rrr.Name = "label_rrr";
            this.label_rrr.Size = new System.Drawing.Size(34, 13);
            this.label_rrr.TabIndex = 15;
            this.label_rrr.Text = "RRR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 275);
            this.Controls.Add(this.label_rrr);
            this.Controls.Add(this.label_iar);
            this.Controls.Add(this.label_uor);
            this.Controls.Add(this.label_ssr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_drr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_air);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_dur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_dhr);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_dt);
            this.Controls.Add(this.button_start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dhr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_air)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_drr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_dhr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_dur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_air;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_drr;
        private System.Windows.Forms.Label label_ssr;
        private System.Windows.Forms.Label label_uor;
        private System.Windows.Forms.Label label_iar;
        private System.Windows.Forms.Label label_rrr;
    }
}

