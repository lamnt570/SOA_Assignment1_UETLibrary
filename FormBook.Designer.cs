namespace Client
{
	partial class FormBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelErrorName = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.textBoxAuthor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labelErrorPublishYear = new System.Windows.Forms.Label();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.textBoxPublishYear = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.textBoxPublisher = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.labelErrorPageNum = new System.Windows.Forms.Label();
			this.labelPageNum = new System.Windows.Forms.Label();
			this.textBoxPageNum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelErrorCategory = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.textBoxCategory = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labelISBN = new System.Windows.Forms.Label();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.pictureBookCover = new System.Windows.Forms.PictureBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.linkLabelChangeCover = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBookCover)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(3, 23);
			this.textBoxName.Multiline = true;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxName.Size = new System.Drawing.Size(300, 40);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.Visible = false;
			this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 26);
			this.labelName.MaximumSize = new System.Drawing.Size(300, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(63, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Book Name";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.labelErrorName);
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.textBoxName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(11, 3);
			this.panel1.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(306, 66);
			this.panel1.TabIndex = 0;
			// 
			// labelErrorName
			// 
			this.labelErrorName.AutoSize = true;
			this.labelErrorName.ForeColor = System.Drawing.Color.Red;
			this.labelErrorName.Location = new System.Drawing.Point(54, 7);
			this.labelErrorName.Name = "labelErrorName";
			this.labelErrorName.Size = new System.Drawing.Size(115, 13);
			this.labelErrorName.TabIndex = 3;
			this.labelErrorName.Text = "Book name is required!";
			this.labelErrorName.Visible = false;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.labelAuthor);
			this.panel2.Controls.Add(this.textBoxAuthor);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(11, 72);
			this.panel2.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(306, 66);
			this.panel2.TabIndex = 1;
			// 
			// labelAuthor
			// 
			this.labelAuthor.AutoSize = true;
			this.labelAuthor.Location = new System.Drawing.Point(3, 26);
			this.labelAuthor.MaximumSize = new System.Drawing.Size(300, 0);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(38, 13);
			this.labelAuthor.TabIndex = 1;
			this.labelAuthor.Text = "Author";
			// 
			// textBoxAuthor
			// 
			this.textBoxAuthor.Location = new System.Drawing.Point(3, 23);
			this.textBoxAuthor.Multiline = true;
			this.textBoxAuthor.Name = "textBoxAuthor";
			this.textBoxAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxAuthor.Size = new System.Drawing.Size(300, 40);
			this.textBoxAuthor.TabIndex = 0;
			this.textBoxAuthor.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Author";
			// 
			// panelInfo
			// 
			this.panelInfo.AutoScroll = true;
			this.panelInfo.Controls.Add(this.panel1);
			this.panelInfo.Controls.Add(this.panel7);
			this.panelInfo.Controls.Add(this.panel8);
			this.panelInfo.Controls.Add(this.panel6);
			this.panelInfo.Controls.Add(this.panel5);
			this.panelInfo.Controls.Add(this.panel3);
			this.panelInfo.Controls.Add(this.panel4);
			this.panelInfo.Controls.Add(this.panel2);
			this.panelInfo.Location = new System.Drawing.Point(318, 12);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(338, 400);
			this.panelInfo.TabIndex = 3;
			// 
			// panel7
			// 
			this.panel7.AutoSize = true;
			this.panel7.Controls.Add(this.labelErrorPublishYear);
			this.panel7.Controls.Add(this.labelPublishYear);
			this.panel7.Controls.Add(this.textBoxPublishYear);
			this.panel7.Controls.Add(this.label7);
			this.panel7.Location = new System.Drawing.Point(11, 337);
			this.panel7.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(306, 48);
			this.panel7.TabIndex = 5;
			// 
			// labelErrorPublishYear
			// 
			this.labelErrorPublishYear.AutoSize = true;
			this.labelErrorPublishYear.ForeColor = System.Drawing.Color.Red;
			this.labelErrorPublishYear.Location = new System.Drawing.Point(97, 7);
			this.labelErrorPublishYear.Name = "labelErrorPublishYear";
			this.labelErrorPublishYear.Size = new System.Drawing.Size(63, 13);
			this.labelErrorPublishYear.TabIndex = 2;
			this.labelErrorPublishYear.Text = "Invalid Year";
			this.labelErrorPublishYear.Visible = false;
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.AutoSize = true;
			this.labelPublishYear.Location = new System.Drawing.Point(3, 26);
			this.labelPublishYear.MaximumSize = new System.Drawing.Size(300, 15);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(31, 13);
			this.labelPublishYear.TabIndex = 1;
			this.labelPublishYear.Text = "2015";
			// 
			// textBoxPublishYear
			// 
			this.textBoxPublishYear.Location = new System.Drawing.Point(3, 23);
			this.textBoxPublishYear.Name = "textBoxPublishYear";
			this.textBoxPublishYear.Size = new System.Drawing.Size(300, 20);
			this.textBoxPublishYear.TabIndex = 0;
			this.textBoxPublishYear.Visible = false;
			this.textBoxPublishYear.Enter += new System.EventHandler(this.textBoxPublishYear_Enter);
			this.textBoxPublishYear.Leave += new System.EventHandler(this.textBoxPublishYear_Leave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "Publish Year";
			// 
			// panel8
			// 
			this.panel8.AutoSize = true;
			this.panel8.Controls.Add(this.labelDescription);
			this.panel8.Controls.Add(this.textBoxDescription);
			this.panel8.Controls.Add(this.label8);
			this.panel8.Location = new System.Drawing.Point(11, 386);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(306, 146);
			this.panel8.TabIndex = 6;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(3, 26);
			this.labelDescription.MaximumSize = new System.Drawing.Size(300, 0);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(60, 13);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Description";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(3, 23);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxDescription.Size = new System.Drawing.Size(300, 120);
			this.textBoxDescription.TabIndex = 0;
			this.textBoxDescription.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 15);
			this.label8.TabIndex = 2;
			this.label8.Text = "Description";
			// 
			// panel6
			// 
			this.panel6.AutoSize = true;
			this.panel6.Controls.Add(this.labelPublisher);
			this.panel6.Controls.Add(this.textBoxPublisher);
			this.panel6.Controls.Add(this.label6);
			this.panel6.Location = new System.Drawing.Point(11, 288);
			this.panel6.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(306, 48);
			this.panel6.TabIndex = 4;
			// 
			// labelPublisher
			// 
			this.labelPublisher.AutoSize = true;
			this.labelPublisher.Location = new System.Drawing.Point(3, 26);
			this.labelPublisher.MaximumSize = new System.Drawing.Size(300, 15);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(50, 13);
			this.labelPublisher.TabIndex = 1;
			this.labelPublisher.Text = "Publisher";
			// 
			// textBoxPublisher
			// 
			this.textBoxPublisher.Location = new System.Drawing.Point(3, 23);
			this.textBoxPublisher.Name = "textBoxPublisher";
			this.textBoxPublisher.Size = new System.Drawing.Size(300, 20);
			this.textBoxPublisher.TabIndex = 0;
			this.textBoxPublisher.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "Publisher";
			// 
			// panel5
			// 
			this.panel5.AutoSize = true;
			this.panel5.Controls.Add(this.labelErrorPageNum);
			this.panel5.Controls.Add(this.labelPageNum);
			this.panel5.Controls.Add(this.textBoxPageNum);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Location = new System.Drawing.Point(11, 239);
			this.panel5.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(306, 48);
			this.panel5.TabIndex = 3;
			// 
			// labelErrorPageNum
			// 
			this.labelErrorPageNum.AutoSize = true;
			this.labelErrorPageNum.ForeColor = System.Drawing.Color.Red;
			this.labelErrorPageNum.Location = new System.Drawing.Point(92, 7);
			this.labelErrorPageNum.Name = "labelErrorPageNum";
			this.labelErrorPageNum.Size = new System.Drawing.Size(103, 13);
			this.labelErrorPageNum.TabIndex = 2;
			this.labelErrorPageNum.Text = "Invalid page number";
			this.labelErrorPageNum.Visible = false;
			// 
			// labelPageNum
			// 
			this.labelPageNum.AutoSize = true;
			this.labelPageNum.Location = new System.Drawing.Point(3, 26);
			this.labelPageNum.MaximumSize = new System.Drawing.Size(300, 15);
			this.labelPageNum.Name = "labelPageNum";
			this.labelPageNum.Size = new System.Drawing.Size(25, 13);
			this.labelPageNum.TabIndex = 1;
			this.labelPageNum.Text = "123";
			// 
			// textBoxPageNum
			// 
			this.textBoxPageNum.Location = new System.Drawing.Point(3, 23);
			this.textBoxPageNum.Name = "textBoxPageNum";
			this.textBoxPageNum.Size = new System.Drawing.Size(300, 20);
			this.textBoxPageNum.TabIndex = 0;
			this.textBoxPageNum.Visible = false;
			this.textBoxPageNum.Enter += new System.EventHandler(this.textBoxPageNum_Enter);
			this.textBoxPageNum.Leave += new System.EventHandler(this.textBoxPageNum_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Total Pages";
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.Controls.Add(this.labelErrorCategory);
			this.panel3.Controls.Add(this.labelCategory);
			this.panel3.Controls.Add(this.textBoxCategory);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new System.Drawing.Point(11, 141);
			this.panel3.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(306, 48);
			this.panel3.TabIndex = 2;
			// 
			// labelErrorCategory
			// 
			this.labelErrorCategory.AutoSize = true;
			this.labelErrorCategory.ForeColor = System.Drawing.Color.Red;
			this.labelErrorCategory.Location = new System.Drawing.Point(72, 7);
			this.labelErrorCategory.Name = "labelErrorCategory";
			this.labelErrorCategory.Size = new System.Drawing.Size(103, 13);
			this.labelErrorCategory.TabIndex = 3;
			this.labelErrorCategory.Text = "Category is required!";
			this.labelErrorCategory.Visible = false;
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(3, 26);
			this.labelCategory.MaximumSize = new System.Drawing.Size(300, 15);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(49, 13);
			this.labelCategory.TabIndex = 1;
			this.labelCategory.Text = "Category";
			// 
			// textBoxCategory
			// 
			this.textBoxCategory.Location = new System.Drawing.Point(3, 23);
			this.textBoxCategory.Name = "textBoxCategory";
			this.textBoxCategory.Size = new System.Drawing.Size(300, 20);
			this.textBoxCategory.TabIndex = 0;
			this.textBoxCategory.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 15);
			this.label9.TabIndex = 2;
			this.label9.Text = "Category";
			// 
			// panel4
			// 
			this.panel4.AutoSize = true;
			this.panel4.Controls.Add(this.labelISBN);
			this.panel4.Controls.Add(this.textBoxISBN);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(11, 190);
			this.panel4.MaximumSize = new System.Drawing.Size(0, 70);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(306, 48);
			this.panel4.TabIndex = 2;
			// 
			// labelISBN
			// 
			this.labelISBN.AutoSize = true;
			this.labelISBN.Location = new System.Drawing.Point(3, 26);
			this.labelISBN.MaximumSize = new System.Drawing.Size(300, 15);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(32, 13);
			this.labelISBN.TabIndex = 1;
			this.labelISBN.Text = "ISBN";
			// 
			// textBoxISBN
			// 
			this.textBoxISBN.Location = new System.Drawing.Point(3, 23);
			this.textBoxISBN.Name = "textBoxISBN";
			this.textBoxISBN.Size = new System.Drawing.Size(300, 20);
			this.textBoxISBN.TabIndex = 0;
			this.textBoxISBN.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "ISBN";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Image = global::Client.Properties.Resources.delete_icon;
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDelete.Location = new System.Drawing.Point(581, 432);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 36);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Image = global::Client.Properties.Resources.save_icon;
			this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSave.Location = new System.Drawing.Point(208, 432);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 36);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Visible = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
			this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonEdit.Location = new System.Drawing.Point(293, 432);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 36);
			this.buttonEdit.TabIndex = 0;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// pictureBookCover
			// 
			this.pictureBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBookCover.ErrorImage = global::Client.Properties.Resources.default_cover;
			this.pictureBookCover.Image = global::Client.Properties.Resources.default_cover;
			this.pictureBookCover.InitialImage = global::Client.Properties.Resources.default_cover;
			this.pictureBookCover.Location = new System.Drawing.Point(12, 12);
			this.pictureBookCover.Name = "pictureBookCover";
			this.pictureBookCover.Size = new System.Drawing.Size(300, 400);
			this.pictureBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBookCover.TabIndex = 0;
			this.pictureBookCover.TabStop = false;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Image = global::Client.Properties.Resources.cancel_icon;
			this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCancel.Location = new System.Drawing.Point(377, 432);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 36);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Visible = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// linkLabelChangeCover
			// 
			this.linkLabelChangeCover.AutoSize = true;
			this.linkLabelChangeCover.Location = new System.Drawing.Point(9, 415);
			this.linkLabelChangeCover.Name = "linkLabelChangeCover";
			this.linkLabelChangeCover.Size = new System.Drawing.Size(74, 13);
			this.linkLabelChangeCover.TabIndex = 4;
			this.linkLabelChangeCover.TabStop = true;
			this.linkLabelChangeCover.Text = "Change cover";
			this.linkLabelChangeCover.Visible = false;
			this.linkLabelChangeCover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangeCover_LinkClicked);
			// 
			// FormBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 480);
			this.Controls.Add(this.linkLabelChangeCover);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.pictureBookCover);
			this.Controls.Add(this.panelInfo);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBook_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBook_FormClosed);
			this.Load += new System.EventHandler(this.FormBook_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelInfo.ResumeLayout(false);
			this.panelInfo.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBookCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBookCover;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.TextBox textBoxAuthor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelInfo;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label labelISBN;
		private System.Windows.Forms.TextBox textBoxISBN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label labelPageNum;
		private System.Windows.Forms.TextBox textBoxPageNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.TextBox textBoxPublisher;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label labelPublishYear;
		private System.Windows.Forms.TextBox textBoxPublishYear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelErrorName;
		private System.Windows.Forms.Label labelErrorPageNum;
		private System.Windows.Forms.Label labelErrorPublishYear;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.TextBox textBoxCategory;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelErrorCategory;
		private System.Windows.Forms.LinkLabel linkLabelChangeCover;
	}
}