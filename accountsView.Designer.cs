
namespace hevhai_system
{
    partial class accountsView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.addressCol,
            this.fbCol,
            this.emailCol,
            this.conNumCol,
            this.MIDateCol});
            this.dataGridView1.Location = new System.Drawing.Point(28, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(851, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 125;
            // 
            // addressCol
            // 
            this.addressCol.HeaderText = "Address";
            this.addressCol.MinimumWidth = 6;
            this.addressCol.Name = "addressCol";
            this.addressCol.ReadOnly = true;
            this.addressCol.Width = 125;
            // 
            // fbCol
            // 
            this.fbCol.HeaderText = "FB Account";
            this.fbCol.MinimumWidth = 6;
            this.fbCol.Name = "fbCol";
            this.fbCol.ReadOnly = true;
            this.fbCol.Width = 125;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email Address";
            this.emailCol.MinimumWidth = 6;
            this.emailCol.Name = "emailCol";
            this.emailCol.ReadOnly = true;
            this.emailCol.Width = 125;
            // 
            // conNumCol
            // 
            this.conNumCol.HeaderText = "Contact Number";
            this.conNumCol.MinimumWidth = 6;
            this.conNumCol.Name = "conNumCol";
            this.conNumCol.ReadOnly = true;
            this.conNumCol.Width = 125;
            // 
            // MIDateCol
            // 
            this.MIDateCol.HeaderText = "Moved In Date";
            this.MIDateCol.MinimumWidth = 6;
            this.MIDateCol.Name = "MIDateCol";
            this.MIDateCol.ReadOnly = true;
            this.MIDateCol.Width = 200;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(28, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(28, 405);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 33);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // accountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "accountsView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn conNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIDateCol;
    }
}