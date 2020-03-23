namespace Impact_Respirators
{
    partial class ucSmallRespiratorData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMachineNum = new System.Windows.Forms.Label();
            this.pnlAlertColor = new System.Windows.Forms.Panel();
            this.pnlMainData.SuspendLayout();
            this.pnlAlertColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainData
            // 
            this.pnlMainData.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlMainData.Controls.Add(this.lblMachineNum);
            this.pnlMainData.Controls.Add(this.label1);
            this.pnlMainData.Location = new System.Drawing.Point(11, 9);
            this.pnlMainData.Name = "pnlMainData";
            this.pnlMainData.Size = new System.Drawing.Size(210, 127);
            this.pnlMainData.TabIndex = 0;
            this.pnlMainData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMainData_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lblMachineNum
            // 
            this.lblMachineNum.AutoSize = true;
            this.lblMachineNum.ForeColor = System.Drawing.Color.White;
            this.lblMachineNum.Location = new System.Drawing.Point(13, 11);
            this.lblMachineNum.Name = "lblMachineNum";
            this.lblMachineNum.Size = new System.Drawing.Size(89, 13);
            this.lblMachineNum.TabIndex = 1;
            this.lblMachineNum.Text = "Machine number:";
            // 
            // pnlAlertColor
            // 
            this.pnlAlertColor.BackColor = System.Drawing.Color.Lime;
            this.pnlAlertColor.Controls.Add(this.pnlMainData);
            this.pnlAlertColor.Location = new System.Drawing.Point(3, 2);
            this.pnlAlertColor.Name = "pnlAlertColor";
            this.pnlAlertColor.Size = new System.Drawing.Size(232, 144);
            this.pnlAlertColor.TabIndex = 1;
            // 
            // ucSmallRespiratorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlAlertColor);
            this.Name = "ucSmallRespiratorData";
            this.Size = new System.Drawing.Size(238, 148);
            this.pnlMainData.ResumeLayout(false);
            this.pnlMainData.PerformLayout();
            this.pnlAlertColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainData;
        private System.Windows.Forms.Label lblMachineNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAlertColor;
    }
}
