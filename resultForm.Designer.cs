
namespace HIMYM_EpisodeGenerator
{
    partial class resultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resultForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBttnTwo = new System.Windows.Forms.Button();
            this.seasonLbl = new System.Windows.Forms.Label();
            this.episodeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitBttnTwo
            // 
            this.exitBttnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttnTwo.Location = new System.Drawing.Point(313, 383);
            this.exitBttnTwo.Name = "exitBttnTwo";
            this.exitBttnTwo.Size = new System.Drawing.Size(159, 55);
            this.exitBttnTwo.TabIndex = 1;
            this.exitBttnTwo.Text = "Exit";
            this.exitBttnTwo.UseVisualStyleBackColor = true;
            this.exitBttnTwo.Click += new System.EventHandler(this.exitBttnTwo_Click);
            // 
            // seasonLbl
            // 
            this.seasonLbl.AutoSize = true;
            this.seasonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonLbl.Location = new System.Drawing.Point(192, 314);
            this.seasonLbl.Name = "seasonLbl";
            this.seasonLbl.Size = new System.Drawing.Size(79, 29);
            this.seasonLbl.TabIndex = 2;
            this.seasonLbl.Text = "label1";
            // 
            // episodeLbl
            // 
            this.episodeLbl.AutoSize = true;
            this.episodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLbl.Location = new System.Drawing.Point(418, 314);
            this.episodeLbl.Name = "episodeLbl";
            this.episodeLbl.Size = new System.Drawing.Size(79, 29);
            this.episodeLbl.TabIndex = 3;
            this.episodeLbl.Text = "label2";
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.episodeLbl);
            this.Controls.Add(this.seasonLbl);
            this.Controls.Add(this.exitBttnTwo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "resultForm";
            this.Text = "resultForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBttnTwo;
        public System.Windows.Forms.Label episodeLbl;
        public System.Windows.Forms.Label seasonLbl;
    }
}