using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Graph.Forms
{
    partial class RandomNumbersForm
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
            ApplyRandomButton = new Button();
            RandomMinimumLabel = new Label();
            RandomMaximumLabel = new Label();
            RandomMinimumInput = new TextBox();
            RandomMaximumInput = new TextBox();
            SuspendLayout();
            // 
            // ApplyRandomButton
            // 
            ApplyRandomButton.BackColor = SystemColors.GradientActiveCaption;
            ApplyRandomButton.Location = new Point(72, 105);
            ApplyRandomButton.Name = "ApplyRandomButton";
            ApplyRandomButton.Size = new Size(147, 37);
            ApplyRandomButton.TabIndex = 0;
            ApplyRandomButton.Text = "Apply";
            ApplyRandomButton.UseVisualStyleBackColor = false;
            ApplyRandomButton.Click += ApplyRandomButton_Click;
            // 
            // RandomMinimumLabel
            // 
            RandomMinimumLabel.AutoSize = true;
            RandomMinimumLabel.Location = new Point(49, 28);
            RandomMinimumLabel.Name = "RandomMinimumLabel";
            RandomMinimumLabel.Size = new Size(85, 20);
            RandomMinimumLabel.TabIndex = 1;
            RandomMinimumLabel.Text = "X Minimum";
            // 
            // RandomMaximumLabel
            // 
            RandomMaximumLabel.AutoSize = true;
            RandomMaximumLabel.Location = new Point(49, 72);
            RandomMaximumLabel.Name = "RandomMaximumLabel";
            RandomMaximumLabel.Size = new Size(88, 20);
            RandomMaximumLabel.TabIndex = 2;
            RandomMaximumLabel.Text = "X Maximum";
            // 
            // RandomMinimumInput
            // 
            RandomMinimumInput.Location = new Point(139, 24);
            RandomMinimumInput.Name = "RandomMinimumInput";
            RandomMinimumInput.Size = new Size(107, 27);
            RandomMinimumInput.TabIndex = 3;
            // 
            // RandomMaximumInput
            // 
            RandomMaximumInput.Location = new Point(139, 69);
            RandomMaximumInput.Name = "RandomMaximumInput";
            RandomMaximumInput.Size = new Size(107, 27);
            RandomMaximumInput.TabIndex = 4;
            // 
            // RandomNumbersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(297, 153);
            Controls.Add(RandomMaximumInput);
            Controls.Add(RandomMinimumInput);
            Controls.Add(RandomMaximumLabel);
            Controls.Add(RandomMinimumLabel);
            Controls.Add(ApplyRandomButton);
            Name = "RandomNumbersForm";
            Text = "RandomNumbersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ApplyRandomButton;
        private Label RandomMinimumLabel;
        private Label RandomMaximumLabel;
        private TextBox RandomMinimumInput;
        private TextBox RandomMaximumInput;
    }
}