namespace BanditWithOneArm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spinButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.scoreDisplay = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.reel3Output = new System.Windows.Forms.PictureBox();
            this.reel2Output = new System.Windows.Forms.PictureBox();
            this.reel1Output = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reel3Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel2Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel1Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.Color.LimeGreen;
            this.spinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(319, 122);
            this.spinButton.Margin = new System.Windows.Forms.Padding(2);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(51, 46);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "SPIN";
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.DimGray;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(104, 236);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(162, 31);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreDisplay
            // 
            this.scoreDisplay.BackColor = System.Drawing.Color.Transparent;
            this.scoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreDisplay.ForeColor = System.Drawing.Color.Black;
            this.scoreDisplay.Location = new System.Drawing.Point(59, 236);
            this.scoreDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreDisplay.Name = "scoreDisplay";
            this.scoreDisplay.Size = new System.Drawing.Size(41, 31);
            this.scoreDisplay.TabIndex = 5;
            this.scoreDisplay.Text = "10";
            this.scoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinLabel
            // 
            this.coinLabel.BackColor = System.Drawing.Color.Transparent;
            this.coinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinLabel.ForeColor = System.Drawing.Color.Black;
            this.coinLabel.Location = new System.Drawing.Point(11, 235);
            this.coinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(56, 31);
            this.coinLabel.TabIndex = 6;
            this.coinLabel.Text = "Coins:";
            this.coinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reel3Output
            // 
            this.reel3Output.BackColor = System.Drawing.Color.Transparent;
            this.reel3Output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reel3Output.Location = new System.Drawing.Point(235, 116);
            this.reel3Output.Name = "reel3Output";
            this.reel3Output.Size = new System.Drawing.Size(54, 56);
            this.reel3Output.TabIndex = 12;
            this.reel3Output.TabStop = false;
            // 
            // reel2Output
            // 
            this.reel2Output.BackColor = System.Drawing.Color.Transparent;
            this.reel2Output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reel2Output.Location = new System.Drawing.Point(159, 116);
            this.reel2Output.Name = "reel2Output";
            this.reel2Output.Size = new System.Drawing.Size(54, 56);
            this.reel2Output.TabIndex = 11;
            this.reel2Output.TabStop = false;
            // 
            // reel1Output
            // 
            this.reel1Output.BackColor = System.Drawing.Color.Transparent;
            this.reel1Output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reel1Output.Location = new System.Drawing.Point(80, 116);
            this.reel1Output.Name = "reel1Output";
            this.reel1Output.Size = new System.Drawing.Size(54, 56);
            this.reel1Output.TabIndex = 10;
            this.reel1Output.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BanditWithOneArm.Properties.Resources.slotBack;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(373, 268);
            this.Controls.Add(this.reel3Output);
            this.Controls.Add(this.reel2Output);
            this.Controls.Add(this.reel1Output);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.scoreDisplay);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Armed Bandit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reel3Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel2Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reel1Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label scoreDisplay;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.PictureBox reel3Output;
        private System.Windows.Forms.PictureBox reel2Output;
        private System.Windows.Forms.PictureBox reel1Output;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}