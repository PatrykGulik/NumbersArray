using System;
/*
 * Patryk Gulik
 * 11002010
 * Class: Form1
 * Calls methods on interaction with UI elements
 */
namespace NumbersArray
{
    public partial class Form1 : Form
    {
        // Fields
        private ArrayOfNumbers arrayOfNumbers;

        private int index;

        private int arrayIndex;
        private int arrayValue;

        private int inputEqualIndex1;
        private int inputEqualIndex2;

        private int inputGCDIndex1;
        private int inputGCDIndex2;

        private int inputScale;
        private int inputConstant;



        public Form1()
        {
            InitializeComponent();
        }

        // Fills the array and instantiates the object
        private void Btn_AddArray_Click_1(object sender, EventArgs e)
        {
            string input = Txt_AddArray.Text;
            int[] numbers = ParseInputToArray(input);
            arrayOfNumbers = new ArrayOfNumbers(numbers);
        }

        // Displays array element at a specific index
        private void Btn_ArraySize_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_Index.Text, out index);
            Lbl_ArraySize.Text = arrayOfNumbers.FindValueAtIndex(index).ToString();

        }

        // Sets an element at specified index to a given value
        private void Btn_AddInt_Click(object sender, EventArgs e)
        {

            int.TryParse(Txt_AddIndex.Text, out arrayIndex);
            int.TryParse(Txt_AddInt.Text, out arrayValue);
            arrayOfNumbers.SetValueAtIndex(arrayIndex, arrayValue);
            Lbl_ArrayElements.Text = string.Join(" ", arrayOfNumbers.Array);

        }

        // Parses TextBox input into an array of numbers
        public int[] ParseInputToArray(string input)
        {
            string[] parts = input.Split(' ');
            List<int> numbers = new List<int>();

            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    numbers.Add(int.Parse(part));
                }
            }
            return numbers.ToArray();
        }

        // Finds the highest number in an array
        private void button1_Click(object sender, EventArgs e)
        {
            Lbl_FindMax.Text = arrayOfNumbers.FindMax().ToString();
        }

        // Counts all elements in an array
        private void Btn_CountElements_Click(object sender, EventArgs e)
        {
            Lbl_CountElements.Text = arrayOfNumbers.ArraySize.ToString();
        }

        // Sums all values in the array
        private void Btn_Sum_Click(object sender, EventArgs e)
        {
            Lbl_Sum.Text = arrayOfNumbers.SumArray().ToString();
        }

        // Calculates the average number in the array
        private void Btn_Avg_Click(object sender, EventArgs e)
        {
            Lbl_Avg.Text = arrayOfNumbers.AvgArray().ToString();
        }

        // Checks if values at two indices are equal
        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_EqualIndex1.Text, out inputEqualIndex1);
            int.TryParse(Txt_EqualIndex2.Text, out inputEqualIndex2);

            Lbl_Equal.Text = arrayOfNumbers.Equal(inputEqualIndex1, inputEqualIndex2).ToString();
        }

        // Calculates the GCD
        private void Btn_GCD_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_GCD1.Text, out inputGCDIndex1);
            int.TryParse(Txt_GCD2.Text, out inputGCDIndex2);

            Lbl_GCD.Text = arrayOfNumbers.EuclidAlgorithm(inputGCDIndex1, inputGCDIndex2).ToString();
        }
        
        // Returns the formatted array as string
        private void Btn_ShowArray_Click(object sender, EventArgs e)
        {
            Lbl_Array.Text = arrayOfNumbers.ToString();
        }

        // Multiplies each element by a given multiplier
        private void Btn_Scale_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_Scale.Text, out inputScale);
            Lbl_Scale.Text = string.Join(" ", arrayOfNumbers.Scalar(inputScale));
        }

        // Adds a constant to each array element
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_Constant.Text, out inputConstant);
            Lbl_Constant.Text = string.Join(" ", arrayOfNumbers.AddConstant(inputConstant));
        }
    }
}

