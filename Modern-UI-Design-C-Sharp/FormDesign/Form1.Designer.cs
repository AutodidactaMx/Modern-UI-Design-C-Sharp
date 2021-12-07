namespace Modern_UI_Design_C_Sharp.FormDesign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelSlideMenu = new System.Windows.Forms.Panel();
            this.PanelSlideMenuImage = new System.Windows.Forms.Panel();
            this.PanelSubMenuCatalogo = new System.Windows.Forms.Panel();
            this.PanelNav = new System.Windows.Forms.Panel();
            this.PanelNavTitle = new System.Windows.Forms.Panel();
            this.iconSettings = new FontAwesome.Sharp.IconButton();
            this.iconInfo = new FontAwesome.Sharp.IconButton();
            this.iconPicture = new FontAwesome.Sharp.IconButton();
            this.iconProfile = new FontAwesome.Sharp.IconButton();
            this.iconDashboard = new FontAwesome.Sharp.IconButton();
            this.PictureBoxImg = new System.Windows.Forms.PictureBox();
            this.iconBar = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelSlideMenu.SuspendLayout();
            this.PanelSlideMenuImage.SuspendLayout();
            this.PanelSubMenuCatalogo.SuspendLayout();
            this.PanelNav.SuspendLayout();
            this.PanelNavTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImg)).BeginInit();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSlideMenu
            // 
            this.PanelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.PanelSlideMenu.Controls.Add(this.iconSettings);
            this.PanelSlideMenu.Controls.Add(this.PanelSubMenuCatalogo);
            this.PanelSlideMenu.Controls.Add(this.iconProfile);
            this.PanelSlideMenu.Controls.Add(this.iconDashboard);
            this.PanelSlideMenu.Controls.Add(this.PanelSlideMenuImage);
            this.PanelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlideMenu.Location = new System.Drawing.Point(0, 46);
            this.PanelSlideMenu.Name = "PanelSlideMenu";
            this.PanelSlideMenu.Size = new System.Drawing.Size(170, 589);
            this.PanelSlideMenu.TabIndex = 0;
            // 
            // PanelSlideMenuImage
            // 
            this.PanelSlideMenuImage.Controls.Add(this.PictureBoxImg);
            this.PanelSlideMenuImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSlideMenuImage.Location = new System.Drawing.Point(0, 0);
            this.PanelSlideMenuImage.Name = "PanelSlideMenuImage";
            this.PanelSlideMenuImage.Size = new System.Drawing.Size(170, 134);
            this.PanelSlideMenuImage.TabIndex = 1;
            // 
            // PanelSubMenuCatalogo
            // 
            this.PanelSubMenuCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.PanelSubMenuCatalogo.Controls.Add(this.iconInfo);
            this.PanelSubMenuCatalogo.Controls.Add(this.iconPicture);
            this.PanelSubMenuCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuCatalogo.Location = new System.Drawing.Point(0, 212);
            this.PanelSubMenuCatalogo.Name = "PanelSubMenuCatalogo";
            this.PanelSubMenuCatalogo.Size = new System.Drawing.Size(170, 84);
            this.PanelSubMenuCatalogo.TabIndex = 4;
            // 
            // PanelNav
            // 
            this.PanelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.PanelNav.Controls.Add(this.iconButton1);
            this.PanelNav.Controls.Add(this.iconBar);
            this.PanelNav.Controls.Add(this.PanelNavTitle);
            this.PanelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNav.Location = new System.Drawing.Point(0, 0);
            this.PanelNav.Name = "PanelNav";
            this.PanelNav.Size = new System.Drawing.Size(973, 46);
            this.PanelNav.TabIndex = 1;
            this.PanelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindowsMouseDown);
            // 
            // PanelNavTitle
            // 
            this.PanelNavTitle.Controls.Add(this.labelTitle);
            this.PanelNavTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelNavTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelNavTitle.Name = "PanelNavTitle";
            this.PanelNavTitle.Size = new System.Drawing.Size(177, 46);
            this.PanelNavTitle.TabIndex = 0;
            // 
            // iconSettings
            // 
            this.iconSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconSettings.FlatAppearance.BorderSize = 0;
            this.iconSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSettings.ForeColor = System.Drawing.Color.White;
            this.iconSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconSettings.IconColor = System.Drawing.Color.White;
            this.iconSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSettings.IconSize = 30;
            this.iconSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSettings.Location = new System.Drawing.Point(0, 296);
            this.iconSettings.Margin = new System.Windows.Forms.Padding(0);
            this.iconSettings.Name = "iconSettings";
            this.iconSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconSettings.Size = new System.Drawing.Size(170, 39);
            this.iconSettings.TabIndex = 6;
            this.iconSettings.Text = "           Settings";
            this.iconSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSettings.UseVisualStyleBackColor = true;
            // 
            // iconInfo
            // 
            this.iconInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconInfo.FlatAppearance.BorderSize = 0;
            this.iconInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconInfo.ForeColor = System.Drawing.Color.White;
            this.iconInfo.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconInfo.IconColor = System.Drawing.Color.White;
            this.iconInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInfo.IconSize = 25;
            this.iconInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconInfo.Location = new System.Drawing.Point(0, 39);
            this.iconInfo.Margin = new System.Windows.Forms.Padding(0);
            this.iconInfo.Name = "iconInfo";
            this.iconInfo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.iconInfo.Size = new System.Drawing.Size(170, 39);
            this.iconInfo.TabIndex = 4;
            this.iconInfo.Text = "           Info";
            this.iconInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconInfo.UseVisualStyleBackColor = true;
            // 
            // iconPicture
            // 
            this.iconPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPicture.FlatAppearance.BorderSize = 0;
            this.iconPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPicture.ForeColor = System.Drawing.Color.White;
            this.iconPicture.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPicture.IconColor = System.Drawing.Color.White;
            this.iconPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicture.IconSize = 25;
            this.iconPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPicture.Location = new System.Drawing.Point(0, 0);
            this.iconPicture.Margin = new System.Windows.Forms.Padding(0);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.iconPicture.Size = new System.Drawing.Size(170, 39);
            this.iconPicture.TabIndex = 3;
            this.iconPicture.Text = "           Picture";
            this.iconPicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPicture.UseVisualStyleBackColor = true;
            // 
            // iconProfile
            // 
            this.iconProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconProfile.FlatAppearance.BorderSize = 0;
            this.iconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProfile.ForeColor = System.Drawing.Color.White;
            this.iconProfile.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconProfile.IconColor = System.Drawing.Color.White;
            this.iconProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProfile.IconSize = 30;
            this.iconProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.Location = new System.Drawing.Point(0, 173);
            this.iconProfile.Margin = new System.Windows.Forms.Padding(0);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconProfile.Size = new System.Drawing.Size(170, 39);
            this.iconProfile.TabIndex = 3;
            this.iconProfile.Text = "           Profile";
            this.iconProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.UseVisualStyleBackColor = true;
            this.iconProfile.Click += new System.EventHandler(this.iconProfile_Click);
            // 
            // iconDashboard
            // 
            this.iconDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDashboard.FlatAppearance.BorderSize = 0;
            this.iconDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDashboard.ForeColor = System.Drawing.Color.White;
            this.iconDashboard.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.iconDashboard.IconColor = System.Drawing.Color.White;
            this.iconDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDashboard.IconSize = 30;
            this.iconDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDashboard.Location = new System.Drawing.Point(0, 134);
            this.iconDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.iconDashboard.Name = "iconDashboard";
            this.iconDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconDashboard.Size = new System.Drawing.Size(170, 39);
            this.iconDashboard.TabIndex = 2;
            this.iconDashboard.Text = "           Dashboard";
            this.iconDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDashboard.UseVisualStyleBackColor = true;
            // 
            // PictureBoxImg
            // 
            this.PictureBoxImg.Image = global::Modern_UI_Design_C_Sharp.Properties.Resources.Perfil;
            this.PictureBoxImg.Location = new System.Drawing.Point(37, 15);
            this.PictureBoxImg.Name = "PictureBoxImg";
            this.PictureBoxImg.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxImg.TabIndex = 1;
            this.PictureBoxImg.TabStop = false;
            // 
            // iconBar
            // 
            this.iconBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBar.FlatAppearance.BorderSize = 0;
            this.iconBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBar.ForeColor = System.Drawing.Color.White;
            this.iconBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconBar.IconColor = System.Drawing.Color.White;
            this.iconBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBar.IconSize = 30;
            this.iconBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBar.Location = new System.Drawing.Point(177, 0);
            this.iconBar.Margin = new System.Windows.Forms.Padding(0);
            this.iconBar.Name = "iconBar";
            this.iconBar.Size = new System.Drawing.Size(37, 46);
            this.iconBar.TabIndex = 3;
            this.iconBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBar.UseVisualStyleBackColor = true;
            this.iconBar.Click += new System.EventHandler(this.iconBar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(156, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Autodidacta MX";
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.PictureLogo);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(170, 46);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(803, 589);
            this.PanelContent.TabIndex = 2;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::Modern_UI_Design_C_Sharp.Properties.Resources.Autodidacta_cuadro;
            this.PictureLogo.Location = new System.Drawing.Point(289, 173);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(240, 199);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(936, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 46);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 635);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelSlideMenu);
            this.Controls.Add(this.PanelNav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelSlideMenu.ResumeLayout(false);
            this.PanelSlideMenuImage.ResumeLayout(false);
            this.PanelSubMenuCatalogo.ResumeLayout(false);
            this.PanelNav.ResumeLayout(false);
            this.PanelNavTitle.ResumeLayout(false);
            this.PanelNavTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImg)).EndInit();
            this.PanelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSlideMenu;
        private System.Windows.Forms.Panel PanelSlideMenuImage;
        private FontAwesome.Sharp.IconButton iconSettings;
        private System.Windows.Forms.Panel PanelSubMenuCatalogo;
        private FontAwesome.Sharp.IconButton iconInfo;
        private FontAwesome.Sharp.IconButton iconPicture;
        private FontAwesome.Sharp.IconButton iconProfile;
        private FontAwesome.Sharp.IconButton iconDashboard;
        private System.Windows.Forms.PictureBox PictureBoxImg;
        private System.Windows.Forms.Panel PanelNav;
        private System.Windows.Forms.Panel PanelNavTitle;
        private FontAwesome.Sharp.IconButton iconBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.PictureBox PictureLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}