namespace SensorVisualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            labelHumValue = new Label();
            labelTempValue = new Label();
            label4 = new Label();
            buttonOpenFile = new Button();
            labelLastUpdate = new Label();
            minute = new Button();
            hour = new Button();
            live = new Button();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.Location = new Point(24, 51);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(647, 327);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            plotView1.Click += plotView1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(38, 384);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(143, 384);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(507, 384);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Location = new Point(677, 72);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Humidity:";
            // 
            // labelHumValue
            // 
            labelHumValue.AutoSize = true;
            labelHumValue.Location = new Point(688, 102);
            labelHumValue.Name = "labelHumValue";
            labelHumValue.Size = new Size(13, 15);
            labelHumValue.TabIndex = 5;
            labelHumValue.Text = "0";
            labelHumValue.Click += labelHumValue_Click;
            // 
            // labelTempValue
            // 
            labelTempValue.AutoSize = true;
            labelTempValue.Location = new Point(688, 190);
            labelTempValue.Name = "labelTempValue";
            labelTempValue.Size = new Size(13, 15);
            labelTempValue.TabIndex = 6;
            labelTempValue.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 255);
            label4.Location = new Point(677, 152);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Temperature:";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.YellowGreen;
            buttonOpenFile.Location = new Point(677, 278);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 23);
            buttonOpenFile.TabIndex = 8;
            buttonOpenFile.Text = "Open CSV";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // labelLastUpdate
            // 
            labelLastUpdate.AutoSize = true;
            labelLastUpdate.BackColor = Color.FromArgb(255, 255, 192);
            labelLastUpdate.Location = new Point(249, 388);
            labelLastUpdate.Name = "labelLastUpdate";
            labelLastUpdate.Size = new Size(71, 15);
            labelLastUpdate.TabIndex = 9;
            labelLastUpdate.Text = "Last update:";
            // 
            // minute
            // 
            minute.BackColor = Color.Yellow;
            minute.Location = new Point(224, 22);
            minute.Name = "minute";
            minute.Size = new Size(75, 23);
            minute.TabIndex = 10;
            minute.Text = "1 minute";
            minute.UseVisualStyleBackColor = false;
            minute.Click += minute_Click;
            // 
            // hour
            // 
            hour.BackColor = Color.Yellow;
            hour.Location = new Point(360, 22);
            hour.Name = "hour";
            hour.Size = new Size(75, 23);
            hour.TabIndex = 11;
            hour.Text = "1 hour";
            hour.UseVisualStyleBackColor = false;
            hour.Click += hour_Click;
            // 
            // live
            // 
            live.BackColor = Color.Yellow;
            live.Location = new Point(50, 22);
            live.Name = "live";
            live.Size = new Size(120, 23);
            live.TabIndex = 12;
            live.Text = "10 seconds (live)";
            live.UseVisualStyleBackColor = false;
            live.Click += live_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLastUpdate);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(buttonOpenFile);
            Controls.Add(labelHumValue);
            Controls.Add(label1);
            Controls.Add(labelTempValue);
            Controls.Add(label4);
            Controls.Add(live);
            Controls.Add(minute);
            Controls.Add(hour);
            Controls.Add(plotView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label labelHumValue;
        private Label labelTempValue;
        private Label label4;
        private Button buttonOpenFile;
        private Label labelLastUpdate;
        private Button minute;
        private Button hour;
        private Button live;
    }
}
