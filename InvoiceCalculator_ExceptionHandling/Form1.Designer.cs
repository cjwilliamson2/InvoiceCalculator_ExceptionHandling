namespace InvoiceCalculator_ExceptionHandling
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
            txtSubTotal = new TextBox();
            txtDiscountPercentage = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotal = new TextBox();
            lblSubTotal = new Label();
            lblDiscountPercentage = new Label();
            lblDiscountAmount = new Label();
            lblTotal = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(195, 59);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 0;
            // 
            // txtDiscountPercentage
            // 
            txtDiscountPercentage.Location = new Point(195, 103);
            txtDiscountPercentage.Name = "txtDiscountPercentage";
            txtDiscountPercentage.Size = new Size(100, 23);
            txtDiscountPercentage.TabIndex = 1;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(195, 154);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(100, 23);
            txtDiscountAmount.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(195, 203);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 3;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(96, 62);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(55, 15);
            lblSubTotal.TabIndex = 4;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblDiscountPercentage
            // 
            lblDiscountPercentage.AutoSize = true;
            lblDiscountPercentage.Location = new Point(32, 106);
            lblDiscountPercentage.Name = "lblDiscountPercentage";
            lblDiscountPercentage.Size = new Size(119, 15);
            lblDiscountPercentage.TabIndex = 5;
            lblDiscountPercentage.Text = "Discount Percentage:";
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Location = new Point(47, 157);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(104, 15);
            lblDiscountAmount.TabIndex = 6;
            lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(116, 206);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(61, 267);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(195, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(338, 325);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscountAmount);
            Controls.Add(lblDiscountPercentage);
            Controls.Add(lblSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercentage);
            Controls.Add(txtSubTotal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubTotal;
        private TextBox txtDiscountPercentage;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private Label lblSubTotal;
        private Label lblDiscountPercentage;
        private Label lblDiscountAmount;
        private Label lblTotal;
        private Button btnCalculate;
        private Button btnExit;
    }
}