
namespace hevhai_system
{
    partial class outstandingForm
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
            this.CAlabel = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ORTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CanAcc = new System.Windows.Forms.Button();
            this.SubAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAlabel
            // 
            this.CAlabel.AutoSize = true;
            this.CAlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CAlabel.Location = new System.Drawing.Point(212, 107);
            this.CAlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CAlabel.Name = "CAlabel";
            this.CAlabel.Size = new System.Drawing.Size(338, 46);
            this.CAlabel.TabIndex = 2;
            this.CAlabel.Text = "Add New Balance";
            this.CAlabel.Click += new System.EventHandler(this.CAlabel_Click);
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(330, 173);
            this.accountComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(184, 21);
            this.accountComboBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(240, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Account:";
            // 
            // ORTB
            // 
            this.ORTB.Location = new System.Drawing.Point(329, 212);
            this.ORTB.Margin = new System.Windows.Forms.Padding(2);
            this.ORTB.Name = "ORTB";
            this.ORTB.Size = new System.Drawing.Size(185, 20);
            this.ORTB.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(215, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(244, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CanAcc
            // 
            this.CanAcc.Location = new System.Drawing.Point(410, 283);
            this.CanAcc.Margin = new System.Windows.Forms.Padding(2);
            this.CanAcc.Name = "CanAcc";
            this.CanAcc.Size = new System.Drawing.Size(50, 19);
            this.CanAcc.TabIndex = 26;
            this.CanAcc.Text = "Cancel";
            this.CanAcc.UseVisualStyleBackColor = true;
            // 
            // SubAcc
            // 
            this.SubAcc.Location = new System.Drawing.Point(331, 283);
            this.SubAcc.Margin = new System.Windows.Forms.Padding(2);
            this.SubAcc.Name = "SubAcc";
            this.SubAcc.Size = new System.Drawing.Size(50, 19);
            this.SubAcc.TabIndex = 25;
            this.SubAcc.Text = "Submit";
            this.SubAcc.UseVisualStyleBackColor = true;
            // 
            // outstandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CanAcc);
            this.Controls.Add(this.SubAcc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ORTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CAlabel);
            this.Name = "outstandingForm";
            this.Text = "outstandingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CAlabel;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ORTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CanAcc;
        private System.Windows.Forms.Button SubAcc;
    }
}