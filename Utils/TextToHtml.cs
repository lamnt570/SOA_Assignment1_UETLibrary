using System.Text;
using System.IO;

namespace Client.Utils
{
	class TextToHtml
	{

		public string convert(string text)
		{
			if (text == null || text.Length == 0)
				return "";

			//Create a StringBuilder object from the string intput
			//parameter
			StringBuilder sb = new StringBuilder(text);
			//Replace all double white spaces with a single white space
			//and &nbsp;
			sb.Replace("  ", " &nbsp;");
			//Convert the brackets into HTML equivalents
			sb.Replace("<", "&lt;");
			sb.Replace(">", "&gt;");
			//Convert the double quote
			sb.Replace("\"", "&quot;");
			//Create a StringReader from the processed string of 
			//the StringBuilder
			StringReader sr = new StringReader(sb.ToString());
			StringWriter sw = new StringWriter();
			//Loop while next character exists
			while (sr.Peek() > -1)
			{
				//Read a line from the string and store it to a temp
				//variable
				string temp = sr.ReadLine();
				//write the string with the HTML break tag
				//Note here write method writes to a Internal StringBuilder
				//object created automatically
				sw.Write(temp + "<br>");
			}
			//Return the final processed text
			return "<p>" + sw.GetStringBuilder().ToString() + "</p>";
		}

	}
}
