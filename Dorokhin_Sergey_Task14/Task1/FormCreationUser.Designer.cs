namespace Task1
{
    partial class FormCreationUser
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.labelDateRules = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelRewardsUser = new System.Windows.Forms.Label();
            this.labelRewardsAvaiable = new System.Windows.Forms.Label();
            this.listRewardsAvailable = new System.Windows.Forms.ListBox();
            this.btnAddReward = new System.Windows.Forms.Button();
            this.listRewardsUser = new System.Windows.Forms.ListBox();
            this.btnRemoveReward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(22, 25);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 17);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(202, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(283, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(25, 64);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(70, 17);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(202, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(283, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(25, 135);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(111, 17);
            this.labelBirthDay.TabIndex = 4;
            this.labelBirthDay.Text = "Дата рождения";
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(202, 129);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(283, 22);
            this.txtBirthDay.TabIndex = 5;
            // 
            // labelDateRules
            // 
            this.labelDateRules.AutoSize = true;
            this.labelDateRules.Location = new System.Drawing.Point(202, 106);
            this.labelDateRules.Name = "labelDateRules";
            this.labelDateRules.Size = new System.Drawing.Size(190, 17);
            this.labelDateRules.TabIndex = 6;
            this.labelDateRules.Text = "Формат даты: ДД.ММ.ГГГГ";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(761, 409);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(127, 29);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(895, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelRewardsUser
            // 
            this.labelRewardsUser.AutoSize = true;
            this.labelRewardsUser.Location = new System.Drawing.Point(25, 179);
            this.labelRewardsUser.Name = "labelRewardsUser";
            this.labelRewardsUser.Size = new System.Drawing.Size(161, 17);
            this.labelRewardsUser.TabIndex = 9;
            this.labelRewardsUser.Text = "Награды пользователя";
            // 
            // labelRewardsAvaiable
            // 
            this.labelRewardsAvaiable.AutoSize = true;
            this.labelRewardsAvaiable.Location = new System.Drawing.Point(515, 178);
            this.labelRewardsAvaiable.Name = "labelRewardsAvaiable";
            this.labelRewardsAvaiable.Size = new System.Drawing.Size(140, 17);
            this.labelRewardsAvaiable.TabIndex = 11;
            this.labelRewardsAvaiable.Text = "Награды доступные";
            // 
            // listRewardsAvailable
            // 
            this.listRewardsAvailable.FormattingEnabled = true;
            this.listRewardsAvailable.ItemHeight = 16;
            this.listRewardsAvailable.Location = new System.Drawing.Point(662, 179);
            this.listRewardsAvailable.Name = "listRewardsAvailable";
            this.listRewardsAvailable.Size = new System.Drawing.Size(283, 164);
            this.listRewardsAvailable.TabIndex = 12;
            // 
            // btnAddReward
            // 
            this.btnAddReward.Location = new System.Drawing.Point(546, 207);
            this.btnAddReward.Name = "btnAddReward";
            this.btnAddReward.Size = new System.Drawing.Size(109, 39);
            this.btnAddReward.TabIndex = 13;
            this.btnAddReward.Text = "Добавить";
            this.btnAddReward.UseVisualStyleBackColor = true;
            this.btnAddReward.Click += new System.EventHandler(this.btnAddReward_Click);
            // 
            // listRewardsUser
            // 
            this.listRewardsUser.FormattingEnabled = true;
            this.listRewardsUser.ItemHeight = 16;
            this.listRewardsUser.Location = new System.Drawing.Point(202, 179);
            this.listRewardsUser.Name = "listRewardsUser";
            this.listRewardsUser.Size = new System.Drawing.Size(283, 164);
            this.listRewardsUser.TabIndex = 14;
            // 
            // btnRemoveReward
            // 
            this.btnRemoveReward.Location = new System.Drawing.Point(89, 207);
            this.btnRemoveReward.Name = "btnRemoveReward";
            this.btnRemoveReward.Size = new System.Drawing.Size(107, 39);
            this.btnRemoveReward.TabIndex = 15;
            this.btnRemoveReward.Text = "Убрать";
            this.btnRemoveReward.UseVisualStyleBackColor = true;
            this.btnRemoveReward.Click += new System.EventHandler(this.btnRemoveReward_Click);
            // 
            // FormCreationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.btnRemoveReward);
            this.Controls.Add(this.listRewardsUser);
            this.Controls.Add(this.btnAddReward);
            this.Controls.Add(this.listRewardsAvailable);
            this.Controls.Add(this.labelRewardsAvaiable);
            this.Controls.Add(this.labelRewardsUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelDateRules);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelFirstName);
            this.MinimumSize = new System.Drawing.Size(1000, 490);
            this.Name = "FormCreationUser";
            this.Text = "Создание пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreationUser_FormClosing);
            this.Load += new System.EventHandler(this.FormCreationUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.TextBox txtBirthDay;
        private System.Windows.Forms.Label labelDateRules;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelRewardsUser;
        private System.Windows.Forms.Label labelRewardsAvaiable;
        private System.Windows.Forms.ListBox listRewardsAvailable;
        private System.Windows.Forms.Button btnAddReward;
        private System.Windows.Forms.ListBox listRewardsUser;
        private System.Windows.Forms.Button btnRemoveReward;
    }
}