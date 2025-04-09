namespace CalculatorMVC.Views
{
    partial class MainForm
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
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            txtValueA = new TextBox();
            txtValueB = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(239, 126);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(156, 46);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "Відняти";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(55, 187);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(156, 46);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "Помножити";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(239, 187);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(156, 46);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "Поділити";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // txtValueA
            // 
            txtValueA.Location = new Point(55, 41);
            txtValueA.Name = "txtValueA";
            txtValueA.Size = new Size(156, 39);
            txtValueA.TabIndex = 7;
            // 
            // txtValueB
            // 
            txtValueB.Location = new Point(239, 41);
            txtValueB.Name = "txtValueB";
            txtValueB.Size = new Size(156, 39);
            txtValueB.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(139, 278);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(120, 32);
            lblResult.TabIndex = 9;
            lblResult.Text = "Результат";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 324);
            Controls.Add(lblResult);
            Controls.Add(txtValueB);
            Controls.Add(txtValueA);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private TextBox txtValueA;
        private TextBox txtValueB;
        private Label lblResult;
    }
}