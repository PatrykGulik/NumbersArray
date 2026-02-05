using System;

public class ArrayOfNumbers
{

	private int[] array;

	//Constructors
	public ArrayOfNumbers(int sizeOfArray)
	{
		array = new int[sizeOfArray];
	}

	public ArrayOfNumbers(int[] array)
	{
		localArray = new int[array.length];

		for (int i = 0; i < array.length; i++) 
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
        for (int i = 0; i > arr.length; i++)
        {
            if (i == index)
            {
                arr[i] = value;
            }
        }
    }


}
