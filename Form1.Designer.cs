namespace DnaSynthMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通道选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.合成仪端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synth_com1 = new System.Windows.Forms.ToolStripMenuItem();
            this.synth_com2 = new System.Windows.Forms.ToolStripMenuItem();
            this.synth_com3 = new System.Windows.Forms.ToolStripMenuItem();
            this.synth_com4 = new System.Windows.Forms.ToolStripMenuItem();
            this.synth_com5 = new System.Windows.Forms.ToolStripMenuItem();
            this.吸光度计端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_com1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_com2 = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_com3 = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_com4 = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_com5 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.synth_port = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.abm_port = new System.Windows.Forms.ToolStripStatusLabel();
            this.curr_stat = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatChart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.通道选择ToolStripMenuItem,
            this.合成仪端口ToolStripMenuItem,
            this.吸光度计端口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2214, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 通道选择ToolStripMenuItem
            // 
            this.通道选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem13,
            this.toolStripMenuItem12,
            this.toolStripMenuItem11,
            this.toolStripMenuItem10,
            this.toolStripMenuItem9,
            this.toolStripMenuItem8,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripMenuItem16,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.通道选择ToolStripMenuItem.Name = "通道选择ToolStripMenuItem";
            this.通道选择ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.通道选择ToolStripMenuItem.Text = "通道选择";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem1.Text = "4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem5.Text = "5";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.CheckOnClick = true;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem13.Text = "6";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.CheckOnClick = true;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem12.Text = "7";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.CheckOnClick = true;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem11.Text = "8";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.CheckOnClick = true;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem10.Text = "9";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.CheckOnClick = true;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem9.Text = "10";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.CheckOnClick = true;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem8.Text = "11";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem7.Text = "12";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem6.Text = "13";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.CheckOnClick = true;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem16.Text = "14";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.CheckOnClick = true;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem14.Text = "16";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.CheckOnClick = true;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(132, 34);
            this.toolStripMenuItem15.Text = "15";
            // 
            // 合成仪端口ToolStripMenuItem
            // 
            this.合成仪端口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.synth_com1,
            this.synth_com2,
            this.synth_com3,
            this.synth_com4,
            this.synth_com5});
            this.合成仪端口ToolStripMenuItem.Name = "合成仪端口ToolStripMenuItem";
            this.合成仪端口ToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.合成仪端口ToolStripMenuItem.Text = "合成仪端口";
            // 
            // synth_com1
            // 
            this.synth_com1.CheckOnClick = true;
            this.synth_com1.Name = "synth_com1";
            this.synth_com1.Size = new System.Drawing.Size(166, 34);
            this.synth_com1.Text = "COM1";
            this.synth_com1.CheckedChanged += new System.EventHandler(this.synth_com1_CheckedChanged);
            // 
            // synth_com2
            // 
            this.synth_com2.CheckOnClick = true;
            this.synth_com2.Name = "synth_com2";
            this.synth_com2.Size = new System.Drawing.Size(166, 34);
            this.synth_com2.Text = "COM2";
            this.synth_com2.CheckedChanged += new System.EventHandler(this.synth_com2_CheckedChanged);
            // 
            // synth_com3
            // 
            this.synth_com3.CheckOnClick = true;
            this.synth_com3.Name = "synth_com3";
            this.synth_com3.Size = new System.Drawing.Size(166, 34);
            this.synth_com3.Text = "COM3";
            this.synth_com3.CheckedChanged += new System.EventHandler(this.synth_com3_CheckedChanged);
            // 
            // synth_com4
            // 
            this.synth_com4.CheckOnClick = true;
            this.synth_com4.Name = "synth_com4";
            this.synth_com4.Size = new System.Drawing.Size(166, 34);
            this.synth_com4.Text = "COM4";
            this.synth_com4.CheckedChanged += new System.EventHandler(this.synth_com4_CheckedChanged);
            // 
            // synth_com5
            // 
            this.synth_com5.CheckOnClick = true;
            this.synth_com5.Name = "synth_com5";
            this.synth_com5.Size = new System.Drawing.Size(166, 34);
            this.synth_com5.Text = "COM5";
            this.synth_com5.CheckedChanged += new System.EventHandler(this.synth_com5_CheckedChanged);
            // 
            // 吸光度计端口ToolStripMenuItem
            // 
            this.吸光度计端口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abm_com1,
            this.abm_com2,
            this.abm_com3,
            this.abm_com4,
            this.abm_com5});
            this.吸光度计端口ToolStripMenuItem.Name = "吸光度计端口ToolStripMenuItem";
            this.吸光度计端口ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.吸光度计端口ToolStripMenuItem.Text = "吸光度计端口";
            // 
            // abm_com1
            // 
            this.abm_com1.CheckOnClick = true;
            this.abm_com1.Name = "abm_com1";
            this.abm_com1.Size = new System.Drawing.Size(166, 34);
            this.abm_com1.Text = "COM1";
            this.abm_com1.CheckedChanged += new System.EventHandler(this.abm_com1_CheckedChanged);
            // 
            // abm_com2
            // 
            this.abm_com2.CheckOnClick = true;
            this.abm_com2.Name = "abm_com2";
            this.abm_com2.Size = new System.Drawing.Size(166, 34);
            this.abm_com2.Text = "COM2";
            this.abm_com2.CheckedChanged += new System.EventHandler(this.abm_com2_CheckedChanged);
            // 
            // abm_com3
            // 
            this.abm_com3.CheckOnClick = true;
            this.abm_com3.Name = "abm_com3";
            this.abm_com3.Size = new System.Drawing.Size(166, 34);
            this.abm_com3.Text = "COM3";
            this.abm_com3.CheckedChanged += new System.EventHandler(this.abm_com3_CheckedChanged);
            // 
            // abm_com4
            // 
            this.abm_com4.CheckOnClick = true;
            this.abm_com4.Name = "abm_com4";
            this.abm_com4.Size = new System.Drawing.Size(166, 34);
            this.abm_com4.Text = "COM4";
            this.abm_com4.CheckedChanged += new System.EventHandler(this.abm_com4_CheckedChanged);
            // 
            // abm_com5
            // 
            this.abm_com5.CheckOnClick = true;
            this.abm_com5.Name = "abm_com5";
            this.abm_com5.Size = new System.Drawing.Size(166, 34);
            this.abm_com5.Text = "COM5";
            this.abm_com5.CheckedChanged += new System.EventHandler(this.abm_com5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1228, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前事件：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(771, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 245);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "NA";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(1232, 194);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(84, 28);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "开始记录";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(1253, 244);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(84, 28);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "串口测试";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DataChart.Legends.Add(legend1);
            this.DataChart.Location = new System.Drawing.Point(14, 320);
            this.DataChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataChart.Name = "DataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DataChart.Series.Add(series1);
            this.DataChart.Size = new System.Drawing.Size(1475, 312);
            this.DataChart.TabIndex = 5;
            this.DataChart.Text = "chart1";
            // 
            // StatChart
            // 
            chartArea2.Name = "ChartArea1";
            this.StatChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StatChart.Legends.Add(legend2);
            this.StatChart.Location = new System.Drawing.Point(84, 67);
            this.StatChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatChart.Name = "StatChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StatChart.Series.Add(series2);
            this.StatChart.Size = new System.Drawing.Size(530, 191);
            this.StatChart.TabIndex = 6;
            this.StatChart.Text = "chart2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.synth_port,
            this.toolStripStatusLabel3,
            this.abm_port,
            this.curr_stat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1034);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2214, 68);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 61);
            this.toolStripStatusLabel1.Text = "合成仪端口：";
            // 
            // synth_port
            // 
            this.synth_port.Name = "synth_port";
            this.synth_port.Size = new System.Drawing.Size(38, 61);
            this.synth_port.Text = "NA";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(50, 4, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(136, 62);
            this.toolStripStatusLabel3.Text = "吸光度计端口：";
            // 
            // abm_port
            // 
            this.abm_port.Name = "abm_port";
            this.abm_port.Size = new System.Drawing.Size(38, 61);
            this.abm_port.Text = "NA";
            // 
            // curr_stat
            // 
            this.curr_stat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.curr_stat.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.curr_stat.ForeColor = System.Drawing.Color.Green;
            this.curr_stat.Margin = new System.Windows.Forms.Padding(200, 4, 0, 2);
            this.curr_stat.Name = "curr_stat";
            this.curr_stat.Size = new System.Drawing.Size(155, 62);
            this.curr_stat.Text = "ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2214, 1102);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StatChart);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatChart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatChart;
        private System.Windows.Forms.ToolStripMenuItem 通道选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem 合成仪端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synth_com1;
        private System.Windows.Forms.ToolStripMenuItem synth_com2;
        private System.Windows.Forms.ToolStripMenuItem synth_com3;
        private System.Windows.Forms.ToolStripMenuItem synth_com4;
        private System.Windows.Forms.ToolStripMenuItem synth_com5;
        private System.Windows.Forms.ToolStripMenuItem 吸光度计端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abm_com1;
        private System.Windows.Forms.ToolStripMenuItem abm_com2;
        private System.Windows.Forms.ToolStripMenuItem abm_com3;
        private System.Windows.Forms.ToolStripMenuItem abm_com4;
        private System.Windows.Forms.ToolStripMenuItem abm_com5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel synth_port;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel abm_port;
        private System.Windows.Forms.ToolStripStatusLabel curr_stat;
    }
}

