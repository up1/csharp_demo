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
			String expectedResult = fizzBuzz.say (3);
			Assert.AreEqual (expectedResult, "Fizz");
		}

		[Test]
		public void Four ()
		{
			String expectedResult = fizzBuzz.say (4);
			Assert.AreEqual (expectedResult, "4");
		}

		[Test]
		[ExpectedException(typeof(MyException), ExpectedMessage="Number invalid") ]
		public void invalid_number_throw_exception ()
		{
			fizzBuzz.say (0);
		}

		[Test]
		[ExpectedException("Hi.MyException") ]
		public void invalid_number_throw_exception2 ()
		{
			fizzBuzz.say (0);
		}

		[TestCase(1,"1")]
		[TestCase(2,"2")]
		[TestCase(3,"Fizz")]
		public void fizzBuzzXX(int input, String expectedResult) {
			Assert.AreEqual (expectedResult, fizzBuzz.say (input));
		}

		[TestCase(1, Result="1")]
		[TestCase(2, Result="2")]
		[TestCase(3, Result="Fizz")]
		public string fizzBuzzYY(int input) {
			return fizzBuzz.say (input);
		}
	}
}