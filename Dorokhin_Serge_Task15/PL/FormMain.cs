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
using DAL;

namespace PL
{
    public partial class FormMain : Form
    {
        private UsersBL _usersBL = new UsersBL();
        private RewardsBL _rewardsBL = new RewardsBL();

        public FormMain()
        {
            InitializeComponent();

            _usersBL.Init();
            DisplayUsers();
            _rewardsBL.Init();
            DisplayRewards();
        }

        private void ConfigureDgvUsers()
        {
            this.dgvUsers.Columns[0].HeaderText = "Идентификатор";
            this.dgvUsers.Columns[1].HeaderText = "Имя";
            this.dgvUsers.Columns[2].HeaderText = "Фмилия";
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
            }
        }


        private void CreateUser()
        {
            var formUser = new FormUser(_rewardsBL.GetList());

            if (formUser.ShowDialog(this) == DialogResult.OK)
            {
                _usersBL.Add(new User(formUser.FirstName, formUser.LastName, formUser.DateBirthday, formUser.Rewards));
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
                }
            }
        }

        private void RemoveUser()
        {
            if (dgvUsers.Rows.Count > 0)
            {
                var formSureRemove = new FormSureRemove(DeletingItem.User);

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
                _rewardsBL.Add(new Reward(formReward.Title, formReward.Description));
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
                }
            }
        }

        private void RemoveReward()
        {
            if (dgvRewards.Rows.Count > 0)
            {
                var formSureRemove = new FormSureRemove(DeletingItem.Rewrad);

                if (formSureRemove.ShowDialog(this) == DialogResult.OK)
                {
                    Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;

                    _rewardsBL.Remove(reward);

                    foreach (var user in _usersBL.GetList())
                    {
                        foreach (var rew in user.Rewards)
                        {
                            if (rew == reward)
                            {
                                user.Rewards.Remove(reward);
                                break;
                            }
                        }
                    }
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
            }
        }
    }
}
