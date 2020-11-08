namespace Task1
{
    partial class FormCreationReward
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
            this.labelTitleReward = new System.Windows.Forms.Label();
            this.txtTitleReward = new System.Windows.Forms.TextBox();
            this.labelDescriptionReward = new System.Windows.Forms.Label();
            this.txtDescriptionReward = new System.Windows.Forms.TextBox();
            this.btnCreateReward = new System.Windows.Forms.Button();
            this.btnCloseReward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleReward
            // 
            this.labelTitleReward.AutoSize = true;
            this.labelTitleReward.Location = new System.Drawing.Point(24, 32);
            this.labelTitleReward.Name = "labelTitleReward";
            this.labelTitleReward.Size = new System.Drawing.Size(106, 17);
            this.labelTitleReward.TabIndex = 0;
            this.labelTitleReward.Text = "Наименование";
            // 
            // txtTitleReward
            // 
            this.txtTitleReward.Location = new System.Drawing.Point(162, 26);
            this.txtTitleReward.Name = "txtTitleReward";
            this.txtTitleReward.Size = new System.Drawing.Size(467, 22);
            this.txtTitleReward.TabIndex = 1;
            // 
            // labelDescriptionReward
            // 
            this.labelDescriptionReward.AutoSize = true;
            this.labelDescriptionReward.Location = new System.Drawing.Point(27, 71);
            this.labelDescriptionReward.Name = "labelDescriptionReward";
            this.labelDescriptionReward.Size = new System.Drawing.Size(74, 17);
            this.labelDescriptionReward.TabIndex = 2;
            this.labelDescriptionReward.Text = "Описание";
            // 
            // txtDescriptionReward
            // 
            this.txtDescriptionReward.Location = new System.Drawing.Point(162, 65);
            this.txtDescriptionReward.Multiline = true;
            this.txtDescriptionReward.Name = "txtDescriptionReward";
            this.txtDescriptionReward.Size = new System.Drawing.Size(467, 140);
            this.txtDescriptionReward.TabIndex = 3;
            // 
            // btnCreateReward
            // 
            this.btnCreateReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateReward.Location = new System.Drawing.Point(437, 260);
            this.btnCreateReward.Name = "btnCreateReward";
            this.btnCreateReward.Size = new System.Drawing.Size(142, 31);
            this.btnCreateReward.TabIndex = 4;
            this.btnCreateReward.Text = "Создать";
            this.btnCreateReward.UseVisualStyleBackColor = true;
            this.btnCreateReward.Click += new System.EventHandler(this.btnCreateReward_Click);
            // 
            // btnCloseReward
            // 
            this.btnCloseReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseReward.Location = new System.Drawing.Point(585, 260);
            this.btnCloseReward.Name = "btnCloseReward";
            this.btnCloseReward.Size = new System.Drawing.Size(85, 31);
            this.btnCloseReward.TabIndex = 5;
            this.btnCloseReward.Text = "Закрыть";
            this.btnCloseReward.UseVisualStyleBackColor = true;
            this.btnCloseReward.Click += new System.EventHandler(this.btnCloseReward_Click);
            // 
            // FormCreationReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.btnCloseReward);
            this.Controls.Add(this.btnCreateReward);
            this.Controls.Add(this.txtDescriptionReward);
            this.Controls.Add(this.labelDescriptionReward);
            this.Controls.Add(this.txtTitleReward);
            this.Controls.Add(this.labelTitleReward);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "FormCreationReward";
            this.Text = "Создать награду";
            this.Load += new System.EventHandler(this.FormCreationReward_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleReward;
        private System.Windows.Forms.TextBox txtTitleReward;
        private System.Windows.Forms.Label labelDescriptionReward;
        private System.Windows.Forms.TextBox txtDescriptionReward;
        private System.Windows.Forms.Button btnCreateReward;
        private System.Windows.Forms.Button btnCloseReward;
    }
}