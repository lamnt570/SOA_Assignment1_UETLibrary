namespace Client
{
	partial class FormMainPage
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
			this.dataGridViewBookPreview = new System.Windows.Forms.DataGridView();
			this.cover = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceBookPreview = new System.Windows.Forms.BindingSource(this.components);
			this.buttonNextPage = new System.Windows.Forms.Button();
			this.buttonPrevPage = new System.Windows.Forms.Button();
			this.labelPageCur = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.linkSignOut = new System.Windows.Forms.LinkLabel();
			this.labelUserName = new System.Windows.Forms.Label();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxPageCur = new System.Windows.Forms.TextBox();
			this.labelPageNum = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBookPreview)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewBookPreview
			// 
			this.dataGridViewBookPreview.AllowUserToAddRows = false;
			this.dataGridViewBookPreview.AllowUserToDeleteRows = false;
			this.dataGridViewBookPreview.AllowUserToResizeColumns = false;
			this.dataGridViewBookPreview.AllowUserToResizeRows = false;
			this.dataGridViewBookPreview.AutoGenerateColumns = false;
			this.dataGridViewBookPreview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewBookPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewBookPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewBookPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cover,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dataGridViewBookPreview.DataSource = this.bindingSourceBookPreview;
			this.dataGridViewBookPreview.Location = new System.Drawing.Point(44, 100);
			this.dataGridViewBookPreview.MultiSelect = false;
			this.dataGridViewBookPreview.Name = "dataGridViewBookPreview";
			this.dataGridViewBookPreview.ReadOnly = true;
			this.dataGridViewBookPreview.RowHeadersVisible = false;
			this.dataGridViewBookPreview.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewBookPreview.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewBookPreview.RowTemplate.Height = 100;
			this.dataGridViewBookPreview.RowTemplate.ReadOnly = true;
			this.dataGridViewBookPreview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewBookPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewBookPreview.Size = new System.Drawing.Size(673, 425);
			this.dataGridViewBookPreview.TabIndex = 0;
			this.dataGridViewBookPreview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookPreview_CellDoubleClick);
			// 
			// cover
			// 
			this.cover.DataPropertyName = "cover";
			this.cover.HeaderText = "Cover";
			this.cover.Image = global::Client.Properties.Resources.default_cover;
			this.cover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.cover.Name = "cover";
			this.cover.ReadOnly = true;
			this.cover.Width = 80;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn1.HeaderText = "Book Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 330;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "author";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn2.HeaderText = "Author";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 160;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "year";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn3.HeaderText = "Publish Year";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// bindingSourceBookPreview
			// 
			this.bindingSourceBookPreview.DataSource = typeof(Client.Model.BookPreview);
			// 
			// buttonNextPage
			// 
			this.buttonNextPage.Enabled = false;
			this.buttonNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNextPage.Location = new System.Drawing.Point(167, 5);
			this.buttonNextPage.Name = "buttonNextPage";
			this.buttonNextPage.Size = new System.Drawing.Size(36, 23);
			this.buttonNextPage.TabIndex = 1;
			this.buttonNextPage.Text = ">";
			this.buttonNextPage.UseVisualStyleBackColor = true;
			this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
			// 
			// buttonPrevPage
			// 
			this.buttonPrevPage.Enabled = false;
			this.buttonPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPrevPage.Location = new System.Drawing.Point(3, 5);
			this.buttonPrevPage.Name = "buttonPrevPage";
			this.buttonPrevPage.Size = new System.Drawing.Size(36, 23);
			this.buttonPrevPage.TabIndex = 0;
			this.buttonPrevPage.Text = "<";
			this.buttonPrevPage.UseVisualStyleBackColor = true;
			this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
			// 
			// labelPageCur
			// 
			this.labelPageCur.AutoSize = true;
			this.labelPageCur.Location = new System.Drawing.Point(55, 10);
			this.labelPageCur.Name = "labelPageCur";
			this.labelPageCur.Size = new System.Drawing.Size(32, 13);
			this.labelPageCur.TabIndex = 3;
			this.labelPageCur.Text = "Page";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.linkSignOut);
			this.panel1.Controls.Add(this.labelUserName);
			this.panel1.Controls.Add(this.pictureBoxAvatar);
			this.panel1.Location = new System.Drawing.Point(553, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(164, 42);
			this.panel1.TabIndex = 6;
			// 
			// linkSignOut
			// 
			this.linkSignOut.AutoSize = true;
			this.linkSignOut.Location = new System.Drawing.Point(45, 26);
			this.linkSignOut.Name = "linkSignOut";
			this.linkSignOut.Size = new System.Drawing.Size(46, 13);
			this.linkSignOut.TabIndex = 0;
			this.linkSignOut.TabStop = true;
			this.linkSignOut.Text = "Sign out";
			this.linkSignOut.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignOut_LinkClicked);
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUserName.Location = new System.Drawing.Point(45, 3);
			this.labelUserName.MaximumSize = new System.Drawing.Size(100, 15);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(68, 15);
			this.labelUserName.TabIndex = 1;
			this.labelUserName.Text = "User name";
			this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.ErrorImage = global::Client.Properties.Resources.default_avatar;
			this.pictureBoxAvatar.Image = global::Client.Properties.Resources.default_avatar;
			this.pictureBoxAvatar.InitialImage = global::Client.Properties.Resources.default_avatar;
			this.pictureBoxAvatar.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(36, 36);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAvatar.TabIndex = 0;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Search book";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(116, 69);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(420, 20);
			this.textBoxSearch.TabIndex = 2;
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(642, 67);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.buttonDelete);
			this.panel2.Controls.Add(this.buttonEdit);
			this.panel2.Controls.Add(this.buttonAdd);
			this.panel2.Location = new System.Drawing.Point(44, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(308, 42);
			this.panel2.TabIndex = 1;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Image = global::Client.Properties.Resources.delete_icon;
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDelete.Location = new System.Drawing.Point(229, 3);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 36);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
			this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonEdit.Location = new System.Drawing.Point(116, 3);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 36);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAdd.Location = new System.Drawing.Point(3, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 36);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxPageCur
			// 
			this.textBoxPageCur.Location = new System.Drawing.Point(91, 7);
			this.textBoxPageCur.Name = "textBoxPageCur";
			this.textBoxPageCur.Size = new System.Drawing.Size(26, 20);
			this.textBoxPageCur.TabIndex = 2;
			this.textBoxPageCur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPageCur_KeyPress);
			// 
			// labelPageNum
			// 
			this.labelPageNum.AutoSize = true;
			this.labelPageNum.Location = new System.Drawing.Point(120, 10);
			this.labelPageNum.Name = "labelPageNum";
			this.labelPageNum.Size = new System.Drawing.Size(33, 13);
			this.labelPageNum.TabIndex = 4;
			this.labelPageNum.Text = "/ 123";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.buttonPrevPage);
			this.panel3.Controls.Add(this.labelPageNum);
			this.panel3.Controls.Add(this.textBoxPageCur);
			this.panel3.Controls.Add(this.buttonNextPage);
			this.panel3.Controls.Add(this.labelPageCur);
			this.panel3.Location = new System.Drawing.Point(277, 531);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(206, 32);
			this.panel3.TabIndex = 5;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(554, 67);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 3;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// FormMainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 570);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridViewBookPreview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMainPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UET Library";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainPage_FormClosing);
			this.Load += new System.EventHandler(this.FormMainPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBookPreview)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewBookPreview;
		private System.Windows.Forms.BindingSource bindingSourceBookPreview;
		private System.Windows.Forms.Button buttonNextPage;
		private System.Windows.Forms.Button buttonPrevPage;
		private System.Windows.Forms.Label labelPageCur;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.TextBox textBoxPageCur;
		private System.Windows.Forms.Label labelPageNum;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.LinkLabel linkSignOut;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridViewImageColumn cover;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}

