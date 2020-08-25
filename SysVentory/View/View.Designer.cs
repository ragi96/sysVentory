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
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.TxtSelection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(1074, 781);
            this.CmdScan.Margin = new System.Windows.Forms.Padding(6);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(478, 68);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scanne diesen Computer";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.CmdScan_Click);
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(537, 23);
            this.TxtOut.Margin = new System.Windows.Forms.Padding(6);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(1011, 721);
            this.TxtOut.TabIndex = 1;
            // 
            // TxtSelection
            // 
            this.TxtSelection.Location = new System.Drawing.Point(26, 23);
            this.TxtSelection.Multiline = true;
            this.TxtSelection.Name = "TxtSelection";
            this.TxtSelection.Size = new System.Drawing.Size(481, 721);
            this.TxtSelection.TabIndex = 2;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 870);
            this.Controls.Add(this.TxtSelection);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.CmdScan);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdScan;
        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.TextBox TxtSelection;
    }
}