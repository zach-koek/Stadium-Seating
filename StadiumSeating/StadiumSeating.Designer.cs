
namespace StadiumSeating
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalcRev = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxClassASold = new System.Windows.Forms.TextBox();
            this.txtBoxClassBSold = new System.Windows.Forms.TextBox();
            this.txtBoxClassCSold = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.txtBoxClassCRev = new System.Windows.Forms.TextBox();
            this.txtBoxClassBRev = new System.Windows.Forms.TextBox();
            this.txtBoxClassARev = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalcRev
            // 
            this.btnCalcRev.Location = new System.Drawing.Point(60, 235);
            this.btnCalcRev.Name = "btnCalcRev";
            this.btnCalcRev.Size = new System.Drawing.Size(110, 40);
            this.btnCalcRev.TabIndex = 3;
            this.btnCalcRev.Text = "Calculate Revenue";
            this.btnCalcRev.UseVisualStyleBackColor = true;
            this.btnCalcRev.Click += new System.EventHandler(this.btnCalcRev_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(292, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class B:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter the number of tickets sold for class of seats.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Class C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Class B:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Class A:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxClassASold);
            this.groupBox1.Controls.Add(this.txtBoxClassBSold);
            this.groupBox1.Controls.Add(this.txtBoxClassCSold);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 201);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // txtBoxClassASold
            // 
            this.txtBoxClassASold.Location = new System.Drawing.Point(85, 64);
            this.txtBoxClassASold.Name = "txtBoxClassASold";
            this.txtBoxClassASold.Size = new System.Drawing.Size(100, 23);
            this.txtBoxClassASold.TabIndex = 0;
            // 
            // txtBoxClassBSold
            // 
            this.txtBoxClassBSold.Location = new System.Drawing.Point(85, 101);
            this.txtBoxClassBSold.Name = "txtBoxClassBSold";
            this.txtBoxClassBSold.Size = new System.Drawing.Size(100, 23);
            this.txtBoxClassBSold.TabIndex = 1;
            // 
            // txtBoxClassCSold
            // 
            this.txtBoxClassCSold.Location = new System.Drawing.Point(85, 139);
            this.txtBoxClassCSold.Name = "txtBoxClassCSold";
            this.txtBoxClassCSold.Size = new System.Drawing.Size(100, 23);
            this.txtBoxClassCSold.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxTotal);
            this.groupBox2.Controls.Add(this.txtBoxClassCRev);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBoxClassBRev);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxClassARev);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(94, 159);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.txtBoxTotal.TabIndex = 13;
            this.txtBoxTotal.TabStop = false;
            // 
            // txtBoxClassCRev
            // 
            this.txtBoxClassCRev.Location = new System.Drawing.Point(94, 85);
            this.txtBoxClassCRev.Name = "txtBoxClassCRev";
            this.txtBoxClassCRev.ReadOnly = true;
            this.txtBoxClassCRev.Size = new System.Drawing.Size(100, 23);
            this.txtBoxClassCRev.TabIndex = 14;
            this.txtBoxClassCRev.TabStop = false;
            // 
            // txtBoxClassBRev
            // 
            this.txtBoxClassBRev.Location = new System.Drawing.Point(94, 56);
            this.txtBoxClassBRev.Name = "txtBoxClassBRev";
            this.txtBoxClassBRev.ReadOnly = true;
            this.txtBoxClassBRev.Size = new System.Drawing.Size(100, 23);
            this.txtBoxClassBRev.TabIndex = 15;
            this.txtBoxClassBRev.TabStop = false;
            // 
            // txtBoxClassARev
            // 
            this.txtBoxClassARev.Location = new System.Drawing.Point(94, 27);
            this.txtBoxClassARev.Name = "txtBoxClassARev";
            this.txtBoxClassARev.ReadOnly = true;
            this.txtBoxClassARev.Size = new System.Drawing.Size(100, 23);
            this.txtBoxClassARev.TabIndex = 16;
            this.txtBoxClassARev.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcRev);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalcRev;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxClassASold;
        private System.Windows.Forms.TextBox txtBoxClassBSold;
        private System.Windows.Forms.TextBox txtBoxClassCSold;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.TextBox txtBoxClassCRev;
        private System.Windows.Forms.TextBox txtBoxClassBRev;
        private System.Windows.Forms.TextBox txtBoxClassARev;
    }
}

