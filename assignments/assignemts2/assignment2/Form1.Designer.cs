namespace assignment2
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSem = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.showInfoBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStudentSem = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(489, 54);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(315, 40);
            this.txtStudentName.TabIndex = 0;
            // 
            // txtStudentSem
            // 
            this.txtStudentSem.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSem.Location = new System.Drawing.Point(489, 277);
            this.txtStudentSem.Multiline = true;
            this.txtStudentSem.Name = "txtStudentSem";
            this.txtStudentSem.Size = new System.Drawing.Size(315, 40);
            this.txtStudentSem.TabIndex = 3;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(489, 203);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(315, 40);
            this.txtDepartment.TabIndex = 2;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(489, 128);
            this.txtStudentId.Multiline = true;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(315, 40);
            this.txtStudentId.TabIndex = 1;
            // 
            // showInfoBtn
            // 
            this.showInfoBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfoBtn.Location = new System.Drawing.Point(59, 504);
            this.showInfoBtn.Name = "showInfoBtn";
            this.showInfoBtn.Size = new System.Drawing.Size(277, 69);
            this.showInfoBtn.TabIndex = 4;
            this.showInfoBtn.Text = "&Show information";
            this.showInfoBtn.UseVisualStyleBackColor = true;
            this.showInfoBtn.Click += new System.EventHandler(this.showInfoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(656, 504);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 69);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(440, 504);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(147, 69);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(308, 26);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Enter the student name";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(55, 128);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(262, 26);
            this.lblStudentId.TabIndex = 8;
            this.lblStudentId.Text = "Enter the student id";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(55, 203);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(281, 26);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Enter the department";
            // 
            // lblStudentSem
            // 
            this.lblStudentSem.AutoSize = true;
            this.lblStudentSem.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSem.Location = new System.Drawing.Point(55, 277);
            this.lblStudentSem.Name = "lblStudentSem";
            this.lblStudentSem.Size = new System.Drawing.Size(251, 26);
            this.lblStudentSem.TabIndex = 10;
            this.lblStudentSem.Text = "Enter the semester";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(64, 366);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(740, 96);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(869, 614);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblStudentSem);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showInfoBtn);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtStudentSem);
            this.Controls.Add(this.txtStudentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSem;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button showInfoBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStudentSem;
        private System.Windows.Forms.Label lblOutput;
    }
}

