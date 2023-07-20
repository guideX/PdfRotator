namespace PdfRotator {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.cmdRotate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.cmdInputFile = new System.Windows.Forms.Button();
            this.cmdOutputFile = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRotation = new System.Windows.Forms.ComboBox();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.cmdRotate);
            this.panel1.Location = new System.Drawing.Point(-1, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(20, 14);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 1;
            this.lblError.Visible = false;
            // 
            // cmdRotate
            // 
            this.cmdRotate.Location = new System.Drawing.Point(17, 14);
            this.cmdRotate.Name = "cmdRotate";
            this.cmdRotate.Size = new System.Drawing.Size(318, 21);
            this.cmdRotate.TabIndex = 0;
            this.cmdRotate.Text = "Rotate";
            this.cmdRotate.UseVisualStyleBackColor = true;
            this.cmdRotate.Click += new System.EventHandler(this.cmdRotate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input File:";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(16, 30);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(259, 21);
            this.txtInputFile.TabIndex = 2;
            // 
            // cmdInputFile
            // 
            this.cmdInputFile.Location = new System.Drawing.Point(281, 29);
            this.cmdInputFile.Name = "cmdInputFile";
            this.cmdInputFile.Size = new System.Drawing.Size(53, 21);
            this.cmdInputFile.TabIndex = 3;
            this.cmdInputFile.Text = "Select";
            this.cmdInputFile.UseVisualStyleBackColor = true;
            this.cmdInputFile.Click += new System.EventHandler(this.cmdInputFile_Click);
            // 
            // cmdOutputFile
            // 
            this.cmdOutputFile.Location = new System.Drawing.Point(281, 71);
            this.cmdOutputFile.Name = "cmdOutputFile";
            this.cmdOutputFile.Size = new System.Drawing.Size(53, 21);
            this.cmdOutputFile.TabIndex = 6;
            this.cmdOutputFile.Text = "Select";
            this.cmdOutputFile.UseVisualStyleBackColor = true;
            this.cmdOutputFile.Click += new System.EventHandler(this.cmdOutputFile_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(16, 71);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(259, 21);
            this.txtOutputFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rotation:";
            // 
            // cboRotation
            // 
            this.cboRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRotation.FormattingEnabled = true;
            this.cboRotation.Items.AddRange(new object[] {
            "Rotate Right (80)",
            "Rotate Flip (160)",
            "Flip Left (270)"});
            this.cboRotation.Location = new System.Drawing.Point(16, 115);
            this.cboRotation.Name = "cboRotation";
            this.cboRotation.Size = new System.Drawing.Size(318, 21);
            this.cboRotation.TabIndex = 8;
            this.cboRotation.SelectedIndexChanged += new System.EventHandler(this.cboRotation_SelectedIndexChanged);
            // 
            // txtRotation
            // 
            this.txtRotation.Location = new System.Drawing.Point(175, 115);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(100, 21);
            this.txtRotation.TabIndex = 9;
            this.txtRotation.Text = "90";
            this.txtRotation.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdOutputFile);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdInputFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboRotation);
            this.Controls.Add(this.txtRotation);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Pdf  Rotator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button cmdInputFile;
        private System.Windows.Forms.Button cmdOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRotation;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.Label lblError;
    }
}