using System;

public class ArrayOfNumbers
{

    public int[] Array {get; set;}


	//Constructors
	public ArrayOfNumbers(int sizeOfArray)
	{
        Array = new int[sizeOfArray];
	}

	public ArrayOfNumbers(int[] array)
	{
		int[] localArray = new int[array.Length];

		for (int i = 0; i < array.Length; i++) 
		{
			localArray[i] = array[i];
		}
	}

    public int FindValueAtIndex(int[] arr, int index)
    {
        return arr[index];
    }

    public void SetValueAtIndex(int[] arr, int index, int value) 
    {
        if (index < 0 || index > arr.Length)
        {
            throw new IndexOutOfRangeException("Out of range - choose another index number");
        }

        arr[index] = value;
    }

}
