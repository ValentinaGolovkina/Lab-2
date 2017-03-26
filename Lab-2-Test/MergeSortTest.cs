using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2;

namespace Lab_2_Test
{
    [TestClass]
    public class MergeSortTest
    {
        //Черный ящик
        [TestMethod]
        public void b_mergeSortOne()
        {
            int[] source = { 2 };
            int[] expected = { 2 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 0, 0);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void b_mergeSortEven()
        {
            int[] source = { 2, 1, 0, 6, -1, 9, 8, 7 };
            int[] expected = { -1, 0, 1, 2, 6, 7, 8, 9 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 0, 7);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void b_mergeSortOdd()
        {
            int[] source = { 2, 1, 0, 6, -1, 9, 8, 7, 3 };
            int[] expected = { -1, 0, 1, 2, 3, 6, 7, 8, 9 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 0, 8);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void b_mergeSortPrecondition()
        {
            int[] source = { 4, 2, 5 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 2, 0);

        }

        //Белый ящик
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void w_mergeSortPath1()
        {
            int[] source = { 4, 2, 5 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 2, 0);
        }
        [TestMethod]
        public void w_mergeSortPath2()
        {
            int[] source = { 2 };
            int[] expected = { 2 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 0, 0);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void w_mergeSortPath3()
        {
            int[] source = { 2, 1 };
            int[] expected = { 1, 2 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.mergeSort(source, 0, 1);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void w_mergePath1()
        {
            int[] sourceA = { 1, 3 };
            int[] sourceB = { 2 };
            int[] expected = { 1, 2, 3 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.merge(sourceA, 0, 1, sourceB, 0, 0);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void w_mergePath2()
        {
            int[] sourceA = { 1 };
            int[] sourceB = { 2, 3 };
            int[] expected = { 1, 2, 3 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.merge(sourceA, 0, 0, sourceB, 0, 1);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void w_mergePath3()
        {
            int[] sourceA = { 1 };
            int[] sourceB = { 2 };
            int[] expected = { 1, 2 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.merge(sourceA, 0, 0, sourceB, 0, 0);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void w_mergePath4()
        {
            int[] sourceA = { 2 };
            int[] sourceB = { 1 };
            int[] expected = { 1, 2 };
            MergeSort mS = new MergeSort();
            int[] actual = mS.merge(sourceA, 0, 0, sourceB, 0, 0);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
