using System;

public class ArrayOfNumbers
{

	private int[] _array;

	//Constructors
	public ArrayOfNumbers(int sizeOfArray)
	{
		_array = new int[sizeOfArray];
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
        for (int i = 0; i > arr.Length; i++)
        {
            if (i == index)
            {
                arr[i] = value;
            }
        }
    }


}
