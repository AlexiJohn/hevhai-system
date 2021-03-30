
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentForCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.MoPComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fromORComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toORComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 28);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.AutoSize = true;
            this.paymentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsLabel.Location = new System.Drawing.Point(145, 25);
            this.paymentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(135, 31);
            this.paymentsLabel.TabIndex = 4;
            this.paymentsLabel.Text = "Payments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 71);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCol,
            this.ORCol,
            this.DoPCol,
            this.amountCol,
            this.MoPCol,
            this.paymentForCol,
            this.descriptionCol});
            this.dataGridView1.Location = new System.Drawing.Point(37, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(984, 356);
            this.dataGridView1.TabIndex = 7;
            // 
            // accountCol
            // 
            this.accountCol.HeaderText = "Account";
            this.accountCol.MinimumWidth = 6;
            this.accountCol.Name = "accountCol";
            this.accountCol.ReadOnly = true;
            this.accountCol.Width = 125;
            // 
            // ORCol
            // 
            this.ORCol.HeaderText = "OR#";
            this.ORCol.MinimumWidth = 6;
            this.ORCol.Name = "ORCol";
            this.ORCol.ReadOnly = true;
            this.ORCol.Width = 125;
            // 
            // DoPCol
            // 
            this.DoPCol.HeaderText = "Date of Payment";
            this.DoPCol.MinimumWidth = 6;
            this.DoPCol.Name = "DoPCol";
            this.DoPCol.ReadOnly = true;
            this.DoPCol.Width = 125;
            // 
            // amountCol
            // 
            this.amountCol.HeaderText = "Amount";
            this.amountCol.MinimumWidth = 6;
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            this.amountCol.Width = 125;
            // 
            // MoPCol
            // 
            this.MoPCol.HeaderText = "Mode of Payment";
            this.MoPCol.MinimumWidth = 6;
            this.MoPCol.Name = "MoPCol";
            this.MoPCol.ReadOnly = true;
            this.MoPCol.Width = 125;
            // 
            // paymentForCol
            // 
            this.paymentForCol.HeaderText = "Payment For";
            this.paymentForCol.MinimumWidth = 6;
            this.paymentForCol.Name = "paymentForCol";
            this.paymentForCol.ReadOnly = true;
            this.paymentForCol.Width = 125;
            // 
            // descriptionCol
            // 
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.MinimumWidth = 6;
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
            this.descriptionCol.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mode of Payment";
            // 
            // MoPComboBox
            // 
            this.MoPComboBox.FormattingEnabled = true;
            this.MoPComboBox.Location = new System.Drawing.Point(457, 71);
            this.MoPComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoPComboBox.Name = "MoPComboBox";
            this.MoPComboBox.Size = new System.Drawing.Size(115, 24);
            this.MoPComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "From OR#";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fromORComboBox
            // 
            this.fromORComboBox.FormattingEnabled = true;
            this.fromORComboBox.Location = new System.Drawing.Point(749, 71);
            this.fromORComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.fromORComboBox.Name = "fromORComboBox";
            this.fromORComboBox.Size = new System.Drawing.Size(96, 24);
            this.fromORComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "To OR#";
            // 
            // toORComboBox
            // 
            this.toORComboBox.FormattingEnabled = true;
            this.toORComboBox.Location = new System.Drawing.Point(924, 71);
            this.toORComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.toORComboBox.Name = "toORComboBox";
            this.toORComboBox.Size = new System.Drawing.Size(96, 24);
            this.toORComboBox.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 503);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(223, 41);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(799, 503);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(223, 41);
            this.downloadButton.TabIndex = 16;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(500, 503);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(223, 41);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(269, 503);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(223, 41);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(801, 468);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(206, 31);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total: PHP 0.00";
            // 
            // paymentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.toORComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromORComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MoPComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentsLabel);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "paymentsView";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label paymentsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentForCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MoPComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fromORComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox toORComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label totalLabel;
    }
}