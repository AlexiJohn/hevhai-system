
namespace hevhai_system
{
    partial class homeIndex
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
            this.summaryButton = new System.Windows.Forms.Button();
            this.paymentsButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(332, 265);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(134, 23);
            this.summaryButton.TabIndex = 5;
            this.summaryButton.Text = "Treasurer Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // paymentsButton
            // 
            this.paymentsButton.Location = new System.Drawing.Point(332, 236);
            this.paymentsButton.Name = "paymentsButton";
            this.paymentsButton.Size = new System.Drawing.Size(134, 23);
            this.paymentsButton.TabIndex = 4;
            this.paymentsButton.Text = "Payments";
            this.paymentsButton.UseVisualStyleBackColor = true;
            this.paymentsButton.Click += new System.EventHandler(this.paymentsButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.Location = new System.Drawing.Point(332, 206);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(134, 23);
            this.accountsButton.TabIndex = 3;
            this.accountsButton.Text = "Accounts";
            this.accountsButton.UseVisualStyleBackColor = true;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Getting Started";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(243, 74);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(311, 85);
            this.menuLabel.TabIndex = 7;
            this.menuLabel.Text = "HEVHAI";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuLabel2
            // 
            this.menuLabel2.AutoSize = true;
            this.menuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel2.Location = new System.Drawing.Point(299, 159);
            this.menuLabel2.Name = "menuLabel2";
            this.menuLabel2.Size = new System.Drawing.Size(199, 17);
            this.menuLabel2.TabIndex = 8;
            this.menuLabel2.Text = "Payment Management System";
            this.menuLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuLabel2);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.paymentsButton);
            this.Controls.Add(this.accountsButton);
            this.Name = "homeIndex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button paymentsButton;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label menuLabel2;
    }
}

