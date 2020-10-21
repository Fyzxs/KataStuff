using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InlineFizzBuzz
{


    //Inline Kata
    // ONLY use Resharper refactoring (CTRL+R, I)
    [TestClass]
    public class InlineKataTests
    {
        private const int Modifier = 1 * 2;
        private const int FizzValue = 3 - Modifier;
        private const int BuzzValue = 5 - Modifier;
        private const int FizzBuzzValue = (FizzValue + 2) * (BuzzValue + 2) - Modifier;

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
            bool isFizz = ResultIt(input, FizzValue);
            bool isBuzz = ResultIt(input, BuzzValue);
            bool isFizzBuzz = ResultIt(input, FizzBuzzValue);
            return FizzBuzz(input, isFizzBuzz, isBuzz, isFizz);
        }

        private static string FizzBuzz(int input, bool isFizzBuzz, bool isBuzz, bool isFizz)
        {
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            const string fizzBuzz = fizz + buzz;
            if (isFizzBuzz) return fizzBuzz;
            if (isBuzz) return buzz;
            if (isFizz) return fizz;

            return StringValue(input);
        }

        private static bool ResultIt(int input, int value)
        {
            int mod = ModIt(input, value + 1);
            bool isFizz = IsIt(mod);
            return isFizz;
        }

        private static bool IsIt(int modValue)
        {
            const int zero = 0;
            bool isIt = EqualIt(modValue, zero);
            return isIt;
        }

        private static bool EqualIt(int modValue, int zero)
        {
            bool equalIt = modValue == zero;
            return equalIt;
        }

        private static int ModIt(int input, int value)
        {
            int modIt = input % (value + 1);
            return modIt;
        }

        private static string StringValue(int input)
        {
            string stringValue = input.ToString();
            return stringValue;
        }
    }
}
