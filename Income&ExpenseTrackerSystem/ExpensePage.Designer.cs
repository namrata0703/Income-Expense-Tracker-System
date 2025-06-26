namespace Income_ExpenseTrackerSystem
{
    partial class ExpensePage
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
            this.lblCrossForgetPasswordFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeInExpense = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPayModeTypeInExpense = new System.Windows.Forms.ComboBox();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearOnExpense = new System.Windows.Forms.Button();
            this.btnAddOnExpense = new System.Windows.Forms.Button();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDescriptionExpense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxExpense = new System.Windows.Forms.TextBox();
            this.lblExpense = new System.Windows.Forms.Label();
            this.txtBoxItemExpense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCatagoeyIdInExpense = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewExpenseList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCrossForgetPasswordFrom
            // 
            this.lblCrossForgetPasswordFrom.AutoSize = true;
            this.lblCrossForgetPasswordFrom.Location = new System.Drawing.Point(980, 27);
            this.lblCrossForgetPasswordFrom.Name = "lblCrossForgetPasswordFrom";
            this.lblCrossForgetPasswordFrom.Size = new System.Drawing.Size(15, 16);
            this.lblCrossForgetPasswordFrom.TabIndex = 24;
            this.lblCrossForgetPasswordFrom.Text = "X";
            this.lblCrossForgetPasswordFrom.Click += new System.EventHandler(this.lblCrossForgetPasswordFrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense List";
            // 
            // comboBoxTypeInExpense
            // 
            this.comboBoxTypeInExpense.FormattingEnabled = true;
            this.comboBoxTypeInExpense.Location = new System.Drawing.Point(191, 232);
            this.comboBoxTypeInExpense.Name = "comboBoxTypeInExpense";
            this.comboBoxTypeInExpense.Size = new System.Drawing.Size(198, 24);
            this.comboBoxTypeInExpense.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type:";
            // 
            // comboBoxPayModeTypeInExpense
            // 
            this.comboBoxPayModeTypeInExpense.FormattingEnabled = true;
            this.comboBoxPayModeTypeInExpense.Location = new System.Drawing.Point(571, 42);
            this.comboBoxPayModeTypeInExpense.Name = "comboBoxPayModeTypeInExpense";
            this.comboBoxPayModeTypeInExpense.Size = new System.Drawing.Size(325, 24);
            this.comboBoxPayModeTypeInExpense.TabIndex = 18;
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseType.Location = new System.Drawing.Point(458, 40);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(63, 23);
            this.lblExpenseType.TabIndex = 14;
            this.lblExpenseType.Text = "Mode:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBoxTypeInExpense);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxPayModeTypeInExpense);
            this.panel2.Controls.Add(this.lblExpenseType);
            this.panel2.Controls.Add(this.btnClearOnExpense);
            this.panel2.Controls.Add(this.btnAddOnExpense);
            this.panel2.Controls.Add(this.dateTimePickerExpense);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBoxDescriptionExpense);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBoxExpense);
            this.panel2.Controls.Add(this.lblExpense);
            this.panel2.Controls.Add(this.txtBoxItemExpense);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxCatagoeyIdInExpense);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 360);
            this.panel2.TabIndex = 26;
            // 
            // btnClearOnExpense
            // 
            this.btnClearOnExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btnClearOnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOnExpense.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOnExpense.ForeColor = System.Drawing.Color.White;
            this.btnClearOnExpense.Location = new System.Drawing.Point(629, 281);
            this.btnClearOnExpense.Name = "btnClearOnExpense";
            this.btnClearOnExpense.Size = new System.Drawing.Size(129, 47);
            this.btnClearOnExpense.TabIndex = 12;
            this.btnClearOnExpense.Text = "Clear";
            this.btnClearOnExpense.UseVisualStyleBackColor = false;
            // 
            // btnAddOnExpense
            // 
            this.btnAddOnExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btnAddOnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOnExpense.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOnExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddOnExpense.Location = new System.Drawing.Point(430, 281);
            this.btnAddOnExpense.Name = "btnAddOnExpense";
            this.btnAddOnExpense.Size = new System.Drawing.Size(129, 47);
            this.btnAddOnExpense.TabIndex = 10;
            this.btnAddOnExpense.Text = "Add";
            this.btnAddOnExpense.UseVisualStyleBackColor = false;
            this.btnAddOnExpense.Click += new System.EventHandler(this.btnAddOnExpense_Click);
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Location = new System.Drawing.Point(593, 199);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(303, 22);
            this.dateTimePickerExpense.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date:";
            // 
            // txtBoxDescriptionExpense
            // 
            this.txtBoxDescriptionExpense.Location = new System.Drawing.Point(558, 90);
            this.txtBoxDescriptionExpense.Multiline = true;
            this.txtBoxDescriptionExpense.Name = "txtBoxDescriptionExpense";
            this.txtBoxDescriptionExpense.Size = new System.Drawing.Size(338, 79);
            this.txtBoxDescriptionExpense.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // txtBoxExpense
            // 
            this.txtBoxExpense.Location = new System.Drawing.Point(191, 177);
            this.txtBoxExpense.Name = "txtBoxExpense";
            this.txtBoxExpense.Size = new System.Drawing.Size(185, 22);
            this.txtBoxExpense.TabIndex = 5;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(15, 176);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(151, 23);
            this.lblExpense.TabIndex = 4;
            this.lblExpense.Text = "Expense Amount:";
            this.lblExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxItemExpense
            // 
            this.txtBoxItemExpense.Location = new System.Drawing.Point(191, 113);
            this.txtBoxItemExpense.Name = "txtBoxItemExpense";
            this.txtBoxItemExpense.Size = new System.Drawing.Size(185, 22);
            this.txtBoxItemExpense.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item:";
            // 
            // comboBoxCatagoeyIdInExpense
            // 
            this.comboBoxCatagoeyIdInExpense.FormattingEnabled = true;
            this.comboBoxCatagoeyIdInExpense.Location = new System.Drawing.Point(191, 45);
            this.comboBoxCatagoeyIdInExpense.Name = "comboBoxCatagoeyIdInExpense";
            this.comboBoxCatagoeyIdInExpense.Size = new System.Drawing.Size(185, 24);
            this.comboBoxCatagoeyIdInExpense.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cateagory:";
            // 
            // dataGridViewExpenseList
            // 
            this.dataGridViewExpenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenseList.Location = new System.Drawing.Point(19, 70);
            this.dataGridViewExpenseList.Name = "dataGridViewExpenseList";
            this.dataGridViewExpenseList.RowHeadersWidth = 51;
            this.dataGridViewExpenseList.RowTemplate.Height = 24;
            this.dataGridViewExpenseList.Size = new System.Drawing.Size(892, 218);
            this.dataGridViewExpenseList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridViewExpenseList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 325);
            this.panel1.TabIndex = 25;
            // 
            // ExpensePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 794);
            this.Controls.Add(this.lblCrossForgetPasswordFrom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExpensePage";
            this.Load += new System.EventHandler(this.ExpensePage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrossForgetPasswordFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeInExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPayModeTypeInExpense;
        private System.Windows.Forms.Label lblExpenseType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearOnExpense;
        private System.Windows.Forms.Button btnAddOnExpense;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDescriptionExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxExpense;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.TextBox txtBoxItemExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCatagoeyIdInExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewExpenseList;
        private System.Windows.Forms.Panel panel1;
    }
}