using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class FormRecoveryPassword : Form
    {
        public FormRecoveryPassword()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblResult.Text = result;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnroll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserRequest_Enter(object sender, EventArgs e)
        {
            if (txtUserRequest.Text == "Логин или почта")
            {
                txtUserRequest.Text = "";
                txtUserRequest.ForeColor = Color.DimGray;
            }
        }

        private void txtUserRequest_Leave(object sender, EventArgs e)
        {
            if (txtUserRequest.Text == "")
            {
                txtUserRequest.Text = "Логин или почта";
                txtUserRequest.ForeColor = Color.DimGray;
            }
        }

        private void FormRecoveryPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
