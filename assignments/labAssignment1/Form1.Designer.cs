namespace labAssignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rHight = new System.Windows.Forms.RadioButton();
            this.rNormal = new System.Windows.Forms.RadioButton();
            this.rStandard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBreakFast = new System.Windows.Forms.CheckBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNumOfGuests = new System.Windows.Forms.TextBox();
            this.txtNumOfNights = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number Of Guests:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number of Nights:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rHight);
            this.groupBox1.Controls.Add(this.rNormal);
            this.groupBox1.Controls.Add(this.rStandard);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            // 
            // rHight
            // 
            this.rHight.AutoSize = true;
            this.rHight.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rHight.Location = new System.Drawing.Point(395, 65);
            this.rHight.Name = "rHight";
            this.rHight.Size = new System.Drawing.Size(98, 29);
            this.rHight.TabIndex = 2;
            this.rHight.TabStop = true;
            this.rHight.Text = "Hight";
            this.rHight.UseVisualStyleBackColor = true;
            // 
            // rNormal
            // 
            this.rNormal.AutoSize = true;
            this.rNormal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNormal.Location = new System.Drawing.Point(196, 65);
            this.rNormal.Name = "rNormal";
            this.rNormal.Size = new System.Drawing.Size(119, 29);
            this.rNormal.TabIndex = 1;
            this.rNormal.TabStop = true;
            this.rNormal.Text = "Normal";
            this.rNormal.UseVisualStyleBackColor = true;
            // 
            // rStandard
            // 
            this.rStandard.AutoSize = true;
            this.rStandard.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rStandard.Location = new System.Drawing.Point(35, 65);
            this.rStandard.Name = "rStandard";
            this.rStandard.Size = new System.Drawing.Size(138, 29);
            this.rStandard.TabIndex = 0;
            this.rStandard.TabStop = true;
            this.rStandard.Text = "Standard";
            this.rStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBreakFast);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(111, 517);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            // 
            // checkBreakFast
            // 
            this.checkBreakFast.AutoSize = true;
            this.checkBreakFast.Location = new System.Drawing.Point(51, 54);
            this.checkBreakFast.Name = "checkBreakFast";
            this.checkBreakFast.Size = new System.Drawing.Size(484, 30);
            this.checkBreakFast.TabIndex = 0;
            this.checkBreakFast.Text = "BreakFast(10 Per Guest per nights)";
            this.checkBreakFast.UseVisualStyleBackColor = true;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(506, 95);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(356, 40);
            this.txtGuestName.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(961, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 524);
            this.listBox1.TabIndex = 8;
            // 
            // txtNumOfGuests
            // 
            this.txtNumOfGuests.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfGuests.Location = new System.Drawing.Point(506, 313);
            this.txtNumOfGuests.Multiline = true;
            this.txtNumOfGuests.Name = "txtNumOfGuests";
            this.txtNumOfGuests.Size = new System.Drawing.Size(356, 29);
            this.txtNumOfGuests.TabIndex = 3;
            // 
            // txtNumOfNights
            // 
            this.txtNumOfNights.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfNights.Location = new System.Drawing.Point(506, 234);
            this.txtNumOfNights.Multiline = true;
            this.txtNumOfNights.Name = "txtNumOfNights";
            this.txtNumOfNights.Size = new System.Drawing.Size(356, 38);
            this.txtNumOfNights.TabIndex = 2;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestAge.Location = new System.Drawing.Point(506, 170);
            this.txtGuestAge.Multiline = true;
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(356, 39);
            this.txtGuestAge.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(111, 651);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(189, 52);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(429, 651);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(189, 52);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(728, 651);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(189, 52);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 729);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.txtGuestAge);
            this.Controls.Add(this.txtNumOfNights);
            this.Controls.Add(this.txtNumOfGuests);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rStandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBreakFast;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNumOfGuests;
        private System.Windows.Forms.TextBox txtNumOfNights;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.RadioButton rHight;
        private System.Windows.Forms.RadioButton rNormal;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

