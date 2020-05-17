namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClir = new System.Windows.Forms.Button();
            this.Beckspace = new System.Windows.Forms.Button();
            this.buttonClosedShower = new System.Windows.Forms.Button();
            this.buttonOpenShower = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonNull = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMAdd = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(78, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 23);
            this.label3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClir);
            this.groupBox1.Controls.Add(this.Beckspace);
            this.groupBox1.Controls.Add(this.buttonClosedShower);
            this.groupBox1.Controls.Add(this.buttonOpenShower);
            this.groupBox1.Location = new System.Drawing.Point(16, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // buttonClir
            // 
            this.buttonClir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClir.ForeColor = System.Drawing.Color.Red;
            this.buttonClir.Location = new System.Drawing.Point(275, 19);
            this.buttonClir.Name = "buttonClir";
            this.buttonClir.Size = new System.Drawing.Size(50, 39);
            this.buttonClir.TabIndex = 3;
            this.buttonClir.Text = "C";
            this.buttonClir.UseVisualStyleBackColor = true;
            this.buttonClir.Click += new System.EventHandler(this.buttonClir_Click);
            // 
            // Beckspace
            // 
            this.Beckspace.ForeColor = System.Drawing.Color.Red;
            this.Beckspace.Location = new System.Drawing.Point(172, 19);
            this.Beckspace.Name = "Beckspace";
            this.Beckspace.Size = new System.Drawing.Size(97, 38);
            this.Beckspace.TabIndex = 2;
            this.Beckspace.Text = "Beckspace";
            this.Beckspace.UseVisualStyleBackColor = true;
            this.Beckspace.Click += new System.EventHandler(this.Beckspace_Click);
            // 
            // buttonClosedShower
            // 
            this.buttonClosedShower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClosedShower.Location = new System.Drawing.Point(61, 20);
            this.buttonClosedShower.Name = "buttonClosedShower";
            this.buttonClosedShower.Size = new System.Drawing.Size(49, 38);
            this.buttonClosedShower.TabIndex = 1;
            this.buttonClosedShower.Text = ")";
            this.buttonClosedShower.UseVisualStyleBackColor = true;
            this.buttonClosedShower.Click += new System.EventHandler(this.buttonClosedShower_Click);
            // 
            // buttonOpenShower
            // 
            this.buttonOpenShower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenShower.Location = new System.Drawing.Point(7, 20);
            this.buttonOpenShower.Name = "buttonOpenShower";
            this.buttonOpenShower.Size = new System.Drawing.Size(48, 38);
            this.buttonOpenShower.TabIndex = 0;
            this.buttonOpenShower.Text = "(";
            this.buttonOpenShower.UseVisualStyleBackColor = true;
            this.buttonOpenShower.Click += new System.EventHandler(this.buttonOpenShower_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(78, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 40);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 40);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(78, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 40);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(132, 255);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 40);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonNull
            // 
            this.buttonNull.Location = new System.Drawing.Point(77, 301);
            this.buttonNull.Name = "buttonNull";
            this.buttonNull.Size = new System.Drawing.Size(48, 40);
            this.buttonNull.TabIndex = 15;
            this.buttonNull.Text = "0";
            this.buttonNull.UseVisualStyleBackColor = true;
            this.buttonNull.Click += new System.EventHandler(this.buttonNull_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(23, 301);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 40);
            this.button11.TabIndex = 16;
            this.button11.Text = "+/-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.ForeColor = System.Drawing.Color.Red;
            this.buttonMod.Location = new System.Drawing.Point(132, 301);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(48, 40);
            this.buttonMod.TabIndex = 17;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(185, 163);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(48, 40);
            this.buttonDiv.TabIndex = 18;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.ForeColor = System.Drawing.Color.Red;
            this.buttonMult.Location = new System.Drawing.Point(185, 209);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(48, 40);
            this.buttonMult.TabIndex = 19;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSub.ForeColor = System.Drawing.Color.Red;
            this.buttonSub.Location = new System.Drawing.Point(185, 255);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(48, 40);
            this.buttonSub.TabIndex = 20;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonAdd.Location = new System.Drawing.Point(185, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(48, 40);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMR
            // 
            this.buttonMR.ForeColor = System.Drawing.Color.Blue;
            this.buttonMR.Location = new System.Drawing.Point(299, 163);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(48, 41);
            this.buttonMR.TabIndex = 22;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            // 
            // buttonMAdd
            // 
            this.buttonMAdd.ForeColor = System.Drawing.Color.Blue;
            this.buttonMAdd.Location = new System.Drawing.Point(299, 210);
            this.buttonMAdd.Name = "buttonMAdd";
            this.buttonMAdd.Size = new System.Drawing.Size(48, 41);
            this.buttonMAdd.TabIndex = 23;
            this.buttonMAdd.Text = "M+";
            this.buttonMAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMC
            // 
            this.buttonMC.ForeColor = System.Drawing.Color.Blue;
            this.buttonMC.Location = new System.Drawing.Point(299, 257);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(48, 41);
            this.buttonMC.TabIndex = 24;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.ForeColor = System.Drawing.Color.Red;
            this.buttonSum.Location = new System.Drawing.Point(299, 301);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(48, 41);
            this.buttonSum.TabIndex = 25;
            this.buttonSum.Text = "=";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 434);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMAdd);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.buttonNull);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClir;
        private System.Windows.Forms.Button Beckspace;
        private System.Windows.Forms.Button buttonClosedShower;
        private System.Windows.Forms.Button buttonOpenShower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonNull;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMAdd;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonSum;
    }
}

