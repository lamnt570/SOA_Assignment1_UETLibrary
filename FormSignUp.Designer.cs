namespace Client
{
	partial class FormSignUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelErrorEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelErrorUsername = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labelErrorPassword = new System.Windows.Forms.Label();
			this.textBoxPassword2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonSignUp = new System.Windows.Forms.Button();
			this.labelSignUpFail = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Client.Properties.Resources.UETLib_Logo;
			this.pictureBox1.Location = new System.Drawing.Point(154, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(301, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelErrorEmail);
			this.panel1.Controls.Add(this.textBoxEmail);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(42, 208);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 49);
			this.panel1.TabIndex = 0;
			// 
			// labelErrorEmail
			// 
			this.labelErrorEmail.AutoSize = true;
			this.labelErrorEmail.ForeColor = System.Drawing.Color.Red;
			this.labelErrorEmail.Location = new System.Drawing.Point(109, 5);
			this.labelErrorEmail.Name = "labelErrorEmail";
			this.labelErrorEmail.Size = new System.Drawing.Size(105, 13);
			this.labelErrorEmail.TabIndex = 2;
			this.labelErrorEmail.Text = "Invalid email address";
			this.labelErrorEmail.Visible = false;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(6, 24);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(241, 20);
			this.textBoxEmail.TabIndex = 0;
			this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
			this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email Address";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelErrorUsername);
			this.panel2.Controls.Add(this.textBoxUserName);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(42, 263);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(251, 49);
			this.panel2.TabIndex = 1;
			// 
			// labelErrorUsername
			// 
			this.labelErrorUsername.AutoSize = true;
			this.labelErrorUsername.ForeColor = System.Drawing.Color.Red;
			this.labelErrorUsername.Location = new System.Drawing.Point(108, 6);
			this.labelErrorUsername.Name = "labelErrorUsername";
			this.labelErrorUsername.Size = new System.Drawing.Size(106, 13);
			this.labelErrorUsername.TabIndex = 2;
			this.labelErrorUsername.Text = "Username is required";
			this.labelErrorUsername.Visible = false;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(6, 24);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(241, 20);
			this.textBoxUserName.TabIndex = 0;
			this.textBoxUserName.Enter += new System.EventHandler(this.textBoxUserName_Enter);
			this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textBoxPassword);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(315, 208);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(251, 49);
			this.panel3.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(6, 24);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '•';
			this.textBoxPassword.Size = new System.Drawing.Size(241, 20);
			this.textBoxPassword.TabIndex = 0;
			this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Password";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.labelErrorPassword);
			this.panel4.Controls.Add(this.textBoxPassword2);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(315, 263);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(251, 49);
			this.panel4.TabIndex = 3;
			// 
			// labelErrorPassword
			// 
			this.labelErrorPassword.AutoSize = true;
			this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
			this.labelErrorPassword.Location = new System.Drawing.Point(124, 5);
			this.labelErrorPassword.Name = "labelErrorPassword";
			this.labelErrorPassword.Size = new System.Drawing.Size(129, 13);
			this.labelErrorPassword.TabIndex = 2;
			this.labelErrorPassword.Text = "Password dose not match";
			this.labelErrorPassword.Visible = false;
			// 
			// textBoxPassword2
			// 
			this.textBoxPassword2.Location = new System.Drawing.Point(6, 24);
			this.textBoxPassword2.Name = "textBoxPassword2";
			this.textBoxPassword2.PasswordChar = '•';
			this.textBoxPassword2.Size = new System.Drawing.Size(241, 20);
			this.textBoxPassword2.TabIndex = 0;
			this.textBoxPassword2.Enter += new System.EventHandler(this.textBoxPassword2_Enter);
			this.textBoxPassword2.Leave += new System.EventHandler(this.textBoxPassword2_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Re-enter Password";
			// 
			// buttonSignUp
			// 
			this.buttonSignUp.Location = new System.Drawing.Point(267, 353);
			this.buttonSignUp.Name = "buttonSignUp";
			this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
			this.buttonSignUp.TabIndex = 4;
			this.buttonSignUp.Text = "Sign Up";
			this.buttonSignUp.UseVisualStyleBackColor = true;
			this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
			// 
			// labelSignUpFail
			// 
			this.labelSignUpFail.AutoSize = true;
			this.labelSignUpFail.ForeColor = System.Drawing.Color.Red;
			this.labelSignUpFail.Location = new System.Drawing.Point(239, 332);
			this.labelSignUpFail.Name = "labelSignUpFail";
			this.labelSignUpFail.Size = new System.Drawing.Size(130, 13);
			this.labelSignUpFail.TabIndex = 5;
			this.labelSignUpFail.Text = "This email has been used!";
			this.labelSignUpFail.Visible = false;
			// 
			// FormSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 401);
			this.Controls.Add(this.labelSignUpFail);
			this.Controls.Add(this.buttonSignUp);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormSignUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UET Library";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox textBoxPassword2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSignUp;
		private System.Windows.Forms.Label labelSignUpFail;
		private System.Windows.Forms.Label labelErrorEmail;
		private System.Windows.Forms.Label labelErrorPassword;
		private System.Windows.Forms.Label labelErrorUsername;
	}
}