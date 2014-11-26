using NUnit.Framework;
using System;
using Hi;

namespace HiTest
{
	[TestFixture]
	public class FizzBuzzTest
	{
		private FizzBuzz fizzBuzz;

		[TestFixtureSetUp]
		public void start() {
			Console.WriteLine ("Start...");
		}

		[TestFixtureTearDown]
		public void finish() {
			Console.WriteLine ("Finish");
		}

		[SetUp]
		public void init() {
			Console.WriteLine ("Init");
			fizzBuzz = new FizzBuzz ();
		}

		[TearDown]
		public void releasedResource() {
			Console.WriteLine ("releasedResource");
			fizzBuzz = null;
		}

		[Test]
		public void One ()
		{
			//arrange
			//FizzBuzz fizzBuzz = new FizzBuzz ();

			//act
			String expectedResult = fizzBuzz.say (1);

			//assert
			Assert.AreEqual (expectedResult, "1");
		}

		[Test]
		public void Two ()
		{
			//FizzBuzz fizzBuzz = new FizzBuzz ();
			String expectedResult = fizzBuzz.say (2);
			Assert.AreEqual (expectedResult, "2");
		}

		[Test]
		public void Three ()
		{
			//FizzBuzz fizzBuzz = new FizzBuzz ();
			String expectedResult = fizzBuzz.say (3);
			Assert.AreEqual (expectedResult, "3");
		}

		[Test]
		[ExpectedException(typeof(MyException), ExpectedMessage="Number invalid") ]
		public void invalid_number_throw_exception ()
		{
			fizzBuzz.say (0);
		}
	}
}