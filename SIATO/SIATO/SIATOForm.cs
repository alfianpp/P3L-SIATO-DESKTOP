using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIATO
{
    public partial class SIATOForm : Form
    {
        private LoginForm _loginForm;
        private Pegawai logged_in_user;

        public SIATOForm(LoginForm _loginForm, Pegawai logged_in_user)
        {
            InitializeComponent();
            this._loginForm = _loginForm;
            this.logged_in_user = logged_in_user;
        }

        private void SIATOForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }
    }
}
