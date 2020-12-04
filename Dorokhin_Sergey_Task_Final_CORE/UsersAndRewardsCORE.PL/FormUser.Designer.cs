namespace UsersAndRewardsCORE.PL
{
    partial class FormUser
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDateBirthday = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDateBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.labelRewardsUser = new System.Windows.Forms.Label();
            this.listRewardsUser = new System.Windows.Forms.ListBox();
            this.labelAvailableRewards = new System.Windows.Forms.Label();
            this.listAvailableRewards = new System.Windows.Forms.ListBox();
            this.btnAddToUser = new System.Windows.Forms.Button();
            this.btnRemoveFromUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(13, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 77);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelDateBirthday
            // 
            this.labelDateBirthday.AutoSize = true;
            this.labelDateBirthday.Location = new System.Drawing.Point(16, 145);
            this.labelDateBirthday.Name = "labelDateBirthday";
            this.labelDateBirthday.Size = new System.Drawing.Size(86, 13);
            this.labelDateBirthday.TabIndex = 2;
            this.labelDateBirthday.Text = "Дата рождения";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // dtpDateBirthday
            // 
            this.dtpDateBirthday.Location = new System.Drawing.Point(124, 145);
            this.dtpDateBirthday.Name = "dtpDateBirthday";
            this.dtpDateBirthday.Size = new System.Drawing.Size(250, 20);
            this.dtpDateBirthday.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(671, 400);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 38);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Создать";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // labelRewardsUser
            // 
            this.labelRewardsUser.AutoSize = true;
            this.labelRewardsUser.Location = new System.Drawing.Point(19, 201);
            this.labelRewardsUser.Name = "labelRewardsUser";
            this.labelRewardsUser.Size = new System.Drawing.Size(126, 13);
            this.labelRewardsUser.TabIndex = 7;
            this.labelRewardsUser.Text = "Награды пользователя";
            // 
            // listRewardsUser
            // 
            this.listRewardsUser.FormattingEnabled = true;
            this.listRewardsUser.Location = new System.Drawing.Point(22, 218);
            this.listRewardsUser.Name = "listRewardsUser";
            this.listRewardsUser.Size = new System.Drawing.Size(250, 134);
            this.listRewardsUser.TabIndex = 8;
            // 
            // labelAvailableRewards
            // 
            this.labelAvailableRewards.AutoSize = true;
            this.labelAvailableRewards.Location = new System.Drawing.Point(443, 201);
            this.labelAvailableRewards.Name = "labelAvailableRewards";
            this.labelAvailableRewards.Size = new System.Drawing.Size(110, 13);
            this.labelAvailableRewards.TabIndex = 9;
            this.labelAvailableRewards.Text = "Доступные награды";
            // 
            // listAvailableRewards
            // 
            this.listAvailableRewards.FormattingEnabled = true;
            this.listAvailableRewards.Location = new System.Drawing.Point(446, 218);
            this.listAvailableRewards.Name = "listAvailableRewards";
            this.listAvailableRewards.Size = new System.Drawing.Size(250, 134);
            this.listAvailableRewards.TabIndex = 10;
            // 
            // btnAddToUser
            // 
            this.btnAddToUser.Location = new System.Drawing.Point(365, 218);
            this.btnAddToUser.Name = "btnAddToUser";
            this.btnAddToUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddToUser.TabIndex = 11;
            this.btnAddToUser.Text = "<-------";
            this.btnAddToUser.UseVisualStyleBackColor = true;
            this.btnAddToUser.Click += new System.EventHandler(this.btnAddToUser_Click);
            // 
            // btnRemoveFromUser
            // 
            this.btnRemoveFromUser.Location = new System.Drawing.Point(279, 328);
            this.btnRemoveFromUser.Name = "btnRemoveFromUser";
            this.btnRemoveFromUser.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromUser.TabIndex = 12;
            this.btnRemoveFromUser.Text = "------->";
            this.btnRemoveFromUser.UseVisualStyleBackColor = true;
            this.btnRemoveFromUser.Click += new System.EventHandler(this.btnRemoveFromUser_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveFromUser);
            this.Controls.Add(this.btnAddToUser);
            this.Controls.Add(this.listAvailableRewards);
            this.Controls.Add(this.labelAvailableRewards);
            this.Controls.Add(this.listRewardsUser);
            this.Controls.Add(this.labelRewardsUser);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dtpDateBirthday);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelDateBirthday);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "FormUser";
            this.Text = "Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDateBirthday;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDateBirthday;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label labelRewardsUser;
        private System.Windows.Forms.ListBox listRewardsUser;
        private System.Windows.Forms.Label labelAvailableRewards;
        private System.Windows.Forms.ListBox listAvailableRewards;
        private System.Windows.Forms.Button btnAddToUser;
        private System.Windows.Forms.Button btnRemoveFromUser;
    }
}