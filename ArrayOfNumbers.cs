using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
 * Patryk Gulik
 * 11002010
 * Class: ArrayOfNumbers
 * Class that manages an array of integers
 * and provides various operations on the array
 */
public class ArrayOfNumbers
{
    // Fields
    private int[] _array;

    // Properties
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

    // Methods

    // Returns the value of given index
    public int FindValueAtIndex(int index)
    {
        return _array[index];
    }

    // Sets the specified index with a given value
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

    // Checks if values at two specified indices are equal
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

    // Find the GCD of two values in specified indices
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

    // Returns the internal state of the array
    public override string ToString()
    {
        return string.Join(" ", _array);
    }

    //Mutator methods

    // Scalar multiplies each array element by a given multiplier
    public int[] Scalar(int multiplier)
    {
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = _array[i] * multiplier;
        }
        return _array;
    }

    // Adds a constant to each array element
    public int[] AddConstant(int constant)
    {
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = _array[i] + constant;
        }
        return _array;
    }
}
