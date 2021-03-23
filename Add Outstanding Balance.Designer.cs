
namespace hevhai_system
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ORTB = new System.Windows.Forms.TextBox();
            this.PaymentDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AmDueTB = new System.Windows.Forms.TextBox();
            this.CanOB = new System.Windows.Forms.Button();
            this.SubOB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAlabel
            // 
            this.CAlabel.AutoSize = true;
            this.CAlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CAlabel.Location = new System.Drawing.Point(245, 21);
            this.CAlabel.Name = "CAlabel";
            this.CAlabel.Size = new System.Drawing.Size(592, 58);
            this.CAlabel.TabIndex = 1;
            this.CAlabel.Text = "Add Outstanding Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(308, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "OR Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(350, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(350, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // ORTB
            // 
            this.ORTB.Location = new System.Drawing.Point(468, 171);
            this.ORTB.Name = "ORTB";
            this.ORTB.Size = new System.Drawing.Size(245, 22);
            this.ORTB.TabIndex = 14;
            // 
            // PaymentDD
            // 
            this.PaymentDD.FormattingEnabled = true;
            this.PaymentDD.Location = new System.Drawing.Point(469, 218);
            this.PaymentDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentDD.Name = "PaymentDD";
            this.PaymentDD.Size = new System.Drawing.Size(244, 24);
            this.PaymentDD.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(465, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "₱ ";
            // 
            // AmDueTB
            // 
            this.AmDueTB.Location = new System.Drawing.Point(496, 270);
            this.AmDueTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmDueTB.Name = "AmDueTB";
            this.AmDueTB.Size = new System.Drawing.Size(217, 22);
            this.AmDueTB.TabIndex = 16;
            // 
            // CanOB
            // 
            this.CanOB.Location = new System.Drawing.Point(565, 325);
            this.CanOB.Name = "CanOB";
            this.CanOB.Size = new System.Drawing.Size(66, 23);
            this.CanOB.TabIndex = 19;
            this.CanOB.Text = "Cancel";
            this.CanOB.UseVisualStyleBackColor = true;
            // 
            // SubOB
            // 
            this.SubOB.Location = new System.Drawing.Point(460, 325);
            this.SubOB.Name = "SubOB";
            this.SubOB.Size = new System.Drawing.Size(66, 23);
            this.SubOB.TabIndex = 18;
            this.SubOB.Text = "Submit";
            this.SubOB.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CanOB);
            this.Controls.Add(this.SubOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AmDueTB);
            this.Controls.Add(this.PaymentDD);
            this.Controls.Add(this.ORTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CAlabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CAlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ORTB;
        private System.Windows.Forms.ComboBox PaymentDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AmDueTB;
        private System.Windows.Forms.Button CanOB;
        private System.Windows.Forms.Button SubOB;
    }
}