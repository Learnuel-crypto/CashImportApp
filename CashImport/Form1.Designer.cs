namespace CashImport
    {
    partial class CashImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashImportForm));
            this.lbInfor = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfor.Location = new System.Drawing.Point(159, 111);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(87, 17);
            this.lbInfor.TabIndex = 19;
            this.lbInfor.Text = "Please Wait...";
            this.lbInfor.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(291, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 33);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnimport
            // 
            this.btnimport.FlatAppearance.BorderSize = 0;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimport.Location = new System.Drawing.Point(208, 72);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(67, 33);
            this.btnimport.TabIndex = 17;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(7, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(351, 25);
            this.txtFileName.TabIndex = 16;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Image = global::CashImport.Properties.Resources.More_30px;
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectFile.Location = new System.Drawing.Point(363, 25);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(37, 26);
            this.btnSelectFile.TabIndex = 14;
            this.btnSelectFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Please ensure to import the two files";
            // 
            // CashImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CashImportForm_FormClosed);
            this.Load += new System.EventHandler(this.CashImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label lbInfor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        }
    }

