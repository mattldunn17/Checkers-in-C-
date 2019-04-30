namespace Checkers
{
    partial class Register
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
            this.startGame = new System.Windows.Forms.Button();
            this.redplayertitle = new System.Windows.Forms.TextBox();
            this.blueplayertitle = new System.Windows.Forms.TextBox();
            this.redname = new System.Windows.Forms.TextBox();
            this.rednametitle = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bluename = new System.Windows.Forms.TextBox();
            this.closeWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Silver;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(371, 136);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(152, 65);
            this.startGame.TabIndex = 90;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // redplayertitle
            // 
            this.redplayertitle.BackColor = System.Drawing.Color.DarkKhaki;
            this.redplayertitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redplayertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redplayertitle.ForeColor = System.Drawing.Color.Red;
            this.redplayertitle.Location = new System.Drawing.Point(29, 12);
            this.redplayertitle.Name = "redplayertitle";
            this.redplayertitle.ReadOnly = true;
            this.redplayertitle.Size = new System.Drawing.Size(295, 38);
            this.redplayertitle.TabIndex = 91;
            this.redplayertitle.Text = "Red Player";
            this.redplayertitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blueplayertitle
            // 
            this.blueplayertitle.BackColor = System.Drawing.Color.DarkKhaki;
            this.blueplayertitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blueplayertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueplayertitle.ForeColor = System.Drawing.Color.Blue;
            this.blueplayertitle.Location = new System.Drawing.Point(392, 12);
            this.blueplayertitle.Name = "blueplayertitle";
            this.blueplayertitle.ReadOnly = true;
            this.blueplayertitle.Size = new System.Drawing.Size(295, 38);
            this.blueplayertitle.TabIndex = 92;
            this.blueplayertitle.Text = "Blue Player";
            this.blueplayertitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // redname
            // 
            this.redname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redname.Location = new System.Drawing.Point(138, 68);
            this.redname.MaxLength = 20;
            this.redname.Name = "redname";
            this.redname.Size = new System.Drawing.Size(207, 34);
            this.redname.TabIndex = 93;
            // 
            // rednametitle
            // 
            this.rednametitle.BackColor = System.Drawing.Color.DarkKhaki;
            this.rednametitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rednametitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rednametitle.ForeColor = System.Drawing.Color.Black;
            this.rednametitle.Location = new System.Drawing.Point(32, 68);
            this.rednametitle.Name = "rednametitle";
            this.rednametitle.ReadOnly = true;
            this.rednametitle.Size = new System.Drawing.Size(100, 31);
            this.rednametitle.TabIndex = 94;
            this.rednametitle.Text = "Name :";
            this.rednametitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(402, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 98;
            this.textBox4.Text = "Name :";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bluename
            // 
            this.bluename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluename.Location = new System.Drawing.Point(508, 68);
            this.bluename.MaxLength = 20;
            this.bluename.Name = "bluename";
            this.bluename.Size = new System.Drawing.Size(207, 34);
            this.bluename.TabIndex = 97;
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Silver;
            this.closeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow.Location = new System.Drawing.Point(213, 134);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(152, 67);
            this.closeWindow.TabIndex = 101;
            this.closeWindow.Text = "Close";
            this.closeWindow.UseVisualStyleBackColor = false;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(743, 238);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.bluename);
            this.Controls.Add(this.rednametitle);
            this.Controls.Add(this.redname);
            this.Controls.Add(this.blueplayertitle);
            this.Controls.Add(this.redplayertitle);
            this.Controls.Add(this.startGame);
            this.Name = "Register";
            this.Text = "Checkers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TextBox redplayertitle;
        private System.Windows.Forms.TextBox blueplayertitle;
        private System.Windows.Forms.TextBox redname;
        private System.Windows.Forms.TextBox rednametitle;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox bluename;
        private System.Windows.Forms.Button closeWindow;
    }
}