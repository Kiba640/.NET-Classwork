namespace MegaDesk
{
    partial class AddQuote
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
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.MaterialsCombo = new System.Windows.Forms.ComboBox();
            this.comShipping = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(81, 114);
            this.deskDepth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(135, 20);
            this.deskDepth.TabIndex = 0;
            this.deskDepth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(352, 268);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(131, 58);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Location = new System.Drawing.Point(81, 27);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(135, 20);
            this.txtcustomerName.TabIndex = 2;
            this.txtcustomerName.Text = "Please enter your full name";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(81, 211);
            this.deskWidth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskWidth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(135, 20);
            this.deskWidth.TabIndex = 3;
            this.deskWidth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(352, 27);
            this.numDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(135, 20);
            this.numDrawers.TabIndex = 4;
            // 
            // MaterialsCombo
            // 
            this.MaterialsCombo.FormattingEnabled = true;
            this.MaterialsCombo.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.MaterialsCombo.Location = new System.Drawing.Point(352, 113);
            this.MaterialsCombo.Name = "MaterialsCombo";
            this.MaterialsCombo.Size = new System.Drawing.Size(135, 21);
            this.MaterialsCombo.TabIndex = 5;
            // 
            // comShipping
            // 
            this.comShipping.FormattingEnabled = true;
            this.comShipping.Items.AddRange(new object[] {
            "Standard (14 Days)",
            "Rush (7 Days)",
            "Rush (5 Days)",
            "Rush (3 Days)"});
            this.comShipping.Location = new System.Drawing.Point(352, 210);
            this.comShipping.Name = "comShipping";
            this.comShipping.Size = new System.Drawing.Size(131, 21);
            this.comShipping.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Depth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "# of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shipping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Materials";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(37, 268);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(135, 58);
            this.btn_submit.TabIndex = 13;
            this.btn_submit.Text = "Add Quote";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 341);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comShipping);
            this.Controls.Add(this.MaterialsCombo);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.txtcustomerName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.deskDepth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.ComboBox MaterialsCombo;
        private System.Windows.Forms.ComboBox comShipping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_submit;
    }
}