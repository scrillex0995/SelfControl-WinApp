namespace SelfControl
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StartButton = new System.Windows.Forms.Button();
            this.timeBar = new System.Windows.Forms.TrackBar();
            this.blockListButton = new System.Windows.Forms.Button();
            this.estimitedTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(189)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(203, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(77, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButtonPressed);
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(12, 40);
            this.timeBar.Maximum = 49;
            this.timeBar.Minimum = 1;
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(463, 45);
            this.timeBar.TabIndex = 3;
            this.timeBar.Value = 1;
            this.timeBar.Scroll += new System.EventHandler(this.barScroll);
            // 
            // blockListButton
            // 
            this.blockListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.blockListButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.blockListButton.FlatAppearance.BorderSize = 0;
            this.blockListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(189)))));
            this.blockListButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blockListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockListButton.ForeColor = System.Drawing.Color.White;
            this.blockListButton.Location = new System.Drawing.Point(377, 84);
            this.blockListButton.Name = "blockListButton";
            this.blockListButton.Size = new System.Drawing.Size(98, 24);
            this.blockListButton.TabIndex = 4;
            this.blockListButton.Text = "Edit Blacklist";
            this.blockListButton.UseVisualStyleBackColor = false;
            this.blockListButton.Click += new System.EventHandler(this.openBlackList);
            // 
            // estimitedTimeLabel
            // 
            this.estimitedTimeLabel.AutoSize = true;
            this.estimitedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimitedTimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.estimitedTimeLabel.Location = new System.Drawing.Point(12, 88);
            this.estimitedTimeLabel.Name = "estimitedTimeLabel";
            this.estimitedTimeLabel.Size = new System.Drawing.Size(63, 16);
            this.estimitedTimeLabel.TabIndex = 5;
            this.estimitedTimeLabel.Text = "1 minutes";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(487, 119);
            this.Controls.Add(this.estimitedTimeLabel);
            this.Controls.Add(this.blockListButton);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Self Control";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Main_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Showed);
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TrackBar timeBar;
        private System.Windows.Forms.Button blockListButton;
        private System.Windows.Forms.Label estimitedTimeLabel;
    }
}

