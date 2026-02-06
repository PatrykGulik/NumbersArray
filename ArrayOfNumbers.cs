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

    public bool Equal(int index1, int index2)
    {
        bool result = false;
        if (_array[index1] == _array[index2])
        {
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }

    public int EuclidAlgorithm(int a, int b)
    {
        a = _array[a]; b = _array[b];

        while (a != b) // Continue while a is not equal to b - if a and b are equal, then a must be the GCD
        {
            if (a > b) 
                a = a - b; // If a is greater than b, then a becomes result of a - b
            else
                b = b - a; // If b is greater than a, then b becomes result of b - a
        }return a;
    }

    public override string ToString()
    {
        return string.Join(" ", _array);
    }
}
