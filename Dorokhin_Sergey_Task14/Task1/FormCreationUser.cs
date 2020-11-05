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
        private readonly ErrorProvider _errorProvider;
        private readonly User _user;
        private readonly bool isCreateUser;

        public FormCreationUser()
        {
            InitializeComponent();

            _errorProvider = new ErrorProvider();
            isCreateUser = true;
        }


        public FormCreationUser(User user)
        {
            InitializeComponent();

            _errorProvider = new ErrorProvider();
            isCreateUser = false;
            _user = user;
        }

        private bool ValidateFirstName()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || txtFirstName.Text.Length < 3 || txtFirstName.Text.Length > 50)
            {
                _errorProvider.SetError(txtFirstName, "Неверные данные");
                return false;
            }

            _errorProvider.SetError(txtFirstName, string.Empty);
            return (FirstName = txtFirstName.Text) == txtFirstName.Text;
        }

        private bool ValidateLastName()
        {
            if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text.Length < 3 || txtLastName.Text.Length > 50)
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
                if (birthDay < DateTime.Now && (DateTime.Now.Year - birthDay.Year) < 150)
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
            }
            else
            {
                btnCreate.Text = "Редактировать";
                this.Text = "Редактирование пользователя";

                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtBirthDay.Text = _user.BirthDay.ToString("dd.MM.yyyy");
            }
        }
    }
}
