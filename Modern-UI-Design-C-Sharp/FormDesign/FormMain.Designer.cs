namespace Modern_UI_Design_C_Sharp.FormDesign
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ContentFormPanel = new System.Windows.Forms.Panel();
            this.PanelFormBar = new System.Windows.Forms.Panel();
            this.PanelHeaderCaption = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelFormAction = new System.Windows.Forms.Panel();
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonPlus = new FontAwesome.Sharp.IconButton();
            this.iconButtonNormal = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.PictureIconForm = new System.Windows.Forms.PictureBox();
            this.PanelFormBar.SuspendLayout();
            this.PanelHeaderCaption.SuspendLayout();
            this.PanelFormAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconForm)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentFormPanel
            // 
            this.ContentFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ContentFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentFormPanel.Location = new System.Drawing.Point(0, 30);
            this.ContentFormPanel.Name = "ContentFormPanel";
            this.ContentFormPanel.Size = new System.Drawing.Size(800, 420);
            this.ContentFormPanel.TabIndex = 4;
            // 
            // PanelFormBar
            // 
            this.PanelFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.PanelFormBar.Controls.Add(this.PanelHeaderCaption);
            this.PanelFormBar.Controls.Add(this.PanelFormAction);
            this.PanelFormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFormBar.Location = new System.Drawing.Point(0, 0);
            this.PanelFormBar.Name = "PanelFormBar";
            this.PanelFormBar.Size = new System.Drawing.Size(800, 30);
            this.PanelFormBar.TabIndex = 3;
            this.PanelFormBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindows_MouseDown);
            // 
            // PanelHeaderCaption
            // 
            this.PanelHeaderCaption.Controls.Add(this.PictureIconForm);
            this.PanelHeaderCaption.Controls.Add(this.LabelTitle);
            this.PanelHeaderCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelHeaderCaption.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderCaption.Name = "PanelHeaderCaption";
            this.PanelHeaderCaption.Size = new System.Drawing.Size(146, 30);
            this.PanelHeaderCaption.TabIndex = 1;
            this.PanelHeaderCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindows_MouseDown);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTitle.Location = new System.Drawing.Point(35, 5);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(102, 20);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Autodidacta MX";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindows_MouseDown);
            // 
            // PanelFormAction
            // 
            this.PanelFormAction.Controls.Add(this.iconButtonMinus);
            this.PanelFormAction.Controls.Add(this.iconButtonPlus);
            this.PanelFormAction.Controls.Add(this.iconButtonNormal);
            this.PanelFormAction.Controls.Add(this.iconButtonClose);
            this.PanelFormAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFormAction.Location = new System.Drawing.Point(643, 0);
            this.PanelFormAction.Name = "PanelFormAction";
            this.PanelFormAction.Size = new System.Drawing.Size(157, 30);
            this.PanelFormAction.TabIndex = 0;
            this.PanelFormAction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindows_MouseDown);
            // 
            // iconButtonMinus
            // 
            this.iconButtonMinus.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(59)))));
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonMinus.IconSize = 25;
            this.iconButtonMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButtonMinus.Location = new System.Drawing.Point(9, 0);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Size = new System.Drawing.Size(37, 30);
            this.iconButtonMinus.TabIndex = 1;
            this.iconButtonMinus.UseMnemonic = false;
            this.iconButtonMinus.UseVisualStyleBackColor = true;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            // 
            // iconButtonPlus
            // 
            this.iconButtonPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonPlus.FlatAppearance.BorderSize = 0;
            this.iconButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPlus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonPlus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(58)))));
            this.iconButtonPlus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonPlus.IconSize = 25;
            this.iconButtonPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButtonPlus.Location = new System.Drawing.Point(46, 0);
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.Size = new System.Drawing.Size(37, 30);
            this.iconButtonPlus.TabIndex = 2;
            this.iconButtonPlus.UseMnemonic = false;
            this.iconButtonPlus.UseVisualStyleBackColor = true;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonPlus_Click);
            // 
            // iconButtonNormal
            // 
            this.iconButtonNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonNormal.FlatAppearance.BorderSize = 0;
            this.iconButtonNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNormal.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonNormal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(58)))));
            this.iconButtonNormal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonNormal.IconSize = 25;
            this.iconButtonNormal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButtonNormal.Location = new System.Drawing.Point(83, 0);
            this.iconButtonNormal.Name = "iconButtonNormal";
            this.iconButtonNormal.Size = new System.Drawing.Size(37, 30);
            this.iconButtonNormal.TabIndex = 3;
            this.iconButtonNormal.UseMnemonic = false;
            this.iconButtonNormal.UseVisualStyleBackColor = true;
            this.iconButtonNormal.Visible = false;
            this.iconButtonNormal.Click += new System.EventHandler(this.iconButtonNormal_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonClose.IconSize = 25;
            this.iconButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButtonClose.Location = new System.Drawing.Point(120, 0);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(37, 30);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.UseMnemonic = false;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // PictureIconForm
            // 
            this.PictureIconForm.BackgroundImage = global::Modern_UI_Design_C_Sharp.Properties.Resources.Autodidacta_cuadro;
            this.PictureIconForm.Image = ((System.Drawing.Image)(resources.GetObject("PictureIconForm.Image")));
            this.PictureIconForm.Location = new System.Drawing.Point(4, 2);
            this.PictureIconForm.Name = "PictureIconForm";
            this.PictureIconForm.Size = new System.Drawing.Size(25, 25);
            this.PictureIconForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureIconForm.TabIndex = 1;
            this.PictureIconForm.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentFormPanel);
            this.Controls.Add(this.PanelFormBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.PanelFormBar.ResumeLayout(false);
            this.PanelHeaderCaption.ResumeLayout(false);
            this.PanelHeaderCaption.PerformLayout();
            this.PanelFormAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureIconForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentFormPanel;
        private System.Windows.Forms.Panel PanelFormBar;
        private System.Windows.Forms.Panel PanelFormAction;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonPlus;
        private FontAwesome.Sharp.IconButton iconButtonNormal;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.Panel PanelHeaderCaption;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox PictureIconForm;
    }
}