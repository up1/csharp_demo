using System;
namespace Hi
{
	public class FizzBuzz
	{
		public string say(int number)
		{
			if (number <= 0) {
				throw new MyException ("Number invalid");
			}
			if (number == 3) {
				return "Fizz";
			}
			return number.ToString();
		}
			
	}

}

