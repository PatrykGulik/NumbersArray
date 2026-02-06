namespace NumbersArray
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
            label2 = new Label();
            Btn_ArraySize = new Button();
            Lbl_EnterArray = new Label();
            Btn_AddInt = new Button();
            groupBox1 = new GroupBox();
            Txt_Index = new TextBox();
            label6 = new Label();
            Lbl_ArraySize = new Label();
            groupBox2 = new GroupBox();
            Lbl_ArrayElements = new Label();
            Txt_AddInt = new TextBox();
            label3 = new Label();
            Txt_AddIndex = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            Lbl_Array = new Label();
            Btn_AddArray = new Button();
            Txt_AddArray = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            Lbl_FindMax = new Label();
            button1 = new Button();
            groupBox5 = new GroupBox();
            Lbl_CountElements = new Label();
            Btn_CountElements = new Button();
            groupBox6 = new GroupBox();
            Lbl_Sum = new Label();
            Btn_Sum = new Button();
            groupBox7 = new GroupBox();
            Lbl_Avg = new Label();
            Btn_Avg = new Button();
            groupBox8 = new GroupBox();
            Txt_EqualIndex2 = new TextBox();
            label7 = new Label();
            Lbl_Equal = new Label();
            Txt_EqualIndex1 = new TextBox();
            Btn_Equal = new Button();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Array of Numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 60);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // Btn_ArraySize
            // 
            Btn_ArraySize.Location = new Point(6, 86);
            Btn_ArraySize.Name = "Btn_ArraySize";
            Btn_ArraySize.Size = new Size(75, 23);
            Btn_ArraySize.TabIndex = 3;
            Btn_ArraySize.Text = "Show";
            Btn_ArraySize.UseVisualStyleBackColor = true;
            Btn_ArraySize.Click += Btn_ArraySize_Click;
            // 
            // Lbl_EnterArray
            // 
            Lbl_EnterArray.AutoSize = true;
            Lbl_EnterArray.Location = new Point(6, 25);
            Lbl_EnterArray.Name = "Lbl_EnterArray";
            Lbl_EnterArray.Size = new Size(65, 15);
            Lbl_EnterArray.TabIndex = 5;
            Lbl_EnterArray.Text = "Enter Index";
            // 
            // Btn_AddInt
            // 
            Btn_AddInt.Location = new Point(6, 111);
            Btn_AddInt.Name = "Btn_AddInt";
            Btn_AddInt.Size = new Size(75, 23);
            Btn_AddInt.TabIndex = 7;
            Btn_AddInt.Text = "Add";
            Btn_AddInt.UseVisualStyleBackColor = true;
            Btn_AddInt.Click += Btn_AddInt_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Txt_Index);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Lbl_ArraySize);
            groupBox1.Controls.Add(Btn_ArraySize);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(40, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 126);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Array Index Value";
            // 
            // Txt_Index
            // 
            Txt_Index.Location = new Point(52, 25);
            Txt_Index.Name = "Txt_Index";
            Txt_Index.Size = new Size(100, 23);
            Txt_Index.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 28);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 5;
            label6.Text = "Index";
            // 
            // Lbl_ArraySize
            // 
            Lbl_ArraySize.AutoSize = true;
            Lbl_ArraySize.Location = new Point(63, 60);
            Lbl_ArraySize.Name = "Lbl_ArraySize";
            Lbl_ArraySize.Size = new Size(38, 15);
            Lbl_ArraySize.TabIndex = 4;
            Lbl_ArraySize.Text = "label6";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Lbl_ArrayElements);
            groupBox2.Controls.Add(Txt_AddInt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Txt_AddIndex);
            groupBox2.Controls.Add(Btn_AddInt);
            groupBox2.Controls.Add(Lbl_EnterArray);
            groupBox2.Location = new Point(277, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 140);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Number";
            // 
            // Lbl_ArrayElements
            // 
            Lbl_ArrayElements.AutoSize = true;
            Lbl_ArrayElements.Location = new Point(6, 84);
            Lbl_ArrayElements.Name = "Lbl_ArrayElements";
            Lbl_ArrayElements.Size = new Size(38, 15);
            Lbl_ArrayElements.TabIndex = 10;
            Lbl_ArrayElements.Text = "label4";
            // 
            // Txt_AddInt
            // 
            Txt_AddInt.Location = new Point(100, 51);
            Txt_AddInt.Name = "Txt_AddInt";
            Txt_AddInt.Size = new Size(94, 23);
            Txt_AddInt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Enter a number";
            // 
            // Txt_AddIndex
            // 
            Txt_AddIndex.Location = new Point(100, 22);
            Txt_AddIndex.Name = "Txt_AddIndex";
            Txt_AddIndex.Size = new Size(94, 23);
            Txt_AddIndex.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(Lbl_Array);
            groupBox3.Controls.Add(Btn_AddArray);
            groupBox3.Controls.Add(Txt_AddArray);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(40, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 140);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Array Elements";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 93);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 12;
            label5.Text = "Original array";
            // 
            // Lbl_Array
            // 
            Lbl_Array.AutoSize = true;
            Lbl_Array.Location = new Point(6, 115);
            Lbl_Array.Name = "Lbl_Array";
            Lbl_Array.Size = new Size(38, 15);
            Lbl_Array.TabIndex = 11;
            Lbl_Array.Text = "label5";
            // 
            // Btn_AddArray
            // 
            Btn_AddArray.Location = new Point(6, 59);
            Btn_AddArray.Name = "Btn_AddArray";
            Btn_AddArray.Size = new Size(75, 23);
            Btn_AddArray.TabIndex = 2;
            Btn_AddArray.Text = "Enter";
            Btn_AddArray.UseVisualStyleBackColor = true;
            Btn_AddArray.Click += Btn_AddArray_Click_1;
            // 
            // Txt_AddArray
            // 
            Txt_AddArray.Location = new Point(94, 27);
            Txt_AddArray.Name = "Txt_AddArray";
            Txt_AddArray.Size = new Size(100, 23);
            Txt_AddArray.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 30);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Enter array";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Lbl_FindMax);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(277, 196);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(155, 57);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Highest Value";
            // 
            // Lbl_FindMax
            // 
            Lbl_FindMax.AutoSize = true;
            Lbl_FindMax.Location = new Point(103, 29);
            Lbl_FindMax.Name = "Lbl_FindMax";
            Lbl_FindMax.Size = new Size(38, 15);
            Lbl_FindMax.TabIndex = 1;
            Lbl_FindMax.Text = "label7";
            // 
            // button1
            // 
            button1.Location = new Point(6, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Lbl_CountElements);
            groupBox5.Controls.Add(Btn_CountElements);
            groupBox5.Location = new Point(277, 262);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(155, 57);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Number of Elements";
            // 
            // Lbl_CountElements
            // 
            Lbl_CountElements.AutoSize = true;
            Lbl_CountElements.Location = new Point(103, 29);
            Lbl_CountElements.Name = "Lbl_CountElements";
            Lbl_CountElements.Size = new Size(38, 15);
            Lbl_CountElements.TabIndex = 1;
            Lbl_CountElements.Text = "label7";
            // 
            // Btn_CountElements
            // 
            Btn_CountElements.Location = new Point(6, 25);
            Btn_CountElements.Name = "Btn_CountElements";
            Btn_CountElements.Size = new Size(75, 23);
            Btn_CountElements.TabIndex = 0;
            Btn_CountElements.Text = "Find";
            Btn_CountElements.UseVisualStyleBackColor = true;
            Btn_CountElements.Click += Btn_CountElements_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(Lbl_Sum);
            groupBox6.Controls.Add(Btn_Sum);
            groupBox6.Location = new Point(277, 325);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(155, 57);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Sum of All Elements";
            // 
            // Lbl_Sum
            // 
            Lbl_Sum.AutoSize = true;
            Lbl_Sum.Location = new Point(103, 29);
            Lbl_Sum.Name = "Lbl_Sum";
            Lbl_Sum.Size = new Size(38, 15);
            Lbl_Sum.TabIndex = 1;
            Lbl_Sum.Text = "label7";
            // 
            // Btn_Sum
            // 
            Btn_Sum.Location = new Point(6, 25);
            Btn_Sum.Name = "Btn_Sum";
            Btn_Sum.Size = new Size(75, 23);
            Btn_Sum.TabIndex = 0;
            Btn_Sum.Text = "Find";
            Btn_Sum.UseVisualStyleBackColor = true;
            Btn_Sum.Click += Btn_Sum_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(Lbl_Avg);
            groupBox7.Controls.Add(Btn_Avg);
            groupBox7.Location = new Point(277, 388);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(155, 57);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "Average";
            // 
            // Lbl_Avg
            // 
            Lbl_Avg.AutoSize = true;
            Lbl_Avg.Location = new Point(103, 29);
            Lbl_Avg.Name = "Lbl_Avg";
            Lbl_Avg.Size = new Size(38, 15);
            Lbl_Avg.TabIndex = 1;
            Lbl_Avg.Text = "label7";
            // 
            // Btn_Avg
            // 
            Btn_Avg.Location = new Point(6, 25);
            Btn_Avg.Name = "Btn_Avg";
            Btn_Avg.Size = new Size(75, 23);
            Btn_Avg.TabIndex = 0;
            Btn_Avg.Text = "Find";
            Btn_Avg.UseVisualStyleBackColor = true;
            Btn_Avg.Click += Btn_Avg_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(Txt_EqualIndex2);
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(Lbl_Equal);
            groupBox8.Controls.Add(Txt_EqualIndex1);
            groupBox8.Controls.Add(Btn_Equal);
            groupBox8.Controls.Add(label9);
            groupBox8.Location = new Point(531, 50);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(200, 108);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "Check Equal Numbers";
            // 
            // Txt_EqualIndex2
            // 
            Txt_EqualIndex2.Location = new Point(100, 51);
            Txt_EqualIndex2.Name = "Txt_EqualIndex2";
            Txt_EqualIndex2.Size = new Size(94, 23);
            Txt_EqualIndex2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 54);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 12;
            label7.Text = "Enter Index 2";
            // 
            // Lbl_Equal
            // 
            Lbl_Equal.AutoSize = true;
            Lbl_Equal.Location = new Point(87, 84);
            Lbl_Equal.Name = "Lbl_Equal";
            Lbl_Equal.Size = new Size(38, 15);
            Lbl_Equal.TabIndex = 10;
            Lbl_Equal.Text = "label4";
            // 
            // Txt_EqualIndex1
            // 
            Txt_EqualIndex1.Location = new Point(100, 22);
            Txt_EqualIndex1.Name = "Txt_EqualIndex1";
            Txt_EqualIndex1.Size = new Size(94, 23);
            Txt_EqualIndex1.TabIndex = 0;
            // 
            // Btn_Equal
            // 
            Btn_Equal.Location = new Point(6, 80);
            Btn_Equal.Name = "Btn_Equal";
            Btn_Equal.Size = new Size(75, 23);
            Btn_Equal.TabIndex = 7;
            Btn_Equal.Text = "Check";
            Btn_Equal.UseVisualStyleBackColor = true;
            Btn_Equal.Click += Btn_Equal_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 25);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 5;
            label9.Text = "Enter Index 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Btn_ArraySize;
        private Label Lbl_EnterArray;
        private ListBox ListBox_AddInt;
        private Button Btn_AddInt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox Txt_AddIndex;
        private TextBox Txt_AddInt;
        private Label label3;
        private Label Lbl_ArrayElements;
        private GroupBox groupBox3;
        private Button Btn_AddArray;
        private TextBox Txt_AddArray;
        private Label label4;
        private Label Lbl_Array;
        private Label label5;
        private Label Lbl_ArraySize;
        private TextBox Txt_Index;
        private Label label6;
        private GroupBox groupBox4;
        private Label Lbl_FindMax;
        private Button button1;
        private GroupBox groupBox5;
        private Label Lbl_CountElements;
        private Button Btn_CountElements;
        private GroupBox groupBox6;
        private Label Lbl_Sum;
        private Button Btn_Sum;
        private GroupBox groupBox7;
        private Label Lbl_Avg;
        private Button Btn_Avg;
        private GroupBox groupBox8;
        private Label Lbl_Equal;
        private TextBox Txt_EqualIndex1;
        private Button Btn_Equal;
        private Label label9;
        private TextBox Txt_EqualIndex2;
        private Label label7;
    }
}
