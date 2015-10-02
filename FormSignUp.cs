using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Http;
using System.Json;

namespace Client
{
	public partial class FormSignUp : Form
	{

		private bool validEmail, validPassword, validUsername;

		private HttpClient client;

		public FormSignUp()
		{
			InitializeComponent();
			client = new HttpClient();
		}

		private void buttonSignUp_Click(object sender, EventArgs e)
		{
			if (!infoValid())
			{
				labelErrorEmail.Visible = !validEmail;
				labelErrorPassword.Visible = !validPassword;
				labelErrorUsername.Visible = !validUsername;
				return;
			}

			if (!register())
			{
				labelSignUpFail.Visible = true;
				return;
			}

			string message = "Your account has been created.\nPlease check email to complete the registation.";
			string caption = "Register";
			MessageBox.Show(message, caption);
			this.Close();
		}

		private bool register()
		{
			string uri = Program.BASE_URL + "/account/register";

			MultipartFormDataContent content = new MultipartFormDataContent();
			content.Add(new StringContent(textBoxEmail.Text), "email");
			content.Add(new StringContent(textBoxUserName.Text), "name");
			content.Add(new StringContent(textBoxPassword.Text), "password");

			HttpResponseMessage result = client.PostAsync(uri, content).Result;
			JsonObject obj = (JsonObject)JsonObject.Load(result.Content.ReadAsStreamAsync().Result);

			string status = (string)obj["status"];
			if (!status.Equals("ok"))
				return false;

			return true;
		}

		private bool infoValid()
		{
			return (validateEmail() & validatePassword() & validateUsername());
		}

		private bool validateEmail()
		{
			string email = textBoxEmail.Text;

			try
			{
				MailAddress ma = new MailAddress(email);
				validEmail = true;
			}
			catch
			{
				validEmail = false;
			}

			return validEmail;
		}

		private bool validatePassword()
		{
			string pass1 = textBoxPassword.Text;
			string pass2 = textBoxPassword2.Text;

			if (String.IsNullOrEmpty(pass1) || String.IsNullOrEmpty(pass2))
				validPassword = false;
			else
				validPassword = pass1.Equals(pass2);

			return validPassword;
		}

		private bool validateUsername()
		{
			validUsername = !String.IsNullOrEmpty(textBoxUserName.Text);
			return validUsername;
		}

		private void textBoxEmail_Enter(object sender, EventArgs e)
		{
			labelSignUpFail.Visible = false;
			labelErrorEmail.Visible = false;
		}

		private void textBoxUserName_Enter(object sender, EventArgs e)
		{
			labelSignUpFail.Visible = false;
			labelErrorUsername.Visible = false;
		}

		private void textBoxPassword_Enter(object sender, EventArgs e)
		{
			labelSignUpFail.Visible = false;
			labelErrorPassword.Visible = false;
		}

		private void textBoxPassword2_Enter(object sender, EventArgs e)
		{
			labelSignUpFail.Visible = false;
			labelErrorPassword.Visible = false;
		}

		private void textBoxEmail_Leave(object sender, EventArgs e)
		{
			labelErrorEmail.Visible = !validateEmail();
		}

		private void textBoxUserName_Leave(object sender, EventArgs e)
		{
			labelErrorUsername.Visible = !validateUsername();
		}

		private void textBoxPassword2_Leave(object sender, EventArgs e)
		{
			labelErrorPassword.Visible = !validatePassword();
		}

	}
}
