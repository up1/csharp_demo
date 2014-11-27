using System;
using System.IO;
using System.Collections;

namespace Hi
{
	public class LogAnalyzer
	{
		public LogAnalyzer ()
		{
		}

		public bool isValidFileName(String filename) {
			string line;
			ArrayList extensions = new ArrayList ();
			StreamReader file = new StreamReader(@"/Users/somkiat/Projects/Hi/Hi/extension.txt");
			while( (line = file.ReadLine())  != null) {
				if(!String.IsNullOrEmpty(line)) {
					extensions.Add (line);
				}
			}
			file.Close ();

			foreach(String extension in extensions) {
				if(filename.EndsWith(extension)) {
					return true;
				}
			}
			return false;
		}
	}
}

