namespace Income_ExpenseTrackerSystem
{
    partial class CategoryPage
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
            this.lblCrossCatagoryFrom = new System.Windows.Forms.Label();
            this.lblCatagoryList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCatagoriesList = new System.Windows.Forms.DataGridView();
            this.btnClearOnCatagory = new System.Windows.Forms.Button();
            this.btnAddOnCatagory = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtBoxCatagory = new System.Windows.Forms.TextBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatagoriesList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCrossCatagoryFrom
            // 
            this.lblCrossCatagoryFrom.AutoSize = true;
            this.lblCrossCatagoryFrom.Location = new System.Drawing.Point(887, 17);
            this.lblCrossCatagoryFrom.Name = "lblCrossCatagoryFrom";
            this.lblCrossCatagoryFrom.Size = new System.Drawing.Size(15, 16);
            this.lblCrossCatagoryFrom.TabIndex = 21;
            this.lblCrossCatagoryFrom.Text = "X";
            this.lblCrossCatagoryFrom.Click += new System.EventHandler(this.lblCrossCatagoryFrom_Click);
            // 
            // lblCatagoryList
            // 
            this.lblCatagoryList.AutoSize = true;
            this.lblCatagoryList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryList.Location = new System.Drawing.Point(16, 21);
            this.lblCatagoryList.Name = "lblCatagoryList";
            this.lblCatagoryList.Size = new System.Drawing.Size(150, 27);
            this.lblCatagoryList.TabIndex = 1;
            this.lblCatagoryList.Text = "Catagories List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewCatagoriesList);
            this.panel2.Controls.Add(this.lblCatagoryList);
            this.panel2.Location = new System.Drawing.Point(297, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 653);
            this.panel2.TabIndex = 20;
            // 
            // dataGridViewCatagoriesList
            // 
            this.dataGridViewCatagoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatagoriesList.Location = new System.Drawing.Point(21, 64);
            this.dataGridViewCatagoriesList.Name = "dataGridViewCatagoriesList";
            this.dataGridViewCatagoriesList.RowHeadersWidth = 51;
            this.dataGridViewCatagoriesList.RowTemplate.Height = 24;
            this.dataGridViewCatagoriesList.Size = new System.Drawing.Size(570, 562);
            this.dataGridViewCatagoriesList.TabIndex = 2;
            // 
            // btnClearOnCatagory
            // 
            this.btnClearOnCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btnClearOnCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOnCatagory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOnCatagory.ForeColor = System.Drawing.Color.White;
            this.btnClearOnCatagory.Location = new System.Drawing.Point(49, 403);
            this.btnClearOnCatagory.Name = "btnClearOnCatagory";
            this.btnClearOnCatagory.Size = new System.Drawing.Size(129, 47);
            this.btnClearOnCatagory.TabIndex = 8;
            this.btnClearOnCatagory.Text = "Clear";
            this.btnClearOnCatagory.UseVisualStyleBackColor = false;
            // 
            // btnAddOnCatagory
            // 
            this.btnAddOnCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btnAddOnCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOnCatagory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOnCatagory.ForeColor = System.Drawing.Color.White;
            this.btnAddOnCatagory.Location = new System.Drawing.Point(49, 307);
            this.btnAddOnCatagory.Name = "btnAddOnCatagory";
            this.btnAddOnCatagory.Size = new System.Drawing.Size(129, 47);
            this.btnAddOnCatagory.TabIndex = 6;
            this.btnAddOnCatagory.Text = "Add";
            this.btnAddOnCatagory.UseVisualStyleBackColor = false;
            this.btnAddOnCatagory.Click += new System.EventHandler(this.btnAddOnCatagory_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboBoxType.Location = new System.Drawing.Point(17, 212);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(217, 24);
            this.comboBoxType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 157);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 27);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // txtBoxCatagory
            // 
            this.txtBoxCatagory.Location = new System.Drawing.Point(17, 100);
            this.txtBoxCatagory.Name = "txtBoxCatagory";
            this.txtBoxCatagory.Size = new System.Drawing.Size(217, 22);
            this.txtBoxCatagory.TabIndex = 1;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(12, 36);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(99, 27);
            this.lblCatagory.TabIndex = 0;
            this.lblCatagory.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClearOnCatagory);
            this.panel1.Controls.Add(this.btnAddOnCatagory);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.txtBoxCatagory);
            this.panel1.Controls.Add(this.lblCatagory);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 653);
            this.panel1.TabIndex = 19;
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 711);
            this.Controls.Add(this.lblCrossCatagoryFrom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatagoriesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrossCatagoryFrom;
        private System.Windows.Forms.Label lblCatagoryList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCatagoriesList;
        private System.Windows.Forms.Button btnClearOnCatagory;
        private System.Windows.Forms.Button btnAddOnCatagory;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtBoxCatagory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Panel panel1;
    }
}