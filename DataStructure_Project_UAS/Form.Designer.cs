﻿namespace DataStructure_Project_UAS
{
    partial class Form
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
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPecahan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelSortMethod = new System.Windows.Forms.Label();
            this.textBoxInputPathLink = new System.Windows.Forms.TextBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.comboBoxSortMethod = new System.Windows.Forms.ComboBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFileName.Location = new System.Drawing.Point(564, 194);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(214, 26);
            this.textBoxFileName.TabIndex = 45;
            this.textBoxFileName.Text = "save as";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 44;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonDownload.Location = new System.Drawing.Point(801, 186);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(210, 38);
            this.buttonDownload.TabIndex = 43;
            this.buttonDownload.Text = "DOWNLOAD";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(840, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "ms";
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeElapsed.Location = new System.Drawing.Point(796, 303);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(48, 32);
            this.labelTimeElapsed.TabIndex = 41;
            this.labelTimeElapsed.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "TIME ELAPSED:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(910, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "/ 100)";
            // 
            // labelPecahan
            // 
            this.labelPecahan.AutoSize = true;
            this.labelPecahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPecahan.Location = new System.Drawing.Point(854, 254);
            this.labelPecahan.Name = "labelPecahan";
            this.labelPecahan.Size = new System.Drawing.Size(65, 32);
            this.labelPecahan.TabIndex = 38;
            this.labelPecahan.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(806, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "% (";
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccuracy.Location = new System.Drawing.Point(750, 254);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(65, 32);
            this.labelAccuracy.TabIndex = 36;
            this.labelAccuracy.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "ACCURACY:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxOrder.Location = new System.Drawing.Point(40, 303);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(444, 28);
            this.comboBoxOrder.TabIndex = 34;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(33, 254);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(129, 32);
            this.labelOrder.TabIndex = 33;
            this.labelOrder.Text = "ORDER:";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonClear.Location = new System.Drawing.Point(566, 368);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(210, 55);
            this.buttonClear.TabIndex = 32;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(801, 368);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(210, 55);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(558, 26);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(144, 32);
            this.labelOutput.TabIndex = 30;
            this.labelOutput.Text = "OUTPUT:";
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSort.Location = new System.Drawing.Point(39, 368);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(446, 55);
            this.buttonSort.TabIndex = 29;
            this.buttonSort.Text = "SORT";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelSortMethod
            // 
            this.labelSortMethod.AutoSize = true;
            this.labelSortMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortMethod.Location = new System.Drawing.Point(33, 142);
            this.labelSortMethod.Name = "labelSortMethod";
            this.labelSortMethod.Size = new System.Drawing.Size(240, 32);
            this.labelSortMethod.TabIndex = 28;
            this.labelSortMethod.Text = "SORT METHOD:";
            // 
            // textBoxInputPathLink
            // 
            this.textBoxInputPathLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputPathLink.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxInputPathLink.Location = new System.Drawing.Point(40, 77);
            this.textBoxInputPathLink.Name = "textBoxInputPathLink";
            this.textBoxInputPathLink.Size = new System.Drawing.Size(290, 26);
            this.textBoxInputPathLink.TabIndex = 27;
            this.textBoxInputPathLink.Text = "input file";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(566, 77);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(445, 84);
            this.listBoxOutput.TabIndex = 26;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonBrowse.Location = new System.Drawing.Point(346, 71);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(138, 40);
            this.buttonBrowse.TabIndex = 25;
            this.buttonBrowse.Text = "BROWSE";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // comboBoxSortMethod
            // 
            this.comboBoxSortMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortMethod.FormattingEnabled = true;
            this.comboBoxSortMethod.Items.AddRange(new object[] {
            "Insertion Sort",
            "Bubble Sort",
            "Heap Sort",
            "Radix Sort",
            "Merge Sort"});
            this.comboBoxSortMethod.Location = new System.Drawing.Point(39, 192);
            this.comboBoxSortMethod.Name = "comboBoxSortMethod";
            this.comboBoxSortMethod.Size = new System.Drawing.Size(444, 28);
            this.comboBoxSortMethod.TabIndex = 24;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(33, 23);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(111, 32);
            this.labelInput.TabIndex = 23;
            this.labelInput.Text = "INPUT:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 448);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPecahan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelSortMethod);
            this.Controls.Add(this.textBoxInputPathLink);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.comboBoxSortMethod);
            this.Controls.Add(this.labelInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.Text = "Sorting Algorithm Simulator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPecahan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAccuracy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelSortMethod;
        private System.Windows.Forms.TextBox textBoxInputPathLink;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ComboBox comboBoxSortMethod;
        private System.Windows.Forms.Label labelInput;
    }
}

