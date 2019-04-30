namespace Checkers
{
    partial class Rules
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
            this.ruleBox1 = new System.Windows.Forms.TextBox();
            this.ruleBox3 = new System.Windows.Forms.TextBox();
            this.ruleBox4 = new System.Windows.Forms.TextBox();
            this.ruleTitle = new System.Windows.Forms.TextBox();
            this.ruleBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ruleBox1
            // 
            this.ruleBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.ruleBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleBox1.Location = new System.Drawing.Point(12, 56);
            this.ruleBox1.Name = "ruleBox1";
            this.ruleBox1.ReadOnly = true;
            this.ruleBox1.Size = new System.Drawing.Size(400, 27);
            this.ruleBox1.TabIndex = 2;
            this.ruleBox1.Text = "- The basic rules of checkers apply.";
            this.ruleBox1.TextChanged += new System.EventHandler(this.ruleBox1_TextChanged);
            // 
            // ruleBox3
            // 
            this.ruleBox3.BackColor = System.Drawing.Color.DarkKhaki;
            this.ruleBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleBox3.Location = new System.Drawing.Point(12, 89);
            this.ruleBox3.Name = "ruleBox3";
            this.ruleBox3.ReadOnly = true;
            this.ruleBox3.Size = new System.Drawing.Size(400, 27);
            this.ruleBox3.TabIndex = 4;
            this.ruleBox3.Text = "- Multiple hops are allowed.";
            this.ruleBox3.TextChanged += new System.EventHandler(this.ruleBox3_TextChanged);
            // 
            // ruleBox4
            // 
            this.ruleBox4.BackColor = System.Drawing.Color.DarkKhaki;
            this.ruleBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleBox4.Location = new System.Drawing.Point(12, 122);
            this.ruleBox4.Name = "ruleBox4";
            this.ruleBox4.ReadOnly = true;
            this.ruleBox4.Size = new System.Drawing.Size(560, 27);
            this.ruleBox4.TabIndex = 5;
            this.ruleBox4.Text = "- KING checks can be obtained.";
            this.ruleBox4.TextChanged += new System.EventHandler(this.ruleBox4_TextChanged);
            // 
            // ruleTitle
            // 
            this.ruleTitle.BackColor = System.Drawing.Color.DarkKhaki;
            this.ruleTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleTitle.Location = new System.Drawing.Point(26, 12);
            this.ruleTitle.Name = "ruleTitle";
            this.ruleTitle.ReadOnly = true;
            this.ruleTitle.Size = new System.Drawing.Size(128, 38);
            this.ruleTitle.TabIndex = 7;
            this.ruleTitle.Text = "RULES";
            this.ruleTitle.TextChanged += new System.EventHandler(this.ruleTitle_TextChanged);
            // 
            // ruleBox5
            // 
            this.ruleBox5.BackColor = System.Drawing.Color.DarkKhaki;
            this.ruleBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleBox5.Location = new System.Drawing.Point(12, 155);
            this.ruleBox5.Name = "ruleBox5";
            this.ruleBox5.ReadOnly = true;
            this.ruleBox5.Size = new System.Drawing.Size(586, 27);
            this.ruleBox5.TabIndex = 6;
            this.ruleBox5.Text = "- Match ends once a player loses all of their checkers.";
            this.ruleBox5.TextChanged += new System.EventHandler(this.ruleBox5_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(601, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = " - Select your check, and then select wanted destination.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(5, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(601, 27);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = " - You may reselect checks.";
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.Silver;
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm.Location = new System.Drawing.Point(252, 283);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(109, 42);
            this.closeForm.TabIndex = 95;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(623, 337);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ruleTitle);
            this.Controls.Add(this.ruleBox5);
            this.Controls.Add(this.ruleBox4);
            this.Controls.Add(this.ruleBox3);
            this.Controls.Add(this.ruleBox1);
            this.Name = "Rules";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.RuleList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ruleBox1;
        private System.Windows.Forms.TextBox ruleBox3;
        private System.Windows.Forms.TextBox ruleBox4;
        private System.Windows.Forms.TextBox ruleTitle;
        private System.Windows.Forms.TextBox ruleBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button closeForm;
    }
}