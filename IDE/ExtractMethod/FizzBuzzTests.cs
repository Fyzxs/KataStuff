using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtractMethodFizzBuzz
{

    //Extract Methods
    // ONLY use Resharper refactoring (CTRL+R,M)
    // Extracted methods MUST be generated with appropriately named variables
    // Methods to create
    //      If two numbers are equal
    //      Result of the mod operator
    //      If the number is a multiple of 5
    //      if the number is a multiple of 3
    //      if the number is a multiple of 15
    //      Convert int to string

    [TestClass]
    public class ExtractMethodKataTests
    {
        [TestMethod]
        public void AllTheTests()
        {
            Assert.AreEqual("1", FizzBuzzer(1));
            Assert.AreEqual("2", FizzBuzzer(2));
            Assert.AreEqual("4", FizzBuzzer(4));
            Assert.AreEqual("Fizz", FizzBuzzer(3));
            Assert.AreEqual("Fizz", FizzBuzzer(6));
            Assert.AreEqual("Fizz", FizzBuzzer(9));
            Assert.AreEqual("Buzz", FizzBuzzer(5));
            Assert.AreEqual("Buzz", FizzBuzzer(10));
            Assert.AreEqual("Buzz", FizzBuzzer(20));
            Assert.AreEqual("FizzBuzz", FizzBuzzer(15));
            Assert.AreEqual("FizzBuzz", FizzBuzzer(30));
            Assert.AreEqual("FizzBuzz", FizzBuzzer(45));
        }

        public string FizzBuzzer(int input)
        {
            if (input % 15 == 0) return "FizzBuzz";
            if (input % 5 == 0) return "Buzz";
            if (input % 3 == 0) return "Fizz";

            return input.ToString();
        }
    }
}
