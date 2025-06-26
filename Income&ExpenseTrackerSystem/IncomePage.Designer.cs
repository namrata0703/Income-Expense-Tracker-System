namespace Income_ExpenseTrackerSystem
{
    partial class IncomePage
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
            this.comboBoxTypeOnIncome = new System.Windows.Forms.ComboBox();
            this.lblTypeOnIncom = new System.Windows.Forms.Label();
            this.comboBoxPayModeType = new System.Windows.Forms.ComboBox();
            this.lblIncomeType = new System.Windows.Forms.Label();
            this.btnClearOnIncomeAdd = new System.Windows.Forms.Button();
            this.btnAddOnIncome = new System.Windows.Forms.Button();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDescriptionIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxIncomeAmount = new System.Windows.Forms.TextBox();
            this.lblIncomeAmount = new System.Windows.Forms.Label();
            this.comboBoxCatagoeyInIncome = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewIncomeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCrossIncomeFrom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomeList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTypeOnIncome
            // 
            this.comboBoxTypeOnIncome.FormattingEnabled = true;
            this.comboBoxTypeOnIncome.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboBoxTypeOnIncome.Location = new System.Drawing.Point(172, 176);
            this.comboBoxTypeOnIncome.Name = "comboBoxTypeOnIncome";
            this.comboBoxTypeOnIncome.Size = new System.Drawing.Size(202, 24);
            this.comboBoxTypeOnIncome.TabIndex = 20;
            // 
            // lblTypeOnIncom
            // 
            this.lblTypeOnIncom.AutoSize = true;
            this.lblTypeOnIncom.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOnIncom.Location = new System.Drawing.Point(97, 174);
            this.lblTypeOnIncom.Name = "lblTypeOnIncom";
            this.lblTypeOnIncom.Size = new System.Drawing.Size(54, 23);
            this.lblTypeOnIncom.TabIndex = 19;
            this.lblTypeOnIncom.Text = "Type:";
            // 
            // comboBoxPayModeType
            // 
            this.comboBoxPayModeType.FormattingEnabled = true;
            this.comboBoxPayModeType.Location = new System.Drawing.Point(549, 45);
            this.comboBoxPayModeType.Name = "comboBoxPayModeType";
            this.comboBoxPayModeType.Size = new System.Drawing.Size(259, 24);
            this.comboBoxPayModeType.TabIndex = 18;
            // 
            // lblIncomeType
            // 
            this.lblIncomeType.AutoSize = true;
            this.lblIncomeType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeType.Location = new System.Drawing.Point(456, 45);
            this.lblIncomeType.Name = "lblIncomeType";
            this.lblIncomeType.Size = new System.Drawing.Size(63, 23);
            this.lblIncomeType.TabIndex = 14;
            this.lblIncomeType.Text = "Mode:";
            // 
            // btnClearOnIncomeAdd
            // 
            this.btnClearOnIncomeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btnClearOnIncomeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOnIncomeAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOnIncomeAdd.ForeColor = System.Drawing.Color.White;
            this.btnClearOnIncomeAdd.Location = new System.Drawing.Point(460, 279);
            this.btnClearOnIncomeAdd.Name = "btnClearOnIncomeAdd";
            this.btnClearOnIncomeAdd.Size = new System.Drawing.Size(129, 47);
            this.btnClearOnIncomeAdd.TabIndex = 12;
            this.btnClearOnIncomeAdd.Text = "Clear";
            this.btnClearOnIncomeAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddOnIncome
            // 
            this.btnAddOnIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.btnAddOnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOnIncome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOnIncome.ForeColor = System.Drawing.Color.White;
            this.btnAddOnIncome.Location = new System.Drawing.Point(263, 279);
            this.btnAddOnIncome.Name = "btnAddOnIncome";
            this.btnAddOnIncome.Size = new System.Drawing.Size(129, 47);
            this.btnAddOnIncome.TabIndex = 10;
            this.btnAddOnIncome.Text = "Add";
            this.btnAddOnIncome.UseVisualStyleBackColor = false;
            this.btnAddOnIncome.Click += new System.EventHandler(this.btnAddOnIncome_Click);
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.Location = new System.Drawing.Point(549, 205);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(303, 22);
            this.dateTimePickerIncome.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date:";
            // 
            // txtBoxDescriptionIncome
            // 
            this.txtBoxDescriptionIncome.Location = new System.Drawing.Point(549, 89);
            this.txtBoxDescriptionIncome.Multiline = true;
            this.txtBoxDescriptionIncome.Name = "txtBoxDescriptionIncome";
            this.txtBoxDescriptionIncome.Size = new System.Drawing.Size(313, 87);
            this.txtBoxDescriptionIncome.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // txtBoxIncomeAmount
            // 
            this.txtBoxIncomeAmount.Location = new System.Drawing.Point(172, 115);
            this.txtBoxIncomeAmount.Name = "txtBoxIncomeAmount";
            this.txtBoxIncomeAmount.Size = new System.Drawing.Size(185, 22);
            this.txtBoxIncomeAmount.TabIndex = 5;
            // 
            // lblIncomeAmount
            // 
            this.lblIncomeAmount.AutoSize = true;
            this.lblIncomeAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeAmount.Location = new System.Drawing.Point(15, 113);
            this.lblIncomeAmount.Name = "lblIncomeAmount";
            this.lblIncomeAmount.Size = new System.Drawing.Size(145, 23);
            this.lblIncomeAmount.TabIndex = 4;
            this.lblIncomeAmount.Text = "Income Amount:";
            // 
            // comboBoxCatagoeyInIncome
            // 
            this.comboBoxCatagoeyInIncome.FormattingEnabled = true;
            this.comboBoxCatagoeyInIncome.Location = new System.Drawing.Point(172, 42);
            this.comboBoxCatagoeyInIncome.Name = "comboBoxCatagoeyInIncome";
            this.comboBoxCatagoeyInIncome.Size = new System.Drawing.Size(185, 24);
            this.comboBoxCatagoeyInIncome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category:";
            // 
            // dataGridViewIncomeList
            // 
            this.dataGridViewIncomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomeList.Location = new System.Drawing.Point(19, 70);
            this.dataGridViewIncomeList.Name = "dataGridViewIncomeList";
            this.dataGridViewIncomeList.RowHeadersWidth = 51;
            this.dataGridViewIncomeList.RowTemplate.Height = 24;
            this.dataGridViewIncomeList.Size = new System.Drawing.Size(896, 218);
            this.dataGridViewIncomeList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBoxTypeOnIncome);
            this.panel2.Controls.Add(this.lblTypeOnIncom);
            this.panel2.Controls.Add(this.comboBoxPayModeType);
            this.panel2.Controls.Add(this.lblIncomeType);
            this.panel2.Controls.Add(this.btnClearOnIncomeAdd);
            this.panel2.Controls.Add(this.btnAddOnIncome);
            this.panel2.Controls.Add(this.dateTimePickerIncome);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBoxDescriptionIncome);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBoxIncomeAmount);
            this.panel2.Controls.Add(this.lblIncomeAmount);
            this.panel2.Controls.Add(this.comboBoxCatagoeyInIncome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(41, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 361);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridViewIncomeList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 335);
            this.panel1.TabIndex = 22;
            // 
            // lblCrossIncomeFrom
            // 
            this.lblCrossIncomeFrom.AutoSize = true;
            this.lblCrossIncomeFrom.Location = new System.Drawing.Point(964, 28);
            this.lblCrossIncomeFrom.Name = "lblCrossIncomeFrom";
            this.lblCrossIncomeFrom.Size = new System.Drawing.Size(15, 16);
            this.lblCrossIncomeFrom.TabIndex = 21;
            this.lblCrossIncomeFrom.Text = "X";
            this.lblCrossIncomeFrom.Click += new System.EventHandler(this.lblCrossIncomeFrom_Click);
            // 
            // IncomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCrossIncomeFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IncomePage";
            this.Load += new System.EventHandler(this.IncomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomeList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeOnIncome;
        private System.Windows.Forms.Label lblTypeOnIncom;
        private System.Windows.Forms.ComboBox comboBoxPayModeType;
        private System.Windows.Forms.Label lblIncomeType;
        private System.Windows.Forms.Button btnClearOnIncomeAdd;
        private System.Windows.Forms.Button btnAddOnIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDescriptionIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxIncomeAmount;
        private System.Windows.Forms.Label lblIncomeAmount;
        private System.Windows.Forms.ComboBox comboBoxCatagoeyInIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewIncomeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCrossIncomeFrom;
    }
}