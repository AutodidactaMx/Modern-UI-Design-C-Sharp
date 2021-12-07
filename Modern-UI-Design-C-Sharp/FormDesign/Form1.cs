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
    public partial class Form1 : Form
    {
        private const int widthSlide = 170;
        private const int widthSlideIcon = 45;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
            InitializeSetting();
        }
        public void InitializeSetting() {
            this.FormBorderStyle = FormBorderStyle.None;
            HideSubMenus();
        }
        private void HideSubMenus() {
            PanelSubMenuCatalogo.Visible = false;
        }

        private void MoveWindowsMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void iconBar_Click(object sender, EventArgs e)
        {
            if (PanelSlideMenu.Width != widthSlideIcon)
            {
                PanelSlideMenu.Width = widthSlideIcon;
                HideSubMenus();
                PanelSlideMenuImage.Visible = false;
            }
            else
            {
                PanelSlideMenu.Width = widthSlide;
                PanelSlideMenuImage.Visible = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconProfile_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelSubMenuCatalogo);            
        }
    }
}
