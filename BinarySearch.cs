using System;

public class BinarySearch
{
    public static int Binary_Search(int[] A, int key)
    {
        int left = 0;
        int right = A.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (A[mid] == key)
            {
                return mid;
            }
            if (key < A[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1; 
    }

    public static void Main(string[] args)
    {
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int key = 5;
        int result = Binary_Search(A, key);

        if (result != -1)
        {
            Console.WriteLine(String.Format("Phan tu {0} duoc tim thay tai vi tri {1}.", key, result));
        }
        else
        {
            Console.WriteLine(String.Format("Phan tu {0} khong co trong mang.", key));
        }

        Console.ReadLine();
    }
}
