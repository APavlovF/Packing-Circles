namespace Packing_Circles
{
    partial class Form2
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
            this.listBoxR = new System.Windows.Forms.ListBox();
            this.listBoxT = new System.Windows.Forms.ListBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.labelQtyR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRQtyPerSheet = new System.Windows.Forms.TextBox();
            this.textBoxTQtyPerSheet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxR
            // 
            this.listBoxR.FormattingEnabled = true;
            this.listBoxR.Location = new System.Drawing.Point(16, 59);
            this.listBoxR.Name = "listBoxR";
            this.listBoxR.Size = new System.Drawing.Size(125, 251);
            this.listBoxR.TabIndex = 0;
            // 
            // listBoxT
            // 
            this.listBoxT.FormattingEnabled = true;
            this.listBoxT.Location = new System.Drawing.Point(151, 61);
            this.listBoxT.Name = "listBoxT";
            this.listBoxT.Size = new System.Drawing.Size(125, 251);
            this.listBoxT.TabIndex = 1;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(16, 17);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(83, 13);
            this.labelR.TabIndex = 2;
            this.labelR.Text = "Rectangular cut";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(151, 17);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(72, 13);
            this.labelT.TabIndex = 3;
            this.labelT.Text = "Triangular cut";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(282, 290);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(65, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(282, 253);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(65, 23);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // labelQtyR
            // 
            this.labelQtyR.AutoSize = true;
            this.labelQtyR.Location = new System.Drawing.Point(16, 38);
            this.labelQtyR.Name = "labelQtyR";
            this.labelQtyR.Size = new System.Drawing.Size(59, 13);
            this.labelQtyR.TabIndex = 6;
            this.labelQtyR.Text = "Qty/Sheet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qty/Sheet:";
            // 
            // textBoxRQtyPerSheet
            // 
            this.textBoxRQtyPerSheet.Enabled = false;
            this.textBoxRQtyPerSheet.Location = new System.Drawing.Point(93, 35);
            this.textBoxRQtyPerSheet.Name = "textBoxRQtyPerSheet";
            this.textBoxRQtyPerSheet.Size = new System.Drawing.Size(48, 20);
            this.textBoxRQtyPerSheet.TabIndex = 15;
            this.textBoxRQtyPerSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTQtyPerSheet
            // 
            this.textBoxTQtyPerSheet.Enabled = false;
            this.textBoxTQtyPerSheet.Location = new System.Drawing.Point(228, 35);
            this.textBoxTQtyPerSheet.Name = "textBoxTQtyPerSheet";
            this.textBoxTQtyPerSheet.Size = new System.Drawing.Size(48, 20);
            this.textBoxTQtyPerSheet.TabIndex = 16;
            this.textBoxTQtyPerSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 324);
            this.Controls.Add(this.textBoxTQtyPerSheet);
            this.Controls.Add(this.textBoxRQtyPerSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQtyR);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.listBoxT);
            this.Controls.Add(this.listBoxR);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Centers Positions";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxR;
        private System.Windows.Forms.ListBox listBoxT;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelQtyR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRQtyPerSheet;
        private System.Windows.Forms.TextBox textBoxTQtyPerSheet;
    }
}