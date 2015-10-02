using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Client.Model
{
	public class BookPreview
	{
		public Image cover { get; set; }

		public String name { get; set; }

		public String author { get; set; }

		public String year { get; set; }

		internal string id { get; set; }

		public BookPreview() { }

		public BookPreview(Book book)
		{
			set(book);
		}

		internal void set(Book book)
		{
			id = book.id;
			name = book.name;
			author = book.author;
			year = book.year.ToString();

			if (book.cover != null)
				cover = book.cover;
		}
	}
}
