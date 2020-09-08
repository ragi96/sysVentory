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
            this.CmdDiff = new System.Windows.Forms.Button();
            this.CmdShow1 = new System.Windows.Forms.Button();
            this.CmbScans1 = new System.Windows.Forms.ComboBox();
            this.CmbScans2 = new System.Windows.Forms.ComboBox();
            this.CmdShow2 = new System.Windows.Forms.Button();
            this.TxtOut2 = new System.Windows.Forms.TextBox();
            this.LblScan2 = new System.Windows.Forms.Label();
            this.LblScan1 = new System.Windows.Forms.Label();
            this.CmdDelete1 = new System.Windows.Forms.Button();
            this.CmdDelete2 = new System.Windows.Forms.Button();
            this.RtbDiffSoftware = new System.Windows.Forms.RichTextBox();
            this.CmbDeltas = new System.Windows.Forms.ComboBox();
            this.CmdShowDiff = new System.Windows.Forms.Button();
            this.LblDelta = new System.Windows.Forms.Label();
            this.RtbDiffHardware = new System.Windows.Forms.RichTextBox();
            this.LblHardware = new System.Windows.Forms.Label();
            this.LblSoftware = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(29, 1083);
            this.CmdScan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(2352, 69);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scanne diesen Computer";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.CmdScan_Click);
            // 
            // TxtOut1
            // 
            this.TxtOut1.Location = new System.Drawing.Point(29, 317);
            this.TxtOut1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtOut1.Multiline = true;
            this.TxtOut1.Name = "TxtOut1";
            this.TxtOut1.ReadOnly = true;
            this.TxtOut1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtOut1.Size = new System.Drawing.Size(1156, 722);
            this.TxtOut1.TabIndex = 1;
            this.TxtOut1.WordWrap = false;
            // 
            // CmdDiff
            // 
            this.CmdDiff.Location = new System.Drawing.Point(2411, 234);
            this.CmdDiff.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmdDiff.Name = "CmdDiff";
            this.CmdDiff.Size = new System.Drawing.Size(1163, 69);
            this.CmdDiff.TabIndex = 4;
            this.CmdDiff.Text = "Neues Delta berechnen";
            this.CmdDiff.UseVisualStyleBackColor = true;
            this.CmdDiff.Click += new System.EventHandler(this.CmdDiff_Click);
            // 
            // CmdShow1
            // 
            this.CmdShow1.Location = new System.Drawing.Point(29, 150);
            this.CmdShow1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmdShow1.Name = "CmdShow1";
            this.CmdShow1.Size = new System.Drawing.Size(1163, 69);
            this.CmdShow1.TabIndex = 5;
            this.CmdShow1.Text = "Scan 1 anzeigen";
            this.CmdShow1.UseVisualStyleBackColor = true;
            this.CmdShow1.Click += new System.EventHandler(this.CmdShow1_Click);
            // 
            // CmbScans1
            // 
            this.CmbScans1.FormattingEnabled = true;
            this.CmbScans1.Location = new System.Drawing.Point(29, 91);
            this.CmbScans1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmbScans1.Name = "CmbScans1";
            this.CmbScans1.Size = new System.Drawing.Size(1156, 39);
            this.CmbScans1.TabIndex = 6;
            this.CmbScans1.Text = "Scan 1 auswählen";
            // 
            // CmbScans2
            // 
            this.CmbScans2.FormattingEnabled = true;
            this.CmbScans2.Location = new System.Drawing.Point(1221, 91);
            this.CmbScans2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmbScans2.Name = "CmbScans2";
            this.CmbScans2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbScans2.Size = new System.Drawing.Size(1156, 39);
            this.CmbScans2.TabIndex = 8;
            this.CmbScans2.Text = "Scan 2 auswählen";
            // 
            // CmdShow2
            // 
            this.CmdShow2.Location = new System.Drawing.Point(1221, 155);
            this.CmdShow2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmdShow2.Name = "CmdShow2";
            this.CmdShow2.Size = new System.Drawing.Size(1163, 69);
            this.CmdShow2.TabIndex = 7;
            this.CmdShow2.Text = "Scan 2 anzeigen";
            this.CmdShow2.UseVisualStyleBackColor = true;
            this.CmdShow2.Click += new System.EventHandler(this.CmdShow2_Click);
            // 
            // TxtOut2
            // 
            this.TxtOut2.Location = new System.Drawing.Point(1221, 317);
            this.TxtOut2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtOut2.Multiline = true;
            this.TxtOut2.Name = "TxtOut2";
            this.TxtOut2.ReadOnly = true;
            this.TxtOut2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtOut2.Size = new System.Drawing.Size(1156, 722);
            this.TxtOut2.TabIndex = 9;
            this.TxtOut2.WordWrap = false;
            // 
            // LblScan2
            // 
            this.LblScan2.AutoSize = true;
            this.LblScan2.Location = new System.Drawing.Point(1221, 45);
            this.LblScan2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblScan2.Name = "LblScan2";
            this.LblScan2.Size = new System.Drawing.Size(111, 32);
            this.LblScan2.TabIndex = 11;
            this.LblScan2.Text = "Scan 2:";
            // 
            // LblScan1
            // 
            this.LblScan1.AutoSize = true;
            this.LblScan1.Location = new System.Drawing.Point(21, 45);
            this.LblScan1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblScan1.Name = "LblScan1";
            this.LblScan1.Size = new System.Drawing.Size(111, 32);
            this.LblScan1.TabIndex = 12;
            this.LblScan1.Text = "Scan 1:";
            // 
            // CmdDelete1
            // 
            this.CmdDelete1.Location = new System.Drawing.Point(29, 234);
            this.CmdDelete1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmdDelete1.Name = "CmdDelete1";
            this.CmdDelete1.Size = new System.Drawing.Size(1163, 69);
            this.CmdDelete1.TabIndex = 13;
            this.CmdDelete1.Text = "Scan 1 löschen";
            this.CmdDelete1.UseVisualStyleBackColor = true;
            this.CmdDelete1.Click += new System.EventHandler(this.CmdDelete1_Click);
            // 
            // CmdDelete2
            // 
            this.CmdDelete2.Location = new System.Drawing.Point(1221, 234);
            this.CmdDelete2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmdDelete2.Name = "CmdDelete2";
            this.CmdDelete2.Size = new System.Drawing.Size(1163, 69);
            this.CmdDelete2.TabIndex = 14;
            this.CmdDelete2.Text = "Scan 2 löschen";
            this.CmdDelete2.UseVisualStyleBackColor = true;
            this.CmdDelete2.Click += new System.EventHandler(this.CmdDelete2_Click);
            // 
            // RtbDiffSoftware
            // 
            this.RtbDiffSoftware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RtbDiffSoftware.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RtbDiffSoftware.Location = new System.Drawing.Point(2411, 728);
            this.RtbDiffSoftware.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RtbDiffSoftware.Name = "RtbDiffSoftware";
            this.RtbDiffSoftware.Size = new System.Drawing.Size(1156, 311);
            this.RtbDiffSoftware.TabIndex = 16;
            this.RtbDiffSoftware.Text = "";
            this.RtbDiffSoftware.WordWrap = false;
            // 
            // CmbDeltas
            // 
            this.CmbDeltas.FormattingEnabled = true;
            this.CmbDeltas.Location = new System.Drawing.Point(2411, 91);
            this.CmbDeltas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmbDeltas.Name = "CmbDeltas";
            this.CmbDeltas.Size = new System.Drawing.Size(1156, 39);
            this.CmbDeltas.TabIndex = 17;
            this.CmbDeltas.Text = "Delta auswählen";
            // 
            // CmdShowDiff
            // 
            this.CmdShowDiff.Location = new System.Drawing.Point(2411, 155);
            this.CmdShowDiff.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CmdShowDiff.Name = "CmdShowDiff";
            this.CmdShowDiff.Size = new System.Drawing.Size(1163, 69);
            this.CmdShowDiff.TabIndex = 18;
            this.CmdShowDiff.Text = "Delta anzeigen";
            this.CmdShowDiff.UseVisualStyleBackColor = true;
            this.CmdShowDiff.Click += new System.EventHandler(this.CmdShowDiff_Click);
            // 
            // LblDelta
            // 
            this.LblDelta.AutoSize = true;
            this.LblDelta.Location = new System.Drawing.Point(2405, 45);
            this.LblDelta.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblDelta.Name = "LblDelta";
            this.LblDelta.Size = new System.Drawing.Size(90, 32);
            this.LblDelta.TabIndex = 19;
            this.LblDelta.Text = "Delta:";
            // 
            // RtbDiffHardware
            // 
            this.RtbDiffHardware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RtbDiffHardware.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RtbDiffHardware.Location = new System.Drawing.Point(2411, 359);
            this.RtbDiffHardware.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RtbDiffHardware.Name = "RtbDiffHardware";
            this.RtbDiffHardware.Size = new System.Drawing.Size(1156, 301);
            this.RtbDiffHardware.TabIndex = 20;
            this.RtbDiffHardware.Text = "";
            this.RtbDiffHardware.WordWrap = false;
            // 
            // LblHardware
            // 
            this.LblHardware.AutoSize = true;
            this.LblHardware.Location = new System.Drawing.Point(2407, 320);
            this.LblHardware.Name = "LblHardware";
            this.LblHardware.Size = new System.Drawing.Size(145, 32);
            this.LblHardware.TabIndex = 21;
            this.LblHardware.Text = "Hardware:";
            // 
            // LblSoftware
            // 
            this.LblSoftware.AutoSize = true;
            this.LblSoftware.Location = new System.Drawing.Point(2407, 689);
            this.LblSoftware.Name = "LblSoftware";
            this.LblSoftware.Size = new System.Drawing.Size(135, 32);
            this.LblSoftware.TabIndex = 22;
            this.LblSoftware.Text = "Software:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3597, 1197);
            this.Controls.Add(this.LblSoftware);
            this.Controls.Add(this.LblHardware);
            this.Controls.Add(this.RtbDiffHardware);
            this.Controls.Add(this.LblDelta);
            this.Controls.Add(this.CmdShowDiff);
            this.Controls.Add(this.CmbDeltas);
            this.Controls.Add(this.RtbDiffSoftware);
            this.Controls.Add(this.CmdDelete2);
            this.Controls.Add(this.CmdDelete1);
            this.Controls.Add(this.LblScan1);
            this.Controls.Add(this.LblScan2);
            this.Controls.Add(this.TxtOut2);
            this.Controls.Add(this.CmbScans2);
            this.Controls.Add(this.CmdShow2);
            this.Controls.Add(this.CmbScans1);
            this.Controls.Add(this.CmdShow1);
            this.Controls.Add(this.CmdDiff);
            this.Controls.Add(this.TxtOut1);
            this.Controls.Add(this.CmdScan);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "View";
            this.Text = "sysVentory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdScan;
        private System.Windows.Forms.TextBox TxtOut1;
        private System.Windows.Forms.Button CmdDiff;
        private System.Windows.Forms.Button CmdShow1;
        private System.Windows.Forms.ComboBox CmbScans1;
        private System.Windows.Forms.ComboBox CmbScans2;
        private System.Windows.Forms.Button CmdShow2;
        private System.Windows.Forms.TextBox TxtOut2;
        private System.Windows.Forms.Label LblScan2;
        private System.Windows.Forms.Label LblScan1;
        private System.Windows.Forms.Button CmdDelete1;
        private System.Windows.Forms.Button CmdDelete2;
        private System.Windows.Forms.RichTextBox RtbDiffSoftware;
        private System.Windows.Forms.ComboBox CmbDeltas;
        private System.Windows.Forms.Button CmdShowDiff;
        private System.Windows.Forms.Label LblDelta;
        private System.Windows.Forms.RichTextBox RtbDiffHardware;
        private System.Windows.Forms.Label LblHardware;
        private System.Windows.Forms.Label LblSoftware;
    }
}