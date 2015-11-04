namespace CS.UI.Maintenance.DataAPIForm
{
    partial class frmDataAPI
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
            this.cmdCreateIndividual = new System.Windows.Forms.Button();
            this.cmdCreateClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCreateIndividual
            // 
            this.cmdCreateIndividual.Location = new System.Drawing.Point(12, 40);
            this.cmdCreateIndividual.Name = "cmdCreateIndividual";
            this.cmdCreateIndividual.Size = new System.Drawing.Size(115, 23);
            this.cmdCreateIndividual.TabIndex = 0;
            this.cmdCreateIndividual.Text = "Create Individual";
            this.cmdCreateIndividual.UseVisualStyleBackColor = true;
            this.cmdCreateIndividual.Click += new System.EventHandler(this.cmdCreateIndividual_Click);
            // 
            // cmdCreateClient
            // 
            this.cmdCreateClient.Location = new System.Drawing.Point(12, 69);
            this.cmdCreateClient.Name = "cmdCreateClient";
            this.cmdCreateClient.Size = new System.Drawing.Size(115, 23);
            this.cmdCreateClient.TabIndex = 1;
            this.cmdCreateClient.Text = "Create client";
            this.cmdCreateClient.UseVisualStyleBackColor = true;
            this.cmdCreateClient.Click += new System.EventHandler(this.cmdCreateClient_Click);
            // 
            // frmDataAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(499, 429);
            this.Controls.Add(this.cmdCreateClient);
            this.Controls.Add(this.cmdCreateIndividual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDataAPI";
            this.Text = "frmDataAPI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateIndividual;
        private System.Windows.Forms.Button cmdCreateClient;
    }
}