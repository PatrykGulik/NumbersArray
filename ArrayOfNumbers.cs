using System;

public class ArrayOfNumbers
{


    public int FindValueAtIndex(int[] arr, int index)
    {
        return arr[index];
    }

    public void SetValueAtIndex(int[] arr, int index, int value) 
    {
        for (int i = 0; i > arr.length; i++)
        {
            if (i == index)
            {
                arr[i] = value;
            }
        }
    }


}
