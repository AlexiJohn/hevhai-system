
namespace hevhai_system
{
    partial class summaryView
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.MoPComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.accountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(479, 371);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(165, 26);
            this.totalLabel.TabIndex = 34;
            this.totalLabel.Text = "Total: PHP 0.00";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 403);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 33);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(602, 403);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(167, 33);
            this.downloadButton.TabIndex = 32;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(378, 403);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 33);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(205, 403);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(167, 33);
            this.editButton.TabIndex = 30;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // MoPComboBox
            // 
            this.MoPComboBox.FormattingEnabled = true;
            this.MoPComboBox.Location = new System.Drawing.Point(346, 52);
            this.MoPComboBox.Name = "MoPComboBox";
            this.MoPComboBox.Size = new System.Drawing.Size(87, 21);
            this.MoPComboBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mode of Payment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCol,
            this.descriptionCol,
            this.amountCol});
            this.dataGridView1.Location = new System.Drawing.Point(31, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 315);
            this.dataGridView1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Account";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.Location = new System.Drawing.Point(112, 14);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(220, 26);
            this.summaryLabel.TabIndex = 20;
            this.summaryLabel.Text = "Treasurer\'s Summary";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(31, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // accountCol
            // 
            this.accountCol.HeaderText = "Account";
            this.accountCol.Name = "accountCol";
            this.accountCol.ReadOnly = true;
            // 
            // descriptionCol
            // 
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
            this.descriptionCol.Width = 200;
            // 
            // amountCol
            // 
            this.amountCol.HeaderText = "Amount";
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            // 
            // summaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.MoPComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.backButton);
            this.Name = "summaryView";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox MoPComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
    }
}