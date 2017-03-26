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
        
        [TestMethod]
        public void tdd_add1Test()
        {
            list.add(1);
            Assert.AreEqual(1, list.Count());
            Assert.AreEqual(1, list.head.Data);
            Assert.AreEqual(null, list.head.Next);
            Assert.AreEqual(null, list.head.Previous);
            Assert.AreEqual(1, list.tail.Data);
        }

        [TestMethod]
        public void tdd_add2Test()
        {
            list.add(1);
            list.add(2);
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual(1, list.head.Data);
            Assert.AreEqual(null, list.head.Previous);
            Assert.AreEqual(2, list.head.Next.Data);
            Assert.AreEqual(1, list.head.Next.Previous.Data);
            Assert.AreEqual(null, list.head.Next.Next);
            Assert.AreEqual(2, list.tail.Data);
        }
        
        [TestMethod]
        public void tdd_findTest()
        {
            list.add(1);
            Node<int> node = list.find(1);
            Assert.AreEqual(1, node.Data);
        }
    }
}
