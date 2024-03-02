namespace SelfControl
{
    partial class blockListEditor
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
            this.domainBlackList = new System.Windows.Forms.CheckedListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addDomainButton = new System.Windows.Forms.Button();
            this.domainName = new System.Windows.Forms.TextBox();
            this.ToffCheckbox = new System.Windows.Forms.CheckBox();
            this.barTofAt = new System.Windows.Forms.TrackBar();
            this.labelPCTime = new System.Windows.Forms.Label();
            this.AllResetCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.barTofAt)).BeginInit();
            this.SuspendLayout();
            // 
            // domainBlackList
            // 
            this.domainBlackList.FormattingEnabled = true;
            this.domainBlackList.Location = new System.Drawing.Point(12, 12);
            this.domainBlackList.Name = "domainBlackList";
            this.domainBlackList.Size = new System.Drawing.Size(317, 244);
            this.domainBlackList.TabIndex = 1;
            this.domainBlackList.SelectedIndexChanged += new System.EventHandler(this.blackList_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(12, 261);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteSelectedItems);
            // 
            // addDomainButton
            // 
            this.addDomainButton.Location = new System.Drawing.Point(254, 264);
            this.addDomainButton.Name = "addDomainButton";
            this.addDomainButton.Size = new System.Drawing.Size(75, 22);
            this.addDomainButton.TabIndex = 3;
            this.addDomainButton.Text = "Add";
            this.addDomainButton.UseVisualStyleBackColor = true;
            this.addDomainButton.Click += new System.EventHandler(this.addDomain);
            // 
            // domainName
            // 
            this.domainName.Location = new System.Drawing.Point(138, 264);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(110, 20);
            this.domainName.TabIndex = 4;
            this.domainName.Text = "example.com";
            // 
            // ToffCheckbox
            // 
            this.ToffCheckbox.AutoSize = true;
            this.ToffCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToffCheckbox.Location = new System.Drawing.Point(140, 290);
            this.ToffCheckbox.Name = "ToffCheckbox";
            this.ToffCheckbox.Size = new System.Drawing.Size(108, 20);
            this.ToffCheckbox.TabIndex = 5;
            this.ToffCheckbox.Text = "Turn Off PC At";
            this.ToffCheckbox.UseVisualStyleBackColor = true;
            this.ToffCheckbox.CheckedChanged += new System.EventHandler(this.ToffPCAt_Checkbox);
            // 
            // barTofAt
            // 
            this.barTofAt.Enabled = false;
            this.barTofAt.Location = new System.Drawing.Point(12, 316);
            this.barTofAt.Maximum = 288;
            this.barTofAt.Minimum = 1;
            this.barTofAt.Name = "barTofAt";
            this.barTofAt.Size = new System.Drawing.Size(317, 45);
            this.barTofAt.TabIndex = 6;
            this.barTofAt.Value = 1;
            this.barTofAt.Scroll += new System.EventHandler(this.trackbarTurnOffAt_Scroll);
            // 
            // labelPCTime
            // 
            this.labelPCTime.AutoSize = true;
            this.labelPCTime.Enabled = false;
            this.labelPCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPCTime.Location = new System.Drawing.Point(149, 362);
            this.labelPCTime.Name = "labelPCTime";
            this.labelPCTime.Size = new System.Drawing.Size(38, 15);
            this.labelPCTime.TabIndex = 7;
            this.labelPCTime.Text = "00:00";
            this.labelPCTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllResetCheckbox
            // 
            this.AllResetCheckbox.AutoSize = true;
            this.AllResetCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllResetCheckbox.Location = new System.Drawing.Point(12, 290);
            this.AllResetCheckbox.Name = "AllResetCheckbox";
            this.AllResetCheckbox.Size = new System.Drawing.Size(117, 20);
            this.AllResetCheckbox.TabIndex = 8;
            this.AllResetCheckbox.Text = "Allow To Reset";
            this.AllResetCheckbox.UseVisualStyleBackColor = true;
            // 
            // blockListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 386);
            this.Controls.Add(this.AllResetCheckbox);
            this.Controls.Add(this.labelPCTime);
            this.Controls.Add(this.barTofAt);
            this.Controls.Add(this.ToffCheckbox);
            this.Controls.Add(this.domainName);
            this.Controls.Add(this.addDomainButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.domainBlackList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "blockListEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Domain Blacklist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onClosing);
            this.Load += new System.EventHandler(this.blockListEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barTofAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox domainBlackList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addDomainButton;
        private System.Windows.Forms.TextBox domainName;
        private System.Windows.Forms.CheckBox ToffCheckbox;
        private System.Windows.Forms.TrackBar barTofAt;
        private System.Windows.Forms.Label labelPCTime;
        private System.Windows.Forms.CheckBox AllResetCheckbox;
    }
}