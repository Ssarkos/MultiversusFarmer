namespace MultiversusAfk
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(82, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(92, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00:00";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(88, 28);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(53, 13);
            this.lblChar.TabIndex = 7;
            this.lblChar.Text = "Character";
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Location = new System.Drawing.Point(70, 47);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(95, 13);
            this.lblGames.TabIndex = 8;
            this.lblGames.Text = "Matches Played: 0";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(82, 99);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnChar
            // 
            this.btnChar.FormattingEnabled = true;
            this.btnChar.Items.AddRange(new object[] {
            "Random",
            "Arya Stark",
            "Batman",
            "Bugs Bunny",
            "Finn",
            "Garnet",
            "Harley Quinn",
            "Iron Giant",
            "Jake",
            "Lebron James",
            "Reindog",
            "Shaggy",
            "Steven Universe",
            "Superman",
            "Taz",
            "Tom & Jerry",
            "Velma",
            "Wonder Woman"});
            this.btnChar.Location = new System.Drawing.Point(55, 44);
            this.btnChar.MaxDropDownItems = 20;
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(121, 21);
            this.btnChar.TabIndex = 6;
            this.btnChar.Text = "Random";
            this.btnChar.SelectedIndexChanged += new System.EventHandler(this.btnChar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 145);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox btnChar;
    }
}

