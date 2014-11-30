using System;
using System.Collections;
using System.IO;

namespace Hi
{
	public class FileExtension : ExtensionInterface
	{
		private ArrayList extensions = new ArrayList ();
		public bool isValid(String filename) {
			string line;
			StreamReader file = new StreamReader ("/Users/somkiat/Projects/Hi/Hi/extension2.txt");
			while ((line = file.ReadLine ()) != null) {
				if (!String.IsNullOrEmpty (line)) {
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

