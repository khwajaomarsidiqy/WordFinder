namespace QuestionInInterview
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
            button23 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button23
            // 
            button23.Location = new Point(239, 119);
            button23.Name = "button23";
            button23.Size = new Size(189, 67);
            button23.TabIndex = 22;
            button23.Text = "Find word in matrix";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 44);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 23;
            label1.Text = "Get Words from Matrix ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 279);
            Controls.Add(label1);
            Controls.Add(button23);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button23;
        private Label label1;
    }
}