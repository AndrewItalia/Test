namespace Practice_SAC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Partname = new System.Windows.Forms.TextBox();
            this.txt_numberOfYears = new System.Windows.Forms.TextBox();
            this.txt_payAmount = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_individualWorth = new System.Windows.Forms.Label();
            this.lbl_collectionWorth = new System.Windows.Forms.Label();
            this.txt_individualWorth = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device/Part Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "How old is the device/part? (In Years)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "How much did you pay for it?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Partname
            // 
            this.txt_Partname.Location = new System.Drawing.Point(78, 106);
            this.txt_Partname.Name = "txt_Partname";
            this.txt_Partname.Size = new System.Drawing.Size(183, 26);
            this.txt_Partname.TabIndex = 4;
            // 
            // txt_numberOfYears
            // 
            this.txt_numberOfYears.Location = new System.Drawing.Point(78, 218);
            this.txt_numberOfYears.Name = "txt_numberOfYears";
            this.txt_numberOfYears.Size = new System.Drawing.Size(194, 26);
            this.txt_numberOfYears.TabIndex = 5;
            // 
            // txt_payAmount
            // 
            this.txt_payAmount.Location = new System.Drawing.Point(78, 330);
            this.txt_payAmount.Name = "txt_payAmount";
            this.txt_payAmount.Size = new System.Drawing.Size(194, 26);
            this.txt_payAmount.TabIndex = 6;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(78, 416);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(136, 39);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(723, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(244, 416);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 39);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "End the quote";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_individualWorth
            // 
            this.lbl_individualWorth.AutoSize = true;
            this.lbl_individualWorth.Location = new System.Drawing.Point(604, 330);
            this.lbl_individualWorth.Name = "lbl_individualWorth";
            this.lbl_individualWorth.Size = new System.Drawing.Size(92, 20);
            this.lbl_individualWorth.TabIndex = 10;
            this.lbl_individualWorth.Text = "Final Value:";
            // 
            // lbl_collectionWorth
            // 
            this.lbl_collectionWorth.AutoSize = true;
            this.lbl_collectionWorth.Location = new System.Drawing.Point(603, 416);
            this.lbl_collectionWorth.Name = "lbl_collectionWorth";
            this.lbl_collectionWorth.Size = new System.Drawing.Size(93, 20);
            this.lbl_collectionWorth.TabIndex = 11;
            this.lbl_collectionWorth.Text = "Total Value:";
            this.lbl_collectionWorth.Click += new System.EventHandler(this.lbl_collectionWorth_Click);
            // 
            // txt_individualWorth
            // 
            this.txt_individualWorth.Location = new System.Drawing.Point(702, 327);
            this.txt_individualWorth.Name = "txt_individualWorth";
            this.txt_individualWorth.ReadOnly = true;
            this.txt_individualWorth.Size = new System.Drawing.Size(175, 26);
            this.txt_individualWorth.TabIndex = 12;
            this.txt_individualWorth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(703, 413);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(174, 26);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 495);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_individualWorth);
            this.Controls.Add(this.lbl_collectionWorth);
            this.Controls.Add(this.lbl_individualWorth);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_payAmount);
            this.Controls.Add(this.txt_numberOfYears);
            this.Controls.Add(this.txt_Partname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Device Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Partname;
        private System.Windows.Forms.TextBox txt_numberOfYears;
        private System.Windows.Forms.TextBox txt_payAmount;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_individualWorth;
        private System.Windows.Forms.Label lbl_collectionWorth;
        private System.Windows.Forms.TextBox txt_individualWorth;
        private System.Windows.Forms.TextBox textBox2;
    }
}

