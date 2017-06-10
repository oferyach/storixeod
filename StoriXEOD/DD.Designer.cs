namespace StoriXEOD
{
    partial class DD
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
            this.Stop = new System.Windows.Forms.Button();
            this.Lock = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(47, 395);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(89, 51);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Lock
            // 
            this.Lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lock.Location = new System.Drawing.Point(219, 395);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(103, 51);
            this.Lock.TabIndex = 1;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(417, 395);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(87, 51);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // DD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 496);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.Stop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DD";
            this.Text = "DD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.Button Close;
    }
}