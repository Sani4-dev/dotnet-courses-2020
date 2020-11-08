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
    public partial class FormSureDelete : Form
    {
        public FormSureDelete(Caller caller)
        {
            InitializeComponent();

            if (caller == Caller.User)
            {
                labelSureDelete.Text = "Вы уверены, что хотите удалить пользователя";
            }
            else
            {
                labelSureDelete.Text = "Вы уверены, что хотите удалить награду";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
