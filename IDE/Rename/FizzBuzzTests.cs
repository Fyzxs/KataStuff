using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RenameFizzBuzz
{

    //Rename Kata
    // ONLY use Resharper refactoring (CTRL+R, R)

    [TestClass]
    public class UnitTest1//Rename to InlineKataTests
    {
        private const int A = 1 * 2;//Rename to Modifier
        private const int B = 3 - A;//Rename to FizzValue
        private const int C = 5 - A;//Rename to BuzzValue
        private const int D = (B + 2) * (C + 2) - A;//Rename to FizzBuzzValue

        [TestMethod]
        public void E()//Rename to AllTheTests
        {
            Assert.AreEqual("1", E(1));
            Assert.AreEqual("2", E(2));
            Assert.AreEqual("4", E(4));
            Assert.AreEqual("Fizz", E(3));
            Assert.AreEqual("Fizz", E(6));
            Assert.AreEqual("Fizz", E(9));
            Assert.AreEqual("Buzz", E(5));
            Assert.AreEqual("Buzz", E(10));
            Assert.AreEqual("Buzz", E(20));
            Assert.AreEqual("FizzBuzz", E(15));
            Assert.AreEqual("FizzBuzz", E(30));
            Assert.AreEqual("FizzBuzz", E(45));
        }

        public string E(//Rename to FizzBuzzer
                                    int a//Rename to input
                                    )
        {
            bool b = //Rename to isFizz
                G(a, B);
            bool c = //Rename to isBuzz
                G(a, C);
            bool d = //Rename to isFizzBuzz
                G(a, D);
            return F(
                a, d, c, b);
        }

        private static string F(//Rename FizzBuzz
                                       int a, 
                                       bool b, 
                                       bool c, 
                                       bool d)
        {
            const string e = "Fizz";//Rename to 
            const string f = "Buzz";//Rename to 
            const string g = e + f;//Rename to 
            if (b) return g;//Rename to 
            if (c) return f;//Rename to 
            if (d) return e;//Rename to 

            return J(a);//Rename to 
        }

        private static bool G(//Rename to ResultIt
            int a,//Rename to input
            int b)//Rename to value
        {
            int c = //Rename to mod
                I(a, b + 1);
            bool d = //Rename to isFizz
                G(c);
            return d;
        }

        private static bool G(//Rename to IsIt
            int a)//Rename to modValue
        {
            const int o = 0;//Rename to zero
            bool c = //Rename to isIt
                H(a, o);
            return c;
        }

        private static bool H(//Rename to EqualIt
            int a, //Rename to modValue
            int b)//Rename to 
        {
            bool c = //Rename to equalIt
                a == b;
            return c;//Rename to 
        }

        private static int I(//Rename to ModIt
            int a, //Rename to input
            int b)//Rename to value
        {
            int c = //Rename to modIt
                a % (b + 1);
            return c;
        }

        private static string J(//Rename to StringValue
            int a)//Rename to input
        {
            string b = //Rename to stringValue
                a.ToString();
            return b;
        }
    }
}
