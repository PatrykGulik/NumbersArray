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
            Txt_ArraySize = new TextBox();
            Btn_ArraySize = new Button();
            Lbl_ArraySize = new Label();
            Lbl_EnterArray = new Label();
            Btn_AddInt = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            Txt_AddInt = new TextBox();
            label3 = new Label();
            Txt_AddIndex = new TextBox();
            Lbl_ArrayElements = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter size";
            // 
            // Txt_ArraySize
            // 
            Txt_ArraySize.Location = new Point(68, 24);
            Txt_ArraySize.Name = "Txt_ArraySize";
            Txt_ArraySize.Size = new Size(100, 23);
            Txt_ArraySize.TabIndex = 2;
            // 
            // Btn_ArraySize
            // 
            Btn_ArraySize.Location = new Point(6, 53);
            Btn_ArraySize.Name = "Btn_ArraySize";
            Btn_ArraySize.Size = new Size(75, 23);
            Btn_ArraySize.TabIndex = 3;
            Btn_ArraySize.Text = "Enter";
            Btn_ArraySize.UseVisualStyleBackColor = true;
            Btn_ArraySize.Click += Btn_ArraySize_Click;
            // 
            // Lbl_ArraySize
            // 
            Lbl_ArraySize.AutoSize = true;
            Lbl_ArraySize.Location = new Point(6, 19);
            Lbl_ArraySize.Name = "Lbl_ArraySize";
            Lbl_ArraySize.Size = new Size(109, 15);
            Lbl_ArraySize.TabIndex = 4;
            Lbl_ArraySize.Text = "The size of array is: ";
            // 
            // Lbl_EnterArray
            // 
            Lbl_EnterArray.AutoSize = true;
            Lbl_EnterArray.Location = new Point(6, 49);
            Lbl_EnterArray.Name = "Lbl_EnterArray";
            Lbl_EnterArray.Size = new Size(65, 15);
            Lbl_EnterArray.TabIndex = 5;
            Lbl_EnterArray.Text = "Enter Index";
            // 
            // Btn_AddInt
            // 
            Btn_AddInt.Location = new Point(119, 153);
            Btn_AddInt.Name = "Btn_AddInt";
            Btn_AddInt.Size = new Size(75, 23);
            Btn_AddInt.TabIndex = 7;
            Btn_AddInt.Text = "Add";
            Btn_AddInt.UseVisualStyleBackColor = true;
            Btn_AddInt.Click += Btn_AddInt_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_ArraySize);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Txt_ArraySize);
            groupBox1.Location = new Point(40, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 89);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Array Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Lbl_ArrayElements);
            groupBox2.Controls.Add(Txt_AddInt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Txt_AddIndex);
            groupBox2.Controls.Add(Lbl_ArraySize);
            groupBox2.Controls.Add(Btn_AddInt);
            groupBox2.Controls.Add(Lbl_EnterArray);
            groupBox2.Location = new Point(40, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 226);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Number";
            // 
            // Txt_AddInt
            // 
            Txt_AddInt.Location = new Point(100, 102);
            Txt_AddInt.Name = "Txt_AddInt";
            Txt_AddInt.Size = new Size(94, 23);
            Txt_AddInt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Enter a number";
            // 
            // Txt_AddIndex
            // 
            Txt_AddIndex.Location = new Point(100, 46);
            Txt_AddIndex.Name = "Txt_AddIndex";
            Txt_AddIndex.Size = new Size(94, 23);
            Txt_AddIndex.TabIndex = 0;
            // 
            // Lbl_ArrayElements
            // 
            Lbl_ArrayElements.AutoSize = true;
            Lbl_ArrayElements.Location = new Point(12, 195);
            Lbl_ArrayElements.Name = "Lbl_ArrayElements";
            Lbl_ArrayElements.Size = new Size(38, 15);
            Lbl_ArrayElements.TabIndex = 10;
            Lbl_ArrayElements.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Txt_ArraySize;
        private Button Btn_ArraySize;
        private Label Lbl_ArraySize;
        private Label Lbl_EnterArray;
        private ListBox ListBox_AddInt;
        private Button Btn_AddInt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox Txt_AddIndex;
        private TextBox Txt_AddInt;
        private Label label3;
        private Label Lbl_ArrayElements;
    }
}
