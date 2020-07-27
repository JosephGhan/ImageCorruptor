namespace ImageCorruptor
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.picBoxOld = new System.Windows.Forms.PictureBox();
            this.picBoxNew = new System.Windows.Forms.PictureBox();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(75, 242);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 38);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // picBoxOld
            // 
            this.picBoxOld.Location = new System.Drawing.Point(197, 98);
            this.picBoxOld.Name = "picBoxOld";
            this.picBoxOld.Size = new System.Drawing.Size(252, 235);
            this.picBoxOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOld.TabIndex = 1;
            this.picBoxOld.TabStop = false;
            // 
            // picBoxNew
            // 
            this.picBoxNew.Location = new System.Drawing.Point(455, 98);
            this.picBoxNew.Name = "picBoxNew";
            this.picBoxNew.Size = new System.Drawing.Size(257, 235);
            this.picBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxNew.TabIndex = 2;
            this.picBoxNew.TabStop = false;
            // 
            // nudPercent
            // 
            this.nudPercent.Location = new System.Drawing.Point(75, 356);
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(120, 20);
            this.nudPercent.TabIndex = 3;
            this.nudPercent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPercent.ValueChanged += new System.EventHandler(this.nudPercent_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudPercent);
            this.Controls.Add(this.picBoxNew);
            this.Controls.Add(this.picBoxOld);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox picBoxOld;
        private System.Windows.Forms.PictureBox picBoxNew;
        private System.Windows.Forms.NumericUpDown nudPercent;
    }
}

