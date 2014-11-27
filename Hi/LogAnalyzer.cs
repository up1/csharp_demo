using System;
using System.IO;
using System.Collections;

namespace Hi
{
	public class LogAnalyzer
	{
		private ArrayList extensions = new ArrayList ();
		public LogAnalyzer ()
		{
			string line;
			StreamReader file = new StreamReader("/Users/somkiat/Projects/Hi/Hi/extension.txt");
			while( (line = file.ReadLine())  != null) {
				if(!String.IsNullOrEmpty(line)) {
					extensions.Add (line);
				}
			}
			file.Close ();
		}

		public bool isValidFileName(String filename) {
			foreach(String extension in extensions) {
				if(filename.EndsWith(extension)) {
					return true;
				}
			}
			return false;
		}
	}
}

