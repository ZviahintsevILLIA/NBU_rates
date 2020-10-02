namespace Kurs_Nbu
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonGetCourse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code_r030 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccode_cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_exchangedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.popcUSD = new System.Windows.Forms.Label();
            this.popcEUR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.popcRUB = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.popcGBP = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.popcAUD = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.popCurBox = new System.Windows.Forms.GroupBox();
            this.popdAUD = new System.Windows.Forms.Label();
            this.popdGBP = new System.Windows.Forms.Label();
            this.popdRUB = new System.Windows.Forms.Label();
            this.popdEUR = new System.Windows.Forms.Label();
            this.popdUSD = new System.Windows.Forms.Label();
            this.chartsBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.popCurBox.SuspendLayout();
            this.chartsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetCourse
            // 
            this.buttonGetCourse.Location = new System.Drawing.Point(579, 206);
            this.buttonGetCourse.Name = "buttonGetCourse";
            this.buttonGetCourse.Size = new System.Drawing.Size(227, 23);
            this.buttonGetCourse.TabIndex = 1;
            this.buttonGetCourse.Text = "Get rate for selected date";
            this.buttonGetCourse.UseVisualStyleBackColor = true;
            this.buttonGetCourse.Click += new System.EventHandler(this.buttonGetCourse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_r030,
            this.name_txt,
            this.Rate,
            this.ccode_cc,
            this.date_exchangedate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 419);
            this.dataGridView1.TabIndex = 2;
            // 
            // code_r030
            // 
            this.code_r030.HeaderText = "Code";
            this.code_r030.Name = "code_r030";
            this.code_r030.ReadOnly = true;
            this.code_r030.Width = 50;
            // 
            // name_txt
            // 
            this.name_txt.HeaderText = "Name";
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Width = 200;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // ccode_cc
            // 
            this.ccode_cc.HeaderText = "CODE";
            this.ccode_cc.Name = "ccode_cc";
            this.ccode_cc.ReadOnly = true;
            this.ccode_cc.Width = 50;
            // 
            // date_exchangedate
            // 
            this.date_exchangedate.HeaderText = "Date";
            this.date_exchangedate.Name = "date_exchangedate";
            this.date_exchangedate.ReadOnly = true;
            this.date_exchangedate.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Official exchange rate of Hryvnia against foreign currencies";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(579, 32);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(227, 162);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1996, 1, 6, 0, 0, 0, 0);
            this.monthCalendar1.MinimumSize = new System.Drawing.Size(227, 162);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "USD";
            // 
            // popcUSD
            // 
            this.popcUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popcUSD.Location = new System.Drawing.Point(71, 25);
            this.popcUSD.Name = "popcUSD";
            this.popcUSD.Size = new System.Drawing.Size(115, 25);
            this.popcUSD.TabIndex = 15;
            this.popcUSD.Text = "0.0000";
            this.popcUSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // popcEUR
            // 
            this.popcEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popcEUR.Location = new System.Drawing.Point(71, 50);
            this.popcEUR.Name = "popcEUR";
            this.popcEUR.Size = new System.Drawing.Size(115, 25);
            this.popcEUR.TabIndex = 17;
            this.popcEUR.Text = "0.0000";
            this.popcEUR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "EUR";
            // 
            // popcRUB
            // 
            this.popcRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popcRUB.Location = new System.Drawing.Point(71, 75);
            this.popcRUB.Name = "popcRUB";
            this.popcRUB.Size = new System.Drawing.Size(115, 25);
            this.popcRUB.TabIndex = 19;
            this.popcRUB.Text = "0.0000";
            this.popcRUB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "RUB";
            // 
            // popcGBP
            // 
            this.popcGBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popcGBP.Location = new System.Drawing.Point(71, 100);
            this.popcGBP.Name = "popcGBP";
            this.popcGBP.Size = new System.Drawing.Size(115, 25);
            this.popcGBP.TabIndex = 21;
            this.popcGBP.Text = "0.0000";
            this.popcGBP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "GBP";
            // 
            // popcAUD
            // 
            this.popcAUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popcAUD.Location = new System.Drawing.Point(71, 125);
            this.popcAUD.Name = "popcAUD";
            this.popcAUD.Size = new System.Drawing.Size(115, 25);
            this.popcAUD.TabIndex = 23;
            this.popcAUD.Text = "0.0000";
            this.popcAUD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "AUD";
            // 
            // popCurBox
            // 
            this.popCurBox.Controls.Add(this.popdAUD);
            this.popCurBox.Controls.Add(this.popdGBP);
            this.popCurBox.Controls.Add(this.popdRUB);
            this.popCurBox.Controls.Add(this.popdEUR);
            this.popCurBox.Controls.Add(this.popdUSD);
            this.popCurBox.Controls.Add(this.label3);
            this.popCurBox.Controls.Add(this.popcAUD);
            this.popCurBox.Controls.Add(this.popcUSD);
            this.popCurBox.Controls.Add(this.label16);
            this.popCurBox.Controls.Add(this.label10);
            this.popCurBox.Controls.Add(this.popcGBP);
            this.popCurBox.Controls.Add(this.popcEUR);
            this.popCurBox.Controls.Add(this.label14);
            this.popCurBox.Controls.Add(this.label12);
            this.popCurBox.Controls.Add(this.popcRUB);
            this.popCurBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popCurBox.Location = new System.Drawing.Point(579, 246);
            this.popCurBox.Name = "popCurBox";
            this.popCurBox.Size = new System.Drawing.Size(227, 162);
            this.popCurBox.TabIndex = 24;
            this.popCurBox.TabStop = false;
            this.popCurBox.Text = "Popular currencies:";
            // 
            // popdAUD
            // 
            this.popdAUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popdAUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popdAUD.Location = new System.Drawing.Point(186, 125);
            this.popdAUD.Name = "popdAUD";
            this.popdAUD.Size = new System.Drawing.Size(35, 25);
            this.popdAUD.TabIndex = 28;
            this.popdAUD.Text = "+0.00";
            this.popdAUD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popdGBP
            // 
            this.popdGBP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popdGBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popdGBP.Location = new System.Drawing.Point(186, 100);
            this.popdGBP.Name = "popdGBP";
            this.popdGBP.Size = new System.Drawing.Size(35, 25);
            this.popdGBP.TabIndex = 27;
            this.popdGBP.Text = "+0.00";
            this.popdGBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popdRUB
            // 
            this.popdRUB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popdRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popdRUB.Location = new System.Drawing.Point(186, 75);
            this.popdRUB.Name = "popdRUB";
            this.popdRUB.Size = new System.Drawing.Size(35, 25);
            this.popdRUB.TabIndex = 26;
            this.popdRUB.Text = "+0.00";
            this.popdRUB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popdEUR
            // 
            this.popdEUR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popdEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popdEUR.Location = new System.Drawing.Point(186, 50);
            this.popdEUR.Name = "popdEUR";
            this.popdEUR.Size = new System.Drawing.Size(35, 25);
            this.popdEUR.TabIndex = 25;
            this.popdEUR.Text = "+0.00";
            this.popdEUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popdUSD
            // 
            this.popdUSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popdUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popdUSD.Location = new System.Drawing.Point(186, 25);
            this.popdUSD.Name = "popdUSD";
            this.popdUSD.Size = new System.Drawing.Size(35, 25);
            this.popdUSD.TabIndex = 24;
            this.popdUSD.Text = "+0.00";
            this.popdUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartsBox
            // 
            this.chartsBox.Controls.Add(this.label5);
            this.chartsBox.Controls.Add(this.label4);
            this.chartsBox.Controls.Add(this.label2);
            this.chartsBox.Controls.Add(this.chart1);
            this.chartsBox.Controls.Add(this.comboBox4);
            this.chartsBox.Controls.Add(this.chart4);
            this.chartsBox.Controls.Add(this.chart3);
            this.chartsBox.Controls.Add(this.chart2);
            this.chartsBox.Location = new System.Drawing.Point(12, 465);
            this.chartsBox.Name = "chartsBox";
            this.chartsBox.Size = new System.Drawing.Size(794, 205);
            this.chartsBox.TabIndex = 31;
            this.chartsBox.TabStop = false;
            this.chartsBox.Text = "Charts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(393, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(197, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "EUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "USD";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Location = new System.Drawing.Point(6, 46);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(190, 150);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(594, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(190, 21);
            this.comboBox4.TabIndex = 36;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // chart4
            // 
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            this.chart4.Location = new System.Drawing.Point(594, 46);
            this.chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(190, 150);
            this.chart4.TabIndex = 33;
            this.chart4.Text = "chart4";
            this.chart4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart4_MouseMove);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(398, 46);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(190, 150);
            this.chart3.TabIndex = 32;
            this.chart3.Text = "chart3";
            this.chart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart3_MouseMove);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Location = new System.Drawing.Point(202, 46);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(190, 150);
            this.chart2.TabIndex = 31;
            this.chart2.Text = "chart2";
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseMove);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 682);
            this.Controls.Add(this.chartsBox);
            this.Controls.Add(this.popCurBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGetCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.Text = "National Bank of Ukraine rates - izviahintsev@gmail.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.popCurBox.ResumeLayout(false);
            this.popCurBox.PerformLayout();
            this.chartsBox.ResumeLayout(false);
            this.chartsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_r030;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccode_cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_exchangedate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label popcUSD;
        private System.Windows.Forms.Label popcEUR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label popcRUB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label popcGBP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label popcAUD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox popCurBox;
        private System.Windows.Forms.Label popdAUD;
        private System.Windows.Forms.Label popdGBP;
        private System.Windows.Forms.Label popdRUB;
        private System.Windows.Forms.Label popdEUR;
        private System.Windows.Forms.Label popdUSD;
        private System.Windows.Forms.GroupBox chartsBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;



    }
}

