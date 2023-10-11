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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}