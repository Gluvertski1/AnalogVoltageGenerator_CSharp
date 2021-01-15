namespace AnalogVoltageOutput
{
    partial class AnalogVoltageController
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.analogVoltageDisp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(81, 184);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Minimum = -1000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(282, 43);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // analogVoltageDisp
            // 
            this.analogVoltageDisp.Enabled = false;
            this.analogVoltageDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogVoltageDisp.Location = new System.Drawing.Point(175, 99);
            this.analogVoltageDisp.Name = "analogVoltageDisp";
            this.analogVoltageDisp.Size = new System.Drawing.Size(89, 26);
            this.analogVoltageDisp.TabIndex = 1;
            this.analogVoltageDisp.Text = "0.0";
            this.analogVoltageDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Analog Output Voltage";
            // 
            // AnalogVoltageController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analogVoltageDisp);
            this.Controls.Add(this.hScrollBar1);
            this.MaximizeBox = false;
            this.Name = "AnalogVoltageController";
            this.Text = "Analog Voltage Output";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalogVoltageController_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox analogVoltageDisp;
        private System.Windows.Forms.Label label1;
    }
}

