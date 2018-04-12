namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GetStudents = new System.Windows.Forms.Button();
            this.GetStudentsbyID = new System.Windows.Forms.Button();
            this.GetGroupbyID = new System.Windows.Forms.Button();
            this.GetGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIMER";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DETAILS";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(265, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(534, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Error Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Student ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(534, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter Group ID";
            // 
            // GetStudents
            // 
            this.GetStudents.Location = new System.Drawing.Point(110, 305);
            this.GetStudents.Name = "GetStudents";
            this.GetStudents.Size = new System.Drawing.Size(84, 37);
            this.GetStudents.TabIndex = 15;
            this.GetStudents.Text = "GetStudents";
            this.GetStudents.UseVisualStyleBackColor = true;
            this.GetStudents.Click += new System.EventHandler(this.GetStudents_Click);
            // 
            // GetStudentsbyID
            // 
            this.GetStudentsbyID.Location = new System.Drawing.Point(245, 305);
            this.GetStudentsbyID.Name = "GetStudentsbyID";
            this.GetStudentsbyID.Size = new System.Drawing.Size(101, 37);
            this.GetStudentsbyID.TabIndex = 16;
            this.GetStudentsbyID.Text = "GetStudentsbyID";
            this.GetStudentsbyID.UseVisualStyleBackColor = true;
            this.GetStudentsbyID.Click += new System.EventHandler(this.GetStudentsbyID_Click);
            // 
            // GetGroupbyID
            // 
            this.GetGroupbyID.Location = new System.Drawing.Point(534, 305);
            this.GetGroupbyID.Name = "GetGroupbyID";
            this.GetGroupbyID.Size = new System.Drawing.Size(100, 37);
            this.GetGroupbyID.TabIndex = 18;
            this.GetGroupbyID.Text = "GetGroupbyID";
            this.GetGroupbyID.UseVisualStyleBackColor = true;
            this.GetGroupbyID.Click += new System.EventHandler(this.GetGroupbyID_Click);
            // 
            // GetGroups
            // 
            this.GetGroups.Location = new System.Drawing.Point(398, 305);
            this.GetGroups.Name = "GetGroups";
            this.GetGroups.Size = new System.Drawing.Size(84, 37);
            this.GetGroups.TabIndex = 19;
            this.GetGroups.Text = "GetGroups";
            this.GetGroups.UseVisualStyleBackColor = true;
            this.GetGroups.Click += new System.EventHandler(this.GetGroups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 389);
            this.Controls.Add(this.GetGroups);
            this.Controls.Add(this.GetGroupbyID);
            this.Controls.Add(this.GetStudentsbyID);
            this.Controls.Add(this.GetStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "      ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetStudents;
        private System.Windows.Forms.Button GetStudentsbyID;
        private System.Windows.Forms.Button GetGroupbyID;
        private System.Windows.Forms.Button GetGroups;
    }
}

