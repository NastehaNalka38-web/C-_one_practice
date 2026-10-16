namespace Assignment5
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtNumOfTicket = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.ckTravelInsurance = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBusinessClass = new System.Windows.Forms.RadioButton();
            this.rNormalClass = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rFirstClass = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(631, 652);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(189, 52);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(69, 652);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(189, 52);
            this.calculateBtn.TabIndex = 17;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassengerAge.Location = new System.Drawing.Point(457, 161);
            this.txtPassengerAge.Multiline = true;
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(363, 39);
            this.txtPassengerAge.TabIndex = 1;
            // 
            // txtNumOfTicket
            // 
            this.txtNumOfTicket.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfTicket.Location = new System.Drawing.Point(457, 225);
            this.txtNumOfTicket.Multiline = true;
            this.txtNumOfTicket.Name = "txtNumOfTicket";
            this.txtNumOfTicket.Size = new System.Drawing.Size(363, 38);
            this.txtNumOfTicket.TabIndex = 2;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaggageWeight.Location = new System.Drawing.Point(457, 293);
            this.txtBaggageWeight.Multiline = true;
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(363, 40);
            this.txtBaggageWeight.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(894, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 629);
            this.listBox1.TabIndex = 23;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassengerName.Location = new System.Drawing.Point(457, 86);
            this.txtPassengerName.Multiline = true;
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(363, 40);
            this.txtPassengerName.TabIndex = 0;
            // 
            // ckTravelInsurance
            // 
            this.ckTravelInsurance.AutoSize = true;
            this.ckTravelInsurance.Location = new System.Drawing.Point(51, 54);
            this.ckTravelInsurance.Name = "ckTravelInsurance";
            this.ckTravelInsurance.Size = new System.Drawing.Size(519, 30);
            this.ckTravelInsurance.TabIndex = 0;
            this.ckTravelInsurance.Text = "Add Travel Insurance (25$ per Ticket)";
            this.ckTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(326, 652);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(189, 52);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckTravelInsurance);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(69, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 117);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            // 
            // rBusinessClass
            // 
            this.rBusinessClass.AutoSize = true;
            this.rBusinessClass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBusinessClass.Location = new System.Drawing.Point(402, 65);
            this.rBusinessClass.Name = "rBusinessClass";
            this.rBusinessClass.Size = new System.Drawing.Size(201, 29);
            this.rBusinessClass.TabIndex = 2;
            this.rBusinessClass.TabStop = true;
            this.rBusinessClass.Text = "Business Class";
            this.rBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rNormalClass
            // 
            this.rNormalClass.AutoSize = true;
            this.rNormalClass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNormalClass.Location = new System.Drawing.Point(196, 65);
            this.rNormalClass.Name = "rNormalClass";
            this.rNormalClass.Size = new System.Drawing.Size(184, 29);
            this.rNormalClass.TabIndex = 1;
            this.rNormalClass.TabStop = true;
            this.rNormalClass.Text = "Normal Class";
            this.rNormalClass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBusinessClass);
            this.groupBox1.Controls.Add(this.rNormalClass);
            this.groupBox1.Controls.Add(this.rFirstClass);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 131);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Class";
            // 
            // rFirstClass
            // 
            this.rFirstClass.AutoSize = true;
            this.rFirstClass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFirstClass.Location = new System.Drawing.Point(35, 65);
            this.rFirstClass.Name = "rFirstClass";
            this.rFirstClass.Size = new System.Drawing.Size(153, 29);
            this.rFirstClass.TabIndex = 0;
            this.rFirstClass.TabStop = true;
            this.rFirstClass.Text = "First Class";
            this.rFirstClass.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Baggage Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of Tickets:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(85, 164);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(205, 26);
            this.lbAge.TabIndex = 14;
            this.lbAge.Text = "Passenger Age:";
            this.lbAge.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Passenger Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Personal information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1636, 752);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.txtPassengerAge);
            this.Controls.Add(this.txtNumOfTicket);
            this.Controls.Add(this.txtBaggageWeight);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtNumOfTicket;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.CheckBox ckTravelInsurance;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBusinessClass;
        private System.Windows.Forms.RadioButton rNormalClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rFirstClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

