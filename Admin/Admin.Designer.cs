namespace WindowsFormsApp1
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.chBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPie)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(44, 361);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(58, 121);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(34, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "         ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 65);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(44, 192);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 23);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(44, 221);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(75, 23);
            this.btnTeachers.TabIndex = 7;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(44, 250);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(75, 23);
            this.btnSubjects.TabIndex = 8;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(44, 280);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(75, 23);
            this.btnLogs.TabIndex = 9;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(44, 309);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(44, 163);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // chBar
            // 
            chartArea1.Name = "ChartArea1";
            this.chBar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chBar.Legends.Add(legend1);
            this.chBar.Location = new System.Drawing.Point(218, 22);
            this.chBar.Name = "chBar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chBar.Series.Add(series1);
            this.chBar.Size = new System.Drawing.Size(256, 178);
            this.chBar.TabIndex = 12;
            this.chBar.Text = "chart1";
            // 
            // chColumn
            // 
            chartArea2.Name = "ChartArea1";
            this.chColumn.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chColumn.Legends.Add(legend2);
            this.chColumn.Location = new System.Drawing.Point(505, 22);
            this.chColumn.Name = "chColumn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chColumn.Series.Add(series2);
            this.chColumn.Size = new System.Drawing.Size(256, 178);
            this.chColumn.TabIndex = 13;
            this.chColumn.Text = "chart1";
            // 
            // chLine
            // 
            chartArea3.Name = "ChartArea1";
            this.chLine.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chLine.Legends.Add(legend3);
            this.chLine.Location = new System.Drawing.Point(218, 225);
            this.chLine.Name = "chLine";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chLine.Series.Add(series3);
            this.chLine.Size = new System.Drawing.Size(256, 178);
            this.chLine.TabIndex = 14;
            this.chLine.Text = "chart2";
            // 
            // chPie
            // 
            chartArea4.Name = "ChartArea1";
            this.chPie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chPie.Legends.Add(legend4);
            this.chPie.Location = new System.Drawing.Point(505, 225);
            this.chPie.Name = "chPie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chPie.Series.Add(series4);
            this.chPie.Size = new System.Drawing.Size(256, 178);
            this.chPie.TabIndex = 15;
            this.chPie.Text = "chart1";
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.lblWelcome);
            this.sidePanel.Controls.Add(this.btnDashboard);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.btnStudent);
            this.sidePanel.Controls.Add(this.btnReport);
            this.sidePanel.Controls.Add(this.btnTeachers);
            this.sidePanel.Controls.Add(this.btnLogs);
            this.sidePanel.Controls.Add(this.btnSubjects);
            this.sidePanel.Location = new System.Drawing.Point(-1, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(172, 452);
            this.sidePanel.TabIndex = 16;
            // 
            // displayPanel
            // 
            this.displayPanel.Location = new System.Drawing.Point(168, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(633, 452);
            this.displayPanel.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(672, 307);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(8, 8);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chPie);
            this.Controls.Add(this.chLine);
            this.Controls.Add(this.chColumn);
            this.Controls.Add(this.chBar);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.displayPanel);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPie)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPie;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel sidePanel;
        public System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}