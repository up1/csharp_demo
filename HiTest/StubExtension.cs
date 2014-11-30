using System;
using Hi;

namespace HiTest
{
	public class StubExtension : ExtensionInterface
	{
		public bool ShouldExtensionBe;
		public bool isValid(string filename) {
			return ShouldExtensionBe;
		}
	}
}

