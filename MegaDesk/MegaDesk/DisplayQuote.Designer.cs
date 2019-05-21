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
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(318, 9);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(108, 39);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "name";
            // 
            // customerPrice
            // 
            this.customerPrice.AutoSize = true;
            this.customerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPrice.Location = new System.Drawing.Point(640, 297);
            this.customerPrice.Name = "customerPrice";
            this.customerPrice.Size = new System.Drawing.Size(73, 31);
            this.customerPrice.TabIndex = 1;
            this.customerPrice.Text = "price";
            // 
            // priceTitle
            // 
            this.priceTitle.AutoSize = true;
            this.priceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTitle.Location = new System.Drawing.Point(545, 297);
            this.priceTitle.Name = "priceTitle";
            this.priceTitle.Size = new System.Drawing.Size(89, 31);
            this.priceTitle.TabIndex = 2;
            this.priceTitle.Text = "Total:";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 337);
            this.Controls.Add(this.priceTitle);
            this.Controls.Add(this.customerPrice);
            this.Controls.Add(this.customerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}