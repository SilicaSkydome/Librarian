
namespace Librarian.forms
{
    partial class MakeRequest
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
            this.profilePanel = new System.Windows.Forms.Panel();
            this.Make_Request = new System.Windows.Forms.Label();
            this.requestName = new System.Windows.Forms.TextBox();
            this.requestAuthor = new System.Windows.Forms.TextBox();
            this.requestDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requestMake = new System.Windows.Forms.Button();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.profilePanel.Controls.Add(this.Make_Request);
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1040, 40);
            this.profilePanel.TabIndex = 1;
            // 
            // Make_Request
            // 
            this.Make_Request.AutoSize = true;
            this.Make_Request.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Make_Request.ForeColor = System.Drawing.Color.White;
            this.Make_Request.Location = new System.Drawing.Point(12, 9);
            this.Make_Request.Name = "Make_Request";
            this.Make_Request.Size = new System.Drawing.Size(152, 20);
            this.Make_Request.TabIndex = 0;
            this.Make_Request.Text = "Make Request";
            // 
            // requestName
            // 
            this.requestName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestName.Location = new System.Drawing.Point(76, 132);
            this.requestName.Name = "requestName";
            this.requestName.Size = new System.Drawing.Size(176, 46);
            this.requestName.TabIndex = 2;
            // 
            // requestAuthor
            // 
            this.requestAuthor.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestAuthor.Location = new System.Drawing.Point(76, 242);
            this.requestAuthor.Name = "requestAuthor";
            this.requestAuthor.Size = new System.Drawing.Size(176, 46);
            this.requestAuthor.TabIndex = 3;
            // 
            // requestDescription
            // 
            this.requestDescription.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestDescription.Location = new System.Drawing.Point(347, 123);
            this.requestDescription.Multiline = true;
            this.requestDescription.Name = "requestDescription";
            this.requestDescription.Size = new System.Drawing.Size(644, 323);
            this.requestDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // requestMake
            // 
            this.requestMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.requestMake.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.requestMake.ForeColor = System.Drawing.Color.White;
            this.requestMake.Location = new System.Drawing.Point(76, 347);
            this.requestMake.Name = "requestMake";
            this.requestMake.Size = new System.Drawing.Size(176, 60);
            this.requestMake.TabIndex = 10;
            this.requestMake.Text = "Make Request";
            this.requestMake.UseVisualStyleBackColor = false;
            this.requestMake.Click += new System.EventHandler(this.requestMake_Click);
            // 
            // MakeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 495);
            this.Controls.Add(this.requestMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestDescription);
            this.Controls.Add(this.requestAuthor);
            this.Controls.Add(this.requestName);
            this.Controls.Add(this.profilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeRequest";
            this.Text = "MakeRequest";
            this.Load += new System.EventHandler(this.MakeRequest_Load);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label Make_Request;
        private System.Windows.Forms.TextBox requestName;
        private System.Windows.Forms.TextBox requestAuthor;
        private System.Windows.Forms.TextBox requestDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button requestMake;
    }
}