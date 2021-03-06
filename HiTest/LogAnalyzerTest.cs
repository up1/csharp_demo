﻿using NUnit.Framework;
using System;
using Hi;

namespace HiTest
{
	[TestFixture]
	public class LogAnalyzerTest
	{

		[Test]
		public void isValidFilenameWithLowerCase_Return_True() {
			StubExtension stubExtension = new StubExtension ();
			stubExtension.ShouldExtensionBe = true;
			LogAnalyzer  analyzer = new LogAnalyzer();
			analyzer.extention = stubExtension ;
			bool result = analyzer.isValidFileName ("test.txt");
			Assert.IsTrue (result, "Filename should be valid");
		}

		[Test]
		public void isValidFilenameWithUpperCase_Return_True() {
			StubExtension stubExtension = new StubExtension ();
			stubExtension.ShouldExtensionBe = true;
			LogAnalyzer  analyzer = new LogAnalyzer();
			analyzer.extention = stubExtension ;
			bool result = analyzer.isValidFileName ("test.TXT");
			Assert.IsTrue (result, "Filename should be valid");
		}

		internal class StubExtension : ExtensionInterface
		{
			public bool ShouldExtensionBe;
			public bool isValid(string filename) {
				return ShouldExtensionBe;
			}
		}

	}
}

