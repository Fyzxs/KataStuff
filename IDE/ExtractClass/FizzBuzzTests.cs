using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtractClassFizzBuzz
{
    //Extract Class
    // ONLY use Resharper refactoring (CTRL+SHIFT+R, E)
    //  Ensure the tool creates the correct visibility setting for extracted items
    // 
    //  Extract constants into a class
    //  Extract all (non-test) methods; EXCEPT FizzBuzzer; into a class
    //  Extract ModIt, EqualIt, and IsIt int a single class
    //  Extract StringValue into a class
    //  Extract ResultIt into a class
    //  Move FizzBuzzer into the class with FizzBuzz
    //      Remember, ONLY use resharper refactorings
    //  Extract EqualIt into a class
    //  Move IsIt into the class with EqualIt

    public class ExtractClassKataTests
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

        private const int Modifier = 1 * 2;
        private const int FizzValue = 3 - Modifier;
        private const int BuzzValue = 5 - Modifier;
        private const int FizzBuzzValue = (FizzValue + 2) * (BuzzValue + 2) - Modifier;
        private const string FizzStr = "Fizz";
        private const string BuzzStr = "Buzz";
        private const string FizzBuzzStr = FizzStr + BuzzStr;

        public string FizzBuzzer(int input)
        {
            bool isFizz = ResultIt(input, FizzValue);
            bool isBuzz = ResultIt(input, BuzzValue);
            bool isFizzBuzz = ResultIt(input, FizzBuzzValue);
            return FizzBuzz(input, isFizzBuzz, isBuzz, isFizz);
        }

        private static string FizzBuzz(int input, bool isFizzBuzz, bool isBuzz, bool isFizz)
        {
            if (isFizzBuzz) return FizzBuzzStr;
            if (isBuzz) return BuzzStr;
            if (isFizz) return FizzStr;

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
