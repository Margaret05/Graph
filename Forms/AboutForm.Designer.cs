namespace Graph.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            textBox1 = new TextBox();
            textBox4 = new TextBox();
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
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(814, 94);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Times New Roman", 12F);
            textBox4.Location = new Point(17, 253);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(813, 155);
            textBox4.TabIndex = 3;
            textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // MainFunctionPhotoBox
            // 
            MainFunctionPhotoBox.Image = Properties.Resources.MainFunctionPhoto;
            MainFunctionPhotoBox.Location = new Point(138, 116);
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
            ClientSize = new Size(850, 419);
            Controls.Add(MainFunctionPhotoBox);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private PictureBox MainFunctionPhotoBox;
    }
}