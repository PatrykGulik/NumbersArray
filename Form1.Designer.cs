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
            Lbl_Test = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Arrays";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 46);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter size of the array";
            // 
            // Txt_ArraySize
            // 
            Txt_ArraySize.Location = new Point(65, 64);
            Txt_ArraySize.Name = "Txt_ArraySize";
            Txt_ArraySize.Size = new Size(100, 23);
            Txt_ArraySize.TabIndex = 2;
            // 
            // Btn_ArraySize
            // 
            Btn_ArraySize.Location = new Point(90, 93);
            Btn_ArraySize.Name = "Btn_ArraySize";
            Btn_ArraySize.Size = new Size(75, 23);
            Btn_ArraySize.TabIndex = 3;
            Btn_ArraySize.Text = "Size";
            Btn_ArraySize.UseVisualStyleBackColor = true;
            Btn_ArraySize.Click += Btn_ArraySize_Click;
            // 
            // Lbl_Test
            // 
            Lbl_Test.AutoSize = true;
            Lbl_Test.Location = new Point(118, 123);
            Lbl_Test.Name = "Lbl_Test";
            Lbl_Test.Size = new Size(38, 15);
            Lbl_Test.TabIndex = 4;
            Lbl_Test.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl_Test);
            Controls.Add(Btn_ArraySize);
            Controls.Add(Txt_ArraySize);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Txt_ArraySize;
        private Button Btn_ArraySize;
        private Label Lbl_Test;
    }
}
