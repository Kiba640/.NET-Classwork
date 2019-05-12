namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_searchQuote = new System.Windows.Forms.Button();
            this.btn_newQuote = new System.Windows.Forms.Button();
            this.btn_viewQuote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(34, 216);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 46);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_searchQuote
            // 
            this.btn_searchQuote.Location = new System.Drawing.Point(34, 164);
            this.btn_searchQuote.Name = "btn_searchQuote";
            this.btn_searchQuote.Size = new System.Drawing.Size(122, 46);
            this.btn_searchQuote.TabIndex = 1;
            this.btn_searchQuote.Text = "Search Quotes";
            this.btn_searchQuote.UseVisualStyleBackColor = true;
            this.btn_searchQuote.Click += new System.EventHandler(this.Btn_searchQuote_Click);
            // 
            // btn_newQuote
            // 
            this.btn_newQuote.Location = new System.Drawing.Point(34, 60);
            this.btn_newQuote.Name = "btn_newQuote";
            this.btn_newQuote.Size = new System.Drawing.Size(122, 46);
            this.btn_newQuote.TabIndex = 3;
            this.btn_newQuote.Text = "Add New Quote";
            this.btn_newQuote.UseVisualStyleBackColor = true;
            this.btn_newQuote.Click += new System.EventHandler(this.Btn_newQuote_Click);
            // 
            // btn_viewQuote
            // 
            this.btn_viewQuote.Location = new System.Drawing.Point(34, 112);
            this.btn_viewQuote.Name = "btn_viewQuote";
            this.btn_viewQuote.Size = new System.Drawing.Size(122, 46);
            this.btn_viewQuote.TabIndex = 2;
            this.btn_viewQuote.Text = "View Quote";
            this.btn_viewQuote.UseVisualStyleBackColor = true;
            this.btn_viewQuote.Click += new System.EventHandler(this.Btn_viewQuote_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 202);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_newQuote);
            this.Controls.Add(this.btn_viewQuote);
            this.Controls.Add(this.btn_searchQuote);
            this.Controls.Add(this.btn_exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_searchQuote;
        private System.Windows.Forms.Button btn_newQuote;
        private System.Windows.Forms.Button btn_viewQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

