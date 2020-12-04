using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entites;

namespace UsersAndRewardsCORE.PL
{
    public partial class FormReward : Form
    {
        private ErrorProvider _errorProvider = new ErrorProvider();
        
        public FormReward()
        {
            InitializeComponent();

            btnApply.Text = "Создать";
        }

        public FormReward(Reward reward)
        {
            InitializeComponent();

            btnApply.Text = "Редактировать";

            txtTitle.Text = reward.Title;
            txtDescription.Text = reward.Description;
        }


        private bool ValidateTitle()
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || txtTitle.Text.Length > 50)
            {
                _errorProvider.SetError(txtTitle, "Неверные данные");
                return false;
            }
            else
            {
                _errorProvider.SetError(txtTitle, string.Empty);
                return true;
            }
        }

        private bool ValidateDescription()
        {
            if (txtDescription.Text.Length > 250)
            {
                _errorProvider.SetError(txtDescription, "Неверные данные");
                return false;
            }
            else
            {
                _errorProvider.SetError(txtDescription, string.Empty);
                return true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ValidateTitle() && ValidateDescription())
            {
                Title = txtTitle.Text;
                Description = txtDescription.Text;
                DialogResult = DialogResult.OK;
            }
        }

        public string Title { get; private set; }

        public string Description { get; private set; }
    }
}
