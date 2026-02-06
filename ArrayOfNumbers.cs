using System;

public class ArrayOfNumbers
{

    private int[] _array;

    public int[] Array
    {
        get { return _array; }
    }

    public int ArraySize
    {
        get { return _array.Length; }
    }

	//Constructors
	public ArrayOfNumbers(int sizeOfArray)
	{
        _array = new int[sizeOfArray];
	}

	public ArrayOfNumbers(int[] array)
	{
		_array = new int[array.Length];

		for (int i = 0; i < array.Length; i++) 
		{
            _array[i] = array[i];
		}
	}

    public int FindValueAtIndex(int index)
    {
        return _array[index];
    }

    public void SetValueAtIndex(int index, int value) 
    {
        if (index < 0 || index > _array.Length)
        {
            throw new IndexOutOfRangeException("Out of range - choose another index number");
        }

        _array[index] = value;
    }

    public int FindMax()
    {
        return _array.Max();
    }

    public int SumArray()
    {
        return _array.Sum();
    }

    public int AvgArray()
    {
        return SumArray() / _array.Length;
    }
}
