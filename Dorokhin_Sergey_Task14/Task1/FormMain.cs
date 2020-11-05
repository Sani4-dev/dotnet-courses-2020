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
            _users.Add(new User("Den", "Sidorov", new System.DateTime(1900, 1, 5)));
            _users.Add(new User("Ivan", "Ivanov", new System.DateTime(1997, 3, 12)));
            _users.Add(new User("Maxim", "Petrov", new System.DateTime(2003, 9, 27)));
        }

        private void InitRewards()
        {
            _rewards.Add(new Reward("Премия Дарвина", "Без описания"));
        }

        private void CreateUser()
        {
            var formCreationUser = new FormCreationUser();

            formCreationUser.ShowDialog(this);

            if (formCreationUser.DialogResult == DialogResult.OK)
            {
                _users.Add(new User(formCreationUser.FirstName, formCreationUser.LastName, formCreationUser.BirthDay));
            }
        }

        private void EditUser()
        {
            if (ctlUsers.SelectedCells.Count > 0)
            {
                User user = (User)ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;

                var formEditingUser = new FormCreationUser(user);

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

                var formSureDelete = new FormSureDelete();

                formSureDelete.ShowDialog(this);

                if (formSureDelete.DialogResult == DialogResult.OK)
                {
                    _users.Remove(user);
                }
            }
        }

        private void MenuItemCreateUser_Click(object sender, System.EventArgs e)
        {
            CreateUser();
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
            EditUser();
        }

        private void MenuItemDeleteUser_Click(object sender, System.EventArgs e)
        {
            DeleteUser();
        }

        private void ContextMenuItemCreateUser_Click(object sender, System.EventArgs e)
        {
            CreateUser();
        }

        private void contextMenuItemEditUser_Click(object sender, System.EventArgs e)
        {
            EditUser();
        }

        private void ctlUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex > -1) || (e.Button == MouseButtons.Right))
                ctlUsers.CurrentCell = ctlUsers[e.ColumnIndex, e.RowIndex];
        }

        private void contextMenuItemDeleteUser_Click(object sender, System.EventArgs e)
        {
            DeleteUser();
        }
    }
}
