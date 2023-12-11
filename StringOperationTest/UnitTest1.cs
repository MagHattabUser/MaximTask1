using System.Linq.Expressions;

namespace StringOperationTest
{
    public class Tests
    {
        [Test]
        public void ProcessingStringEven()
        {
            var strOper = new StringOperation();
            var res = strOper.ProcessingString("abcd");
            Assert.AreEqual("badc", res) ;
        }

        [Test]
        public void ProcessingStringOdd()
        {
            var strOper = new StringOperation();
            var res = strOper.ProcessingString("abc");
            Assert.AreEqual("cbaabc", res);
        }

        [Test]
        public void StringIsCorrect()
        {
            var strOper = new StringOperation();
            var res = strOper.StrngIsCorrect("abc");
            Assert.AreEqual(true, res);
        }

        [Test]
        public void StringIsNotCorrectOne()
        {
            var strOper = new StringOperation();
            Assert.Throws<SymbolException>(() => strOper.StrngIsCorrect("ds2"));
        }

        [Test]
        public void StringIsNotCorrectTwo()
        {
            var strOper = new StringOperation();
            Assert.Throws<SymbolException>(() => strOper.StrngIsCorrect("Asd"));
        }

        [Test]
        public void FindLargestSubstringOne()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("abc");
            string res = strOper.FindLargestSubstring(temp);
            Assert.AreEqual("aa", res);
        }

        [Test]
        public void FindLargestSubstringTwo()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("bc");
            var res = strOper.FindLargestSubstring(temp);
            Assert.AreEqual("", res);
        }

        [Test]
        public void FindLargestSubstringThree()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("ba");
            var res = strOper.FindLargestSubstring(temp);
            Assert.AreEqual("a", res);
        }

        [Test]
        public void QuickSort()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("abc");
            var res = strOper.Sort(temp,1);
            Assert.AreEqual("aabbcc", res);
        }

        [Test]
        public void TreeSort()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("abc");
            var res = strOper.Sort(temp, 2);
            Assert.AreEqual("aabbcc", res);
        }

        [Test]
        public void CharsCountInStrngOne()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("ab");
            var res = strOper.CharsCountInStrng(temp);
            Assert.AreEqual(new List<string>() { "a1", "b1" }, res);
        }

        [Test]
        public void CharsCountInStrngTwo()
        {
            var strOper = new StringOperation();
            var temp = strOper.ProcessingString("abc");
            var res = strOper.CharsCountInStrng(temp);
            Assert.AreEqual(new List<string>() { "c2", "b2", "a2" }, res);
        }
    }
}
