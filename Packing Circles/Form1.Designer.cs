namespace Packing_Circles
{
    partial class FormMain
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpaceUnits = new System.Windows.Forms.Label();
            this.textBoxSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.labelWUnits = new System.Windows.Forms.Label();
            this.labelHUnits = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.panelOutputR = new System.Windows.Forms.Panel();
            this.labelRLastRest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRSheets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRQtyPerSheet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelOutputT = new System.Windows.Forms.Panel();
            this.labelTLastRest = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTSheets = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTQtyPerSheet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonFullSheet = new System.Windows.Forms.RadioButton();
            this.radioButtonLastSheet = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelOutputR.SuspendLayout();
            this.panelOutputT.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.labelSpaceUnits);
            this.panelInput.Controls.Add(this.textBoxSpace);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.comboBoxUnits);
            this.panelInput.Controls.Add(this.labelWUnits);
            this.panelInput.Controls.Add(this.labelHUnits);
            this.panelInput.Controls.Add(this.textBoxQuantity);
            this.panelInput.Controls.Add(this.textBoxSize);
            this.panelInput.Controls.Add(this.labelQuantity);
            this.panelInput.Controls.Add(this.labelSize);
            this.panelInput.Controls.Add(this.textBoxHeight);
            this.panelInput.Controls.Add(this.textBoxWidth);
            this.panelInput.Controls.Add(this.labelHeight);
            this.panelInput.Controls.Add(this.labelWidth);
            this.panelInput.Location = new System.Drawing.Point(12, 32);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(147, 139);
            this.panelInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "pc";
            // 
            // labelSpaceUnits
            // 
            this.labelSpaceUnits.AutoSize = true;
            this.labelSpaceUnits.Location = new System.Drawing.Point(105, 114);
            this.labelSpaceUnits.Name = "labelSpaceUnits";
            this.labelSpaceUnits.Size = new System.Drawing.Size(23, 13);
            this.labelSpaceUnits.TabIndex = 18;
            this.labelSpaceUnits.Text = "mm";
            // 
            // textBoxSpace
            // 
            this.textBoxSpace.Location = new System.Drawing.Point(51, 111);
            this.textBoxSpace.Name = "textBoxSpace";
            this.textBoxSpace.Size = new System.Drawing.Size(48, 20);
            this.textBoxSpace.TabIndex = 5;
            this.textBoxSpace.Text = "0";
            this.textBoxSpace.Click += new System.EventHandler(this.textBoxSpace_Click);
            this.textBoxSpace.Enter += new System.EventHandler(this.textBoxSpace_Enter);
            this.textBoxSpace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSpace_KeyDown);
            this.textBoxSpace.Leave += new System.EventHandler(this.textBoxSpace_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Space";
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(105, 6);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(37, 21);
            this.comboBoxUnits.TabIndex = 6;
            this.comboBoxUnits.Text = "Units";
            this.comboBoxUnits.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnits_SelectedIndexChanged);
            // 
            // labelWUnits
            // 
            this.labelWUnits.AutoSize = true;
            this.labelWUnits.Location = new System.Drawing.Point(105, 62);
            this.labelWUnits.Name = "labelWUnits";
            this.labelWUnits.Size = new System.Drawing.Size(23, 13);
            this.labelWUnits.TabIndex = 15;
            this.labelWUnits.Text = "mm";
            // 
            // labelHUnits
            // 
            this.labelHUnits.AutoSize = true;
            this.labelHUnits.Location = new System.Drawing.Point(105, 88);
            this.labelHUnits.Name = "labelHUnits";
            this.labelHUnits.Size = new System.Drawing.Size(23, 13);
            this.labelHUnits.TabIndex = 14;
            this.labelHUnits.Text = "mm";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(51, 32);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(48, 20);
            this.textBoxQuantity.TabIndex = 2;
            this.textBoxQuantity.Click += new System.EventHandler(this.textBoxQuantity_Click);
            this.textBoxQuantity.Enter += new System.EventHandler(this.textBoxQuantity_Enter);
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantity_KeyDown);
            this.textBoxQuantity.Leave += new System.EventHandler(this.textBoxQuantity_Leave);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(51, 6);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(48, 20);
            this.textBoxSize.TabIndex = 1;
            this.textBoxSize.Click += new System.EventHandler(this.textBoxSize_Click);
            this.textBoxSize.Enter += new System.EventHandler(this.textBoxSize_Enter);
            this.textBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSize_KeyDown);
            this.textBoxSize.Leave += new System.EventHandler(this.textBoxSize_Leave);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(3, 35);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 11;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(3, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "Size";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(51, 85);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(48, 20);
            this.textBoxHeight.TabIndex = 4;
            this.textBoxHeight.Click += new System.EventHandler(this.textBoxHeight_Click);
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            this.textBoxHeight.Enter += new System.EventHandler(this.textBoxHeight_Enter);
            this.textBoxHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHeight_KeyDown);
            this.textBoxHeight.Leave += new System.EventHandler(this.textBoxHeight_Leave);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(51, 59);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(48, 20);
            this.textBoxWidth.TabIndex = 3;
            this.textBoxWidth.Click += new System.EventHandler(this.textBoxWidth_Click);
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            this.textBoxWidth.Enter += new System.EventHandler(this.textBoxWidth_Enter);
            this.textBoxWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWidth_KeyDown);
            this.textBoxWidth.Leave += new System.EventHandler(this.textBoxWidth_Leave);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(3, 88);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(3, 62);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 6;
            this.labelWidth.Text = "Width";
            // 
            // panelOutputR
            // 
            this.panelOutputR.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutputR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutputR.Controls.Add(this.labelRLastRest);
            this.panelOutputR.Controls.Add(this.label7);
            this.panelOutputR.Controls.Add(this.label5);
            this.panelOutputR.Controls.Add(this.textBoxRSheets);
            this.panelOutputR.Controls.Add(this.label4);
            this.panelOutputR.Controls.Add(this.textBoxRQtyPerSheet);
            this.panelOutputR.Controls.Add(this.label2);
            this.panelOutputR.Location = new System.Drawing.Point(12, 205);
            this.panelOutputR.Name = "panelOutputR";
            this.panelOutputR.Size = new System.Drawing.Size(147, 94);
            this.panelOutputR.TabIndex = 1;
            // 
            // labelRLastRest
            // 
            this.labelRLastRest.AutoSize = true;
            this.labelRLastRest.Location = new System.Drawing.Point(78, 70);
            this.labelRLastRest.Name = "labelRLastRest";
            this.labelRLastRest.Size = new System.Drawing.Size(66, 13);
            this.labelRLastRest.TabIndex = 22;
            this.labelRLastRest.Text = "100 pc, 10%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last sheet rest:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sheets";
            // 
            // textBoxRSheets
            // 
            this.textBoxRSheets.Enabled = false;
            this.textBoxRSheets.Location = new System.Drawing.Point(15, 42);
            this.textBoxRSheets.Name = "textBoxRSheets";
            this.textBoxRSheets.Size = new System.Drawing.Size(48, 20);
            this.textBoxRSheets.TabIndex = 18;
            this.textBoxRSheets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Qty/Sheet";
            // 
            // textBoxRQtyPerSheet
            // 
            this.textBoxRQtyPerSheet.Enabled = false;
            this.textBoxRQtyPerSheet.Location = new System.Drawing.Point(82, 42);
            this.textBoxRQtyPerSheet.Name = "textBoxRQtyPerSheet";
            this.textBoxRQtyPerSheet.Size = new System.Drawing.Size(48, 20);
            this.textBoxRQtyPerSheet.TabIndex = 14;
            this.textBoxRQtyPerSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rectangular cut";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(84, 176);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(542, 374);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelOutputT
            // 
            this.panelOutputT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutputT.Controls.Add(this.labelTLastRest);
            this.panelOutputT.Controls.Add(this.label12);
            this.panelOutputT.Controls.Add(this.label8);
            this.panelOutputT.Controls.Add(this.textBoxTSheets);
            this.panelOutputT.Controls.Add(this.label9);
            this.panelOutputT.Controls.Add(this.textBoxTQtyPerSheet);
            this.panelOutputT.Controls.Add(this.label10);
            this.panelOutputT.Location = new System.Drawing.Point(12, 305);
            this.panelOutputT.Name = "panelOutputT";
            this.panelOutputT.Size = new System.Drawing.Size(147, 94);
            this.panelOutputT.TabIndex = 20;
            // 
            // labelTLastRest
            // 
            this.labelTLastRest.AutoSize = true;
            this.labelTLastRest.Location = new System.Drawing.Point(78, 70);
            this.labelTLastRest.Name = "labelTLastRest";
            this.labelTLastRest.Size = new System.Drawing.Size(66, 13);
            this.labelTLastRest.TabIndex = 24;
            this.labelTLastRest.Text = "100 pc, 10%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Last sheet rest:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sheets";
            // 
            // textBoxTSheets
            // 
            this.textBoxTSheets.Enabled = false;
            this.textBoxTSheets.Location = new System.Drawing.Point(15, 42);
            this.textBoxTSheets.Name = "textBoxTSheets";
            this.textBoxTSheets.Size = new System.Drawing.Size(48, 20);
            this.textBoxTSheets.TabIndex = 18;
            this.textBoxTSheets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Qty/Sheet";
            // 
            // textBoxTQtyPerSheet
            // 
            this.textBoxTQtyPerSheet.Enabled = false;
            this.textBoxTQtyPerSheet.Location = new System.Drawing.Point(82, 42);
            this.textBoxTQtyPerSheet.Name = "textBoxTQtyPerSheet";
            this.textBoxTQtyPerSheet.Size = new System.Drawing.Size(48, 20);
            this.textBoxTQtyPerSheet.TabIndex = 14;
            this.textBoxTQtyPerSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Triangular cut";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // radioButtonFullSheet
            // 
            this.radioButtonFullSheet.AutoSize = true;
            this.radioButtonFullSheet.Checked = true;
            this.radioButtonFullSheet.Location = new System.Drawing.Point(3, 4);
            this.radioButtonFullSheet.Name = "radioButtonFullSheet";
            this.radioButtonFullSheet.Size = new System.Drawing.Size(70, 17);
            this.radioButtonFullSheet.TabIndex = 22;
            this.radioButtonFullSheet.TabStop = true;
            this.radioButtonFullSheet.Text = "Full sheet";
            this.radioButtonFullSheet.UseVisualStyleBackColor = true;
            this.radioButtonFullSheet.CheckedChanged += new System.EventHandler(this.radioButtonFullSheet_CheckedChanged);
            // 
            // radioButtonLastSheet
            // 
            this.radioButtonLastSheet.AutoSize = true;
            this.radioButtonLastSheet.Location = new System.Drawing.Point(74, 4);
            this.radioButtonLastSheet.Name = "radioButtonLastSheet";
            this.radioButtonLastSheet.Size = new System.Drawing.Size(74, 17);
            this.radioButtonLastSheet.TabIndex = 23;
            this.radioButtonLastSheet.TabStop = true;
            this.radioButtonLastSheet.Text = "Last sheet";
            this.radioButtonLastSheet.UseVisualStyleBackColor = true;
            this.radioButtonLastSheet.CheckedChanged += new System.EventHandler(this.radioButtonLastSheet_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonFullSheet);
            this.panel1.Controls.Add(this.radioButtonLastSheet);
            this.panel1.Location = new System.Drawing.Point(165, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 27);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(320, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 27);
            this.panel2.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Centers positions";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOutputT);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.panelOutputR);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Pack circles";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutputR.ResumeLayout(false);
            this.panelOutputR.PerformLayout();
            this.panelOutputT.ResumeLayout(false);
            this.panelOutputT.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutputR;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label labelWUnits;
        private System.Windows.Forms.Label labelHUnits;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelSpaceUnits;
        private System.Windows.Forms.TextBox textBoxSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRSheets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRQtyPerSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOutputT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTSheets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTQtyPerSheet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRLastRest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTLastRest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonFullSheet;
        private System.Windows.Forms.RadioButton radioButtonLastSheet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

