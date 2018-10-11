namespace AccountFormApp
{
    partial class Form1
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.lblAccName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lbxCurrent = new System.Windows.Forms.ListBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWithdrawal = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(42, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(440, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Wells Fargo Account Creator ";
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(69, 118);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(100, 20);
            this.txtAccName.TabIndex = 1;
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(69, 99);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(103, 13);
            this.lblAccName.TabIndex = 2;
            this.lblAccName.Text = "New Account Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Account";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(69, 217);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(89, 13);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current Accounts";
            // 
            // lbxCurrent
            // 
            this.lbxCurrent.FormattingEnabled = true;
            this.lbxCurrent.Location = new System.Drawing.Point(69, 233);
            this.lbxCurrent.Name = "lbxCurrent";
            this.lbxCurrent.Size = new System.Drawing.Size(165, 134);
            this.lbxCurrent.TabIndex = 5;
            this.lbxCurrent.SelectedIndexChanged += new System.EventHandler(this.currentlbox_SelectedIndexChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(299, 119);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(299, 99);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(89, 13);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Account Balance";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(411, 221);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(383, 237);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtDeposit.TabIndex = 9;
            // 
            // txtWithdrawal
            // 
            this.txtWithdrawal.Location = new System.Drawing.Point(383, 260);
            this.txtWithdrawal.Name = "txtWithdrawal";
            this.txtWithdrawal.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawal.TabIndex = 10;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(302, 236);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(302, 260);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawal.TabIndex = 12;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtWithdrawal);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lbxCurrent);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.ListBox lbxCurrent;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtWithdrawal;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrawal;
    }
}

