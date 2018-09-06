namespace TimerEx
{
    partial class TimerExTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerExTestForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.statLab = new System.Windows.Forms.Label();
            this.ticksLab = new System.Windows.Forms.Label();
            this.statBox = new System.Windows.Forms.TextBox();
            this.ticksBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(307, 141);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 43);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 141);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(73, 43);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(91, 141);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(73, 43);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(170, 141);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(73, 43);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Restart";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // statLab
            // 
            this.statLab.AutoSize = true;
            this.statLab.Location = new System.Drawing.Point(12, 24);
            this.statLab.Name = "statLab";
            this.statLab.Size = new System.Drawing.Size(60, 20);
            this.statLab.TabIndex = 4;
            this.statLab.Text = "Status:";
            // 
            // ticksLab
            // 
            this.ticksLab.AutoSize = true;
            this.ticksLab.Location = new System.Drawing.Point(23, 60);
            this.ticksLab.Name = "ticksLab";
            this.ticksLab.Size = new System.Drawing.Size(49, 20);
            this.ticksLab.TabIndex = 5;
            this.ticksLab.Text = "Ticks:";
            // 
            // statBox
            // 
            this.statBox.Location = new System.Drawing.Point(78, 21);
            this.statBox.Name = "statBox";
            this.statBox.ReadOnly = true;
            this.statBox.Size = new System.Drawing.Size(165, 26);
            this.statBox.TabIndex = 6;
            // 
            // ticksBox
            // 
            this.ticksBox.Location = new System.Drawing.Point(78, 57);
            this.ticksBox.Name = "ticksBox";
            this.ticksBox.ReadOnly = true;
            this.ticksBox.Size = new System.Drawing.Size(165, 26);
            this.ticksBox.TabIndex = 7;
            // 
            // TimerExTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 196);
            this.Controls.Add(this.ticksBox);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.ticksLab);
            this.Controls.Add(this.statLab);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerExTestForm";
            this.Text = "Extended Timer Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label statLab;
        private System.Windows.Forms.Label ticksLab;
        private System.Windows.Forms.TextBox statBox;
        private System.Windows.Forms.TextBox ticksBox;
    }
}

