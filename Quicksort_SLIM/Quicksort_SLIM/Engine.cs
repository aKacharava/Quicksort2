using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort_SLIM
{
    class Engine
    {
        /// <summary>
        /// Take last element of array as pivot and put it in the right position.
        /// Then put everything smaller than pivot to the left of the pivot
        /// and the rest to the right of the pivot.
        /// </summary>
        public static int[] sortArray(int[] array, int first, int last)
        {
            int pivot = array[first];
            int i = (first + 1);
            int j = last;

            while (i < j)
            {
                while (i < j && array[i] > pivot)
                {
                    i++;
                }

                array[i] = array[j];

                while (i < j && array[j] <= pivot)
                {
                    j--;
                }

                array[j] = array[i];
            }

            array[i] = pivot;

            sortArray(array, first, i - 1);
            sortArray(array, i + 1, last);

            return array;
        }
    }
}
