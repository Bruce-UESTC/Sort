//#define BUBBLESORT
#define MERGESORT

using SortLib;

#if BUBBLESORT

Console.WriteLine("下面是冒泡排序测试：");
int[] buff1 = RandomSequence(5);
BubbleSortTest(buff1);

#elif MERGESORT

Console.WriteLine("下面是归并排序测试：");
int[] buff2 = RandomSequence(10);
MergeSortTest(buff2);

#endif

static int[] RandomSequence(int len)
{
    int[] buffer = new int[len];
    Random rdm = new Random();
    for (int i = 0; i < len; i++)
    {
        buffer[i] = rdm.Next(100);
    }

    Console.WriteLine("{0}个数的随机序列:", len);

    foreach (int i in buffer)
    {
        Console.WriteLine(i);
    }

    return buffer;
}

 static void BubbleSortTest(int[] buffer)
{
    Console.WriteLine("冒泡排序后的结果:");   
    Sort.BubbleSort(buffer);

    foreach (int i in buffer)
    {
        Console.WriteLine(i);
    }
}

static void MergeSortTest(int[] buffer)
{     
    Console.WriteLine("归并排序后的结果");
    Sort.MergeSort(buffer);

    foreach (int i in buffer)
        Console.WriteLine(i);
}