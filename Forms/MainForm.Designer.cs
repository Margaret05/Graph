using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph
{
    partial class MainForm
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Series series2 = new Series();
            Series series3 = new Series();
            Series series4 = new Series();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            IntervalGroupBox = new GroupBox();
            InputStep = new TextBox();
            InputXlast = new TextBox();
            InputXfirst = new TextBox();
            StepLabel = new Label();
            Label_x_last = new Label();
            Label_x_first = new Label();
            VisualisationGroupBox = new GroupBox();
            RandomRangeLabel = new Label();
            LinearCheckBox = new CheckBox();
            RandomCheckBox = new CheckBox();
            SinCheckBox = new CheckBox();
            ChartTypeComboBox = new ComboBox();
            MainFunctionCheckBox = new CheckBox();
            TransformationGroupBox = new GroupBox();
            TransformButton = new Button();
            StretchYCheckBox = new CheckBox();
            StretchXCheckBox = new CheckBox();
            ShiftYCheckBox = new CheckBox();
            ShiftXCheckBox = new CheckBox();
            TransformationInput = new TextBox();
            TransformationLabel = new Label();
            BuildButton = new Button();
            DataChart = new Chart();
            menuStrip1.SuspendLayout();
            IntervalGroupBox.SuspendLayout();
            VisualisationGroupBox.SuspendLayout();
            TransformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataChart).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1246, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(67, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // IntervalGroupBox
            // 
            IntervalGroupBox.BackColor = SystemColors.GradientActiveCaption;
            IntervalGroupBox.Controls.Add(InputStep);
            IntervalGroupBox.Controls.Add(InputXlast);
            IntervalGroupBox.Controls.Add(InputXfirst);
            IntervalGroupBox.Controls.Add(StepLabel);
            IntervalGroupBox.Controls.Add(Label_x_last);
            IntervalGroupBox.Controls.Add(Label_x_first);
            IntervalGroupBox.Font = new Font("Times New Roman", 10.2F);
            IntervalGroupBox.Location = new Point(878, 33);
            IntervalGroupBox.Margin = new Padding(3, 4, 3, 4);
            IntervalGroupBox.Name = "IntervalGroupBox";
            IntervalGroupBox.Padding = new Padding(3, 4, 3, 4);
            IntervalGroupBox.Size = new Size(358, 136);
            IntervalGroupBox.TabIndex = 1;
            IntervalGroupBox.TabStop = false;
            IntervalGroupBox.Text = "Interval";
            // 
            // InputStep
            // 
            InputStep.Location = new Point(156, 102);
            InputStep.Margin = new Padding(3, 4, 3, 4);
            InputStep.Name = "InputStep";
            InputStep.Size = new Size(127, 27);
            InputStep.TabIndex = 5;
            // 
            // InputXlast
            // 
            InputXlast.Location = new Point(156, 61);
            InputXlast.Margin = new Padding(3, 4, 3, 4);
            InputXlast.Name = "InputXlast";
            InputXlast.Size = new Size(127, 27);
            InputXlast.TabIndex = 4;
            // 
            // InputXfirst
            // 
            InputXfirst.Location = new Point(156, 20);
            InputXfirst.Margin = new Padding(3, 4, 3, 4);
            InputXfirst.Name = "InputXfirst";
            InputXfirst.Size = new Size(127, 27);
            InputXfirst.TabIndex = 3;
            // 
            // StepLabel
            // 
            StepLabel.AutoSize = true;
            StepLabel.Location = new Point(83, 105);
            StepLabel.Name = "StepLabel";
            StepLabel.Size = new Size(39, 19);
            StepLabel.TabIndex = 2;
            StepLabel.Text = "Step";
            // 
            // Label_x_last
            // 
            Label_x_last.AutoSize = true;
            Label_x_last.Location = new Point(83, 64);
            Label_x_last.Name = "Label_x_last";
            Label_x_last.Size = new Size(49, 19);
            Label_x_last.TabIndex = 1;
            Label_x_last.Text = "X last";
            // 
            // Label_x_first
            // 
            Label_x_first.AutoSize = true;
            Label_x_first.Location = new Point(83, 24);
            Label_x_first.Name = "Label_x_first";
            Label_x_first.Size = new Size(54, 19);
            Label_x_first.TabIndex = 0;
            Label_x_first.Text = "X first";
            // 
            // VisualisationGroupBox
            // 
            VisualisationGroupBox.BackColor = SystemColors.GradientActiveCaption;
            VisualisationGroupBox.Controls.Add(RandomRangeLabel);
            VisualisationGroupBox.Controls.Add(LinearCheckBox);
            VisualisationGroupBox.Controls.Add(RandomCheckBox);
            VisualisationGroupBox.Controls.Add(SinCheckBox);
            VisualisationGroupBox.Controls.Add(ChartTypeComboBox);
            VisualisationGroupBox.Controls.Add(MainFunctionCheckBox);
            VisualisationGroupBox.Font = new Font("Times New Roman", 10.2F);
            VisualisationGroupBox.Location = new Point(878, 176);
            VisualisationGroupBox.Margin = new Padding(3, 4, 3, 4);
            VisualisationGroupBox.Name = "VisualisationGroupBox";
            VisualisationGroupBox.Padding = new Padding(3, 4, 3, 4);
            VisualisationGroupBox.Size = new Size(358, 178);
            VisualisationGroupBox.TabIndex = 2;
            VisualisationGroupBox.TabStop = false;
            VisualisationGroupBox.Text = "Visualisation";
            // 
            // RandomRangeLabel
            // 
            RandomRangeLabel.AutoSize = true;
            RandomRangeLabel.Location = new Point(185, 116);
            RandomRangeLabel.Name = "RandomRangeLabel";
            RandomRangeLabel.Size = new Size(0, 19);
            RandomRangeLabel.TabIndex = 8;
            // 
            // LinearCheckBox
            // 
            LinearCheckBox.AutoSize = true;
            LinearCheckBox.Location = new Point(55, 54);
            LinearCheckBox.Margin = new Padding(3, 4, 3, 4);
            LinearCheckBox.Name = "LinearCheckBox";
            LinearCheckBox.Size = new Size(65, 23);
            LinearCheckBox.TabIndex = 7;
            LinearCheckBox.Text = "y = x";
            LinearCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomCheckBox
            // 
            RandomCheckBox.AutoSize = true;
            RandomCheckBox.Location = new Point(55, 112);
            RandomCheckBox.Margin = new Padding(3, 4, 3, 4);
            RandomCheckBox.Name = "RandomCheckBox";
            RandomCheckBox.Size = new Size(108, 23);
            RandomCheckBox.TabIndex = 4;
            RandomCheckBox.Text = "y = random";
            RandomCheckBox.UseVisualStyleBackColor = true;
            RandomCheckBox.CheckedChanged += RandomCheckBox_CheckedChanged;
            // 
            // SinCheckBox
            // 
            SinCheckBox.AutoSize = true;
            SinCheckBox.Location = new Point(55, 84);
            SinCheckBox.Margin = new Padding(3, 4, 3, 4);
            SinCheckBox.Name = "SinCheckBox";
            SinCheckBox.Size = new Size(97, 23);
            SinCheckBox.TabIndex = 3;
            SinCheckBox.Text = "y = sin(x)";
            SinCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChartTypeComboBox
            // 
            ChartTypeComboBox.FormattingEnabled = true;
            ChartTypeComboBox.Items.AddRange(new object[] { "Point", "Column", "Spline" });
            ChartTypeComboBox.Location = new Point(79, 145);
            ChartTypeComboBox.Margin = new Padding(3, 4, 3, 4);
            ChartTypeComboBox.Name = "ChartTypeComboBox";
            ChartTypeComboBox.Size = new Size(167, 27);
            ChartTypeComboBox.TabIndex = 2;
            ChartTypeComboBox.SelectedIndexChanged += ChartTypeComboBox_SelectedIndexChanged;
            // 
            // MainFunctionCheckBox
            // 
            MainFunctionCheckBox.AutoSize = true;
            MainFunctionCheckBox.Location = new Point(55, 24);
            MainFunctionCheckBox.Margin = new Padding(3, 4, 3, 4);
            MainFunctionCheckBox.Name = "MainFunctionCheckBox";
            MainFunctionCheckBox.Size = new Size(83, 23);
            MainFunctionCheckBox.TabIndex = 0;
            MainFunctionCheckBox.Text = "y = f(x)";
            MainFunctionCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformationGroupBox
            // 
            TransformationGroupBox.BackColor = SystemColors.GradientActiveCaption;
            TransformationGroupBox.Controls.Add(TransformButton);
            TransformationGroupBox.Controls.Add(StretchYCheckBox);
            TransformationGroupBox.Controls.Add(StretchXCheckBox);
            TransformationGroupBox.Controls.Add(ShiftYCheckBox);
            TransformationGroupBox.Controls.Add(ShiftXCheckBox);
            TransformationGroupBox.Controls.Add(TransformationInput);
            TransformationGroupBox.Controls.Add(TransformationLabel);
            TransformationGroupBox.Font = new Font("Times New Roman", 10.2F);
            TransformationGroupBox.Location = new Point(878, 358);
            TransformationGroupBox.Margin = new Padding(3, 4, 3, 4);
            TransformationGroupBox.Name = "TransformationGroupBox";
            TransformationGroupBox.Padding = new Padding(3, 4, 3, 4);
            TransformationGroupBox.Size = new Size(356, 231);
            TransformationGroupBox.TabIndex = 7;
            TransformationGroupBox.TabStop = false;
            TransformationGroupBox.Text = "Transformation";
            // 
            // TransformButton
            // 
            TransformButton.BackColor = SystemColors.GradientInactiveCaption;
            TransformButton.Location = new Point(124, 176);
            TransformButton.Margin = new Padding(3, 4, 3, 4);
            TransformButton.Name = "TransformButton";
            TransformButton.Size = new Size(122, 35);
            TransformButton.TabIndex = 6;
            TransformButton.Text = "Transform";
            TransformButton.UseVisualStyleBackColor = false;
            TransformButton.Click += TransformButton_Click;
            // 
            // StretchYCheckBox
            // 
            StretchYCheckBox.AutoSize = true;
            StretchYCheckBox.Location = new Point(38, 148);
            StretchYCheckBox.Margin = new Padding(3, 4, 3, 4);
            StretchYCheckBox.Name = "StretchYCheckBox";
            StretchYCheckBox.Size = new Size(114, 23);
            StretchYCheckBox.TabIndex = 5;
            StretchYCheckBox.Text = "Stretch by Y";
            StretchYCheckBox.UseVisualStyleBackColor = true;
            // 
            // StretchXCheckBox
            // 
            StretchXCheckBox.AutoSize = true;
            StretchXCheckBox.Location = new Point(38, 119);
            StretchXCheckBox.Margin = new Padding(3, 4, 3, 4);
            StretchXCheckBox.Name = "StretchXCheckBox";
            StretchXCheckBox.Size = new Size(116, 23);
            StretchXCheckBox.TabIndex = 4;
            StretchXCheckBox.Text = "Stretch by X";
            StretchXCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShiftYCheckBox
            // 
            ShiftYCheckBox.AutoSize = true;
            ShiftYCheckBox.Location = new Point(38, 89);
            ShiftYCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShiftYCheckBox.Name = "ShiftYCheckBox";
            ShiftYCheckBox.Size = new Size(98, 23);
            ShiftYCheckBox.TabIndex = 3;
            ShiftYCheckBox.Text = "Shift by Y";
            ShiftYCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShiftXCheckBox
            // 
            ShiftXCheckBox.AutoSize = true;
            ShiftXCheckBox.Location = new Point(38, 61);
            ShiftXCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShiftXCheckBox.Name = "ShiftXCheckBox";
            ShiftXCheckBox.Size = new Size(100, 23);
            ShiftXCheckBox.TabIndex = 2;
            ShiftXCheckBox.Text = "Shift by X";
            ShiftXCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformationInput
            // 
            TransformationInput.Location = new Point(134, 24);
            TransformationInput.Margin = new Padding(3, 4, 3, 4);
            TransformationInput.Name = "TransformationInput";
            TransformationInput.Size = new Size(174, 27);
            TransformationInput.TabIndex = 1;
            // 
            // TransformationLabel
            // 
            TransformationLabel.AutoSize = true;
            TransformationLabel.Location = new Point(55, 27);
            TransformationLabel.Name = "TransformationLabel";
            TransformationLabel.Size = new Size(46, 19);
            TransformationLabel.TabIndex = 0;
            TransformationLabel.Text = "Ratio";
            // 
            // BuildButton
            // 
            BuildButton.BackColor = SystemColors.GradientInactiveCaption;
            BuildButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuildButton.Location = new Point(970, 594);
            BuildButton.Margin = new Padding(3, 4, 3, 4);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(182, 35);
            BuildButton.TabIndex = 6;
            BuildButton.Text = "Build";
            BuildButton.UseVisualStyleBackColor = false;
            BuildButton.Click += BuildButton_Click;
            // 
            // DataChart
            // 
            DataChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataChart.BackColor = SystemColors.GradientActiveCaption;
            DataChart.BorderlineColor = Color.Transparent;
            chartArea1.AxisX.ArrowStyle = AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Enabled = AxisEnabled.True;
            chartArea1.AxisX.InterlacedColor = Color.White;
            chartArea1.AxisX.LabelStyle.Format = "N0";
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineWidth = 2;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisX.TitleForeColor = Color.FromArgb(0, 0, 192);
            chartArea1.AxisY.ArrowStyle = AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Enabled = AxisEnabled.True;
            chartArea1.AxisY.InterlacedColor = Color.White;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineWidth = 2;
            chartArea1.AxisY.TextOrientation = TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisY.TitleForeColor = Color.FromArgb(0, 0, 192);
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BackImageTransparentColor = Color.Transparent;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            DataChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.Name = "Legend1";
            DataChart.Legends.Add(legend1);
            DataChart.Location = new Point(13, 33);
            DataChart.Margin = new Padding(4, 5, 4, 5);
            DataChart.Name = "DataChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "y = f(x)";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Spline;
            series2.Color = Color.OrangeRed;
            series2.Legend = "Legend1";
            series2.Name = "y = x";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Spline;
            series3.Color = Color.Fuchsia;
            series3.LabelBorderColor = Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "y = sin(x)";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = SeriesChartType.Spline;
            series4.Color = Color.ForestGreen;
            series4.Legend = "Legend1";
            series4.Name = "y = random";
            DataChart.Series.Add(series1);
            DataChart.Series.Add(series2);
            DataChart.Series.Add(series3);
            DataChart.Series.Add(series4);
            DataChart.Size = new Size(858, 615);
            DataChart.TabIndex = 0;
            DataChart.Text = "chart";
            DataChart.Click += BuildButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1246, 654);
            Controls.Add(DataChart);
            Controls.Add(BuildButton);
            Controls.Add(TransformationGroupBox);
            Controls.Add(VisualisationGroupBox);
            Controls.Add(IntervalGroupBox);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Main Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            IntervalGroupBox.ResumeLayout(false);
            IntervalGroupBox.PerformLayout();
            VisualisationGroupBox.ResumeLayout(false);
            VisualisationGroupBox.PerformLayout();
            TransformationGroupBox.ResumeLayout(false);
            TransformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox IntervalGroupBox;
        private TextBox InputStep;
        private TextBox InputXlast;
        private TextBox InputXfirst;
        private Label StepLabel;
        private Label Label_x_last;
        private Label Label_x_first;
        private GroupBox VisualisationGroupBox;
        private CheckBox LinearCheckBox;
        private CheckBox RandomCheckBox;
        private CheckBox SinCheckBox;
        private CheckBox MainFunctionCheckBox;
        private GroupBox TransformationGroupBox;
        private CheckBox StretchYCheckBox;
        private CheckBox ShiftYCheckBox;
        private CheckBox ShiftXCheckBox;
        private TextBox TransformationInput;
        private Button TransformButton;
        private Label TransformationLabel;
        private CheckBox StretchXCheckBox;
        private ComboBox ChartTypeComboBox;
        private Label RandomRangeLabel;
        private Button BuildButton;
        private Chart DataChart;
    }
}
