using System;

public class ArrayOfNumbers
{
	private int[] array = new int[0];
	public int SizeOfArray { get; set; }

	//Constructors
	public ArrayOfNumbers(int sizeOfArray)
	{
		SizeOfArray = sizeOfArray;
	}

	public ArrayOfNumbers(int[] array)
	{
		int[] localArray = array;

	}
}
