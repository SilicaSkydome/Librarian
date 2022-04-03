
namespace Librarian.forms
{
    partial class Catalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.Catalog_Label = new System.Windows.Forms.Label();
            this.catalogPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.catalogSearchPanel = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.searchYear = new System.Windows.Forms.RadioButton();
            this.searchGenre = new System.Windows.Forms.RadioButton();
            this.searchName = new System.Windows.Forms.RadioButton();
            this.searchAuthor = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.catalogSearch = new System.Windows.Forms.TextBox();
            this.catalogView = new System.Windows.Forms.DataGridView();
            this.catalogPanel.SuspendLayout();
            this.catalogSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogView)).BeginInit();
            this.SuspendLayout();
            // 
            // Catalog_Label
            // 
            this.Catalog_Label.AutoSize = true;
            this.Catalog_Label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Catalog_Label.ForeColor = System.Drawing.Color.White;
            this.Catalog_Label.Location = new System.Drawing.Point(12, 9);
            this.Catalog_Label.Name = "Catalog_Label";
            this.Catalog_Label.Size = new System.Drawing.Size(94, 20);
            this.Catalog_Label.TabIndex = 0;
            this.Catalog_Label.Text = "Catalog";
            // 
            // catalogPanel
            // 
            this.catalogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.catalogPanel.Controls.Add(this.panel1);
            this.catalogPanel.Controls.Add(this.Catalog_Label);
            this.catalogPanel.Location = new System.Drawing.Point(0, 0);
            this.catalogPanel.Margin = new System.Windows.Forms.Padding(0);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(1040, 40);
            this.catalogPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 60);
            this.panel1.TabIndex = 2;
            // 
            // catalogSearchPanel
            // 
            this.catalogSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catalogSearchPanel.Controls.Add(this.buttonEdit);
            this.catalogSearchPanel.Controls.Add(this.buttonAdd);
            this.catalogSearchPanel.Controls.Add(this.searchYear);
            this.catalogSearchPanel.Controls.Add(this.searchGenre);
            this.catalogSearchPanel.Controls.Add(this.searchName);
            this.catalogSearchPanel.Controls.Add(this.searchAuthor);
            this.catalogSearchPanel.Controls.Add(this.buttonSearch);
            this.catalogSearchPanel.Controls.Add(this.catalogSearch);
            this.catalogSearchPanel.Location = new System.Drawing.Point(0, 40);
            this.catalogSearchPanel.Name = "catalogSearchPanel";
            this.catalogSearchPanel.Size = new System.Drawing.Size(1040, 60);
            this.catalogSearchPanel.TabIndex = 2;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(882, 12);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(68, 33);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(962, 12);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 33);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            // catalogSearch
            // 
            this.catalogSearch.Location = new System.Drawing.Point(11, 12);
            this.catalogSearch.Name = "catalogSearch";
            this.catalogSearch.Size = new System.Drawing.Size(292, 20);
            this.catalogSearch.TabIndex = 0;
            // 
            // catalogView
            // 
            this.catalogView.AllowUserToAddRows = false;
            this.catalogView.AllowUserToDeleteRows = false;
            this.catalogView.AllowUserToResizeColumns = false;
            this.catalogView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.catalogView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.catalogView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catalogView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catalogView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.catalogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catalogView.DefaultCellStyle = dataGridViewCellStyle3;
            this.catalogView.GridColor = System.Drawing.Color.White;
            this.catalogView.Location = new System.Drawing.Point(0, 100);
            this.catalogView.Margin = new System.Windows.Forms.Padding(0);
            this.catalogView.Name = "catalogView";
            this.catalogView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catalogView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.catalogView.RowHeadersWidth = 80;
            this.catalogView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.catalogView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.catalogView.RowTemplate.ReadOnly = true;
            this.catalogView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.catalogView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.catalogView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catalogView.Size = new System.Drawing.Size(1040, 395);
            this.catalogView.TabIndex = 3;
            this.catalogView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalogView_CellClick);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 495);
            this.Controls.Add(this.catalogView);
            this.Controls.Add(this.catalogSearchPanel);
            this.Controls.Add(this.catalogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.catalogPanel.ResumeLayout(false);
            this.catalogPanel.PerformLayout();
            this.catalogSearchPanel.ResumeLayout(false);
            this.catalogSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Catalog_Label;
        private System.Windows.Forms.Panel catalogPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel catalogSearchPanel;
        private System.Windows.Forms.RadioButton searchYear;
        private System.Windows.Forms.RadioButton searchGenre;
        private System.Windows.Forms.RadioButton searchName;
        private System.Windows.Forms.RadioButton searchAuthor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox catalogSearch;
        private System.Windows.Forms.DataGridView catalogView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
    }
}