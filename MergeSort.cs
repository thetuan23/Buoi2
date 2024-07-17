using System;

public class MergeSort
{
    public static void Merge_Sort(int[] A, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            Merge_Sort(A, left, mid);
            Merge_Sort(A, mid + 1, right);
            Merge(A, left, mid, right);
        }
    }

    private static void Merge(int[] A, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            L[i] = A[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            R[j] = A[mid + 1 + j];
        }

        int k = left;
        int iIndex = 0, jIndex = 0;
        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                A[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                A[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            A[k] = L[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            A[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }

    public static void Main(string[] args)
    {
        int[] A = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Mang truoc khi sap xep:");
        foreach (int item in A)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Merge_Sort(A, 0, A.Length - 1);

        Console.WriteLine("Mang sau khi sap xep:");
        foreach (int item in A)
        {
            Console.Write(item + " ");
        }

        Console.ReadLine();
    }
}
