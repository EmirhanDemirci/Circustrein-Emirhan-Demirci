﻿namespace CircusTrein
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxTypeAnimal = new System.Windows.Forms.ComboBox();
            this.cbxFormatAnimal = new System.Windows.Forms.ComboBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(284, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 186);
            this.listBox1.TabIndex = 2;
            // 
            // cbxTypeAnimal
            // 
            this.cbxTypeAnimal.FormattingEnabled = true;
            this.cbxTypeAnimal.Location = new System.Drawing.Point(6, 26);
            this.cbxTypeAnimal.Name = "cbxTypeAnimal";
            this.cbxTypeAnimal.Size = new System.Drawing.Size(162, 21);
            this.cbxTypeAnimal.TabIndex = 3;
            // 
            // cbxFormatAnimal
            // 
            this.cbxFormatAnimal.FormattingEnabled = true;
            this.cbxFormatAnimal.Location = new System.Drawing.Point(6, 53);
            this.cbxFormatAnimal.Name = "cbxFormatAnimal";
            this.cbxFormatAnimal.Size = new System.Drawing.Size(162, 21);
            this.cbxFormatAnimal.TabIndex = 4;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(38, 100);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(100, 51);
            this.btnAddAnimal.TabIndex = 5;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxFormatAnimal);
            this.groupBox1.Controls.Add(this.btnAddAnimal);
            this.groupBox1.Controls.Add(this.cbxTypeAnimal);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wagons";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(606, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(288, 186);
            this.listBox2.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(297, 262);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(259, 51);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 345);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxTypeAnimal;
        private System.Windows.Forms.ComboBox cbxFormatAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCalculate;
    }
}

