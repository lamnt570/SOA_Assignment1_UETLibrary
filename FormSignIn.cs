using System;
using System.Json;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
	public partial class FormSignIn : Form
	{
		private HttpClient client;

		private string username;

		public FormSignIn()
		{
			InitializeComponent();

			client = new HttpClient();
		}

		private void showErrorMessage()
		{
			string message = "Oops. Something went wrong.\nPlease try again later.";
			string caption = "Error";
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void buttonSignIn_Click(object sender, EventArgs e)
		{
			buttonSignIn.Enabled = false;
			try
			{
				if (!checkSignIn())
				{
					labelSignInFail.Visible = true;
					buttonSignIn.Enabled = true;
					return;
				}
			}
			catch
			{
				showErrorMessage();
				buttonSignIn.Enabled = true;
				return;
			}

			// sign in success
			this.Hide();
			FormMainPage mainPage = new FormMainPage(username);
			mainPage.ShowDialog();

			// user sign out
			clearAll();
			buttonSignIn.Enabled = true;
			this.Show();
		}

		private bool checkSignIn()
		{
			try
			{
				string uri = Program.BASE_URL + "/account/login";

				MultipartFormDataContent content = new MultipartFormDataContent();
				content.Add(new StringContent(textBoxUserName.Text), "email");
				content.Add(new StringContent(textBoxPassword.Text), "password");

				HttpResponseMessage result = client.PostAsync(uri, content).Result;

				JsonObject obj = (JsonObject)JsonObject.Load(result.Content.ReadAsStreamAsync().Result);
				string status = (string)obj["status"];
				if (!status.Equals("ok"))
					return false;

				JsonObject data = (JsonObject)obj["data"];
				username = (string)data["name"];

				return true;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		private void clearAll()
		{
			textBoxUserName.Clear();
			textBoxPassword.Clear();
		}

		private void textBoxEmail_Enter(object sender, EventArgs e)
		{
			labelSignInFail.Visible = false;
		}

		private void textBoxPassword_Enter(object sender, EventArgs e)
		{
			labelSignInFail.Visible = false;
		}

		private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormSignUp formSignup = new FormSignUp();
			formSignup.ShowDialog(this);
		}
	}
}
