namespace Presentation
{
    partial class FormRecoveryPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecoveryPassword));
            this.Panel1 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnroll = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.gunaGradientTileButton5 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.Panel1.Controls.Add(this.pictureBox3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(250, 308);
            this.Panel1.TabIndex = 12;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(59, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnsend.FlatAppearance.BorderSize = 0;
            this.btnsend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.ForeColor = System.Drawing.Color.LightGray;
            this.btnsend.Location = new System.Drawing.Point(291, 256);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(477, 40);
            this.btnsend.TabIndex = 16;
            this.btnsend.Text = "Отправить";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Gilroy ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(313, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(331, 33);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Восстановление пароля";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.Location = new System.Drawing.Point(336, 42);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(289, 18);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Введите имя пользователя или почту:";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.BackColor = System.Drawing.Color.White;
            this.txtUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserRequest.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserRequest.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserRequest.Location = new System.Drawing.Point(291, 115);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.Size = new System.Drawing.Size(477, 19);
            this.txtUserRequest.TabIndex = 21;
            this.txtUserRequest.Text = "Логин или почта";
            this.txtUserRequest.Enter += new System.EventHandler(this.txtUserRequest_Enter);
            this.txtUserRequest.Leave += new System.EventHandler(this.txtUserRequest_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(797, 308);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 291;
            this.lineShape2.X2 = 767;
            this.lineShape2.Y1 = 140;
            this.lineShape2.Y2 = 140;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(3, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 18);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Результат";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Location = new System.Drawing.Point(287, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 87);
            this.panel2.TabIndex = 24;
            // 
            // btnroll
            // 
            this.btnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnroll.Image")));
            this.btnroll.Location = new System.Drawing.Point(705, 3);
            this.btnroll.Name = "btnroll";
            this.btnroll.Size = new System.Drawing.Size(37, 33);
            this.btnroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnroll.TabIndex = 26;
            this.btnroll.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(748, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(37, 33);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexit.TabIndex = 25;
            this.btnexit.TabStop = false;
            // 
            // gunaGradientTileButton5
            // 
            this.gunaGradientTileButton5.Animated = true;
            this.gunaGradientTileButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton5.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton5.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton5.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton5.ForeColor = System.Drawing.Color.Gray;
            this.gunaGradientTileButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton5.Image")));
            this.gunaGradientTileButton5.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton5.Location = new System.Drawing.Point(650, 0);
            this.gunaGradientTileButton5.Name = "gunaGradientTileButton5";
            this.gunaGradientTileButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton5.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton5.OnHoverImage")));
            this.gunaGradientTileButton5.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton5.Radius = 6;
            this.gunaGradientTileButton5.Size = new System.Drawing.Size(60, 60);
            this.gunaGradientTileButton5.TabIndex = 27;
            this.gunaGradientTileButton5.Text = "Logout";
            this.gunaGradientTileButton5.Click += new System.EventHandler(this.gunaGradientTileButton5_Click);
            // 
            // FormRecoveryPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 308);
            this.Controls.Add(this.btnroll);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUserRequest);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaGradientTileButton5);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecoveryPassword";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecoveryPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRecoveryPassword_MouseDown);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnsend;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.TextBox txtUserRequest;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Guna.UI.WinForms.GunaLabel lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnroll;
        private System.Windows.Forms.PictureBox btnexit;
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton5;
    }
}