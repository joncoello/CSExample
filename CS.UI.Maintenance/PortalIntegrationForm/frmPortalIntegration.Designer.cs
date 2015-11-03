namespace CS.UI.Maintenance.PortalIntegrationForm
{
    partial class frmPortalIntegration
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
            this.cmdTest = new System.Windows.Forms.Button();
            this.cmdLogIn = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portal Test Rig";
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(12, 54);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 1;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.Location = new System.Drawing.Point(12, 83);
            this.cmdLogIn.Name = "cmdLogIn";
            this.cmdLogIn.Size = new System.Drawing.Size(75, 23);
            this.cmdLogIn.TabIndex = 2;
            this.cmdLogIn.Text = "Log in";
            this.cmdLogIn.UseVisualStyleBackColor = true;
            this.cmdLogIn.Click += new System.EventHandler(this.cmdLogIn_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Location = new System.Drawing.Point(12, 112);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(75, 23);
            this.cmdLogOut.TabIndex = 3;
            this.cmdLogOut.Text = "Log out";
            this.cmdLogOut.UseVisualStyleBackColor = true;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(115, 54);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(482, 380);
            this.txtResponse.TabIndex = 4;
            // 
            // frmPortalIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(609, 446);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.cmdLogOut);
            this.Controls.Add(this.cmdLogIn);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPortalIntegration";
            this.Text = "frmPortalIntegration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Button cmdLogIn;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.TextBox txtResponse;
    }
}