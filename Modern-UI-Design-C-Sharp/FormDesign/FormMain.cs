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

namespace Modern_UI_Design_C_Sharp.FormDesign
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Padding borderNormal = new Padding(2);
        private Padding borderMaximized = new Padding(2, 9, 2, 2);
        public FormMain()
        {
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(0, 0, 0);

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonNormal_Click(object sender, EventArgs e)
        {
            NormalAction();
        }

        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonPlus_Click(object sender, EventArgs e)
        {
            MaximizedAction();
        }

        private void MoveWindows_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.Padding = borderMaximized;
                }
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.Padding = borderNormal;
                }
                return;
            }
            base.WndProc(ref m);
        }

        private void MaximizedAction()
        {
            this.WindowState = FormWindowState.Maximized;
            iconButtonNormal.Visible = true;
            iconButtonPlus.Visible = false;
            this.Padding = borderMaximized;
        }
        private void NormalAction()
        {
            iconButtonNormal.Visible = false;
            iconButtonPlus.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Padding = borderNormal;
        }



    }
}
