namespace UsersAndRewardsCORE.PL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabUsersAndRewards = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageRewards = new System.Windows.Forms.TabPage();
            this.dgvRewards = new System.Windows.Forms.DataGridView();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.MenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabUsersAndRewards.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuMain.SuspendLayout();
            this.tabPageRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).BeginInit();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsersAndRewards
            // 
            this.tabUsersAndRewards.Controls.Add(this.tabPageUsers);
            this.tabUsersAndRewards.Controls.Add(this.tabPageRewards);
            this.tabUsersAndRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsersAndRewards.Location = new System.Drawing.Point(0, 28);
            this.tabUsersAndRewards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUsersAndRewards.Name = "tabUsersAndRewards";
            this.tabUsersAndRewards.SelectedIndex = 0;
            this.tabUsersAndRewards.Size = new System.Drawing.Size(1045, 683);
            this.tabUsersAndRewards.TabIndex = 0;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.dgvUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 29);
            this.tabPageUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUsers.Size = new System.Drawing.Size(1037, 650);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Пользователи";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuMain;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(4, 5);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1029, 640);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_CellMouseDown);
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemCreate,
            this.ContextMenuItemEdit,
            this.ContextMenuItemRemove});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(181, 76);
            // 
            // ContextMenuItemCreate
            // 
            this.ContextMenuItemCreate.Name = "ContextMenuItemCreate";
            this.ContextMenuItemCreate.Size = new System.Drawing.Size(180, 24);
            this.ContextMenuItemCreate.Text = "Создать";
            this.ContextMenuItemCreate.Click += new System.EventHandler(this.ContextMenuItemCreate_Click);
            // 
            // ContextMenuItemEdit
            // 
            this.ContextMenuItemEdit.Name = "ContextMenuItemEdit";
            this.ContextMenuItemEdit.Size = new System.Drawing.Size(180, 24);
            this.ContextMenuItemEdit.Text = "Редактировать";
            this.ContextMenuItemEdit.Click += new System.EventHandler(this.ContextMenuItemEdit_Click);
            // 
            // ContextMenuItemRemove
            // 
            this.ContextMenuItemRemove.Name = "ContextMenuItemRemove";
            this.ContextMenuItemRemove.Size = new System.Drawing.Size(180, 24);
            this.ContextMenuItemRemove.Text = "Удалить";
            this.ContextMenuItemRemove.Click += new System.EventHandler(this.ContextMenuItemRemove_Click);
            // 
            // tabPageRewards
            // 
            this.tabPageRewards.Controls.Add(this.dgvRewards);
            this.tabPageRewards.Location = new System.Drawing.Point(4, 29);
            this.tabPageRewards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRewards.Name = "tabPageRewards";
            this.tabPageRewards.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRewards.Size = new System.Drawing.Size(1037, 650);
            this.tabPageRewards.TabIndex = 1;
            this.tabPageRewards.Text = "Награды";
            this.tabPageRewards.UseVisualStyleBackColor = true;
            // 
            // dgvRewards
            // 
            this.dgvRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRewards.ContextMenuStrip = this.contextMenuMain;
            this.dgvRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRewards.Location = new System.Drawing.Point(4, 5);
            this.dgvRewards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRewards.MultiSelect = false;
            this.dgvRewards.Name = "dgvRewards";
            this.dgvRewards.ReadOnly = true;
            this.dgvRewards.RowHeadersWidth = 51;
            this.dgvRewards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRewards.Size = new System.Drawing.Size(1029, 640);
            this.dgvRewards.TabIndex = 0;
            this.dgvRewards.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRewards_CellMouseDown);
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItems});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(1045, 28);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Text = "Меню";
            // 
            // MenuItems
            // 
            this.MenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCreate,
            this.MenuItemEdit,
            this.MenuItemDelete});
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(65, 24);
            this.MenuItems.Text = "Меню";
            // 
            // MenuItemCreate
            // 
            this.MenuItemCreate.Name = "MenuItemCreate";
            this.MenuItemCreate.Size = new System.Drawing.Size(194, 26);
            this.MenuItemCreate.Text = "Создать";
            this.MenuItemCreate.Click += new System.EventHandler(this.MenuItemCreate_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(194, 26);
            this.MenuItemEdit.Text = "Редактировать";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(194, 26);
            this.MenuItemDelete.Text = "Удалить";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 711);
            this.Controls.Add(this.tabUsersAndRewards);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1061, 436);
            this.Name = "FormMain";
            this.Text = "Пользователи и награды";
            this.tabUsersAndRewards.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuMain.ResumeLayout(false);
            this.tabPageRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).EndInit();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsersAndRewards;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabPageRewards;
        private System.Windows.Forms.DataGridView dgvRewards;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItems;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemRemove;
    }
}

