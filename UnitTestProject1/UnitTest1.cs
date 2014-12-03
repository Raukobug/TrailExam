using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrailExam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        readonly CountingDictionary<string> _cd = new CountingDictionary<string>();
        readonly CountingDictionary<int> _cdint = new CountingDictionary<int>();
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(1, _cd.Add("meh"));
            Assert.AreEqual(2, _cd.Add("meh"));
            Assert.AreNotEqual(2, _cd.Add("meh"));
            Assert.AreEqual(1, _cdint.Add(2));
        }

        [TestMethod]
        public void TestGet()
        {
            _cd.Add("meh");
            _cd.Add("meh");
            Assert.AreEqual(2,_cd.Get("meh"));
            Assert.AreEqual(0, _cd.Get("Tihi"));
        }

        [TestMethod]
        public void TestRemove()
        {
            _cd.Add("meh");
            _cd.Add("meh");
            Assert.AreEqual(1, _cd.Remove("meh"));
            Assert.AreEqual(0, _cd.Remove("meh"));
            Assert.AreEqual(-1, _cd.Remove("Tihi"));
        }

        [TestMethod]
        public void TestCount()
        {
            _cd.Add("meh");
            _cd.Add("meh");
            Assert.AreEqual(1, _cd.Count);
        }
    }
}
