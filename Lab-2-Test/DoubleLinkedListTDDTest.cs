using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2;

namespace Lab_2_Test
{
    [TestClass]
    public class DoubleLinkedListTDDTest
    {
        private DoubleLinkedListTDD<int> list;

        [TestInitialize]
        public void tdd_initializeTest()
        {
            list = new DoubleLinkedListTDD<int>();
        }

        [TestMethod]
        public void tdd_getCountTest()
        {
            Assert.AreEqual(0, list.Count());
        }
    }
}
