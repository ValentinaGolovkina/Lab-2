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

        [TestMethod]
        public void tdd_getCount1Test()
        {
            list.head = new Node<int>(1);
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void tdd_getCount2Test()
        {
            list.head = new Node<int>(1);
            list.head.Next = new Node<int>(2);
            Assert.AreEqual(2, list.Count());
        }
    }
}
