
namespace Librarian.forms
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.catalogPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Orders_Label = new System.Windows.Forms.Label();
            this.catalogSearchPanel = new System.Windows.Forms.Panel();
            this.searchYear = new System.Windows.Forms.RadioButton();
            this.searchGenre = new System.Windows.Forms.RadioButton();
            this.searchName = new System.Windows.Forms.RadioButton();
            this.searchAuthor = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.orderSearch = new System.Windows.Forms.TextBox();
            this.orderView = new System.Windows.Forms.DataGridView();
            this.orderName = new System.Windows.Forms.Label();
            this.orderLogin = new System.Windows.Forms.Label();
            this.orderCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.catalogPanel.SuspendLayout();
            this.catalogSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogPanel
            // 
            this.catalogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.catalogPanel.Controls.Add(this.panel1);
            this.catalogPanel.Controls.Add(this.Orders_Label);
            this.catalogPanel.Location = new System.Drawing.Point(0, 0);
            this.catalogPanel.Margin = new System.Windows.Forms.Padding(0);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(1040, 40);
            this.catalogPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 60);
            this.panel1.TabIndex = 2;
            // 
            // Orders_Label
            // 
            this.Orders_Label.AutoSize = true;
            this.Orders_Label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Orders_Label.ForeColor = System.Drawing.Color.White;
            this.Orders_Label.Location = new System.Drawing.Point(12, 9);
            this.Orders_Label.Name = "Orders_Label";
            this.Orders_Label.Size = new System.Drawing.Size(84, 20);
            this.Orders_Label.TabIndex = 0;
            this.Orders_Label.Text = "Orders";
            // 
            // catalogSearchPanel
            // 
            this.catalogSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catalogSearchPanel.Controls.Add(this.searchYear);
            this.catalogSearchPanel.Controls.Add(this.searchGenre);
            this.catalogSearchPanel.Controls.Add(this.searchName);
            this.catalogSearchPanel.Controls.Add(this.searchAuthor);
            this.catalogSearchPanel.Controls.Add(this.buttonSearch);
            this.catalogSearchPanel.Controls.Add(this.orderSearch);
            this.catalogSearchPanel.Location = new System.Drawing.Point(441, 40);
            this.catalogSearchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.catalogSearchPanel.Name = "catalogSearchPanel";
            this.catalogSearchPanel.Size = new System.Drawing.Size(599, 60);
            this.catalogSearchPanel.TabIndex = 3;
            // 
            // searchYear
            // 
            this.searchYear.AutoSize = true;
            this.searchYear.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchYear.Location = new System.Drawing.Point(243, 36);
            this.searchYear.Name = "searchYear";
            this.searchYear.Size = new System.Drawing.Size(60, 19);
            this.searchYear.TabIndex = 5;
            this.searchYear.Text = "Year";
            this.searchYear.UseVisualStyleBackColor = true;
            // 
            // searchGenre
            // 
            this.searchGenre.AutoSize = true;
            this.searchGenre.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGenre.Location = new System.Drawing.Point(166, 36);
            this.searchGenre.Name = "searchGenre";
            this.searchGenre.Size = new System.Drawing.Size(71, 19);
            this.searchGenre.TabIndex = 4;
            this.searchGenre.Text = "Genre";
            this.searchGenre.UseVisualStyleBackColor = true;
            // 
            // searchName
            // 
            this.searchName.AutoSize = true;
            this.searchName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName.Location = new System.Drawing.Point(96, 36);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(64, 19);
            this.searchName.TabIndex = 3;
            this.searchName.Text = "Name";
            this.searchName.UseVisualStyleBackColor = true;
            // 
            // searchAuthor
            // 
            this.searchAuthor.AutoSize = true;
            this.searchAuthor.Checked = true;
            this.searchAuthor.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAuthor.Location = new System.Drawing.Point(11, 36);
            this.searchAuthor.Name = "searchAuthor";
            this.searchAuthor.Size = new System.Drawing.Size(79, 19);
            this.searchAuthor.TabIndex = 2;
            this.searchAuthor.TabStop = true;
            this.searchAuthor.Text = "Author";
            this.searchAuthor.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(315, 8);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 33);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // orderSearch
            // 
            this.orderSearch.Location = new System.Drawing.Point(11, 12);
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.Size = new System.Drawing.Size(292, 20);
            this.orderSearch.TabIndex = 0;
            // 
            // orderView
            // 
            this.orderView.AllowUserToAddRows = false;
            this.orderView.AllowUserToDeleteRows = false;
            this.orderView.AllowUserToOrderColumns = true;
            this.orderView.AllowUserToResizeColumns = false;
            this.orderView.AllowUserToResizeRows = false;
            this.orderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Location = new System.Drawing.Point(441, 99);
            this.orderView.Margin = new System.Windows.Forms.Padding(0);
            this.orderView.Name = "orderView";
            this.orderView.ReadOnly = true;
            this.orderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderView.Size = new System.Drawing.Size(599, 399);
            this.orderView.TabIndex = 4;
            this.orderView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderView_CellClick);
            // 
            // orderName
            // 
            this.orderName.AutoSize = true;
            this.orderName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderName.Location = new System.Drawing.Point(107, 140);
            this.orderName.Name = "orderName";
            this.orderName.Size = new System.Drawing.Size(102, 38);
            this.orderName.TabIndex = 5;
            this.orderName.Text = "Name";
            // 
            // orderLogin
            // 
            this.orderLogin.AutoSize = true;
            this.orderLogin.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLogin.Location = new System.Drawing.Point(107, 215);
            this.orderLogin.Name = "orderLogin";
            this.orderLogin.Size = new System.Drawing.Size(96, 38);
            this.orderLogin.TabIndex = 6;
            this.orderLogin.Text = "Login";
            // 
            // orderCreate
            // 
            this.orderCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.orderCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderCreate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCreate.ForeColor = System.Drawing.Color.White;
            this.orderCreate.Location = new System.Drawing.Point(114, 295);
            this.orderCreate.Margin = new System.Windows.Forms.Padding(0);
            this.orderCreate.Name = "orderCreate";
            this.orderCreate.Size = new System.Drawing.Size(192, 66);
            this.orderCreate.TabIndex = 7;
            this.orderCreate.Text = "Place Order";
            this.orderCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.orderCreate.UseVisualStyleBackColor = false;
            this.orderCreate.Click += new System.EventHandler(this.orderCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(245, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Book:";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderCreate);
            this.Controls.Add(this.orderLogin);
            this.Controls.Add(this.orderName);
            this.Controls.Add(this.orderView);
            this.Controls.Add(this.catalogSearchPanel);
            this.Controls.Add(this.catalogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.catalogPanel.ResumeLayout(false);
            this.catalogPanel.PerformLayout();
            this.catalogSearchPanel.ResumeLayout(false);
            this.catalogSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel catalogPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Orders_Label;
        private System.Windows.Forms.Panel catalogSearchPanel;
        private System.Windows.Forms.RadioButton searchYear;
        private System.Windows.Forms.RadioButton searchGenre;
        private System.Windows.Forms.RadioButton searchName;
        private System.Windows.Forms.RadioButton searchAuthor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox orderSearch;
        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.Label orderName;
        private System.Windows.Forms.Label orderLogin;
        private System.Windows.Forms.Button orderCreate;
        private System.Windows.Forms.Label label1;
    }
}