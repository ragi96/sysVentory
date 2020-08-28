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
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(375, 600);
            this.CmdScan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(179, 29);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scanne diesen Computer";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.CmdScan_Click);
            // 
            // TxtOut1
            // 
            this.TxtOut1.Location = new System.Drawing.Point(11, 103);
            this.TxtOut1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtOut1.Multiline = true;
            this.TxtOut1.Name = "TxtOut1";
            this.TxtOut1.Size = new System.Drawing.Size(436, 305);
            this.TxtOut1.TabIndex = 1;
            // 
            // cmdDiff
            // 
            this.cmdDiff.Location = new System.Drawing.Point(384, 414);
            this.cmdDiff.Name = "cmdDiff";
            this.cmdDiff.Size = new System.Drawing.Size(183, 29);
            this.cmdDiff.TabIndex = 4;
            this.cmdDiff.Text = "Delta berechnene";
            this.cmdDiff.UseVisualStyleBackColor = true;
            this.cmdDiff.Click += new System.EventHandler(this.cmdDiff_Click);
            // 
            // cmdShow1
            // 
            this.cmdShow1.Location = new System.Drawing.Point(11, 63);
            this.cmdShow1.Name = "cmdShow1";
            this.cmdShow1.Size = new System.Drawing.Size(436, 29);
            this.cmdShow1.TabIndex = 5;
            this.cmdShow1.Text = "Scan 1 anzeigen";
            this.cmdShow1.UseVisualStyleBackColor = true;
            this.cmdShow1.Click += new System.EventHandler(this.cmdShow1_Click);
            // 
            // cmbScans1
            // 
            this.cmbScans1.FormattingEnabled = true;
            this.cmbScans1.Location = new System.Drawing.Point(11, 38);
            this.cmbScans1.Name = "cmbScans1";
            this.cmbScans1.Size = new System.Drawing.Size(436, 21);
            this.cmbScans1.TabIndex = 6;
            // 
            // cmbScans2
            // 
            this.cmbScans2.FormattingEnabled = true;
            this.cmbScans2.Location = new System.Drawing.Point(493, 38);
            this.cmbScans2.Name = "cmbScans2";
            this.cmbScans2.Size = new System.Drawing.Size(436, 21);
            this.cmbScans2.TabIndex = 8;
            // 
            // cmdShow2
            // 
            this.cmdShow2.Location = new System.Drawing.Point(493, 65);
            this.cmdShow2.Name = "cmdShow2";
            this.cmdShow2.Size = new System.Drawing.Size(436, 29);
            this.cmdShow2.TabIndex = 7;
            this.cmdShow2.Text = "Scan 2 anzeigen";
            this.cmdShow2.UseVisualStyleBackColor = true;
            this.cmdShow2.Click += new System.EventHandler(this.cmdShow2_Click);
            // 
            // TxtOut2
            // 
            this.TxtOut2.Location = new System.Drawing.Point(493, 103);
            this.TxtOut2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtOut2.Multiline = true;
            this.TxtOut2.Name = "TxtOut2";
            this.TxtOut2.Size = new System.Drawing.Size(436, 305);
            this.TxtOut2.TabIndex = 9;
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(255, 449);
            this.txtDiff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiff.Multiline = true;
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(436, 145);
            this.txtDiff.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Scan 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Scan 1:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 644);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
    }
}