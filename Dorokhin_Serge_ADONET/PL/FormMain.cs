using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Common;

namespace PL
{
    public partial class FormMain : Form
    {
        private const                  int _DefaultValueId = 0;
        private const string _QuestionWhenDeletingAnReward = "Вы действительно желаете удалить награду?";
        private const   string _QuestionWhenDeletingAnUser = "Вы действительно желаете удалить пользователя?";
        private readonly UsersBL _usersBL;
        private readonly RewardsBL _rewardsBL;

        public FormMain()
        {
            InitializeComponent();

            _usersBL = new UsersBL(ConfigurationManager.ConnectionStrings["ConnectionStringToTaskADONet"].ConnectionString);
            _rewardsBL = new RewardsBL(ConfigurationManager.ConnectionStrings["ConnectionStringToTaskADONet"].ConnectionString);

            DisplayUsers();
            DisplayRewards();
        }

        private void ConfigureDgvUsers()
        {
            this.dgvUsers.Columns[0].HeaderText = "Идентификатор";
            this.dgvUsers.Columns[1].HeaderText = "Имя";
            this.dgvUsers.Columns[2].HeaderText = "Фамилия";
            this.dgvUsers.Columns[3].HeaderText = "Дата рождения";
            this.dgvUsers.Columns[4].HeaderText = "Возраст";
            this.dgvUsers.Columns[5].HeaderText = "Награды";
        }

        private void ConfigureDgvRewards()
        {
            this.dgvRewards.Columns[0].HeaderText = "Идентификатор";
            this.dgvRewards.Columns[1].HeaderText = "Наименование";
            this.dgvRewards.Columns[2].HeaderText = "Описание";
        }

        private void DisplayUsers()
        {
            this.dgvUsers.DataSource = null;
            this.dgvUsers.DataSource = _usersBL.GetList();
            this.dgvUsers.Refresh();
            ConfigureDgvUsers();
        }

        private void DisplayRewards()
        {
            this.dgvRewards.DataSource = null;
            this.dgvRewards.DataSource = _rewardsBL.GetList();
            this.dgvRewards.Refresh();
            ConfigureDgvRewards();
        }

        private void MenuItemCreate_Click(object sender, EventArgs e)
        {
            if (tabUsersAndRewards.SelectedIndex == 0)
            {
                CreateUser();
                DisplayUsers();
            }
            else
            {
                CreateReward();
                DisplayRewards();
            }
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            if (tabUsersAndRewards.SelectedIndex == 0)
            {
                EditUser();
                DisplayUsers();
            }
            else
            {
                EditReward();
                DisplayRewards();
                DisplayUsers();
            }
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {

            if (tabUsersAndRewards.SelectedIndex == 0)
            {
                RemoveUser();
                DisplayUsers();
            }
            else
            {
                RemoveReward();
                DisplayRewards();
                DisplayUsers();
            }
        }


        private void CreateUser()
        {
            var formUser = new FormUser(_rewardsBL.GetList());

            if (formUser.ShowDialog(this) == DialogResult.OK)
            {
                _usersBL.Add(new User(_DefaultValueId, 
                                      formUser.FirstName, 
                                      formUser.LastName, 
                                      formUser.DateBirthday, 
                                      formUser.Rewards));
            }
        }

        private void EditUser()
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                User user = (User)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;

                var formUser = new FormUser(user, _rewardsBL.GetList());

                if (formUser.ShowDialog(this) == DialogResult.OK)
                {
                       user.FirstName = formUser.FirstName;
                        user.LastName = formUser.LastName;
                    user.DateBirthday = formUser.DateBirthday;
                         user.Rewards = formUser.Rewards;

                    _usersBL.Update(user);
                }
            }
        }

        private void RemoveUser()
        {
            if (dgvUsers.Rows.Count > 0)
            {
                var formSureRemove = new FormSureRemove(_QuestionWhenDeletingAnUser);

                if (formSureRemove.ShowDialog(this) == DialogResult.OK)
                {
                    User user = (User)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;

                    _usersBL.Remove(user);
                }
            }
        }

        private void CreateReward()
        {
            var formReward = new FormReward();

            if (formReward.ShowDialog(this) == DialogResult.OK)
            {
                _rewardsBL.Add(new Reward(_DefaultValueId, 
                                          formReward.Title, 
                                          formReward.Description));
            }
        }

        private void EditReward()
        {
            if (dgvRewards.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;

                var formReward = new FormReward(reward);

                if (formReward.ShowDialog(this) == DialogResult.OK)
                {
                          reward.Title = formReward.Title;
                    reward.Description = formReward.Description;

                    _rewardsBL.Update(reward);
                }
            }
        }

        private void RemoveReward()
        {
            if (dgvRewards.Rows.Count > 0)
            {
                var formSureRemove = new FormSureRemove(_QuestionWhenDeletingAnReward);

                if (formSureRemove.ShowDialog(this) == DialogResult.OK)
                {
                    Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;

                    _rewardsBL.Remove(reward);
                }
            }
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && e.Button == MouseButtons.Right)
            {
                dgvUsers.CurrentCell = dgvUsers[e.ColumnIndex, e.RowIndex];
            }
        }

        private void dgvRewards_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && e.Button == MouseButtons.Right)
            {
                dgvRewards.CurrentCell = dgvRewards[e.ColumnIndex, e.RowIndex];
            }
        }

        private void ContextMenuItemCreate_Click(object sender, EventArgs e)
        {
            if (tabUsersAndRewards.SelectedIndex == 0)
            {
                CreateUser();
                DisplayUsers();
            }
            else
            {
                CreateReward();
                DisplayRewards();
            }
        }

        private void ContextMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (tabUsersAndRewards.SelectedIndex == 0)
            {
                EditUser();
                DisplayUsers();
            }
            else
            {
                EditReward();
                DisplayRewards();
                DisplayUsers();
            }
        }

        private void ContextMenuItemRemove_Click(object sender, EventArgs e)
        {
            if (tabUsersAndRewards.SelectedIndex == 0)
            {
                RemoveUser();
                DisplayUsers();
            }
            else
            {
                RemoveReward();
                DisplayRewards();
                DisplayUsers();
            }
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUsers.DataSource = null;

            switch (e.ColumnIndex)
            {
                case 0:
                    dgvUsers.DataSource = _usersBL.GetList().OrderBy(u => u.Id).ToList();
                    break;
                case 1:
                    dgvUsers.DataSource = _usersBL.GetList().OrderBy(u => u.FirstName).ToList();
                    break;
                case 2:
                    dgvUsers.DataSource = _usersBL.GetList().OrderBy(u => u.LastName).ToList();
                    break;
                case 3:
                    dgvUsers.DataSource = _usersBL.GetList().OrderBy(u => u.DateBirthday).ToList();
                    break;
                case 4:
                    dgvUsers.DataSource = _usersBL.GetList().OrderBy(u => u.Age).ToList();
                    break;
                default:
                    dgvUsers.DataSource = _usersBL.GetList().OrderBy(u => u.Id).ToList();
                    break;
            }
        }
    }
}
