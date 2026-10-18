namespace labAssignment2
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
            this.lbNumOfColories = new System.Windows.Forms.Label();
            this.txtNumOfColories = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.lbFat = new System.Windows.Forms.Label();
            this.txtFatGram = new System.Windows.Forms.TextBox();
            this.ckLowFat = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNumOfColories
            // 
            this.lbNumOfColories.AutoSize = true;
            this.lbNumOfColories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfColories.Location = new System.Drawing.Point(86, 131);
            this.lbNumOfColories.Name = "lbNumOfColories";
            this.lbNumOfColories.Size = new System.Drawing.Size(273, 26);
            this.lbNumOfColories.TabIndex = 0;
            this.lbNumOfColories.Text = "Enter number of colories";
            // 
            // txtNumOfColories
            // 
            this.txtNumOfColories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfColories.Location = new System.Drawing.Point(417, 128);
            this.txtNumOfColories.Multiline = true;
            this.txtNumOfColories.Name = "txtNumOfColories";
            this.txtNumOfColories.Size = new System.Drawing.Size(242, 39);
            this.txtNumOfColories.TabIndex = 0;
            this.txtNumOfColories.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(417, 289);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(242, 54);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // lbFat
            // 
            this.lbFat.AutoSize = true;
            this.lbFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFat.Location = new System.Drawing.Point(86, 206);
            this.lbFat.Name = "lbFat";
            this.lbFat.Size = new System.Drawing.Size(171, 26);
            this.lbFat.TabIndex = 3;
            this.lbFat.Text = "Enter fat gram:";
            // 
            // txtFatGram
            // 
            this.txtFatGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatGram.Location = new System.Drawing.Point(417, 202);
            this.txtFatGram.Multiline = true;
            this.txtFatGram.Name = "txtFatGram";
            this.txtFatGram.Size = new System.Drawing.Size(242, 39);
            this.txtFatGram.TabIndex = 1;
            // 
            // ckLowFat
            // 
            this.ckLowFat.AutoSize = true;
            this.ckLowFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckLowFat.Location = new System.Drawing.Point(80, 303);
            this.ckLowFat.Name = "ckLowFat";
            this.ckLowFat.Size = new System.Drawing.Size(160, 29);
            this.ckLowFat.TabIndex = 5;
            this.ckLowFat.Text = "Low Fat Gram";
            this.ckLowFat.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(711, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 229);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calories Percentage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1118, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ckLowFat);
            this.Controls.Add(this.txtFatGram);
            this.Controls.Add(this.lbFat);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.txtNumOfColories);
            this.Controls.Add(this.lbNumOfColories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumOfColories;
        private System.Windows.Forms.TextBox txtNumOfColories;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label lbFat;
        private System.Windows.Forms.TextBox txtFatGram;
        private System.Windows.Forms.CheckBox ckLowFat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

