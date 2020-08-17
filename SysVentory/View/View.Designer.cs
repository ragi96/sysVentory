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
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(537, 403);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(239, 35);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scan diesen Computer";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.CmdScan_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdScan);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdScan;
    }
}