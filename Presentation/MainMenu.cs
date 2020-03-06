using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что выйдете из системы?", "Предупреждение",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName + "," + UserLoginCache.LastName;
            lblPhone.Text = UserLoginCache.phone;
            lblEmail.Text = UserLoginCache.Email;

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadUserData();
            ManagerPermission();
        }
        private void ManagerPermission()
        {
            if (UserLoginCache.Position == Positions.Client)
            {
                gunaAdvenceButton13.Enabled = false;
            }
        }
    }
}
