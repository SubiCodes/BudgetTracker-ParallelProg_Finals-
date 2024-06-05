namespace BudgetTracker
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.artanPanel3 = new BudgetTracker.ArtanPanel();
            this.artanPanel2 = new BudgetTracker.ArtanPanel();
            this.artanPanel8 = new BudgetTracker.ArtanPanel();
            this.artanPanel7 = new BudgetTracker.ArtanPanel();
            this.artanPanel6 = new BudgetTracker.ArtanPanel();
            this.artanPanel5 = new BudgetTracker.ArtanPanel();
            this.artanPanel4 = new BudgetTracker.ArtanPanel();
            this.artanPanel1 = new BudgetTracker.ArtanPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(69, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 18);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(173)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(69, 638);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 18);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(495, 588);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 18);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(495, 638);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 18);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Summation of daily / monthly expenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Savings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(546, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Daily expenses per category\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(546, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BudgetTracker.Properties.Resources.Line_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(764, 574);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(880, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 63);
            this.label5.TabIndex = 14;
            this.label5.Text = "About Us / Developers";
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 50;
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel3.Location = new System.Drawing.Point(57, 398);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(370, 162);
            this.artanPanel3.TabIndex = 2;
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 50;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel2.Location = new System.Drawing.Point(57, 216);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(370, 162);
            this.artanPanel2.TabIndex = 1;
            // 
            // artanPanel8
            // 
            this.artanPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(173)))));
            this.artanPanel8.BorderRadius = 50;
            this.artanPanel8.ForeColor = System.Drawing.Color.Black;
            this.artanPanel8.GradientAngle = 90F;
            this.artanPanel8.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel8.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel8.Location = new System.Drawing.Point(470, 398);
            this.artanPanel8.Name = "artanPanel8";
            this.artanPanel8.Size = new System.Drawing.Size(545, 162);
            this.artanPanel8.TabIndex = 6;
            // 
            // artanPanel7
            // 
            this.artanPanel7.BackColor = System.Drawing.Color.White;
            this.artanPanel7.BorderRadius = 50;
            this.artanPanel7.ForeColor = System.Drawing.Color.Black;
            this.artanPanel7.GradientAngle = 90F;
            this.artanPanel7.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.artanPanel7.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.artanPanel7.Location = new System.Drawing.Point(752, 216);
            this.artanPanel7.Name = "artanPanel7";
            this.artanPanel7.Size = new System.Drawing.Size(263, 162);
            this.artanPanel7.TabIndex = 4;
            // 
            // artanPanel6
            // 
            this.artanPanel6.BackColor = System.Drawing.Color.White;
            this.artanPanel6.BorderRadius = 50;
            this.artanPanel6.ForeColor = System.Drawing.Color.Black;
            this.artanPanel6.GradientAngle = 90F;
            this.artanPanel6.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.artanPanel6.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.artanPanel6.Location = new System.Drawing.Point(470, 216);
            this.artanPanel6.Name = "artanPanel6";
            this.artanPanel6.Size = new System.Drawing.Size(263, 162);
            this.artanPanel6.TabIndex = 5;
            // 
            // artanPanel5
            // 
            this.artanPanel5.BackColor = System.Drawing.Color.White;
            this.artanPanel5.BorderRadius = 50;
            this.artanPanel5.ForeColor = System.Drawing.Color.Black;
            this.artanPanel5.GradientAngle = 90F;
            this.artanPanel5.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.artanPanel5.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.artanPanel5.Location = new System.Drawing.Point(752, 34);
            this.artanPanel5.Name = "artanPanel5";
            this.artanPanel5.Size = new System.Drawing.Size(263, 162);
            this.artanPanel5.TabIndex = 4;
            // 
            // artanPanel4
            // 
            this.artanPanel4.BackColor = System.Drawing.Color.White;
            this.artanPanel4.BorderRadius = 50;
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 90F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.artanPanel4.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.artanPanel4.Location = new System.Drawing.Point(470, 34);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Size = new System.Drawing.Size(263, 162);
            this.artanPanel4.TabIndex = 3;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 50;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(42)))), ((int)(((byte)(132)))));
            this.artanPanel1.Location = new System.Drawing.Point(57, 34);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(370, 162);
            this.artanPanel1.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1068, 701);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.artanPanel3);
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel8);
            this.Controls.Add(this.artanPanel7);
            this.Controls.Add(this.artanPanel6);
            this.Controls.Add(this.artanPanel5);
            this.Controls.Add(this.artanPanel4);
            this.Controls.Add(this.artanPanel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArtanPanel artanPanel1;
        private ArtanPanel artanPanel4;
        private ArtanPanel artanPanel5;
        private ArtanPanel artanPanel6;
        private ArtanPanel artanPanel7;
        private ArtanPanel artanPanel8;
        private ArtanPanel artanPanel2;
        private ArtanPanel artanPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}