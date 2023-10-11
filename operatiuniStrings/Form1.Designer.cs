namespace operatiuniStrings
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
            txtDebug = new TextBox();
            button1 = new Button();
            txtInput = new TextBox();
            txtInput2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtDebug
            // 
            txtDebug.BackColor = Color.Black;
            txtDebug.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDebug.ForeColor = Color.White;
            txtDebug.Location = new Point(409, 31);
            txtDebug.Multiline = true;
            txtDebug.Name = "txtDebug";
            txtDebug.Size = new Size(353, 380);
            txtDebug.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(27, 146);
            button1.Name = "button1";
            button1.Size = new Size(299, 29);
            button1.TabIndex = 1;
            button1.Text = "toASCIIcode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(25, 38);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(301, 91);
            txtInput.TabIndex = 2;
            txtInput.Text = "input";
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(27, 195);
            txtInput2.Multiline = true;
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(301, 91);
            txtInput2.TabIndex = 4;
            txtInput2.Text = "input2";
            // 
            // button2
            // 
            button2.Location = new Point(29, 303);
            button2.Name = "button2";
            button2.Size = new Size(299, 29);
            button2.TabIndex = 3;
            button2.Text = "ToChars";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(139, 347);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "loadCX";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(txtInput2);
            Controls.Add(button2);
            Controls.Add(txtInput);
            Controls.Add(button1);
            Controls.Add(txtDebug);
            Name = "Form1";
            Text = "stringOps";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDebug;
        private Button button1;
        private TextBox txtInput;
        private TextBox txtInput2;
        private Button button2;
        private Button button3;
    }
}