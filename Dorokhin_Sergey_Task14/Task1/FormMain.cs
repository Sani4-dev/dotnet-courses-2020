using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormMain : Form
    {
        private BindingList<User> _users;
        private BindingList<Reward> _rewards;

        public FormMain()
        {
            InitializeComponent();

            _users = new BindingList<User>();
            _rewards = new BindingList<Reward>();

            InitUsers();
            InitRewards();

            ctlUsers.DataSource = _users;
            ctlUsers.Columns[0].HeaderText = "Идентификатор";
            ctlUsers.Columns[1].HeaderText = "Имя";
            ctlUsers.Columns[2].HeaderText = "Фамилия";
            ctlUsers.Columns[3].HeaderText = "Дата рождения";
            ctlUsers.Columns[4].HeaderText = "Возраст";
            ctlUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ctlUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ctlRewards.DataSource = _rewards;
            ctlRewards.Columns[0].HeaderText = "Идентификатор";
            ctlRewards.Columns[1].HeaderText = "Наименование";
            ctlRewards.Columns[2].HeaderText = "Описание";
            ctlRewards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ctlRewards.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitUsers()
        {
            _users.Add(new User("Den", "Sidorov", new System.DateTime(1900, 1, 5), new BindingList<Reward>()));
            _users.Add(new User("Ivan", "Ivanov", new System.DateTime(1997, 3, 12), new BindingList<Reward>()));
            _users.Add(new User("Maxim", "Petrov", new System.DateTime(2003, 9, 27), new BindingList<Reward>()));
        }

        private void InitRewards()
        {
            _rewards.Add(new Reward("Премия Дарвина", "Без описания"));
        }

        private void CreateUser()
        {
            var formCreationUser = new FormCreationUser(_rewards);

            formCreationUser.ShowDialog(this);

            if (formCreationUser.DialogResult == DialogResult.OK)
            {
                _users.Add(new User(formCreationUser.FirstName, formCreationUser.LastName, formCreationUser.BirthDay, 
                    formCreationUser.Rewards));
            }
        }

        private void EditUser()
        {
            if (ctlUsers.SelectedCells.Count > 0)
            {
                User user = (User)ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;

                var formEditingUser = new FormCreationUser(user, _rewards);

                formEditingUser.ShowDialog(this);

                if (formEditingUser.DialogResult == DialogResult.OK)
                {
                    user.FirstName = formEditingUser.FirstName;
                    user.LastName = formEditingUser.LastName;
                    user.BirthDay = formEditingUser.BirthDay;

                    ctlUsers.Refresh();
                }
            }
        }

        private void DeleteUser()
        {
            if (ctlUsers.SelectedCells.Count > 0)
            {
                User user = (User)ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;

                var formSureDelete = new FormSureDelete(Caller.User);

                formSureDelete.ShowDialog(this);

                if (formSureDelete.DialogResult == DialogResult.OK)
                {
                    _users.Remove(user);
                }
            }
        }

        private void CreateReward()
        {
            var formCreationReward = new FormCreationReward();

            formCreationReward.ShowDialog(this);

            if (formCreationReward.DialogResult == DialogResult.OK)
            {
                _rewards.Add(new Reward(formCreationReward.NameReward, formCreationReward.Description));
            }
        }

        private void EditReward()
        {
            if (ctlRewards.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)ctlRewards.SelectedCells[0].OwningRow.DataBoundItem;

                var formEditingReward = new FormCreationReward(reward);

                formEditingReward.ShowDialog(this);

                if (formEditingReward.DialogResult == DialogResult.OK)
                {
                    reward.Title = formEditingReward.NameReward;
                    reward.Description = formEditingReward.Description;

                    ctlRewards.Refresh();
                }
            }
        }

        private void DeleteReward()
        {
            if (ctlRewards.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)ctlRewards.SelectedCells[0].OwningRow.DataBoundItem;

                var formSureDelete = new FormSureDelete(Caller.Reward);

                formSureDelete.ShowDialog(this);

                if (formSureDelete.DialogResult == DialogResult.OK)
                {
                    _rewards.Remove(reward);

                    foreach (var user in _users)
                    {
                        if (user.IsRewardContains(reward))
                        {
                            user.RemoveReward(reward);
                        }
                    }
                }
            }
        }

        private void MenuItemCreateUser_Click(object sender, System.EventArgs e)
        {
            if (tabCtlSelect.SelectedIndex == 0)
            {
                CreateUser();
            }
            else 
            {
                CreateReward();
            }
        }

        private void ctlUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    _users = new BindingList<User>(_users.OrderBy(u => u.Id).ToList());
                    ctlUsers.DataSource = _users;
                    break;
                case 1:
                    _users = new BindingList<User>(_users.OrderBy(u => u.FirstName).ToList());
                    ctlUsers.DataSource = _users;
                    break;
                case 2:
                    _users = new BindingList<User>(_users.OrderBy(u => u.LastName).ToList());
                    ctlUsers.DataSource = _users;
                    break;
                case 3:
                    _users = new BindingList<User>(_users.OrderBy(u => u.BirthDay).ToList());
                    ctlUsers.DataSource = _users;
                    break;
                case 4:
                    _users = new BindingList<User>(_users.OrderBy(u => u.Age).ToList());
                    ctlUsers.DataSource = _users;
                    break;
                default:
                    _users = new BindingList<User>(_users.OrderBy(u => u.Id).ToList());
                    ctlUsers.DataSource = _users;
                    break;
            }
        }

        private void MenuItemEditUser_Click(object sender, System.EventArgs e)
        {
            if (tabCtlSelect.SelectedIndex == 0)
            {
                EditUser();
            }
            else
            {
                EditReward();
            }
        }

        private void MenuItemDeleteUser_Click(object sender, System.EventArgs e)
        {
            if (tabCtlSelect.SelectedIndex == 0)
            {
                DeleteUser();
            }
            else
            {
                DeleteReward();
            }
        }

        private void ContextMenuItemCreateUser_Click(object sender, System.EventArgs e)
        {
            if (tabCtlSelect.SelectedIndex == 0)
            {
                CreateUser();
            }
            else
            {
                CreateReward();
            }
        }

        private void contextMenuItemEditUser_Click(object sender, System.EventArgs e)
        {
            if (tabCtlSelect.SelectedIndex == 0)
            {
                EditUser();
            }
            else
            {
                EditReward();
            }
        }

        private void contextMenuItemDeleteUser_Click(object sender, System.EventArgs e)
        {
            if (tabCtlSelect.SelectedIndex == 0)
            {
                DeleteUser();
            }
            else
            {
                DeleteReward();
            }
        }

        private void ctlUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex > -1) || (e.Button == MouseButtons.Right))
            {
                ctlUsers.CurrentCell = ctlUsers[e.ColumnIndex, e.RowIndex];
            }
        }

        private void ctlRewards_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex > -1) || (e.Button == MouseButtons.Right))
            {
                ctlRewards.CurrentCell = ctlRewards[e.ColumnIndex, e.RowIndex];
            }
        }
    }
}
