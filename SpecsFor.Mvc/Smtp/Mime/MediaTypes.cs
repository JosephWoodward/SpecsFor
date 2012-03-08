// Borrowed from the Papercut project: papercut.codeplex.com.  
using System.Net.Mime;

namespace SpecsFor.Mvc.Smtp.Mime
{
	public static class MediaTypes
	{
		public static readonly string Multipart;

		public static readonly string Mixed;

		public static readonly string Alternative;

		public static readonly string MultipartMixed;

		public static readonly string MultipartAlternative;

        public static readonly string MultipartRelated;

		public static readonly string TextPlain;

		public static readonly string TextHtml;

		public static readonly string TextRich;

		public static readonly string TextXml;

		public static readonly string Message;

		public static readonly string Rfc822;

		public static readonly string MessageRfc822;

		public static readonly string Application;

		static MediaTypes()
		{
			Multipart = "multipart";
			Mixed = "mixed";
			Alternative = "alternative";
			Message = "message";
			Rfc822 = "rfc822";

			MultipartMixed = string.Concat(Multipart, "/", Mixed);
			MultipartAlternative = string.Concat(Multipart, "/", Alternative);
		    MultipartRelated = string.Concat(Multipart, "/related");

			MessageRfc822 = string.Concat(Message, "/", Rfc822);

			TextPlain = MediaTypeNames.Text.Plain;
			TextHtml = MediaTypeNames.Text.Html;
			TextRich = MediaTypeNames.Text.RichText;
			TextXml = MediaTypeNames.Text.Xml;

		}
	}
}