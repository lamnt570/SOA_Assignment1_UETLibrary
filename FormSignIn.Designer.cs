namespace Client
{
	partial class FormSignIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonSignIn = new System.Windows.Forms.Button();
			this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
			this.labelSignInFail = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(165, 204);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(172, 20);
			this.textBoxUserName.TabIndex = 0;
			this.textBoxUserName.Enter += new System.EventHandler(this.textBoxEmail_Enter);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(165, 241);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '•';
			this.textBoxPassword.Size = new System.Drawing.Size(172, 20);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(97, 205);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(84, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Client.Properties.Resources.UETLib_Logo;
			this.pictureBox1.Location = new System.Drawing.Point(58, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(301, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// buttonSignIn
			// 
			this.buttonSignIn.Location = new System.Drawing.Point(171, 292);
			this.buttonSignIn.Name = "buttonSignIn";
			this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
			this.buttonSignIn.TabIndex = 2;
			this.buttonSignIn.Text = "Sign In";
			this.buttonSignIn.UseVisualStyleBackColor = true;
			this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
			// 
			// linkLabelSignUp
			// 
			this.linkLabelSignUp.AutoSize = true;
			this.linkLabelSignUp.Location = new System.Drawing.Point(157, 338);
			this.linkLabelSignUp.Name = "linkLabelSignUp";
			this.linkLabelSignUp.Size = new System.Drawing.Size(103, 13);
			this.linkLabelSignUp.TabIndex = 6;
			this.linkLabelSignUp.TabStop = true;
			this.linkLabelSignUp.Text = "Create new account";
			this.linkLabelSignUp.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
			// 
			// labelSignInFail
			// 
			this.labelSignInFail.AutoSize = true;
			this.labelSignInFail.ForeColor = System.Drawing.Color.Red;
			this.labelSignInFail.Location = new System.Drawing.Point(146, 272);
			this.labelSignInFail.Name = "labelSignInFail";
			this.labelSignInFail.Size = new System.Drawing.Size(129, 13);
			this.labelSignInFail.TabIndex = 3;
			this.labelSignInFail.Text = "Wrong password or email!";
			this.labelSignInFail.Visible = false;
			// 
			// FormSignIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 363);
			this.Controls.Add(this.linkLabelSignUp);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelSignInFail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.buttonSignIn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormSignIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UET Library";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonSignIn;
		private System.Windows.Forms.LinkLabel linkLabelSignUp;
		private System.Windows.Forms.Label labelSignInFail;
	}
}