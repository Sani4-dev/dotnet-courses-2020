namespace Task1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtlSelect = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.ctlUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageRewards = new System.Windows.Forms.TabPage();
            this.ctlRewards = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabCtlSelect.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).BeginInit();
            this.contextMenuMain.SuspendLayout();
            this.tabPageRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewards)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMain
            // 
            this.MenuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCreateUser,
            this.MenuItemEditUser,
            this.MenuItemDeleteUser});
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(65, 24);
            this.MenuMain.Text = "Меню";
            // 
            // MenuItemCreateUser
            // 
            this.MenuItemCreateUser.Name = "MenuItemCreateUser";
            this.MenuItemCreateUser.Size = new System.Drawing.Size(294, 26);
            this.MenuItemCreateUser.Text = "Создать пользователя";
            this.MenuItemCreateUser.Click += new System.EventHandler(this.MenuItemCreateUser_Click);
            // 
            // MenuItemEditUser
            // 
            this.MenuItemEditUser.Name = "MenuItemEditUser";
            this.MenuItemEditUser.Size = new System.Drawing.Size(294, 26);
            this.MenuItemEditUser.Text = "Редактировать пользователя";
            this.MenuItemEditUser.Click += new System.EventHandler(this.MenuItemEditUser_Click);
            // 
            // MenuItemDeleteUser
            // 
            this.MenuItemDeleteUser.Name = "MenuItemDeleteUser";
            this.MenuItemDeleteUser.Size = new System.Drawing.Size(294, 26);
            this.MenuItemDeleteUser.Text = "Удалить пользователя";
            this.MenuItemDeleteUser.Click += new System.EventHandler(this.MenuItemDeleteUser_Click);
            // 
            // tabCtlSelect
            // 
            this.tabCtlSelect.Controls.Add(this.tabPageUsers);
            this.tabCtlSelect.Controls.Add(this.tabPageRewards);
            this.tabCtlSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlSelect.Location = new System.Drawing.Point(0, 28);
            this.tabCtlSelect.Name = "tabCtlSelect";
            this.tabCtlSelect.SelectedIndex = 0;
            this.tabCtlSelect.Size = new System.Drawing.Size(800, 422);
            this.tabCtlSelect.TabIndex = 1;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.ctlUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(792, 393);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Пользователи";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // ctlUsers
            // 
            this.ctlUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsers.ContextMenuStrip = this.contextMenuMain;
            this.ctlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsers.Location = new System.Drawing.Point(3, 3);
            this.ctlUsers.MultiSelect = false;
            this.ctlUsers.Name = "ctlUsers";
            this.ctlUsers.ReadOnly = true;
            this.ctlUsers.RowHeadersWidth = 51;
            this.ctlUsers.RowTemplate.Height = 24;
            this.ctlUsers.Size = new System.Drawing.Size(786, 387);
            this.ctlUsers.TabIndex = 0;
            this.ctlUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlUsers_CellMouseDown);
            this.ctlUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlUsers_ColumnHeaderMouseClick);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemCreateUser,
            this.contextMenuItemEditUser,
            this.contextMenuItemDeleteUser});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(281, 76);
            // 
            // ContextMenuItemCreateUser
            // 
            this.ContextMenuItemCreateUser.Name = "ContextMenuItemCreateUser";
            this.ContextMenuItemCreateUser.Size = new System.Drawing.Size(280, 24);
            this.ContextMenuItemCreateUser.Text = "Создать пользователя";
            this.ContextMenuItemCreateUser.Click += new System.EventHandler(this.ContextMenuItemCreateUser_Click);
            // 
            // contextMenuItemEditUser
            // 
            this.contextMenuItemEditUser.Name = "contextMenuItemEditUser";
            this.contextMenuItemEditUser.Size = new System.Drawing.Size(280, 24);
            this.contextMenuItemEditUser.Text = "Редактировать пользователя";
            this.contextMenuItemEditUser.Click += new System.EventHandler(this.contextMenuItemEditUser_Click);
            // 
            // contextMenuItemDeleteUser
            // 
            this.contextMenuItemDeleteUser.Name = "contextMenuItemDeleteUser";
            this.contextMenuItemDeleteUser.Size = new System.Drawing.Size(280, 24);
            this.contextMenuItemDeleteUser.Text = "Удалить пользователя";
            this.contextMenuItemDeleteUser.Click += new System.EventHandler(this.contextMenuItemDeleteUser_Click);
            // 
            // tabPageRewards
            // 
            this.tabPageRewards.Controls.Add(this.ctlRewards);
            this.tabPageRewards.Location = new System.Drawing.Point(4, 25);
            this.tabPageRewards.Name = "tabPageRewards";
            this.tabPageRewards.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRewards.Size = new System.Drawing.Size(792, 393);
            this.tabPageRewards.TabIndex = 1;
            this.tabPageRewards.Text = "Награды";
            this.tabPageRewards.UseVisualStyleBackColor = true;
            // 
            // ctlRewards
            // 
            this.ctlRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRewards.Location = new System.Drawing.Point(3, 3);
            this.ctlRewards.MultiSelect = false;
            this.ctlRewards.Name = "ctlRewards";
            this.ctlRewards.ReadOnly = true;
            this.ctlRewards.RowHeadersWidth = 51;
            this.ctlRewards.RowTemplate.Height = 24;
            this.ctlRewards.Size = new System.Drawing.Size(786, 387);
            this.ctlRewards.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCtlSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Пользователи и награды";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtlSelect.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).EndInit();
            this.contextMenuMain.ResumeLayout(false);
            this.tabPageRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabCtlSelect;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.DataGridView ctlUsers;
        private System.Windows.Forms.TabPage tabPageRewards;
        private System.Windows.Forms.DataGridView ctlRewards;
        private System.Windows.Forms.ToolStripMenuItem MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreateUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCreateUser;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemEditUser;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDeleteUser;
    }
}

