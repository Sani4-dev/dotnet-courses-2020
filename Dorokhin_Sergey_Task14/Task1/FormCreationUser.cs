using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormCreationUser : Form
    {
        private const int MaxLengthFirstName = 50;
        private const int MinLengthFirstName = 3;
        private const int MaxLengthLastName = 50;
        private const int MinLengthLastName = 3;
        private const int MaxAge = 150;

        private BindingList<Reward> _rewardsTemp = new BindingList<Reward>();

        private readonly ErrorProvider _errorProvider;
        private readonly User _user;
        private readonly BindingList<Reward> _rewards;

        private readonly bool isCreateUser;

        public FormCreationUser(BindingList<Reward> rewards)
        {
            InitializeComponent();

            _errorProvider = new ErrorProvider();
            isCreateUser = true;
            _rewards = rewards;
        }


        public FormCreationUser(User user, BindingList<Reward> rewards)
        {
            InitializeComponent();

            _errorProvider = new ErrorProvider();
            isCreateUser = false;
            _user = user;
            _rewards = rewards;
            _rewardsTemp = user.GetRewards();
        }

        private bool ValidateFirstName()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || 
                txtFirstName.Text.Length < MinLengthFirstName || 
                txtFirstName.Text.Length > MaxLengthFirstName)
            {
                _errorProvider.SetError(txtFirstName, "Неверные данные");
                return false;
            }

            _errorProvider.SetError(txtFirstName, string.Empty);
            return (FirstName = txtFirstName.Text) == txtFirstName.Text;
        }

        private bool ValidateLastName()
        {
            if (string.IsNullOrEmpty(txtLastName.Text) || 
                txtLastName.Text.Length < MinLengthLastName || 
                txtLastName.Text.Length > MaxLengthLastName)
            {
                _errorProvider.SetError(txtLastName, "Неверные данные");
                return false;
            }

            _errorProvider.SetError(txtLastName, string.Empty);
            return (LastName = txtLastName.Text) == txtLastName.Text;
        }

        private bool ValidateBirthDay()
        {
            if (DateTime.TryParseExact(txtBirthDay.Text, "dd.MM.yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, 
                out DateTime birthDay))
            {
                if (birthDay < DateTime.Now && (DateTime.Now.Year - birthDay.Year) < MaxAge)
                {
                    _errorProvider.SetError(txtBirthDay, string.Empty);
                    return (BirthDay = birthDay) == birthDay;
                }
            }

            _errorProvider.SetError(txtBirthDay, "Некорректные данные");
            return false;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDay { get; private set; }

        public BindingList<Reward> Rewards { get; set; }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateFirstName() && ValidateLastName() && ValidateBirthDay())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormCreationUser_Load(object sender, EventArgs e)
        {
            if (isCreateUser)
            {
                btnCreate.Text = "Создать";
                this.Text = "Создание пользователя";

                foreach (var reward in _rewards)
                {
                    listRewardsAvailable.Items.Add(reward.Title);
                }

            }
            else
            {
                btnCreate.Text = "Редактировать";
                this.Text = "Редактирование пользователя";

                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtBirthDay.Text = _user.BirthDay.ToString("dd.MM.yyyy");

                foreach (var reward in _rewardsTemp)
                {
                    listRewardsUser.Items.Add(reward.Title);
                }

                foreach (var reward in _rewards)
                {
                    if (listRewardsUser.FindString(reward.Title) == ListBox.NoMatches)
                    {
                        listRewardsAvailable.Items.Add(reward.Title);
                    }
                }

            }
        }

        private void btnAddReward_Click(object sender, EventArgs e)
        {
            if (listRewardsAvailable.Items.Count > 0)
            {
                if (listRewardsAvailable.SelectedIndex != -1)
                {
                    string titleReward = (string)listRewardsAvailable.SelectedItem;

                    listRewardsUser.Items.Add(titleReward);

                    foreach (var reward in _rewards)
                    {
                        if (reward.Title == titleReward)
                        {
                            _rewardsTemp.Add(reward);
                            listRewardsAvailable.Items.Remove(titleReward);
                            break;
                        }
                    }
                }
            }
        }

        private void FormCreationUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rewards = _rewardsTemp;
        }

        private void btnRemoveReward_Click(object sender, EventArgs e)
        {
            if (listRewardsUser.Items.Count > 0)
            {
                string stringToRemove = (string)listRewardsUser.SelectedItem;

                foreach (var reward in _rewardsTemp)
                {
                    if (reward.Title == stringToRemove)
                    {
                        _rewardsTemp.Remove(reward);
                        listRewardsUser.Items.Remove(stringToRemove);
                        listRewardsAvailable.Items.Add(stringToRemove);
                        break;
                    }
                }
            }
        }
    }
}
