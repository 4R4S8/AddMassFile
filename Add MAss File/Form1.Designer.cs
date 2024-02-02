namespace Add_MAss_File
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
            this.btnSearchPathToUploadTo = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnSearchPathToUploadFrom = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchPathToUploadTo
            // 
            this.btnSearchPathToUploadTo.Location = new System.Drawing.Point(48, 15);
            this.btnSearchPathToUploadTo.Name = "btnSearchPathToUploadTo";
            this.btnSearchPathToUploadTo.Size = new System.Drawing.Size(66, 23);
            this.btnSearchPathToUploadTo.TabIndex = 0;
            this.btnSearchPathToUploadTo.Text = "Browse ...";
            this.btnSearchPathToUploadTo.UseVisualStyleBackColor = true;
            this.btnSearchPathToUploadTo.Click += new System.EventHandler(this.btnSearchPathToUploadTo_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(48, 39);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(182, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // btnSearchPathToUploadFrom
            // 
            this.btnSearchPathToUploadFrom.Location = new System.Drawing.Point(48, 67);
            this.btnSearchPathToUploadFrom.Name = "btnSearchPathToUploadFrom";
            this.btnSearchPathToUploadFrom.Size = new System.Drawing.Size(66, 23);
            this.btnSearchPathToUploadFrom.TabIndex = 0;
            this.btnSearchPathToUploadFrom.Text = "Browse ...";
            this.btnSearchPathToUploadFrom.UseVisualStyleBackColor = true;
            this.btnSearchPathToUploadFrom.Click += new System.EventHandler(this.btnSearchPathToUploadFrom_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(48, 93);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(182, 20);
            this.txtTo.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(220, 185);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 43);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(72, 141);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(101, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 367);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnSearchPathToUploadFrom);
            this.Controls.Add(this.btnSearchPathToUploadTo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPathToUploadTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnSearchPathToUploadFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
    }
}

