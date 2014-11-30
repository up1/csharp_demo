using System;
using System.IO;
using System.Collections;

namespace Hi
{
	public class LogAnalyzer
	{

		public ExtensionInterface extention { set; get;}

		public LogAnalyzer() {
			this.extention = new FileExtension ();
		}

		public bool isValidFileName(String filename) {
			return this.extention.isValid (filename);
		}
	}
}

