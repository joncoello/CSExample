﻿namespace CS.UI.Client.ClientTab
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
            this.grdList = new Janus.Windows.GridEX.GridEX();
            this.cmdStartWorkflow = new System.Windows.Forms.Button();
            this.cmdAssignmentJobList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client form example";
            // 
            // cmdUploadDocument
            // 
            this.cmdUploadDocument.Location = new System.Drawing.Point(20, 73);
            this.cmdUploadDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdUploadDocument.Name = "cmdUploadDocument";
            this.cmdUploadDocument.Size = new System.Drawing.Size(185, 28);
            this.cmdUploadDocument.TabIndex = 1;
            this.cmdUploadDocument.Text = "Upload document";
            this.cmdUploadDocument.UseVisualStyleBackColor = true;
            this.cmdUploadDocument.Click += new System.EventHandler(this.cmdUploadDocument_Click);
            // 
            // grdList
            // 
            this.grdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdList.Location = new System.Drawing.Point(16, 108);
            this.grdList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(625, 369);
            this.grdList.TabIndex = 2;
            this.grdList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.grdList_RowDoubleClick);
            // 
            // cmdStartWorkflow
            // 
            this.cmdStartWorkflow.Location = new System.Drawing.Point(352, 41);
            this.cmdStartWorkflow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdStartWorkflow.Name = "cmdStartWorkflow";
            this.cmdStartWorkflow.Size = new System.Drawing.Size(165, 28);
            this.cmdStartWorkflow.TabIndex = 3;
            this.cmdStartWorkflow.Text = "Start workflow";
            this.cmdStartWorkflow.UseVisualStyleBackColor = true;
            this.cmdStartWorkflow.Click += new System.EventHandler(this.cmdStartWorkflow_Click);
            // 
            // cmdAssignmentJobList
            // 
            this.cmdAssignmentJobList.Location = new System.Drawing.Point(352, 77);
            this.cmdAssignmentJobList.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAssignmentJobList.Name = "cmdAssignmentJobList";
            this.cmdAssignmentJobList.Size = new System.Drawing.Size(165, 28);
            this.cmdAssignmentJobList.TabIndex = 4;
            this.cmdAssignmentJobList.Text = "Assignment/job list";
            this.cmdAssignmentJobList.UseVisualStyleBackColor = true;
            this.cmdAssignmentJobList.Click += new System.EventHandler(this.cmdAssignmentJobList_Click);
            // 
            // frmClientTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.cmdAssignmentJobList);
            this.Controls.Add(this.cmdStartWorkflow);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.cmdUploadDocument);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientTab";
            this.Text = "frmClientTab";
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUploadDocument;
        private Janus.Windows.GridEX.GridEX grdList;
        private System.Windows.Forms.Button cmdStartWorkflow;
        private System.Windows.Forms.Button cmdAssignmentJobList;
    }
}