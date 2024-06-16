namespace WinFormsApp3
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
            label1 = new Label();
            textBox_A = new TextBox();
            numericUpDown_A = new NumericUpDown();
            textBox_B = new TextBox();
            numericUpDown_B = new NumericUpDown();
            textBox_C = new TextBox();
            numericUpDown_C = new NumericUpDown();
            trackBar_A = new TrackBar();
            trackBar_B = new TrackBar();
            trackBar_C = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_C).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_C).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(82, 57);
            label1.Name = "label1";
            label1.Size = new Size(521, 112);
            label1.TabIndex = 0;
            label1.Text = "A <= B <= C";
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(82, 180);
            textBox_A.Margin = new Padding(3, 4, 3, 4);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(103, 27);
            textBox_A.TabIndex = 1;
            textBox_A.KeyDown += textBox_KeyDown;
            textBox_A.Leave += element_Leave;
            // 
            // numericUpDown_A
            // 
            numericUpDown_A.Location = new Point(82, 219);
            numericUpDown_A.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_A.Name = "numericUpDown_A";
            numericUpDown_A.Size = new Size(104, 27);
            numericUpDown_A.TabIndex = 2;
            numericUpDown_A.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown_A.KeyDown += numericUpDown_KeyDown;
            numericUpDown_A.Leave += element_Leave;
            // 
            // textBox_B
            // 
            textBox_B.Location = new Point(267, 180);
            textBox_B.Margin = new Padding(3, 4, 3, 4);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(103, 27);
            textBox_B.TabIndex = 3;
            textBox_B.KeyDown += textBox_KeyDown;
            textBox_B.Leave += element_Leave;
            // 
            // numericUpDown_B
            // 
            numericUpDown_B.Location = new Point(267, 219);
            numericUpDown_B.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_B.Name = "numericUpDown_B";
            numericUpDown_B.Size = new Size(104, 27);
            numericUpDown_B.TabIndex = 4;
            numericUpDown_B.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown_B.KeyDown += numericUpDown_KeyDown;
            numericUpDown_B.Leave += element_Leave;
            // 
            // textBox_C
            // 
            textBox_C.Location = new Point(454, 180);
            textBox_C.Margin = new Padding(3, 4, 3, 4);
            textBox_C.Name = "textBox_C";
            textBox_C.Size = new Size(103, 27);
            textBox_C.TabIndex = 5;
            textBox_C.KeyDown += textBox_KeyDown;
            textBox_C.Leave += element_Leave;
            // 
            // numericUpDown_C
            // 
            numericUpDown_C.Location = new Point(454, 219);
            numericUpDown_C.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_C.Name = "numericUpDown_C";
            numericUpDown_C.Size = new Size(104, 27);
            numericUpDown_C.TabIndex = 6;
            numericUpDown_C.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown_C.KeyDown += numericUpDown_KeyDown;
            numericUpDown_C.Leave += element_Leave;
            // 
            // trackBar_A
            // 
            trackBar_A.Location = new Point(82, 257);
            trackBar_A.Margin = new Padding(3, 4, 3, 4);
            trackBar_A.Name = "trackBar_A";
            trackBar_A.Size = new Size(104, 56);
            trackBar_A.TabIndex = 7;
            trackBar_A.Scroll += trackBar_Scroll;
            trackBar_A.Leave += element_Leave;
            // 
            // trackBar_B
            // 
            trackBar_B.Location = new Point(267, 257);
            trackBar_B.Margin = new Padding(3, 4, 3, 4);
            trackBar_B.Name = "trackBar_B";
            trackBar_B.Size = new Size(104, 56);
            trackBar_B.TabIndex = 8;
            trackBar_B.Scroll += trackBar_Scroll;
            trackBar_B.Leave += element_Leave;
            // 
            // trackBar_C
            // 
            trackBar_C.Location = new Point(454, 257);
            trackBar_C.Margin = new Padding(3, 4, 3, 4);
            trackBar_C.Name = "trackBar_C";
            trackBar_C.Size = new Size(104, 56);
            trackBar_C.TabIndex = 9;
            trackBar_C.Scroll += trackBar_Scroll;
            trackBar_C.Leave += element_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 368);
            Controls.Add(trackBar_C);
            Controls.Add(trackBar_B);
            Controls.Add(trackBar_A);
            Controls.Add(numericUpDown_C);
            Controls.Add(textBox_C);
            Controls.Add(numericUpDown_B);
            Controls.Add(textBox_B);
            Controls.Add(numericUpDown_A);
            Controls.Add(textBox_A);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_C).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_C).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_A;
        private NumericUpDown numericUpDown_A;
        private TextBox textBox_B;
        private NumericUpDown numericUpDown_B;
        private TextBox textBox_C;
        private NumericUpDown numericUpDown_C;
        private TrackBar trackBar_A;
        private TrackBar trackBar_B;
        private TrackBar trackBar_C;
    }
}
