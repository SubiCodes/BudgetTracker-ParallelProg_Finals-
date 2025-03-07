﻿namespace BudgetTracker
{
    partial class OnlinePayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.artanPanel3 = new BudgetTracker.ArtanPanel();
            this.pb_DateSearch = new System.Windows.Forms.PictureBox();
            this.txt_DateSearch = new BudgetTracker.CustomBorderTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.artanPanel2 = new BudgetTracker.ArtanPanel();
            this.pb_TitleSearch = new System.Windows.Forms.PictureBox();
            this.txt_TitleSearch = new BudgetTracker.CustomBorderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.artanPanel1 = new BudgetTracker.ArtanPanel();
            this.rb_LowestPrice = new System.Windows.Forms.RadioButton();
            this.rb_HighestPrice = new System.Windows.Forms.RadioButton();
            this.rb_ZtoA = new System.Windows.Forms.RadioButton();
            this.rb_EarliestFirst = new System.Windows.Forms.RadioButton();
            this.rb_AtoZ = new System.Windows.Forms.RadioButton();
            this.rb_LatestFirst = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_OnlinePayment = new System.Windows.Forms.DataGridView();
            this.artanPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DateSearch)).BeginInit();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TitleSearch)).BeginInit();
            this.artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_OnlinePayment)).BeginInit();
            this.SuspendLayout();
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.MediumPurple;
            this.artanPanel3.BorderRadius = 40;
            this.artanPanel3.Controls.Add(this.pb_DateSearch);
            this.artanPanel3.Controls.Add(this.txt_DateSearch);
            this.artanPanel3.Controls.Add(this.label4);
            this.artanPanel3.ForeColor = System.Drawing.Color.White;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.MediumPurple;
            this.artanPanel3.Location = new System.Drawing.Point(41, 264);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(350, 118);
            this.artanPanel3.TabIndex = 9;
            // 
            // pb_DateSearch
            // 
            this.pb_DateSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.pb_DateSearch.Image = global::BudgetTracker.Properties.Resources.searchIcon;
            this.pb_DateSearch.Location = new System.Drawing.Point(276, 56);
            this.pb_DateSearch.Name = "pb_DateSearch";
            this.pb_DateSearch.Size = new System.Drawing.Size(30, 30);
            this.pb_DateSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_DateSearch.TabIndex = 8;
            this.pb_DateSearch.TabStop = false;
            this.pb_DateSearch.Click += new System.EventHandler(this.pb_DateSearch_Click);
            // 
            // txt_DateSearch
            // 
            this.txt_DateSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.txt_DateSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DateSearch.BottomBorderColorOnFocus = System.Drawing.Color.Black;
            this.txt_DateSearch.BottomColor = System.Drawing.Color.Black;
            this.txt_DateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateSearch.Location = new System.Drawing.Point(35, 68);
            this.txt_DateSearch.Name = "txt_DateSearch";
            this.txt_DateSearch.Size = new System.Drawing.Size(271, 21);
            this.txt_DateSearch.TabIndex = 5;
            this.txt_DateSearch.Enter += new System.EventHandler(this.txt_DateSearch_Enter);
            this.txt_DateSearch.Leave += new System.EventHandler(this.txt_DateSearch_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.BlueViolet;
            this.artanPanel2.BorderRadius = 40;
            this.artanPanel2.Controls.Add(this.pb_TitleSearch);
            this.artanPanel2.Controls.Add(this.txt_TitleSearch);
            this.artanPanel2.Controls.Add(this.label3);
            this.artanPanel2.ForeColor = System.Drawing.Color.White;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.MediumPurple;
            this.artanPanel2.Location = new System.Drawing.Point(41, 112);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(350, 118);
            this.artanPanel2.TabIndex = 8;
            // 
            // pb_TitleSearch
            // 
            this.pb_TitleSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.pb_TitleSearch.Image = global::BudgetTracker.Properties.Resources.searchIcon;
            this.pb_TitleSearch.Location = new System.Drawing.Point(277, 55);
            this.pb_TitleSearch.Name = "pb_TitleSearch";
            this.pb_TitleSearch.Size = new System.Drawing.Size(30, 30);
            this.pb_TitleSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_TitleSearch.TabIndex = 7;
            this.pb_TitleSearch.TabStop = false;
            this.pb_TitleSearch.Click += new System.EventHandler(this.pb_TitleSearch_Click);
            // 
            // txt_TitleSearch
            // 
            this.txt_TitleSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.txt_TitleSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TitleSearch.BottomBorderColorOnFocus = System.Drawing.Color.Black;
            this.txt_TitleSearch.BottomColor = System.Drawing.Color.Black;
            this.txt_TitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TitleSearch.Location = new System.Drawing.Point(35, 67);
            this.txt_TitleSearch.Name = "txt_TitleSearch";
            this.txt_TitleSearch.Size = new System.Drawing.Size(271, 21);
            this.txt_TitleSearch.TabIndex = 6;
            this.txt_TitleSearch.Enter += new System.EventHandler(this.txt_TitleSearch_Enter);
            this.txt_TitleSearch.Leave += new System.EventHandler(this.txt_TitleSearch_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumPurple;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.BlueViolet;
            this.artanPanel1.BorderRadius = 50;
            this.artanPanel1.Controls.Add(this.rb_LowestPrice);
            this.artanPanel1.Controls.Add(this.rb_HighestPrice);
            this.artanPanel1.Controls.Add(this.rb_ZtoA);
            this.artanPanel1.Controls.Add(this.rb_EarliestFirst);
            this.artanPanel1.Controls.Add(this.rb_AtoZ);
            this.artanPanel1.Controls.Add(this.rb_LatestFirst);
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.ForeColor = System.Drawing.Color.White;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.MediumPurple;
            this.artanPanel1.Location = new System.Drawing.Point(41, 412);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(350, 231);
            this.artanPanel1.TabIndex = 7;
            // 
            // rb_LowestPrice
            // 
            this.rb_LowestPrice.AutoSize = true;
            this.rb_LowestPrice.BackColor = System.Drawing.Color.MediumPurple;
            this.rb_LowestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_LowestPrice.ForeColor = System.Drawing.Color.Black;
            this.rb_LowestPrice.Location = new System.Drawing.Point(171, 172);
            this.rb_LowestPrice.Name = "rb_LowestPrice";
            this.rb_LowestPrice.Size = new System.Drawing.Size(112, 22);
            this.rb_LowestPrice.TabIndex = 9;
            this.rb_LowestPrice.TabStop = true;
            this.rb_LowestPrice.Text = "Lowest Price";
            this.rb_LowestPrice.UseVisualStyleBackColor = false;
            this.rb_LowestPrice.CheckedChanged += new System.EventHandler(this.rb_LowestPrice_CheckedChanged);
            // 
            // rb_HighestPrice
            // 
            this.rb_HighestPrice.AutoSize = true;
            this.rb_HighestPrice.BackColor = System.Drawing.Color.MediumPurple;
            this.rb_HighestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_HighestPrice.ForeColor = System.Drawing.Color.Black;
            this.rb_HighestPrice.Location = new System.Drawing.Point(35, 172);
            this.rb_HighestPrice.Name = "rb_HighestPrice";
            this.rb_HighestPrice.Size = new System.Drawing.Size(114, 22);
            this.rb_HighestPrice.TabIndex = 8;
            this.rb_HighestPrice.TabStop = true;
            this.rb_HighestPrice.Text = "Highest Price";
            this.rb_HighestPrice.UseVisualStyleBackColor = false;
            this.rb_HighestPrice.CheckedChanged += new System.EventHandler(this.rb_HighestPrice_CheckedChanged);
            // 
            // rb_ZtoA
            // 
            this.rb_ZtoA.AutoSize = true;
            this.rb_ZtoA.BackColor = System.Drawing.Color.MediumPurple;
            this.rb_ZtoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ZtoA.ForeColor = System.Drawing.Color.Black;
            this.rb_ZtoA.Location = new System.Drawing.Point(171, 129);
            this.rb_ZtoA.Name = "rb_ZtoA";
            this.rb_ZtoA.Size = new System.Drawing.Size(80, 22);
            this.rb_ZtoA.TabIndex = 7;
            this.rb_ZtoA.TabStop = true;
            this.rb_ZtoA.Text = "Title Z-A";
            this.rb_ZtoA.UseVisualStyleBackColor = false;
            this.rb_ZtoA.CheckedChanged += new System.EventHandler(this.rb_ZtoA_CheckedChanged);
            // 
            // rb_EarliestFirst
            // 
            this.rb_EarliestFirst.AutoSize = true;
            this.rb_EarliestFirst.BackColor = System.Drawing.Color.MediumPurple;
            this.rb_EarliestFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EarliestFirst.ForeColor = System.Drawing.Color.Black;
            this.rb_EarliestFirst.Location = new System.Drawing.Point(171, 87);
            this.rb_EarliestFirst.Name = "rb_EarliestFirst";
            this.rb_EarliestFirst.Size = new System.Drawing.Size(108, 22);
            this.rb_EarliestFirst.TabIndex = 6;
            this.rb_EarliestFirst.TabStop = true;
            this.rb_EarliestFirst.Text = "Earliest First";
            this.rb_EarliestFirst.UseVisualStyleBackColor = false;
            this.rb_EarliestFirst.CheckedChanged += new System.EventHandler(this.rb_EarliestFirst_CheckedChanged);
            // 
            // rb_AtoZ
            // 
            this.rb_AtoZ.AutoSize = true;
            this.rb_AtoZ.BackColor = System.Drawing.Color.MediumPurple;
            this.rb_AtoZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_AtoZ.ForeColor = System.Drawing.Color.Black;
            this.rb_AtoZ.Location = new System.Drawing.Point(35, 129);
            this.rb_AtoZ.Name = "rb_AtoZ";
            this.rb_AtoZ.Size = new System.Drawing.Size(80, 22);
            this.rb_AtoZ.TabIndex = 4;
            this.rb_AtoZ.TabStop = true;
            this.rb_AtoZ.Text = "Title A-Z";
            this.rb_AtoZ.UseVisualStyleBackColor = false;
            this.rb_AtoZ.CheckedChanged += new System.EventHandler(this.rb_AtoZ_CheckedChanged);
            // 
            // rb_LatestFirst
            // 
            this.rb_LatestFirst.AutoSize = true;
            this.rb_LatestFirst.BackColor = System.Drawing.Color.MediumPurple;
            this.rb_LatestFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_LatestFirst.ForeColor = System.Drawing.Color.Black;
            this.rb_LatestFirst.Location = new System.Drawing.Point(35, 87);
            this.rb_LatestFirst.Name = "rb_LatestFirst";
            this.rb_LatestFirst.Size = new System.Drawing.Size(99, 22);
            this.rb_LatestFirst.TabIndex = 3;
            this.rb_LatestFirst.TabStop = true;
            this.rb_LatestFirst.Text = "Latest First";
            this.rb_LatestFirst.UseVisualStyleBackColor = false;
            this.rb_LatestFirst.CheckedChanged += new System.EventHandler(this.rb_LatestFirst_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Online Payments";
            // 
            // dg_OnlinePayment
            // 
            this.dg_OnlinePayment.AllowUserToAddRows = false;
            this.dg_OnlinePayment.AllowUserToDeleteRows = false;
            this.dg_OnlinePayment.AllowUserToResizeColumns = false;
            this.dg_OnlinePayment.AllowUserToResizeRows = false;
            this.dg_OnlinePayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dg_OnlinePayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_OnlinePayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_OnlinePayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_OnlinePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_OnlinePayment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_OnlinePayment.Location = new System.Drawing.Point(439, 40);
            this.dg_OnlinePayment.MultiSelect = false;
            this.dg_OnlinePayment.Name = "dg_OnlinePayment";
            this.dg_OnlinePayment.ReadOnly = true;
            this.dg_OnlinePayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_OnlinePayment.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Fluent Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.dg_OnlinePayment.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_OnlinePayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_OnlinePayment.Size = new System.Drawing.Size(603, 603);
            this.dg_OnlinePayment.TabIndex = 10;
            this.dg_OnlinePayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_OnlinePayment_CellClick);
            // 
            // OnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1068, 681);
            this.Controls.Add(this.dg_OnlinePayment);
            this.Controls.Add(this.artanPanel3);
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.label1);
            this.Name = "OnlinePayment";
            this.Text = "OnlinePayments";
            this.Load += new System.EventHandler(this.OnlinePayments_Load);
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DateSearch)).EndInit();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TitleSearch)).EndInit();
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_OnlinePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArtanPanel artanPanel3;
        private System.Windows.Forms.PictureBox pb_DateSearch;
        private CustomBorderTextBox txt_DateSearch;
        private System.Windows.Forms.Label label4;
        private ArtanPanel artanPanel2;
        private System.Windows.Forms.PictureBox pb_TitleSearch;
        private CustomBorderTextBox txt_TitleSearch;
        private System.Windows.Forms.Label label3;
        private ArtanPanel artanPanel1;
        private System.Windows.Forms.RadioButton rb_LowestPrice;
        private System.Windows.Forms.RadioButton rb_HighestPrice;
        private System.Windows.Forms.RadioButton rb_ZtoA;
        private System.Windows.Forms.RadioButton rb_EarliestFirst;
        private System.Windows.Forms.RadioButton rb_AtoZ;
        private System.Windows.Forms.RadioButton rb_LatestFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_OnlinePayment;
    }
}