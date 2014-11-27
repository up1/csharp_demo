using NUnit.Framework;
using System;
using Hi;

namespace HiTest
{
	[TestFixture]
	public class LogAnalyzerTest
	{

		[Test]
		public void isValidFilenameWithLowerCase_Return_True() {
			LogAnalyzer  analyzer = new LogAnalyzer();
			bool result = analyzer.isValidFileName ("test.txt");
			Assert.IsTrue (result, "Filename should be valid");
		}

		[Test]
		public void isValidFilenameWithUpperCase_Return_True() {
			LogAnalyzer  analyzer = new LogAnalyzer();
			bool result = analyzer.isValidFileName ("test.TXT");
			Assert.IsTrue (result, "Filename should be valid");
		}

	}
}

