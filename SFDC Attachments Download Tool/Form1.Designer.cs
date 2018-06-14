namespace SFDC_Attachments_Download_Tool
{
    partial class Form1
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
            this.btnFundRequest = new System.Windows.Forms.Button();
            this.btnFundClaims = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFundRequest
            // 
            this.btnFundRequest.Location = new System.Drawing.Point(12, 31);
            this.btnFundRequest.Name = "btnFundRequest";
            this.btnFundRequest.Size = new System.Drawing.Size(128, 51);
            this.btnFundRequest.TabIndex = 1;
            this.btnFundRequest.Text = "Fund Request";
            this.btnFundRequest.UseVisualStyleBackColor = true;
            this.btnFundRequest.Click += new System.EventHandler(this.btnFundRequest_Click);
            // 
            // btnFundClaims
            // 
            this.btnFundClaims.Location = new System.Drawing.Point(162, 31);
            this.btnFundClaims.Name = "btnFundClaims";
            this.btnFundClaims.Size = new System.Drawing.Size(128, 51);
            this.btnFundClaims.TabIndex = 2;
            this.btnFundClaims.Text = "Fund Claims";
            this.btnFundClaims.UseVisualStyleBackColor = true;
            this.btnFundClaims.Click += new System.EventHandler(this.btnFundClaims_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 110);
            this.Controls.Add(this.btnFundClaims);
            this.Controls.Add(this.btnFundRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFundRequest;
        private System.Windows.Forms.Button btnFundClaims;
    }
}

