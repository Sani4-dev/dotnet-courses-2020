using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormCreationReward : Form
    {
        private const int MaxLengthDescription = 250;
        private const int MaxLengthNameReward = 50;

        private readonly bool isCreateReward;

        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        private Reward _reward;
        
        public FormCreationReward()
        {
            InitializeComponent();

            isCreateReward = true;
        }

        public FormCreationReward(Reward reward)
        {
            InitializeComponent();

            isCreateReward = false;
            _reward = reward;
        }

        public string NameReward { get; private set; }

        public string Description { get; private set; }

        private void btnCloseReward_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnCreateReward_Click(object sender, EventArgs e)
        {
            if (ValidateNameReward() && ValidateDescription())
            {
                DialogResult = DialogResult.OK;
            }
            Description = txtDescriptionReward.Text;
        }

        private bool ValidateNameReward()
        {
            if (String.IsNullOrEmpty(txtTitleReward.Text) || txtTitleReward.Text.Length > MaxLengthNameReward)
            {
                _errorProvider.SetError(txtTitleReward, "Неверные данные");
                return false;
            }

            NameReward = txtTitleReward.Text;
            _errorProvider.SetError(txtTitleReward, string.Empty);
            return true;
        }

        private bool ValidateDescription()
        {
            if (txtDescriptionReward.Text.Length > MaxLengthDescription)
            {
                _errorProvider.SetError(txtDescriptionReward, "Неверные данные");
                return false;
            }

            Description = txtDescriptionReward.Text;
            _errorProvider.SetError(txtDescriptionReward, string.Empty);
            return true;
        }

        private void FormCreationReward_Load(object sender, EventArgs e)
        {
            if (isCreateReward)
            {
                btnCreateReward.Text = "Создать";
                this.Text = "Создание награды";
            }
            else
            {
                btnCreateReward.Text = "Редактировать";
                this.Text = "Редактирование награды";

                txtTitleReward.Text = _reward.Title;
                txtDescriptionReward.Text = _reward.Description;
            }
        }
    }
}
