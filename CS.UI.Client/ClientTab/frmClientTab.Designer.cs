namespace CS.UI.Client.ClientTab
{
    partial class frmClientTab
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUploadDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client form example";
            // 
            // cmdUploadDocument
            // 
            this.cmdUploadDocument.Location = new System.Drawing.Point(15, 59);
            this.cmdUploadDocument.Name = "cmdUploadDocument";
            this.cmdUploadDocument.Size = new System.Drawing.Size(139, 23);
            this.cmdUploadDocument.TabIndex = 1;
            this.cmdUploadDocument.Text = "Upload document";
            this.cmdUploadDocument.UseVisualStyleBackColor = true;
            this.cmdUploadDocument.Click += new System.EventHandler(this.cmdUploadDocument_Click);
            // 
            // frmClientTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(493, 400);
            this.Controls.Add(this.cmdUploadDocument);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientTab";
            this.Text = "frmClientTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUploadDocument;
    }
}