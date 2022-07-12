
namespace HIMYM_EpisodeGenerator
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
            this.firstPictureBox = new System.Windows.Forms.PictureBox();
            this.directionLblOne = new System.Windows.Forms.Label();
            this.secondPictureBox = new System.Windows.Forms.PictureBox();
            this.goBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.seasonRadioBttn = new System.Windows.Forms.RadioButton();
            this.allRadioBttn = new System.Windows.Forms.RadioButton();
            this.episodeRadioBttn = new System.Windows.Forms.RadioButton();
            this.userSelectListBox = new System.Windows.Forms.ListBox();
            this.okayBttnOne = new System.Windows.Forms.Button();
            this.rightLbl = new System.Windows.Forms.Label();
            this.okayBttnTwo = new System.Windows.Forms.Button();
            this.directionLblTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstPictureBox
            // 
            this.firstPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.firstPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstPictureBox.Location = new System.Drawing.Point(56, 131);
            this.firstPictureBox.Name = "firstPictureBox";
            this.firstPictureBox.Size = new System.Drawing.Size(334, 232);
            this.firstPictureBox.TabIndex = 0;
            this.firstPictureBox.TabStop = false;
            // 
            // directionLblOne
            // 
            this.directionLblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLblOne.Location = new System.Drawing.Point(12, 9);
            this.directionLblOne.Name = "directionLblOne";
            this.directionLblOne.Size = new System.Drawing.Size(310, 119);
            this.directionLblOne.TabIndex = 2;
            this.directionLblOne.Text = "Please Select an Option Below and Press Go:\r\n\r\n";
            // 
            // secondPictureBox
            // 
            this.secondPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondPictureBox.Location = new System.Drawing.Point(410, 131);
            this.secondPictureBox.Name = "secondPictureBox";
            this.secondPictureBox.Size = new System.Drawing.Size(334, 232);
            this.secondPictureBox.TabIndex = 3;
            this.secondPictureBox.TabStop = false;
            // 
            // goBttn
            // 
            this.goBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBttn.Location = new System.Drawing.Point(56, 383);
            this.goBttn.Name = "goBttn";
            this.goBttn.Size = new System.Drawing.Size(155, 55);
            this.goBttn.TabIndex = 4;
            this.goBttn.Text = "Go";
            this.goBttn.UseVisualStyleBackColor = true;
            this.goBttn.Click += new System.EventHandler(this.goBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(589, 383);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(155, 55);
            this.exitBttn.TabIndex = 5;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // clearBttn
            // 
            this.clearBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBttn.Location = new System.Drawing.Point(323, 383);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(155, 55);
            this.clearBttn.TabIndex = 6;
            this.clearBttn.Text = "Clear";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // seasonRadioBttn
            // 
            this.seasonRadioBttn.AutoSize = true;
            this.seasonRadioBttn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seasonRadioBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonRadioBttn.Location = new System.Drawing.Point(93, 171);
            this.seasonRadioBttn.Name = "seasonRadioBttn";
            this.seasonRadioBttn.Size = new System.Drawing.Size(208, 29);
            this.seasonRadioBttn.TabIndex = 7;
            this.seasonRadioBttn.TabStop = true;
            this.seasonRadioBttn.Text = "Randomize Season";
            this.seasonRadioBttn.UseVisualStyleBackColor = false;
            // 
            // allRadioBttn
            // 
            this.allRadioBttn.AutoSize = true;
            this.allRadioBttn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.allRadioBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadioBttn.Location = new System.Drawing.Point(96, 315);
            this.allRadioBttn.Name = "allRadioBttn";
            this.allRadioBttn.Size = new System.Drawing.Size(162, 29);
            this.allRadioBttn.TabIndex = 8;
            this.allRadioBttn.TabStop = true;
            this.allRadioBttn.Text = "Randomize All";
            this.allRadioBttn.UseVisualStyleBackColor = false;
            // 
            // episodeRadioBttn
            // 
            this.episodeRadioBttn.AutoSize = true;
            this.episodeRadioBttn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.episodeRadioBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeRadioBttn.Location = new System.Drawing.Point(93, 241);
            this.episodeRadioBttn.Name = "episodeRadioBttn";
            this.episodeRadioBttn.Size = new System.Drawing.Size(211, 29);
            this.episodeRadioBttn.TabIndex = 9;
            this.episodeRadioBttn.TabStop = true;
            this.episodeRadioBttn.Text = "Randomize Episode";
            this.episodeRadioBttn.UseVisualStyleBackColor = false;
            // 
            // userSelectListBox
            // 
            this.userSelectListBox.FormattingEnabled = true;
            this.userSelectListBox.ItemHeight = 20;
            this.userSelectListBox.Location = new System.Drawing.Point(455, 171);
            this.userSelectListBox.Name = "userSelectListBox";
            this.userSelectListBox.Size = new System.Drawing.Size(248, 124);
            this.userSelectListBox.TabIndex = 10;
            this.userSelectListBox.Visible = false;
            // 
            // okayBttnOne
            // 
            this.okayBttnOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okayBttnOne.Location = new System.Drawing.Point(533, 307);
            this.okayBttnOne.Name = "okayBttnOne";
            this.okayBttnOne.Size = new System.Drawing.Size(84, 48);
            this.okayBttnOne.TabIndex = 11;
            this.okayBttnOne.Text = "OK";
            this.okayBttnOne.UseVisualStyleBackColor = false;
            this.okayBttnOne.Visible = false;
            this.okayBttnOne.Click += new System.EventHandler(this.okayBttn_Click);
            // 
            // rightLbl
            // 
            this.rightLbl.AutoSize = true;
            this.rightLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rightLbl.Location = new System.Drawing.Point(451, 147);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(51, 20);
            this.rightLbl.TabIndex = 12;
            this.rightLbl.Text = "label1";
            this.rightLbl.Visible = false;
            // 
            // okayBttnTwo
            // 
            this.okayBttnTwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okayBttnTwo.Location = new System.Drawing.Point(533, 307);
            this.okayBttnTwo.Name = "okayBttnTwo";
            this.okayBttnTwo.Size = new System.Drawing.Size(84, 48);
            this.okayBttnTwo.TabIndex = 13;
            this.okayBttnTwo.Text = "OK";
            this.okayBttnTwo.UseVisualStyleBackColor = false;
            this.okayBttnTwo.Visible = false;
            this.okayBttnTwo.Click += new System.EventHandler(this.okayBttnTwo_Click);
            // 
            // directionLblTwo
            // 
            this.directionLblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLblTwo.Location = new System.Drawing.Point(404, 30);
            this.directionLblTwo.Name = "directionLblTwo";
            this.directionLblTwo.Size = new System.Drawing.Size(250, 98);
            this.directionLblTwo.TabIndex = 14;
            this.directionLblTwo.Text = "Make a Selection and Press OK:";
            this.directionLblTwo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directionLblTwo);
            this.Controls.Add(this.okayBttnTwo);
            this.Controls.Add(this.rightLbl);
            this.Controls.Add(this.okayBttnOne);
            this.Controls.Add(this.userSelectListBox);
            this.Controls.Add(this.episodeRadioBttn);
            this.Controls.Add(this.allRadioBttn);
            this.Controls.Add(this.seasonRadioBttn);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.goBttn);
            this.Controls.Add(this.secondPictureBox);
            this.Controls.Add(this.directionLblOne);
            this.Controls.Add(this.firstPictureBox);
            this.Name = "Form1";
            this.Text = "Episode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox firstPictureBox;
        private System.Windows.Forms.Label directionLblOne;
        private System.Windows.Forms.PictureBox secondPictureBox;
        private System.Windows.Forms.Button goBttn;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.RadioButton seasonRadioBttn;
        private System.Windows.Forms.RadioButton allRadioBttn;
        private System.Windows.Forms.RadioButton episodeRadioBttn;
        private System.Windows.Forms.ListBox userSelectListBox;
        private System.Windows.Forms.Button okayBttnOne;
        private System.Windows.Forms.Label rightLbl;
        private System.Windows.Forms.Button okayBttnTwo;
        private System.Windows.Forms.Label directionLblTwo;
    }
}

