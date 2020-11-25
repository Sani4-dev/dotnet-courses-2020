namespace UsersAndRewards.PL
{
    partial class FormReward
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Наименование";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(162, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(300, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 54);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 54);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 150);
            this.txtDescription.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(530, 263);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(138, 37);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Создать";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FormReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "FormReward";
            this.Text = "Награда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnApply;
    }
}