using System;
using System.IO;
using System.Collections;

namespace Hi
{
	public class LogAnalyzer
	{

		private ExtensionInterface extention;

		public LogAnalyzer() {
			this.extention = new FileExtension ();
		}

		public LogAnalyzer(ExtensionInterface extension) {
			this.extention = extension;
		}

		public bool isValidFileName(String filename) {
			return this.extention.isValid (filename);
		}
	}
}

