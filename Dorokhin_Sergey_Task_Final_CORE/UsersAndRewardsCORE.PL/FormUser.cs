using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.BLL;
using Entites;

namespace UsersAndRewardsCORE.PL
{
    public partial class FormUser : Form
    {
        private ErrorProvider _errorProvider = new ErrorProvider();
        private List<Reward> _rewardsAvailable;
        private List<Reward> _rewardsUser;
        
        public FormUser(List<Reward> rewards)
        {
            InitializeComponent();

            _rewardsAvailable = rewards;
            _rewardsUser = new List<Reward>();
            btnApply.Text = "Создать";

            foreach (var reward in _rewardsAvailable)
            {
                listAvailableRewards.Items.Add(reward.Title);
            }
        }

        public FormUser(User user, List<Reward> rewards)
        {
            InitializeComponent();

            _rewardsAvailable = rewards;
            _rewardsUser = user.Rewards;
            btnApply.Text = "Редактировать";

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            dtpDateBirthday.Value = user.DateBirthday;

            foreach (var reward in _rewardsAvailable)
            {
                listAvailableRewards.Items.Add(reward.Title);
            }

            foreach (var reward in _rewardsUser)
            {
                listRewardsUser.Items.Add(reward.Title);

                if (listAvailableRewards.Items.Contains(reward.Title))
                {
                    listAvailableRewards.Items.Remove(reward.Title);
                }
            }
        }

        private bool ValidateFirstName()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || txtFirstName.Text.Length < 3 || txtFirstName.Text.Length > 50)
            {
                _errorProvider.SetError(txtFirstName, "Неверные данные");
                return false;
            }
            else
            {
                _errorProvider.SetError(txtFirstName, string.Empty);
                return true;
            }
        }

        private bool ValidateLastName()
        {
            if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text.Length < 3 || txtLastName.Text.Length > 50)
            {
                _errorProvider.SetError(txtLastName, "Неверные данные");
                return false;
            }
            else
            {
                _errorProvider.SetError(txtLastName, string.Empty);
                return true;
            }
        }

        private bool ValidateDateBirthday()
        {
            if (dtpDateBirthday.Value.Date > DateTime.Now.Date || DateTime.Now.Year - dtpDateBirthday.Value.Year > 150)
            {
                _errorProvider.SetError(dtpDateBirthday, "Неверные данные");
                return false;
            }
            else
            {
                _errorProvider.SetError(dtpDateBirthday, string.Empty);
                return true;
            }
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime DateBirthday { get; private set; }

        public List<Reward> Rewards { get; private set; }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ValidateFirstName() && ValidateLastName() && ValidateDateBirthday())
            {
                FirstName = txtFirstName.Text;
                LastName = txtLastName.Text;
                DateBirthday = dtpDateBirthday.Value.Date;

                _rewardsUser.Clear();
                
                foreach (string str in listRewardsUser.Items)
                {
                    foreach (var reward in _rewardsAvailable)
                    {
                        if (reward.Title == str)
                        {
                            _rewardsUser.Add(reward);
                        }
                    }
                }

                Rewards = _rewardsUser;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnAddToUser_Click(object sender, EventArgs e)
        {
            if (listAvailableRewards.SelectedIndex > -1)
            {
                string str = (string)listAvailableRewards.SelectedItem;

                listAvailableRewards.Items.Remove(str);
                listRewardsUser.Items.Add(str);
            }
        }

        private void btnRemoveFromUser_Click(object sender, EventArgs e)
        {
            if (listRewardsUser.SelectedIndex > -1)
            {
                string str = (string)listRewardsUser.SelectedItem;

                listRewardsUser.Items.Remove(str);
                listAvailableRewards.Items.Add(str);
            }
        }
    }
}
