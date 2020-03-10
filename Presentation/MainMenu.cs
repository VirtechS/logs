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
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
            //lblPhone.Text = UserLoginCache.phone;
            //lblEmail.Text = UserLoginCache.Email;

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
                gunaGradientTileButton1.Enabled = false;
            }
        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что выйдете из системы?", "Предупреждение",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnroll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaShadowPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
