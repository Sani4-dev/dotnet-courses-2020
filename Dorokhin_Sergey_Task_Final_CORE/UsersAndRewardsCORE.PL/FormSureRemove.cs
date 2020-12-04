using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewardsCORE.PL
{
    public partial class FormSureRemove : Form
    {
        public FormSureRemove(string questionWhenDeletingSomething)
        {
            InitializeComponent();
            
            labelQuestion.Text = questionWhenDeletingSomething;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
