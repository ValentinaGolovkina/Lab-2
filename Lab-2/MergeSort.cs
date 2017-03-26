using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class MergeSort
    {
        public int[] merge(int[] a, int startA, int endA, int[] b, int startB, int endB)
        {
            int aLength = endA - startA + 1;
            int bLength = endB - startB + 1;

            int[] c = new int[aLength + bLength];

            int ai = 0;
            int bi = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (ai >= aLength)
                {
                    c[i] = b[bi++];
                    continue;
                }
                if (bi >= bLength)
                {
                    c[i] = a[ai++];
                    continue;
                }
                if (a[ai] < b[bi])
                {
                    c[i] = a[ai++];
                }
                else
                {
                    c[i] = b[bi++];
                }
            }
            return c;
        }


        public int[] mergeSort(int[] a, int start, int end)
        {
            if (start > end) throw new ArgumentException();
            int length = end - start + 1;

            if (length == 1)
            {
                return new int[] { a[start] };
            }

            if (length == 2)
            {
                if (a[start] < a[end])
                {
                    return new int[] { a[start], a[end] };
                }
                {
                    return new int[] { a[end], a[start] };
                }
            }

            int half = length / 2;

            int[] b = mergeSort(a, start, start + half - 1);
            int[] c = mergeSort(a, start + half, end);

            return merge(b, 0, b.Length - 1, c, 0, c.Length - 1);
        }
    }
}
