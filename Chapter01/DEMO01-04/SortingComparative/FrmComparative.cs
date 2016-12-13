using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SortingComparative
{
    public partial class FrmComparative : Form
    {
        List<int> listOfNum = new List<int>();
        public FrmComparative()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int limit = (int)nudTotalNumbers.Value;
            listOfNum.Clear(); 
            // We use a seed based on the number of milliseconds
            // Other choices might include Guid generation.
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < limit; i++)
            {
                listOfNum.Add(rand.Next(limit));
            }
            
            // Finally, clean up User Interface
            // and assign data to Listboxes
            CleanUpUI();
        }
        public static IEnumerable<T> Shuffle<T>(IEnumerable<T> source, Random rng)
        {
            // This algorithm is published by Jon Skeet at StackOverflow's:
            // http://stackoverflow.com/questions/1287567/is-using-random-and-orderby-a-good-shuffle-algorithm
            // I only modified the original slightly
            T[] elements = source.ToArray();
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                // Swap element "i" with a random earlier element it (or itself)
                // ... except we don't really need to swap it fully, as we can
                // return it immediately, and afterwards it's irrelevant.
                int swapIndex = rng.Next(i + 1);
                yield return elements[swapIndex];
                elements[swapIndex] = elements[i];
            }
        }
        private void CleanUpUI()
        {
            foreach (var item in this.Controls)
            {
                if (item is ListBox)
                {
                    ((ListBox)item).DataSource = null;
                    ((ListBox)item).Items.Clear();
                    // Suspend/ResumeLayout optimizes the process of 
                    // assigning large chunks of data to a control
                    ((ListBox)item).SuspendLayout();
                    ((ListBox)item).DataSource = listOfNum;
                    ((ListBox)item).ResumeLayout();
                }
            }
        }
        #region "Simple Bubble Sort"
        private void btnBubble_Click(object sender, EventArgs e)
        {
            // First, we shuffle the array 
            var randSeed = DateTime.Now.Millisecond;
            var localArray = Shuffle(listOfNum, new Random(randSeed)).ToList();
            // Control of time. We'll use a Stopwatch
            // for all methods
            Stopwatch sw = Stopwatch.StartNew();
            BubbleSort(localArray);
            // We exclude the time inverted in assigning 
            // data to the control
            sw.Stop();
            // Assign data and present results
            lbBubble.DataSource = localArray;
            lbETBublle.Text = sw.Elapsed.TotalSeconds.ToString() + " s.";;
        }
        public void BubbleSort<T>(IList<T> list)
        {
            // We use the default comparer for the type (int)
            // which is assumed by the compiler.
            BubbleSort<T>(list, Comparer<T>.Default);
        }
        public void BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            bool active = true;
            while (active)
            {
                active = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    T x = list[i];
                    T y = list[i + 1];
                    if (comparer.Compare(x, y) > 0)
                    {
                        list[i] = y;
                        list[i + 1] = x;
                        active = true;
                    }
                }
            }
        }
        #endregion
        #region "Heap Sorting Method"
        private void btnHeap_Click(object sender, EventArgs e)
        {
            //var localArray = listOfNum.ToArray();
            var randSeed = DateTime.Now.Millisecond;
            var localArray = Shuffle(listOfNum, new Random(randSeed)).ToArray();
            Stopwatch sw = Stopwatch.StartNew();
            HeapSort(localArray);
            // Assign data and present results
            sw.Stop();
            lbETHeap.Text = sw.Elapsed.TotalSeconds.ToString() + " s.";;
            lbHeap.DataSource = localArray;
        }
        // As you can find in M.I.T. lecture "Heaps and Heap Sort", 
        // available at https://www.youtube.com/watch?v=B7hVxCmfPtM
        public static void HeapSort(int[] array2Sort)
        {
            // Build Max Heap produces a Max Heap from an unordered array
            //Length of the array to calculate Heap size
            int hSize = array2Sort.Length;
            for (int p = (hSize - 1) / 2; p >= 0; p--)
                Max_Heapify(array2Sort, hSize, p);

            for (int i = array2Sort.Length - 1; i > 0; i--)
            {
                //Swapping values
                int temp = array2Sort[i];
                array2Sort[i] = array2Sort[0];
                array2Sort[0] = temp;

                hSize--;
                Max_Heapify(array2Sort, hSize, 0);
            }
        }
        private static void Max_Heapify(int[] array2Sort, int hSize, int index)
        {
            // Corrects a single violation of the Heap property
            // in a subtree's root.
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < hSize && array2Sort[left] > array2Sort[index])
                largest = left;
            else
                largest = index;

            if (right < hSize && array2Sort[right] > array2Sort[largest])
                largest = right;

            if (largest != index)
            {
                int temp = array2Sort[index];
                array2Sort[index] = array2Sort[largest];
                array2Sort[largest] = temp;

                Max_Heapify(array2Sort, hSize, largest);
            }
        }
        #endregion
        #region "Merge Sorting Method"
        private void btnMerge_Click(object sender, EventArgs e)
        {
            var randSeed = DateTime.Now.Millisecond;
            var localArray = Shuffle(listOfNum, new Random(randSeed)).ToArray();
            Stopwatch sw = Stopwatch.StartNew();
            MergeSort(localArray, 0, localArray.Length - 1);
            // Assign data and present results
            sw.Stop();
            lbMerge.DataSource = localArray;
            lbETMerge.Text = sw.Elapsed.TotalSeconds.ToString() + " s.";;
        }

        public static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }
        #endregion

        private void btnInternal_Click(object sender, EventArgs e)
        {
            var randSeed = DateTime.Now.Millisecond;
            var localArray = Shuffle(listOfNum, new Random(randSeed)).ToList();
            listOfNum = localArray;
            Stopwatch sw = Stopwatch.StartNew();
            // In this case we use List<int> itself, since 
            // we're measuring performance of the QuickSort routine
            // embbeded in System.Collections.Generics.List<T>
            listOfNum.Sort();
            // Assign data and present results
            sw.Stop();
            lbInternal.DataSource = listOfNum.ToArray();
            lbETInternal.Text = sw.Elapsed.TotalSeconds.ToString() + " s.";;
        }
    }
}
