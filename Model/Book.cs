using System;
using System.Drawing;
using System.IO;
using System.Json;
using System.Net.Http;

namespace Client.Model
{
	public class Book
	{
		internal string id { get; set; }
		internal string name { get; set; }
		internal int year { get; set; }
		internal string isbn { get; set; }
		internal string author { get; set; }		
		internal string description { get; set; }
		internal int pageNum { get; set; }
		internal string publisher { get; set; }
		internal string createdTime { get; set; }
		internal string modifiedTime { get; set; }
		internal string slug { get; set; }
		internal string category { get; set; }

		internal Image cover { get; set; }
		private string coverLink;

		private static HttpClient client = null;

		public Book()
		{
			id = name = isbn = author = description = publisher = 
				createdTime = modifiedTime = slug = category = null;
			cover = null;
			year = pageNum = 0;
		}

		public Book(JsonObject obj)
		{
			id = (string)obj["id"];
			name = (string)obj["name"];
			author = (string)obj["author"];
			year = string2int((string)obj["year"]);
			isbn = (string)obj["ISBN"];
			description = (string)obj["short_description"];
			pageNum = string2int((string)obj["page_number"]);
			publisher = (string)obj["publisher"];
			createdTime = (string)obj["created_at"];
			modifiedTime = (string)obj["modified_in"];
			slug = (string)obj["slug"];
			category = (string)obj["category"];

			cover = null;
			coverLink = (string)obj["cover"];
			//cover = getImage((string)obj["cover"]);
		}

		internal void getCover()
		{
			if (coverLink == null || coverLink.Length == 0)
			{
				cover = null;
				return;
			}				

			try
			{
				if (client == null)
					client = new HttpClient();
				Stream s = client.GetStreamAsync(coverLink).Result;
				cover = Image.FromStream(s, false, true);
			}
			catch
			{
				cover = null;
				return;
			}
		}

		private int string2int(string s)
		{
			try
			{
				return Convert.ToInt32(s);
			}
			catch
			{
				return 0;
			}
		}

		public Book(Book book)
		{
			set(book);
		}

		public void set(Book book)
		{
			id = book.id;
			name = book.name;
			author = book.author;
			category = book.category;
			year = book.year;
			isbn = book.isbn;
			description = book.description;
			pageNum = book.pageNum;
			publisher = book.publisher;
			createdTime = book.createdTime;
			modifiedTime = book.modifiedTime;
			slug = book.slug;
			coverLink = book.coverLink;
			if (book.cover != null)
				cover = (Image)book.cover.Clone();
		}
	}
}
