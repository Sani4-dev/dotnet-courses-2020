namespace PL
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
            this.labelFirstName.Location = new System.Drawing.Point(17, 16);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 17);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(16, 95);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(70, 17);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelDateBirthday
            // 
            this.labelDateBirthday.AutoSize = true;
            this.labelDateBirthday.Location = new System.Drawing.Point(21, 178);
            this.labelDateBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateBirthday.Name = "labelDateBirthday";
            this.labelDateBirthday.Size = new System.Drawing.Size(111, 17);
            this.labelDateBirthday.TabIndex = 2;
            this.labelDateBirthday.Text = "Дата рождения";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(165, 16);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(332, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(165, 95);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(332, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // dtpDateBirthday
            // 
            this.dtpDateBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateBirthday.Location = new System.Drawing.Point(165, 178);
            this.dtpDateBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateBirthday.Name = "dtpDateBirthday";
            this.dtpDateBirthday.Size = new System.Drawing.Size(332, 22);
            this.dtpDateBirthday.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(895, 492);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(156, 47);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Создать";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // labelRewardsUser
            // 
            this.labelRewardsUser.AutoSize = true;
            this.labelRewardsUser.Location = new System.Drawing.Point(25, 247);
            this.labelRewardsUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRewardsUser.Name = "labelRewardsUser";
            this.labelRewardsUser.Size = new System.Drawing.Size(161, 17);
            this.labelRewardsUser.TabIndex = 7;
            this.labelRewardsUser.Text = "Награды пользователя";
            // 
            // listRewardsUser
            // 
            this.listRewardsUser.FormattingEnabled = true;
            this.listRewardsUser.ItemHeight = 16;
            this.listRewardsUser.Location = new System.Drawing.Point(29, 268);
            this.listRewardsUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listRewardsUser.Name = "listRewardsUser";
            this.listRewardsUser.Size = new System.Drawing.Size(332, 164);
            this.listRewardsUser.TabIndex = 8;
            // 
            // labelAvailableRewards
            // 
            this.labelAvailableRewards.AutoSize = true;
            this.labelAvailableRewards.Location = new System.Drawing.Point(591, 247);
            this.labelAvailableRewards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailableRewards.Name = "labelAvailableRewards";
            this.labelAvailableRewards.Size = new System.Drawing.Size(141, 17);
            this.labelAvailableRewards.TabIndex = 9;
            this.labelAvailableRewards.Text = "Доступные награды";
            // 
            // listAvailableRewards
            // 
            this.listAvailableRewards.FormattingEnabled = true;
            this.listAvailableRewards.ItemHeight = 16;
            this.listAvailableRewards.Location = new System.Drawing.Point(595, 268);
            this.listAvailableRewards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listAvailableRewards.Name = "listAvailableRewards";
            this.listAvailableRewards.Size = new System.Drawing.Size(332, 164);
            this.listAvailableRewards.TabIndex = 10;
            // 
            // btnAddToUser
            // 
            this.btnAddToUser.Location = new System.Drawing.Point(487, 268);
            this.btnAddToUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToUser.Name = "btnAddToUser";
            this.btnAddToUser.Size = new System.Drawing.Size(100, 28);
            this.btnAddToUser.TabIndex = 11;
            this.btnAddToUser.Text = "<-------";
            this.btnAddToUser.UseVisualStyleBackColor = true;
            this.btnAddToUser.Click += new System.EventHandler(this.btnAddToUser_Click);
            // 
            // btnRemoveFromUser
            // 
            this.btnRemoveFromUser.Location = new System.Drawing.Point(372, 404);
            this.btnRemoveFromUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFromUser.Name = "btnRemoveFromUser";
            this.btnRemoveFromUser.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveFromUser.TabIndex = 12;
            this.btnRemoveFromUser.Text = "------->";
            this.btnRemoveFromUser.UseVisualStyleBackColor = true;
            this.btnRemoveFromUser.Click += new System.EventHandler(this.btnRemoveFromUser_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1085, 601);
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