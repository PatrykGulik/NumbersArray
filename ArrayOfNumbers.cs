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
}
