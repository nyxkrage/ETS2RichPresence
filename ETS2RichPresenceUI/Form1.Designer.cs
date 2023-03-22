namespace ETS2RichPresenceUI
{
    partial class ETS2RichPresenceUI
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.useRealTimeFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyBtn.Location = new System.Drawing.Point(12, 36);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(165, 59);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Apply Configuration";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // runBtn
            // 
            this.runBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runBtn.Location = new System.Drawing.Point(183, 36);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(165, 59);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Start Rich Presence";
            this.runBtn.UseVisualStyleBackColor = true;
            // 
            // useRealTimeFormat
            // 
            this.useRealTimeFormat.AutoSize = true;
            this.useRealTimeFormat.Location = new System.Drawing.Point(12, 12);
            this.useRealTimeFormat.Name = "useRealTimeFormat";
            this.useRealTimeFormat.Size = new System.Drawing.Size(205, 17);
            this.useRealTimeFormat.TabIndex = 2;
            this.useRealTimeFormat.Text = "Use real time for time left on active job";
            this.useRealTimeFormat.UseVisualStyleBackColor = true;
            // 
            // ETS2RichPresenceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 107);
            this.Controls.Add(this.useRealTimeFormat);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.applyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ETS2RichPresenceUI";
            this.Text = "Euro Truck Simulator 2 Rich Presence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.CheckBox useRealTimeFormat;
    }
}

