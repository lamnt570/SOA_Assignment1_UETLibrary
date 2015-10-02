using Client.Model;
using Client.Utils;
using System;
using System.Collections.Generic;
using System.Json;
using System.Net.Http;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Client
{
	public partial class FormBook : Form
	{
		internal const int VIEW_BOOK = 0;
		internal const int EDIT_BOOK = 1;
		internal const int CREATE_BOOK = 2;

		private int type;

		private Book book;
		
		private bool editting = false;

		private bool validName, validPageNum, validYear, validCategory;
		
		private HtmlToText html2text = new HtmlToText();
		private TextToHtml text2html = new TextToHtml();

		private HttpClient client = null;

		private bool changeCover = false;
		private OpenFileDialog openImageDialog;
		private string coverImageName;
		
		private FormMainPage mainPage;

		public FormBook(FormMainPage mainPage)
		{
			InitializeComponent();
			this.mainPage = mainPage;
			book = new Book();
			this.type = VIEW_BOOK;
			setLabels();
			redisplay();
		}

		public FormBook(Book book, FormMainPage mainPage)
		{
			InitializeComponent();
			this.mainPage = mainPage;
			if (book.name != null && book.name.Length != 0)
				this.Text = book.name;
			this.book = book;
			this.type = VIEW_BOOK;
			editting = false;
			setLabels();
			redisplay();
		}

		public FormBook(Book book, int type, FormMainPage mainPage)
		{
			InitializeComponent();
			this.mainPage = mainPage;
			if (!String.IsNullOrEmpty(book.name))
				this.Text = book.name;
			this.book = book;
			this.type = type;
			switch (type)
			{
				case VIEW_BOOK:
					editting = false; setLabels(); break;
				case EDIT_BOOK:
				case CREATE_BOOK:
					editting = true; setTextBoxes(); break;
			}
			redisplay();
		}

		private void setLabels()
		{
			labelName.Text = book.name;
			labelAuthor.Text = book.author;
			labelCategory.Text = book.category;
			labelISBN.Text = book.isbn;
			labelPageNum.Text = null;
			if (book.pageNum > 0)
				labelPageNum.Text = book.pageNum.ToString();
			labelPublisher.Text = book.publisher;
			labelPublishYear.Text = null;
			if (book.year > 0)
				labelPublishYear.Text = book.year.ToString();
			
			labelDescription.Text = html2text.Convert(book.description);
		}

		private void setTextBoxes()
		{
			textBoxName.Text = book.name;
			textBoxAuthor.Text = book.author;
			textBoxCategory.Text = book.category;
			textBoxISBN.Text = book.isbn;
			if (book.pageNum > 0)
				textBoxPageNum.Text = book.pageNum.ToString();
			textBoxPublisher.Text = book.publisher;
			if (book.year > 0)
				textBoxPublishYear.Text = book.year.ToString();

			textBoxDescription.Text = html2text.Convert(book.description);
		}

		private void redisplay()
		{
			if (book.cover != null)
			{
				pictureBookCover.Image = book.cover;
				pictureBookCover.Refresh();
			}

			panelInfo.VerticalScroll.Value = 0;

			buttonEdit.Visible = buttonDelete.Visible = !editting;
			buttonSave.Visible = buttonCancel.Visible = editting;

			labelName.Visible = labelAuthor.Visible = labelISBN.Visible = 
				labelPageNum.Visible = labelPublisher.Visible = labelPublishYear.Visible = 
				labelDescription.Visible = labelCategory.Visible = !editting;

			textBoxName.Visible = textBoxAuthor.Visible = textBoxISBN.Visible = 
				textBoxPageNum.Visible = textBoxPublisher.Visible = textBoxPublishYear.Visible = 
				textBoxDescription.Visible = textBoxCategory.Visible = editting;

			if (!editting)
				labelErrorName.Visible = labelErrorPageNum.Visible = labelErrorPublishYear.Visible = 
					labelErrorCategory.Visible = false;

			linkLabelChangeCover.Visible = editting;
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			editting = true;
			type = EDIT_BOOK;
			changeCover = false;
			setTextBoxes();
			redisplay();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			// check book infomation is OK
			if (!infoValid()) {
				panelInfo.VerticalScroll.Value = 0;
				labelErrorName.Visible = !validName;
				labelErrorPageNum.Visible = !validPageNum;
				labelErrorPublishYear.Visible = !validYear;
				labelErrorCategory.Visible = !validCategory;
				return;
			}

			bool requestSuccess = false;
			if (type == CREATE_BOOK)
				requestSuccess = createBook();
			else
				requestSuccess = updateBook();

			if (!requestSuccess)
			{
				const string message = "Oops! Cannot update book right now.\nPlease try again later.";
				const string caption = "Update fail";
				MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (type == CREATE_BOOK)
			{
				mainPage.addOpeningBook(book.id, this);
				mainPage.reloadPage();
				this.Text = book.name;
			}
			else
			{
				mainPage.updateBook(book);
			}
			editting = false;			
			type = VIEW_BOOK;
			setLabels();
			redisplay();
		}

		private bool infoValid()
		{
			return (validateName() & validatePageNum() & validateYear() & validateCategory());
		}

		private bool validateName()
		{
			validName = (textBoxName.Text != null && textBoxName.Text.Length > 0);
			return validName;
		}

		private bool validatePageNum()
		{
			int i = convertStr2PositiveInt(textBoxPageNum.Text);
			validPageNum = (i >= 0);
			return validPageNum;
		}

		private bool validateYear()
		{
			int i = convertStr2PositiveInt(textBoxPublishYear.Text);
			validYear = (i == 0 || (1500 <= i && i <= 2015));
			return validYear;
		}

		private bool validateCategory()
		{
			validCategory = (textBoxCategory.Text != null && textBoxCategory.Text.Length > 0);
			return validCategory;
		}

		private void setBookData()
		{
			book.name = textBoxName.Text;
			book.author = textBoxAuthor.Text;
			book.category = textBoxCategory.Text;
			book.isbn = textBoxISBN.Text;
			book.pageNum = convertStr2PositiveInt(textBoxPageNum.Text);
			book.publisher = textBoxPublisher.Text;
			book.year = convertStr2PositiveInt(textBoxPublishYear.Text);
			book.description = text2html.convert(textBoxDescription.Text);
			if (changeCover)
				book.cover = pictureBookCover.Image;
		}

		private bool updateBook()
		{
			// send update request
			if (!sendUpdateRequest())
				return false;
			setBookData();
			return true;
		}

		private bool createBook()
		{
			// send create request
			if (!sendCreateRequest())
				return false;
			setBookData();
			return true;
		}

		// set null textbox to epmty string ""
		private void correctTextBoxes()
		{
			if (textBoxName.Text == null) textBoxName.Text = "";
			if (textBoxAuthor.Text == null) textBoxAuthor.Text = "";
			if (textBoxCategory.Text == null) textBoxCategory.Text = "";
			if (textBoxISBN.Text == null) textBoxISBN.Text = "";
			if (textBoxPageNum.Text == null) textBoxPageNum.Text = "";
			if (textBoxPublisher.Text == null) textBoxPublisher.Text = "";
			if (textBoxPublishYear.Text == null) textBoxPublishYear.Text = "";
			if (textBoxDescription.Text == null) textBoxDescription.Text = "";
		}

		private bool sendUpdateRequest()
		{
			correctTextBoxes();

			string requestUri = Program.BASE_URL + "/book/edit";

			MultipartFormDataContent content = new MultipartFormDataContent();
			content.Add(new StringContent(book.id), "id");
			content.Add(new StringContent(textBoxName.Text), "name");
			content.Add(new StringContent(textBoxPublishYear.Text), "year");
			content.Add(new StringContent(textBoxISBN.Text), "ISBN");
			content.Add(new StringContent(textBoxAuthor.Text), "author");
			content.Add(new StringContent(textBoxDescription.Text), "short_description");
			content.Add(new StringContent(textBoxPublisher.Text), "publisher");
			content.Add(new StringContent(textBoxPageNum.Text), "page_number");
			content.Add(new StringContent(textBoxCategory.Text), "category");
			if (changeCover)
				content.Add(new StreamContent(getImageStream(pictureBookCover.Image)), "cover", coverImageName);

			HttpResponseMessage result = client.PostAsync(requestUri, content).Result;

			JsonObject obj = (JsonObject)JsonObject.Load(result.Content.ReadAsStreamAsync().Result);
			string status = (string)obj["status"];
			if (!status.Equals("ok"))
				return false;
			return true;
		}

		private bool sendCreateRequest()
		{
			correctTextBoxes();

			string requestUri = Program.BASE_URL + "/book/create";

			MultipartFormDataContent content = new MultipartFormDataContent();
			content.Add(new StringContent(textBoxName.Text), "name");
			content.Add(new StringContent(textBoxPublishYear.Text), "year");
			content.Add(new StringContent(textBoxISBN.Text), "ISBN");
			content.Add(new StringContent(textBoxAuthor.Text), "author");
			content.Add(new StringContent(textBoxDescription.Text), "short_description");
			content.Add(new StringContent(textBoxPublisher.Text), "publisher");
			content.Add(new StringContent(textBoxPageNum.Text), "page_number");
			content.Add(new StringContent(textBoxCategory.Text), "category");
			if (changeCover)
				content.Add(new StreamContent(getImageStream(pictureBookCover.Image)), "cover", coverImageName);

			HttpResponseMessage result = client.PostAsync(requestUri, content).Result;

			JsonObject obj = (JsonObject)JsonObject.Load(result.Content.ReadAsStreamAsync().Result);
			string status = (string)obj["status"];
			if (!status.Equals("ok"))
				return false;

			// !!!
			book.id = (string)obj["data"];
			return true;
		}

		private Stream getImageStream(Image image)
		{
			MemoryStream ms = new MemoryStream();
			image.Save(ms, image.RawFormat);
			ms.Position = 0;
			return ms;
		}

		private void textBoxName_Enter(object sender, EventArgs e)
		{
			labelErrorName.Visible = false;
		}

		private void textBoxName_Leave(object sender, EventArgs e)
		{
			if (!validateName())
				labelErrorName.Visible = true;
		}

		private void textBoxPageNum_Enter(object sender, EventArgs e)
		{
			labelErrorPageNum.Visible = false;
		}

		private void textBoxPageNum_Leave(object sender, EventArgs e)
		{
			if (!validatePageNum())
				labelErrorPageNum.Visible = true;
		}

		private void textBoxPublishYear_Enter(object sender, EventArgs e)
		{
			labelErrorPublishYear.Visible = false;
		}

		private void textBoxPublishYear_Leave(object sender, EventArgs e)
		{
			if (!validateYear())
				labelErrorPublishYear.Visible = true;
		}

		private int convertStr2PositiveInt(string s)
		{
			if (s == null || s.Length == 0)
				return 0;

			try
			{
				int res = Convert.ToInt32(s);
				if (res >= 0)
					return res;
				else
					return -1;
			}
			catch
			{
				return -1;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (type == CREATE_BOOK)
			{
				this.Close();
				return;
			}

			const string message = "Do you want cancel without saving?";
			const string caption = "Cancel Editor";
			DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				editting = false;
				type = VIEW_BOOK;
				setLabels();
				redisplay();
			}
		}

		private void FormBook_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (type != CREATE_BOOK)
				return;

			const string message = "Do you want exit without saving?";
			const string caption = "Exit";
			DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			const string message = "Are you sure you want to delete this book?";
			const string caption = "Delete";
			DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				if (!deleteBook())
				{
					const string message2 = "Cannot delete book right now.\nPlease try again later.";
					const string caption2 = "Delete fail";
					MessageBox.Show(message2, caption2, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					MessageBox.Show("Successfully delete book.", "Delete", MessageBoxButtons.OK);
					mainPage.reloadPage();
					this.Close();
				}
			}
		}

		private bool deleteBook()
		{
			if (sendDeleteRequest())
				return true;
			return false;
		}

		private bool sendDeleteRequest()
		{
			string requestUri = Program.BASE_URL + "/book/delete";

			Dictionary<string, string> dict = new Dictionary<string, string>();
			dict.Add("id", book.id);
			FormUrlEncodedContent content = new FormUrlEncodedContent(dict);

			HttpResponseMessage result = client.PutAsync(requestUri, content).Result;

			JsonObject obj = (JsonObject)JsonObject.Load(result.Content.ReadAsStreamAsync().Result);
			string status = (string)obj["status"];
			if (!status.Equals("ok"))
				return false;

			return true;
		}

		private void FormBook_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainPage.closeBook(book.id);
		}

		private void FormBook_Load(object sender, EventArgs e)
		{
			client = new HttpClient();

			openImageDialog = new OpenFileDialog();
			openImageDialog.RestoreDirectory = true;
			openImageDialog.Filter = "Image|*.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
		}

		private void linkLabelChangeCover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (openImageDialog.ShowDialog() == DialogResult.OK)
			{
				changeCover = true;
				Image img = Image.FromFile(openImageDialog.FileName);
				pictureBookCover.Image = img;
				coverImageName = openImageDialog.SafeFileName;
			}
		}
	}
}
