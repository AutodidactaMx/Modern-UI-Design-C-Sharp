namespace Modern_UI_Design_C_Sharp
{
    partial class FormMaster
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.PanelFormBar = new System.Windows.Forms.Panel();
            this.PanelFormAction = new System.Windows.Forms.Panel();
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonPlus = new FontAwesome.Sharp.IconButton();
            this.iconButtonNormal = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.ContentFormPanel = new System.Windows.Forms.Panel();
            this.PanelContentMain = new System.Windows.Forms.Panel();
            this.PanelFormBar.SuspendLayout();
            this.PanelFormAction.SuspendLayout();
            this.PanelContentMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormBar
            // 
            this.PanelFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.PanelFormBar.Controls.Add(this.PanelFormAction);
            resources.ApplyResources(this.PanelFormBar, "PanelFormBar");
            this.PanelFormBar.Name = "PanelFormBar";
            this.PanelFormBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // PanelFormAction
            // 
            this.PanelFormAction.Controls.Add(this.iconButtonMinus);
            this.PanelFormAction.Controls.Add(this.iconButtonPlus);
            this.PanelFormAction.Controls.Add(this.iconButtonNormal);
            this.PanelFormAction.Controls.Add(this.iconButtonClose);
            resources.ApplyResources(this.PanelFormAction, "PanelFormAction");
            this.PanelFormAction.Name = "PanelFormAction";
            // 
            // iconButtonMinus
            // 
            resources.ApplyResources(this.iconButtonMinus, "iconButtonMinus");
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(59)))));
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonMinus.IconSize = 25;
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.UseMnemonic = false;
            this.iconButtonMinus.UseVisualStyleBackColor = true;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            // 
            // iconButtonPlus
            // 
            resources.ApplyResources(this.iconButtonPlus, "iconButtonPlus");
            this.iconButtonPlus.FlatAppearance.BorderSize = 0;
            this.iconButtonPlus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonPlus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(58)))));
            this.iconButtonPlus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonPlus.IconSize = 25;
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.UseMnemonic = false;
            this.iconButtonPlus.UseVisualStyleBackColor = true;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonPlus_Click);
            // 
            // iconButtonNormal
            // 
            resources.ApplyResources(this.iconButtonNormal, "iconButtonNormal");
            this.iconButtonNormal.FlatAppearance.BorderSize = 0;
            this.iconButtonNormal.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonNormal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(58)))));
            this.iconButtonNormal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonNormal.IconSize = 25;
            this.iconButtonNormal.Name = "iconButtonNormal";
            this.iconButtonNormal.UseMnemonic = false;
            this.iconButtonNormal.UseVisualStyleBackColor = true;
            this.iconButtonNormal.Click += new System.EventHandler(this.iconButtonNormal_Click);
            // 
            // iconButtonClose
            // 
            resources.ApplyResources(this.iconButtonClose, "iconButtonClose");
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonClose.IconSize = 25;
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.UseMnemonic = false;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // ContentFormPanel
            // 
            this.ContentFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            resources.ApplyResources(this.ContentFormPanel, "ContentFormPanel");
            this.ContentFormPanel.Name = "ContentFormPanel";
            // 
            // PanelContentMain
            // 
            this.PanelContentMain.Controls.Add(this.ContentFormPanel);
            this.PanelContentMain.Controls.Add(this.PanelFormBar);
            resources.ApplyResources(this.PanelContentMain, "PanelContentMain");
            this.PanelContentMain.Name = "PanelContentMain";
            // 
            // FormMaster
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContentMain);
            this.Name = "FormMaster";
            this.Opacity = 0.95D;
            this.PanelFormBar.ResumeLayout(false);
            this.PanelFormAction.ResumeLayout(false);
            this.PanelContentMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormBar;
        private System.Windows.Forms.Panel ContentFormPanel;
        private System.Windows.Forms.Panel PanelFormAction;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonPlus;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonNormal;
        private System.Windows.Forms.Panel PanelContentMain;
    }
}

