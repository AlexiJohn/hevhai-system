
namespace hevhai_system
{
    partial class paymentsView
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
            this.backButton = new System.Windows.Forms.Button();
            this.paymentsLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.MoPLabel = new System.Windows.Forms.Label();
            this.MoPComboBox = new System.Windows.Forms.ComboBox();
            this.fromORLabel = new System.Windows.Forms.Label();
            this.toORLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fromORTB = new System.Windows.Forms.TextBox();
            this.toORTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterByCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(28, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.AutoSize = true;
            this.paymentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsLabel.Location = new System.Drawing.Point(109, 20);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(110, 26);
            this.paymentsLabel.TabIndex = 4;
            this.paymentsLabel.Text = "Payments";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(202, 61);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(47, 13);
            this.accountLabel.TabIndex = 5;
            this.accountLabel.Text = "Account";
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(255, 57);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(160, 21);
            this.accountComboBox.TabIndex = 6;
            this.accountComboBox.SelectedIndexChanged += new System.EventHandler(this.accountComboBox_SelectedIndexChanged);
            // 
            // MoPLabel
            // 
            this.MoPLabel.AutoSize = true;
            this.MoPLabel.Location = new System.Drawing.Point(202, 62);
            this.MoPLabel.Name = "MoPLabel";
            this.MoPLabel.Size = new System.Drawing.Size(90, 13);
            this.MoPLabel.TabIndex = 8;
            this.MoPLabel.Text = "Mode of Payment";
            // 
            // MoPComboBox
            // 
            this.MoPComboBox.FormattingEnabled = true;
            this.MoPComboBox.Location = new System.Drawing.Point(298, 58);
            this.MoPComboBox.Name = "MoPComboBox";
            this.MoPComboBox.Size = new System.Drawing.Size(117, 21);
            this.MoPComboBox.TabIndex = 9;
            this.MoPComboBox.SelectedIndexChanged += new System.EventHandler(this.MoPComboBox_SelectedIndexChanged);
            // 
            // fromORLabel
            // 
            this.fromORLabel.AutoSize = true;
            this.fromORLabel.Location = new System.Drawing.Point(202, 62);
            this.fromORLabel.Name = "fromORLabel";
            this.fromORLabel.Size = new System.Drawing.Size(56, 13);
            this.fromORLabel.TabIndex = 10;
            this.fromORLabel.Text = "From OR#";
            // 
            // toORLabel
            // 
            this.toORLabel.AutoSize = true;
            this.toORLabel.Location = new System.Drawing.Point(343, 62);
            this.toORLabel.Name = "toORLabel";
            this.toORLabel.Size = new System.Drawing.Size(46, 13);
            this.toORLabel.TabIndex = 12;
            this.toORLabel.Text = "To OR#";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(29, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 33);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(599, 409);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(167, 33);
            this.downloadButton.TabIndex = 16;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(375, 409);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 33);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(202, 409);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(167, 33);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(29, 380);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(737, 30);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total: PHP 0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 289);
            this.dataGridView1.TabIndex = 19;
            // 
            // fromORTB
            // 
            this.fromORTB.Location = new System.Drawing.Point(264, 58);
            this.fromORTB.Name = "fromORTB";
            this.fromORTB.Size = new System.Drawing.Size(73, 20);
            this.fromORTB.TabIndex = 21;
            this.fromORTB.TextChanged += new System.EventHandler(this.fromORTB_TextChanged);
            // 
            // toORTB
            // 
            this.toORTB.Location = new System.Drawing.Point(395, 58);
            this.toORTB.Name = "toORTB";
            this.toORTB.Size = new System.Drawing.Size(73, 20);
            this.toORTB.TabIndex = 22;
            this.toORTB.TextChanged += new System.EventHandler(this.toORTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Filter by";
            // 
            // filterByCB
            // 
            this.filterByCB.FormattingEnabled = true;
            this.filterByCB.Location = new System.Drawing.Point(75, 59);
            this.filterByCB.Name = "filterByCB";
            this.filterByCB.Size = new System.Drawing.Size(121, 21);
            this.filterByCB.TabIndex = 24;
            this.filterByCB.SelectedIndexChanged += new System.EventHandler(this.filterByCB_SelectedIndexChanged);
            // 
            // paymentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterByCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toORTB);
            this.Controls.Add(this.fromORTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.toORLabel);
            this.Controls.Add(this.fromORLabel);
            this.Controls.Add(this.MoPComboBox);
            this.Controls.Add(this.MoPLabel);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.paymentsLabel);
            this.Controls.Add(this.backButton);
            this.Name = "paymentsView";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label paymentsLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label MoPLabel;
        private System.Windows.Forms.ComboBox MoPComboBox;
        private System.Windows.Forms.Label fromORLabel;
        private System.Windows.Forms.Label toORLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox fromORTB;
        private System.Windows.Forms.TextBox toORTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filterByCB;
    }
}