namespace MegaDesk
{
    partial class DisplayQuote
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
            this.customerName = new System.Windows.Forms.Label();
            this.customerPrice = new System.Windows.Forms.Label();
            this.priceTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaterial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDepth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numShipping = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.customerName.Location = new System.Drawing.Point(12, 9);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(323, 39);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "name";
            this.customerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerPrice
            // 
            this.customerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerPrice.Location = new System.Drawing.Point(156, 299);
            this.customerPrice.Name = "customerPrice";
            this.customerPrice.Size = new System.Drawing.Size(176, 31);
            this.customerPrice.TabIndex = 1;
            this.customerPrice.Text = "price";
            this.customerPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerPrice.Click += new System.EventHandler(this.CustomerPrice_Click);
            // 
            // priceTitle
            // 
            this.priceTitle.AutoSize = true;
            this.priceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTitle.Location = new System.Drawing.Point(73, 299);
            this.priceTitle.Name = "priceTitle";
            this.priceTitle.Size = new System.Drawing.Size(89, 31);
            this.priceTitle.TabIndex = 2;
            this.priceTitle.Text = "Total:";
            this.priceTitle.Click += new System.EventHandler(this.PriceTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Drawers:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // numDrawers
            // 
            this.numDrawers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numDrawers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numDrawers.Location = new System.Drawing.Point(283, 65);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(49, 25);
            this.numDrawers.TabIndex = 3;
            this.numDrawers.Text = "1";
            this.numDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numDrawers.Click += new System.EventHandler(this.NumDrawers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(106, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Material:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // numMaterial
            // 
            this.numMaterial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numMaterial.Location = new System.Drawing.Point(208, 199);
            this.numMaterial.Name = "numMaterial";
            this.numMaterial.Size = new System.Drawing.Size(124, 25);
            this.numMaterial.TabIndex = 5;
            this.numMaterial.Text = "1";
            this.numMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numMaterial.Click += new System.EventHandler(this.NumMaterial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(202, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Depth:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // numDepth
            // 
            this.numDepth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numDepth.Location = new System.Drawing.Point(283, 109);
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(49, 25);
            this.numDepth.TabIndex = 7;
            this.numDepth.Text = "1";
            this.numDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numDepth.Click += new System.EventHandler(this.NumDepth_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(98, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Shipping:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // numShipping
            // 
            this.numShipping.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numShipping.Location = new System.Drawing.Point(208, 237);
            this.numShipping.Name = "numShipping";
            this.numShipping.Size = new System.Drawing.Size(124, 25);
            this.numShipping.TabIndex = 9;
            this.numShipping.Text = "1";
            this.numShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numShipping.Click += new System.EventHandler(this.NumShipping_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(203, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Width:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // numWidth
            // 
            this.numWidth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numWidth.Location = new System.Drawing.Point(284, 158);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(49, 25);
            this.numWidth.TabIndex = 11;
            this.numWidth.Text = "1";
            this.numWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numWidth.Click += new System.EventHandler(this.NumWidth_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 344);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numShipping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.priceTitle);
            this.Controls.Add(this.customerPrice);
            this.Controls.Add(this.customerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerPrice;
        private System.Windows.Forms.Label priceTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numDrawers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numDepth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numShipping;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label numWidth;
    }
}