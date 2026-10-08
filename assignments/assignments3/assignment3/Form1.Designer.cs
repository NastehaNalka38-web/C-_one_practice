namespace assignment3
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblElectricity = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.lblElectricityOutput = new System.Windows.Forms.Label();
            this.lblTaxOutput = new System.Windows.Forms.Label();
            this.lblTotalBillOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(511, 149);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(379, 46);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(98, 153);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(305, 26);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Enter customer name  :";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.Azure;
            this.calculateBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(378, 417);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(203, 57);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "&Calculate Bill";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblTotalBillOutput);
            this.panel1.Controls.Add(this.lblTaxOutput);
            this.panel1.Controls.Add(this.lblElectricityOutput);
            this.panel1.Controls.Add(this.lblElectricity);
            this.panel1.Controls.Add(this.lblTaxAmount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 214);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(98, 213);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(320, 26);
            this.lblPrevious.TabIndex = 4;
            this.lblPrevious.Text = "Enter previous Reading :";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(98, 275);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(305, 26);
            this.lblCurrent.TabIndex = 5;
            this.lblCurrent.Text = "Enter current Reading :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(98, 344);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(313, 26);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Enter price per unit($) :";
            // 
            // lblElectricity
            // 
            this.lblElectricity.AutoSize = true;
            this.lblElectricity.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricity.Location = new System.Drawing.Point(41, 45);
            this.lblElectricity.Name = "lblElectricity";
            this.lblElectricity.Size = new System.Drawing.Size(312, 25);
            this.lblElectricity.TabIndex = 7;
            this.lblElectricity.Text = "Electricity usage (units)  : ";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.Location = new System.Drawing.Point(41, 99);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(230, 25);
            this.lblTaxAmount.TabIndex = 8;
            this.lblTaxAmount.Text = "Tax Amount (7%) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total bill (including $5 fixed charge) :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(511, 347);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(379, 46);
            this.txtPrice.TabIndex = 3;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(511, 278);
            this.txtCurrent.Multiline = true;
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(379, 46);
            this.txtCurrent.TabIndex = 2;
            // 
            // txtPrevious
            // 
            this.txtPrevious.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.Location = new System.Drawing.Point(511, 216);
            this.txtPrevious.Multiline = true;
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(379, 46);
            this.txtPrevious.TabIndex = 1;
            // 
            // lblElectricityOutput
            // 
            this.lblElectricityOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElectricityOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityOutput.Location = new System.Drawing.Point(530, 36);
            this.lblElectricityOutput.Name = "lblElectricityOutput";
            this.lblElectricityOutput.Size = new System.Drawing.Size(383, 42);
            this.lblElectricityOutput.TabIndex = 10;
            this.lblElectricityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaxOutput
            // 
            this.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxOutput.Location = new System.Drawing.Point(530, 90);
            this.lblTaxOutput.Name = "lblTaxOutput";
            this.lblTaxOutput.Size = new System.Drawing.Size(383, 42);
            this.lblTaxOutput.TabIndex = 11;
            this.lblTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalBillOutput
            // 
            this.lblTotalBillOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBillOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBillOutput.Location = new System.Drawing.Point(530, 142);
            this.lblTotalBillOutput.Name = "lblTotalBillOutput";
            this.lblTotalBillOutput.Size = new System.Drawing.Size(383, 42);
            this.lblTotalBillOutput.TabIndex = 12;
            this.lblTotalBillOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 44);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(424, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Electricity Bill Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalBillOutput;
        private System.Windows.Forms.Label lblTaxOutput;
        private System.Windows.Forms.Label lblElectricityOutput;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Label label1;
    }
}

