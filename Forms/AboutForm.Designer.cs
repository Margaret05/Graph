﻿namespace Graph.Forms
{
    partial class AboutForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            MainFunctionPhotoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MainFunctionPhotoBox).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(16, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "This program is designed for graphing functions.";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 12F);
            textBox2.Location = new Point(17, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(810, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "To begin, enter X start and X end and the step between them and then select the function to display.";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Times New Roman", 12F);
            textBox3.Location = new Point(18, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(947, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "The function y = f(x) calculates the basic formula. Formulas y = x and y = sin(x) calculate the corresponding functions.";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Times New Roman", 12F);
            textBox4.Location = new Point(17, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(957, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "For the function y = random, you must additionally enter the minimum and maximum value of X in the pop-up window.";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Times New Roman", 12F);
            textBox5.Location = new Point(16, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(669, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "You can also choose the type of graph - points, column or spline.";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveCaption;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Times New Roman", 12F);
            textBox6.Location = new Point(16, 322);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(958, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "In the window Transformation, you can enter the coefficient by which the X or Y graph will be shifted or stretched.";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Times New Roman", 12F);
            textBox7.Location = new Point(16, 359);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(529, 23);
            textBox7.TabIndex = 6;
            textBox7.Text = "By clicking on the button build, the graph is built.";
            // 
            // MainFunctionPhotoBox
            // 
            MainFunctionPhotoBox.Image = Properties.Resources.MainFunctionPhoto;
            MainFunctionPhotoBox.Location = new Point(188, 128);
            MainFunctionPhotoBox.Name = "MainFunctionPhotoBox";
            MainFunctionPhotoBox.Size = new Size(575, 109);
            MainFunctionPhotoBox.TabIndex = 7;
            MainFunctionPhotoBox.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(965, 465);
            Controls.Add(MainFunctionPhotoBox);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AboutForm";
            Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)MainFunctionPhotoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private PictureBox MainFunctionPhotoBox;
    }
}