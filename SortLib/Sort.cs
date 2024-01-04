namespace SortLib
{
    public class Sort
    {
        //**********  01-冒泡排序  **********//
        public static void BubbleSort(int[] arr)
        { 
            int len = arr.Length;
            int i, j, temp;
            for (i = 0; i < len - 1; i++)
                for (j = 0; j < len - 1 - i; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        //**********  02-归并排序  **********//
        public static void MergeSort(int[] arr) 
        {
            //int len = arr.Length;
            if (arr.Length <= 1)
            {
                return;
            }
            else
            {
                int halflen = arr.Length / 2;
                int[] tempa = new int[halflen];
                int[] tempb = new int[arr.Length - halflen];

                Array.Copy(arr, 0, tempa, 0, halflen);
                Array.Copy(arr, halflen, tempb, 0, tempb.Length);

                MergeSort(tempa);
                MergeSort(tempb);

                int a = 0;
                int b = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (a >= tempa.Length)
                    {
                        arr[i] = tempb[b++];
                    }
                    else if (b >= tempb.Length)
                    {
                        arr[i] = tempa[a++];
                    }
                    else
                    {
                        if (tempa[a] <= tempb[b])
                        {
                            arr[i] = tempa[a++];
                        }
                        else
                        {
                            arr[i] = tempb[b++];
                        }
                    }
                }

            }
        }
        
    }
}
