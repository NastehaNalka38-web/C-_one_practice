namespace FilesAssignment
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
            this.CreateFileBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.WriteFileBtn = new System.Windows.Forms.Button();
            this.deleteFileBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deleteItemFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateFileBtn
            // 
            this.CreateFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileBtn.Location = new System.Drawing.Point(98, 34);
            this.CreateFileBtn.Name = "CreateFileBtn";
            this.CreateFileBtn.Size = new System.Drawing.Size(262, 99);
            this.CreateFileBtn.TabIndex = 0;
            this.CreateFileBtn.Text = "Create File";
            this.CreateFileBtn.UseVisualStyleBackColor = true;
            this.CreateFileBtn.Click += new System.EventHandler(this.CreateFileBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.Location = new System.Drawing.Point(98, 299);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(262, 99);
            this.openFileBtn.TabIndex = 1;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // WriteFileBtn
            // 
            this.WriteFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteFileBtn.Location = new System.Drawing.Point(98, 159);
            this.WriteFileBtn.Name = "WriteFileBtn";
            this.WriteFileBtn.Size = new System.Drawing.Size(262, 99);
            this.WriteFileBtn.TabIndex = 2;
            this.WriteFileBtn.Text = "Write text file";
            this.WriteFileBtn.UseVisualStyleBackColor = true;
            this.WriteFileBtn.Click += new System.EventHandler(this.appendFileBtn_Click);
            // 
            // deleteFileBtn
            // 
            this.deleteFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFileBtn.Location = new System.Drawing.Point(98, 563);
            this.deleteFileBtn.Name = "deleteFileBtn";
            this.deleteFileBtn.Size = new System.Drawing.Size(262, 99);
            this.deleteFileBtn.TabIndex = 3;
            this.deleteFileBtn.Text = "Delete File";
            this.deleteFileBtn.UseVisualStyleBackColor = true;
            this.deleteFileBtn.Click += new System.EventHandler(this.deleteFileBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(476, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 628);
            this.listBox1.TabIndex = 4;
            // 
            // deleteItemFile
            // 
            this.deleteItemFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemFile.Location = new System.Drawing.Point(98, 429);
            this.deleteItemFile.Name = "deleteItemFile";
            this.deleteItemFile.Size = new System.Drawing.Size(262, 99);
            this.deleteItemFile.TabIndex = 5;
            this.deleteItemFile.Text = "Delete Item File";
            this.deleteItemFile.UseVisualStyleBackColor = true;
            this.deleteItemFile.Click += new System.EventHandler(this.deleteItemFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1093, 687);
            this.Controls.Add(this.deleteItemFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteFileBtn);
            this.Controls.Add(this.WriteFileBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.CreateFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateFileBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button WriteFileBtn;
        private System.Windows.Forms.Button deleteFileBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deleteItemFile;
    }
}

