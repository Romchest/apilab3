namespace GrpcClient
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
            firstNumberInput = new TextBox();
            magicBtn = new Button();
            sumResult = new TextBox();
            multResult = new TextBox();
            secondNumberInput = new TextBox();
            SuspendLayout();
            // 
            // firstNumberInput
            // 
            firstNumberInput.Location = new Point(33, 27);
            firstNumberInput.Margin = new Padding(3, 2, 3, 2);
            firstNumberInput.Name = "firstNumberInput";
            firstNumberInput.Size = new Size(140, 23);
            firstNumberInput.TabIndex = 0;
            firstNumberInput.Text = "10";
            // 
            // magicBtn
            // 
            magicBtn.Location = new Point(132, 64);
            magicBtn.Margin = new Padding(3, 2, 3, 2);
            magicBtn.Name = "magicBtn";
            magicBtn.Size = new Size(128, 27);
            magicBtn.TabIndex = 1;
            magicBtn.Text = "Get sum and mult";
            magicBtn.UseVisualStyleBackColor = true;
            magicBtn.Click += DoMagic;
            // 
            // sumResult
            // 
            sumResult.Location = new Point(33, 111);
            sumResult.Margin = new Padding(3, 2, 3, 2);
            sumResult.Name = "sumResult";
            sumResult.ReadOnly = true;
            sumResult.Size = new Size(316, 23);
            sumResult.TabIndex = 2;
            sumResult.Text = "...";
            // 
            // multResult
            // 
            multResult.Location = new Point(33, 155);
            multResult.Margin = new Padding(3, 2, 3, 2);
            multResult.Name = "multResult";
            multResult.ReadOnly = true;
            multResult.Size = new Size(316, 23);
            multResult.TabIndex = 3;
            multResult.Text = "...";
            // 
            // secondNumberInput
            // 
            secondNumberInput.Location = new Point(209, 27);
            secondNumberInput.Margin = new Padding(3, 2, 3, 2);
            secondNumberInput.Name = "secondNumberInput";
            secondNumberInput.Size = new Size(140, 23);
            secondNumberInput.TabIndex = 4;
            secondNumberInput.Text = "10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 224);
            Controls.Add(secondNumberInput);
            Controls.Add(multResult);
            Controls.Add(sumResult);
            Controls.Add(magicBtn);
            Controls.Add(firstNumberInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNumberInput;
        private Button magicBtn;
        private TextBox sumResult;
        private TextBox multResult;
        private TextBox secondNumberInput;
    }
}
