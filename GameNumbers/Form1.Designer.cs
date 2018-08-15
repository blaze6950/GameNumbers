namespace GameNumbers
{
    partial class NumbersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumbersForm));
            this.panel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.minimuLabel = new System.Windows.Forms.Label();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.minimumUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumUpDown = new System.Windows.Forms.NumericUpDown();
            this.threeXThree = new System.Windows.Forms.RadioButton();
            this.fourXFour = new System.Windows.Forms.RadioButton();
            this.FiveXFive = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(12, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(268, 268);
            this.panel.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 313);
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(497, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(286, 264);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(410, 264);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(304, 63);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(46, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Время :";
            // 
            // minimuLabel
            // 
            this.minimuLabel.AutoSize = true;
            this.minimuLabel.Location = new System.Drawing.Point(289, 135);
            this.minimuLabel.Name = "minimuLabel";
            this.minimuLabel.Size = new System.Drawing.Size(61, 13);
            this.minimuLabel.TabIndex = 5;
            this.minimuLabel.Text = "Минимум :";
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(283, 202);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(67, 13);
            this.maximumLabel.TabIndex = 6;
            this.maximumLabel.Text = "Максимум :";
            // 
            // timeTrackBar
            // 
            this.timeTrackBar.LargeChange = 10;
            this.timeTrackBar.Location = new System.Drawing.Point(347, 60);
            this.timeTrackBar.Maximum = 250;
            this.timeTrackBar.Minimum = 10;
            this.timeTrackBar.Name = "timeTrackBar";
            this.timeTrackBar.Size = new System.Drawing.Size(138, 45);
            this.timeTrackBar.SmallChange = 5;
            this.timeTrackBar.TabIndex = 7;
            this.timeTrackBar.TickFrequency = 10;
            this.timeTrackBar.Value = 10;
            this.timeTrackBar.Scroll += new System.EventHandler(this.timeTrackBar_Scroll);
            // 
            // minimumUpDown
            // 
            this.minimumUpDown.Location = new System.Drawing.Point(356, 133);
            this.minimumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minimumUpDown.Name = "minimumUpDown";
            this.minimumUpDown.Size = new System.Drawing.Size(129, 20);
            this.minimumUpDown.TabIndex = 8;
            this.minimumUpDown.ValueChanged += new System.EventHandler(this.minimumUpDown_ValueChanged);
            // 
            // maximumUpDown
            // 
            this.maximumUpDown.Location = new System.Drawing.Point(356, 200);
            this.maximumUpDown.Maximum = new decimal(new int[] {
            1009,
            0,
            0,
            0});
            this.maximumUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.maximumUpDown.Name = "maximumUpDown";
            this.maximumUpDown.Size = new System.Drawing.Size(129, 20);
            this.maximumUpDown.TabIndex = 9;
            this.maximumUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.maximumUpDown.ValueChanged += new System.EventHandler(this.maximumUpDown_ValueChanged);
            // 
            // threeXThree
            // 
            this.threeXThree.AutoSize = true;
            this.threeXThree.Checked = true;
            this.threeXThree.Location = new System.Drawing.Point(70, 12);
            this.threeXThree.Name = "threeXThree";
            this.threeXThree.Size = new System.Drawing.Size(48, 17);
            this.threeXThree.TabIndex = 10;
            this.threeXThree.TabStop = true;
            this.threeXThree.Text = "3 x 3";
            this.threeXThree.UseVisualStyleBackColor = true;
            this.threeXThree.CheckedChanged += new System.EventHandler(this.threeXThree_CheckedChanged);
            // 
            // fourXFour
            // 
            this.fourXFour.AutoSize = true;
            this.fourXFour.Location = new System.Drawing.Point(124, 12);
            this.fourXFour.Name = "fourXFour";
            this.fourXFour.Size = new System.Drawing.Size(48, 17);
            this.fourXFour.TabIndex = 11;
            this.fourXFour.Text = "4 x 4";
            this.fourXFour.UseVisualStyleBackColor = true;
            this.fourXFour.CheckedChanged += new System.EventHandler(this.fourXFour_CheckedChanged);
            // 
            // FiveXFive
            // 
            this.FiveXFive.AutoSize = true;
            this.FiveXFive.Location = new System.Drawing.Point(175, 12);
            this.FiveXFive.Name = "FiveXFive";
            this.FiveXFive.Size = new System.Drawing.Size(48, 17);
            this.FiveXFive.TabIndex = 12;
            this.FiveXFive.Text = "5 x 5";
            this.FiveXFive.UseVisualStyleBackColor = true;
            this.FiveXFive.CheckedChanged += new System.EventHandler(this.FiveXFive_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // NumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 336);
            this.Controls.Add(this.FiveXFive);
            this.Controls.Add(this.fourXFour);
            this.Controls.Add(this.threeXThree);
            this.Controls.Add(this.maximumUpDown);
            this.Controls.Add(this.minimumUpDown);
            this.Controls.Add(this.timeTrackBar);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.minimuLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumbersForm";
            this.Text = "Числа";
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label minimuLabel;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.TrackBar timeTrackBar;
        private System.Windows.Forms.NumericUpDown minimumUpDown;
        private System.Windows.Forms.NumericUpDown maximumUpDown;
        private System.Windows.Forms.RadioButton threeXThree;
        private System.Windows.Forms.RadioButton fourXFour;
        private System.Windows.Forms.RadioButton FiveXFive;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

