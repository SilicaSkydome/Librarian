
namespace Librarian.forms
{
    public partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.profilePanel = new System.Windows.Forms.Panel();
            this.Profile_Label = new System.Windows.Forms.Label();
            this.Profile_Name = new System.Windows.Forms.Label();
            this.Profile_Login = new System.Windows.Forms.Label();
            this.profilePassword = new System.Windows.Forms.Label();
            this.profileStatus = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.Profile_Change = new System.Windows.Forms.Button();
            this.profileHistory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.profilePanel.Controls.Add(this.Profile_Label);
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1040, 40);
            this.profilePanel.TabIndex = 0;
            // 
            // Profile_Label
            // 
            this.Profile_Label.AutoSize = true;
            this.Profile_Label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Profile_Label.ForeColor = System.Drawing.Color.White;
            this.Profile_Label.Location = new System.Drawing.Point(12, 9);
            this.Profile_Label.Name = "Profile_Label";
            this.Profile_Label.Size = new System.Drawing.Size(86, 20);
            this.Profile_Label.TabIndex = 0;
            this.Profile_Label.Text = "Profile";
            // 
            // Profile_Name
            // 
            this.Profile_Name.AutoSize = true;
            this.Profile_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_Name.Location = new System.Drawing.Point(19, 83);
            this.Profile_Name.Name = "Profile_Name";
            this.Profile_Name.Size = new System.Drawing.Size(57, 22);
            this.Profile_Name.TabIndex = 1;
            this.Profile_Name.Text = "Имя: ";
            // 
            // Profile_Login
            // 
            this.Profile_Login.AutoSize = true;
            this.Profile_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Profile_Login.Location = new System.Drawing.Point(19, 127);
            this.Profile_Login.Name = "Profile_Login";
            this.Profile_Login.Size = new System.Drawing.Size(80, 22);
            this.Profile_Login.TabIndex = 2;
            this.Profile_Login.Text = "Логин:  ";
            // 
            // profilePassword
            // 
            this.profilePassword.AutoSize = true;
            this.profilePassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.profilePassword.Location = new System.Drawing.Point(19, 176);
            this.profilePassword.Name = "profilePassword";
            this.profilePassword.Size = new System.Drawing.Size(85, 22);
            this.profilePassword.TabIndex = 3;
            this.profilePassword.Text = "Пароль: ";
            // 
            // profileStatus
            // 
            this.profileStatus.AutoSize = true;
            this.profileStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.profileStatus.Location = new System.Drawing.Point(19, 217);
            this.profileStatus.Name = "profileStatus";
            this.profileStatus.Size = new System.Drawing.Size(79, 22);
            this.profileStatus.TabIndex = 4;
            this.profileStatus.Text = "Статус: ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(173, 85);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 5;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(173, 130);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(100, 20);
            this.textLogin.TabIndex = 6;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(173, 178);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 7;
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(173, 220);
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(100, 20);
            this.textStatus.TabIndex = 8;
            // 
            // Profile_Change
            // 
            this.Profile_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Profile_Change.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Profile_Change.ForeColor = System.Drawing.Color.White;
            this.Profile_Change.Location = new System.Drawing.Point(83, 279);
            this.Profile_Change.Name = "Profile_Change";
            this.Profile_Change.Size = new System.Drawing.Size(140, 46);
            this.Profile_Change.TabIndex = 9;
            this.Profile_Change.Text = "Изменить";
            this.Profile_Change.UseVisualStyleBackColor = false;
            this.Profile_Change.Click += new System.EventHandler(this.Profile_Change_Click);
            this.Profile_Change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profile_Change_MouseDown);
            this.Profile_Change.MouseEnter += new System.EventHandler(this.Profile_Change_MouseEnter);
            this.Profile_Change.MouseLeave += new System.EventHandler(this.Profile_Change_MouseLeave);
            this.Profile_Change.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Profile_Change_MouseUp);
            // 
            // profileHistory
            // 
            this.profileHistory.AllowUserToAddRows = false;
            this.profileHistory.AllowUserToDeleteRows = false;
            this.profileHistory.AllowUserToResizeColumns = false;
            this.profileHistory.AllowUserToResizeRows = false;
            this.profileHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profileHistory.BackgroundColor = System.Drawing.Color.White;
            this.profileHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileHistory.GridColor = System.Drawing.Color.White;
            this.profileHistory.Location = new System.Drawing.Point(406, 114);
            this.profileHistory.Margin = new System.Windows.Forms.Padding(0);
            this.profileHistory.Name = "profileHistory";
            this.profileHistory.ReadOnly = true;
            this.profileHistory.Size = new System.Drawing.Size(573, 322);
            this.profileHistory.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(406, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 40);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order History";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileHistory);
            this.Controls.Add(this.Profile_Change);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.profileStatus);
            this.Controls.Add(this.profilePassword);
            this.Controls.Add(this.Profile_Login);
            this.Controls.Add(this.Profile_Name);
            this.Controls.Add(this.profilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label Profile_Label;
        private System.Windows.Forms.Label Profile_Name;
        private System.Windows.Forms.Label Profile_Login;
        private System.Windows.Forms.Label profilePassword;
        private System.Windows.Forms.Label profileStatus;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Button Profile_Change;
        private System.Windows.Forms.DataGridView profileHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}