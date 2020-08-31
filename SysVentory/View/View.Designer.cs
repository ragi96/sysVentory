namespace SysVentory.View
{
    partial class View
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
            this.CmdScan = new System.Windows.Forms.Button();
            this.TxtOut1 = new System.Windows.Forms.TextBox();
            this.cmdDiff = new System.Windows.Forms.Button();
            this.cmdShow1 = new System.Windows.Forms.Button();
            this.cmbScans1 = new System.Windows.Forms.ComboBox();
            this.cmbScans2 = new System.Windows.Forms.ComboBox();
            this.cmdShow2 = new System.Windows.Forms.Button();
            this.TxtOut2 = new System.Windows.Forms.TextBox();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDelete1 = new System.Windows.Forms.Button();
            this.cmdDelete2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(340, 775);
            this.CmdScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(581, 36);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scanne diesen Computer";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.CmdScan_Click);
            // 
            // TxtOut1
            // 
            this.TxtOut1.Location = new System.Drawing.Point(15, 164);
            this.TxtOut1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtOut1.Multiline = true;
            this.TxtOut1.Name = "TxtOut1";
            this.TxtOut1.ReadOnly = true;
            this.TxtOut1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOut1.Size = new System.Drawing.Size(580, 374);
            this.TxtOut1.TabIndex = 1;
            // 
            // cmdDiff
            // 
            this.cmdDiff.Location = new System.Drawing.Point(340, 546);
            this.cmdDiff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDiff.Name = "cmdDiff";
            this.cmdDiff.Size = new System.Drawing.Size(581, 36);
            this.cmdDiff.TabIndex = 4;
            this.cmdDiff.Text = "Delta berechnene";
            this.cmdDiff.UseVisualStyleBackColor = true;
            this.cmdDiff.Click += new System.EventHandler(this.cmdDiff_Click);
            // 
            // cmdShow1
            // 
            this.cmdShow1.Location = new System.Drawing.Point(15, 78);
            this.cmdShow1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdShow1.Name = "cmdShow1";
            this.cmdShow1.Size = new System.Drawing.Size(581, 36);
            this.cmdShow1.TabIndex = 5;
            this.cmdShow1.Text = "Scan 1 anzeigen";
            this.cmdShow1.UseVisualStyleBackColor = true;
            this.cmdShow1.Click += new System.EventHandler(this.cmdShow1_Click);
            // 
            // cmbScans1
            // 
            this.cmbScans1.FormattingEnabled = true;
            this.cmbScans1.Location = new System.Drawing.Point(15, 47);
            this.cmbScans1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbScans1.Name = "cmbScans1";
            this.cmbScans1.Size = new System.Drawing.Size(580, 24);
            this.cmbScans1.TabIndex = 6;
            this.cmbScans1.Text = "Scan 1 auswählen";
            // 
            // cmbScans2
            // 
            this.cmbScans2.FormattingEnabled = true;
            this.cmbScans2.Location = new System.Drawing.Point(657, 47);
            this.cmbScans2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbScans2.Name = "cmbScans2";
            this.cmbScans2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbScans2.Size = new System.Drawing.Size(580, 24);
            this.cmbScans2.TabIndex = 8;
            this.cmbScans2.Text = "Scan 2 auswählen";
            // 
            // cmdShow2
            // 
            this.cmdShow2.Location = new System.Drawing.Point(657, 80);
            this.cmdShow2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdShow2.Name = "cmdShow2";
            this.cmdShow2.Size = new System.Drawing.Size(581, 36);
            this.cmdShow2.TabIndex = 7;
            this.cmdShow2.Text = "Scan 2 anzeigen";
            this.cmdShow2.UseVisualStyleBackColor = true;
            this.cmdShow2.Click += new System.EventHandler(this.cmdShow2_Click);
            // 
            // TxtOut2
            // 
            this.TxtOut2.Location = new System.Drawing.Point(657, 164);
            this.TxtOut2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtOut2.Multiline = true;
            this.TxtOut2.Name = "TxtOut2";
            this.TxtOut2.ReadOnly = true;
            this.TxtOut2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOut2.Size = new System.Drawing.Size(580, 374);
            this.TxtOut2.TabIndex = 9;
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(340, 590);
            this.txtDiff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiff.Multiline = true;
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.ReadOnly = true;
            this.txtDiff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiff.Size = new System.Drawing.Size(580, 178);
            this.txtDiff.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Scan 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Scan 1:";
            // 
            // cmdDelete1
            // 
            this.cmdDelete1.Location = new System.Drawing.Point(15, 121);
            this.cmdDelete1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDelete1.Name = "cmdDelete1";
            this.cmdDelete1.Size = new System.Drawing.Size(581, 36);
            this.cmdDelete1.TabIndex = 13;
            this.cmdDelete1.Text = "Scan 1 löschen";
            this.cmdDelete1.UseVisualStyleBackColor = true;
            this.cmdDelete1.Click += new System.EventHandler(this.cmdDelete1_Click);
            // 
            // cmdDelete2
            // 
            this.cmdDelete2.Location = new System.Drawing.Point(657, 121);
            this.cmdDelete2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDelete2.Name = "cmdDelete2";
            this.cmdDelete2.Size = new System.Drawing.Size(581, 36);
            this.cmdDelete2.TabIndex = 14;
            this.cmdDelete2.Text = "Scan 2 löschen";
            this.cmdDelete2.UseVisualStyleBackColor = true;
            this.cmdDelete2.Click += new System.EventHandler(this.cmdDelete2_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 821);
            this.Controls.Add(this.cmdDelete2);
            this.Controls.Add(this.cmdDelete1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiff);
            this.Controls.Add(this.TxtOut2);
            this.Controls.Add(this.cmbScans2);
            this.Controls.Add(this.cmdShow2);
            this.Controls.Add(this.cmbScans1);
            this.Controls.Add(this.cmdShow1);
            this.Controls.Add(this.cmdDiff);
            this.Controls.Add(this.TxtOut1);
            this.Controls.Add(this.CmdScan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdScan;
        private System.Windows.Forms.TextBox TxtOut1;
        private System.Windows.Forms.Button cmdDiff;
        private System.Windows.Forms.Button cmdShow1;
        private System.Windows.Forms.ComboBox cmbScans1;
        private System.Windows.Forms.ComboBox cmbScans2;
        private System.Windows.Forms.Button cmdShow2;
        private System.Windows.Forms.TextBox TxtOut2;
        private System.Windows.Forms.TextBox txtDiff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDelete1;
        private System.Windows.Forms.Button cmdDelete2;
    }
}