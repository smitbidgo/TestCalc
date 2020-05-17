﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalaizerClass;
using CalcClas;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonNull_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonOpenShower_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void buttonClosedShower_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void buttonClir_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Analaizer.expression = textBox1.Text;

            
            if (!Analaizer.CheckCurrency())
                MessageBox.Show(CalcClas.Calculator.lastError);

            if (Analaizer.Format() == CalcClas.Calculator.lastError)
                MessageBox.Show(CalcClas.Calculator.lastError);



            if (Analaizer.CreateStack() == null)
                MessageBox.Show(CalcClas.Calculator.lastError);
            else label3.Text=Analaizer.RunEstimate(Analaizer.CreateStack());
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            textBox1.Text += "mod";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            
            //if (textBox1.Text == ""|| textBox1.Text.Substring(textBox1.Text.Length - 1, 1) == "m")
            //    textBox1.Text += "p";
            
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;

        }

        private void Beckspace_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

       

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }
    }
}
