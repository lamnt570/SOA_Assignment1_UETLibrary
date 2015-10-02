using Client.Model;
using System;
using System.Collections.Generic;
using System.Json;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
	public partial class FormMainPage : Form
	{
		private List<Book> books;
		private List<BookPreview> page;

		private int pageNum, pageCur;

		private const int MAX_BOOKS_PER_PAGE = 10;

		private bool signout = false;

		private HttpClient client;

		private bool useSearch = false;

		private Thread getBookCoversThread = null;

		private Dictionary<string, FormBook> openingBook;

		private FormWaiting formWaiting;

		public FormMainPage()
		{
			InitializeComponent();
			labelUserName.Text = "No Name";
			openingBook = new Dictionary<string, FormBook>();
			//init();
		}

		public FormMainPage(string userName)
		{
			InitializeComponent();
			labelUserName.Text = userName;
			openingBook = new Dictionary<string, FormBook>();
			//init();
		}

		private void init()
		{
			books = new List<Book>();
			page = new List<BookPreview>();
			pageNum = pageCur = 0;

			// make first request
			getPage();

			// display
			redisplay();
		}

		WebResponse makeGetBooksRequest(int page)
		{
			string request = Program.BASE_URL + "/books?limit=" + MAX_BOOKS_PER_PAGE + "&page=" + page;

			WebRequest webRequest = WebRequest.Create(request);
			webRequest.Credentials = CredentialCache.DefaultCredentials;

			return webRequest.GetResponse();
		}

		WebResponse makeSearchBooksRequest(int page)
		{
			string query = textBoxSearch.Text;
			if (query == null) query = "";
			string request = Program.BASE_URL + "/book/search?q=" + query + "&limit=" + MAX_BOOKS_PER_PAGE + "&page=" + page;

			WebRequest webRequest = WebRequest.Create(request);
			webRequest.Credentials = CredentialCache.DefaultCredentials;

			return webRequest.GetResponse();
		}

		private void getBookCovers()
		{
			for (int i = 0; i < books.Count; i++)
			{
				books[i].getCover();
				if (books[i].cover != null)
				{
					//page[i].cover = books[i].cover;
					DataGridViewCell cell = dataGridViewBookPreview.Rows[i].Cells[0];
					cell.Value = books[i].cover;
				}
			}
		}

		private void showWaitingForm()
		{
			formWaiting.Show();
		}

		private void getPage()
		{
			//Thread waitingThread = new Thread(showWaitingForm);
			//waitingThread.Start();
	
			if (getBookCoversThread != null && getBookCoversThread.IsAlive)
			{
				getBookCoversThread.Abort();
				getBookCoversThread = null;
			}
			
			WebResponse response;
			if (!useSearch)
				response = makeGetBooksRequest(pageCur + 1);
			else
				response = makeSearchBooksRequest(pageCur + 1);
			JsonObject json = (JsonObject)JsonObject.Load(response.GetResponseStream());

			//waitingThread.Abort();

			// check status
			string status = (string)json["status"];
			if (!status.Equals("ok"))
			{
				MessageBox.Show("Fail to load page.");
				return;
			}

			// update total page number
			int count = (int)json["count"];
			pageNum = (int)Math.Ceiling(1.0 * count / MAX_BOOKS_PER_PAGE);

			// update page data
			books.Clear();
			page.Clear();
			JsonArray data = (JsonArray)json["data"];
			for (int i = 0; i < data.Count; i++)
			{
				JsonObject o = data[i].ToJsonObject();
				Book book = new Book(o);
				books.Add(book);
				page.Add(new BookPreview(book));
			}

			// make new thread to load cover book
			getBookCoversThread = new Thread(getBookCovers);
			getBookCoversThread.Start();
		}

		private void displayPage()
		{
			dataGridViewBookPreview.DataSource = null;
			if (page.Count == 0)
				return;
			dataGridViewBookPreview.DataSource = page;

			if (page.Count > 4)
				dataGridViewBookPreview.Columns[1].Width = 313;
			else
				dataGridViewBookPreview.Columns[1].Width = 330;
			dataGridViewBookPreview.CurrentCell = dataGridViewBookPreview.Rows[0].Cells[0];
		}

		private void redisplay()
		{
			displayPage();

			buttonPrevPage.Enabled = (pageCur != 0);
			buttonNextPage.Enabled = (pageCur < pageNum - 1);

			labelPageNum.Text = "/ " + pageNum;
			setTextBoxPageCur();
		}

		private void buttonNextPage_Click(object sender, EventArgs e)
		{
			pageCur++;
			getPage();
			redisplay();
		}

		private void buttonPrevPage_Click(object sender, EventArgs e)
		{
			pageCur--;
			getPage();
			redisplay();
		}

		private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			signout = true;
			this.Close();
		}

		private void FormMainPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!signout)
				Application.Exit();
		}

		private void dataGridViewBookPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowId = e.RowIndex;
			if (rowId < 0)
				return;

			Book book = new Book(books[rowId]);
			if (openingBook.ContainsKey(book.id))
			{
				openingBook[book.id].Activate();
			}
			else
			{
				FormBook formBook = new FormBook(book, this);
				openingBook.Add(book.id, formBook);
				formBook.Show();
			}
		}

		private void textBoxPageCur_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				try
				{
					int i = Convert.ToInt32(textBoxPageCur.Text);
					i--;
					if (i != pageCur && 0 <= i && i < pageNum)
					{
						pageCur = i;
						getPage();
						redisplay();
					}
					else
					{
						setTextBoxPageCur();
					}
				}
				catch
				{					
					setTextBoxPageCur();
				}
			}
		}

		private void setTextBoxPageCur()
		{
			textBoxPageCur.Text = (pageCur + 1).ToString();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			int rowId = dataGridViewBookPreview.SelectedRows[0].Index;
			if (rowId < 0)
				return;

			Book book = new Book(books[rowId]);
			if (openingBook.ContainsKey(book.id))
			{
				openingBook[book.id].Activate();
			}
			else
			{
				FormBook formBook = new FormBook(book, FormBook.EDIT_BOOK, this);
				openingBook.Add(book.id, formBook);
				formBook.Show();
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			FormBook formBook = new FormBook(new Book(), FormBook.CREATE_BOOK, this);
			formBook.Show();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int rowId = dataGridViewBookPreview.SelectedRows[0].Index;
			if (rowId < 0)
				return;
			deleteBook(books[rowId]);
		}

		private void deleteBook(Book book)
		{
			const string message = "Are you sure you want to delete this book?";
			const string caption = "Delete";
			DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				if (!sendDeleteRequest(book.id))
				{
					const string message2 = "Cannot delete book right now.\nPlease try again later.";
					const string caption2 = "Delete fail";
					MessageBox.Show(message2, caption2, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					MessageBox.Show("Successfully delete book.", "Delete", MessageBoxButtons.OK);
					reloadPage();
					return;
				}
			}

		}

		private bool sendDeleteRequest(string bookId)
		{
			string requestUri = Program.BASE_URL + "/book/delete";

			Dictionary<string, string> dict = new Dictionary<string, string>();
			dict.Add("id", bookId);
			FormUrlEncodedContent content = new FormUrlEncodedContent(dict);

			if (client == null)
				client = new HttpClient();
			HttpResponseMessage result = client.PutAsync(requestUri, content).Result;

			JsonObject obj = (JsonObject)JsonObject.Load(result.Content.ReadAsStreamAsync().Result);
			string status = (string)obj["status"];
			if (!status.Equals("ok"))
				return false;

			return true;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			useSearch = true;
			pageCur = pageNum = 0;

			getPage();
			redisplay();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			if (!useSearch)
				return;

			useSearch = false;
			textBoxSearch.Clear();
			pageCur = pageNum = 0;

			getPage();
			redisplay();
		}

		internal void reloadPage()
		{
			getPage();
			redisplay();
		}

		internal void closeBook(string id)
		{
			if (id != null && openingBook.ContainsKey(id))
				openingBook.Remove(id);
		}

		internal void addOpeningBook(string id, FormBook formBook)
		{
			openingBook.Add(id, formBook);
		}

		internal void updateBook(Book book)
		{
			string id = book.id;
			for (int i = 0; i < books.Count; i++)
				if (books[i].id.Equals(id))
				{
					books[i].set(book);
					page[i].set(book);

					dataGridViewBookPreview.Rows[i].Cells[0].Value = book.cover;
					dataGridViewBookPreview.Rows[i].Cells[1].Value = book.name;
					dataGridViewBookPreview.Rows[i].Cells[2].Value = book.author;
					dataGridViewBookPreview.Rows[i].Cells[3].Value = book.year;
					break;
				}
		}

		private void FormMainPage_Load(object sender, EventArgs e)
		{
			formWaiting = new FormWaiting();
			init();
		}

	}
}
