namespace assigment4
{
    partial class Form1
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
            this.lblFood1 = new System.Windows.Forms.Label();
            this.Price1 = new System.Windows.Forms.Label();
            this.lblFood2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.salesTax = new System.Windows.Forms.Label();
            this.TipsAmount = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.calculatePrice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblTipsAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFood1
            // 
            this.lblFood1.AutoSize = true;
            this.lblFood1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood1.Location = new System.Drawing.Point(74, 80);
            this.lblFood1.Name = "lblFood1";
            this.lblFood1.Size = new System.Drawing.Size(241, 25);
            this.lblFood1.TabIndex = 0;
            this.lblFood1.Text = "Enter Name Food 1 :";
            this.lblFood1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price1.Location = new System.Drawing.Point(74, 140);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(234, 25);
            this.Price1.TabIndex = 1;
            this.Price1.Text = "Enter Price Food 1 :";
            // 
            // lblFood2
            // 
            this.lblFood2.AutoSize = true;
            this.lblFood2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood2.Location = new System.Drawing.Point(74, 194);
            this.lblFood2.Name = "lblFood2";
            this.lblFood2.Size = new System.Drawing.Size(241, 25);
            this.lblFood2.TabIndex = 2;
            this.lblFood2.Text = "Enter Name Food 2 :";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(74, 250);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(234, 25);
            this.lblPrice2.TabIndex = 3;
            this.lblPrice2.Text = "Enter Price Food 2 :";
            // 
            // salesTax
            // 
            this.salesTax.AutoSize = true;
            this.salesTax.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTax.Location = new System.Drawing.Point(89, 413);
            this.salesTax.Name = "salesTax";
            this.salesTax.Size = new System.Drawing.Size(159, 25);
            this.salesTax.TabIndex = 4;
            this.salesTax.Text = "Sales Tax is :";
            // 
            // TipsAmount
            // 
            this.TipsAmount.AutoSize = true;
            this.TipsAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipsAmount.Location = new System.Drawing.Point(89, 475);
            this.TipsAmount.Name = "TipsAmount";
            this.TipsAmount.Size = new System.Drawing.Size(176, 25);
            this.TipsAmount.TabIndex = 5;
            this.TipsAmount.Text = "Tips Amount : ";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(89, 538);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(164, 25);
            this.TotalAmount.TabIndex = 6;
            this.TotalAmount.Text = "Total Amount";
            // 
            // calculatePrice
            // 
            this.calculatePrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePrice.Location = new System.Drawing.Point(327, 319);
            this.calculatePrice.Name = "calculatePrice";
            this.calculatePrice.Size = new System.Drawing.Size(211, 49);
            this.calculatePrice.TabIndex = 7;
            this.calculatePrice.Text = "Calculate the Price";
            this.calculatePrice.UseVisualStyleBackColor = true;
            this.calculatePrice.Click += new System.EventHandler(this.calculatePrice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(370, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 37);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(370, 248);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(472, 38);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(370, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(472, 39);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(370, 127);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(472, 39);
            this.textBox4.TabIndex = 11;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTax.Location = new System.Drawing.Point(370, 400);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(472, 34);
            this.lblSalesTax.TabIndex = 12;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipsAmount
            // 
            this.lblTipsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipsAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipsAmount.Location = new System.Drawing.Point(370, 465);
            this.lblTipsAmount.Name = "lblTipsAmount";
            this.lblTipsAmount.Size = new System.Drawing.Size(472, 30);
            this.lblTipsAmount.TabIndex = 13;
            this.lblTipsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(370, 526);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(472, 33);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 620);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTipsAmount);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculatePrice);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.TipsAmount);
            this.Controls.Add(this.salesTax);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblFood2);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.lblFood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFood1;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Label lblFood2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label salesTax;
        private System.Windows.Forms.Label TipsAmount;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Button calculatePrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblTipsAmount;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}

