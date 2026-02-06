using System;

namespace NumbersArray
{
    public partial class Form1 : Form
    {

        private ArrayOfNumbers arrayOfNumbers;

        private int arraySize;

        private int arrayIndex;
        private int index;

        private int inputEqualIndex1;
        private int inputEqualIndex2;

        private int inputGCDIndex1;
        private int inputGCDIndex2;

        private int arrayValue;


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ArraySize_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_Index.Text, out index);
            Lbl_ArraySize.Text = arrayOfNumbers.FindValueAtIndex(index).ToString();

        }
        private void Btn_AddArray_Click_1(object sender, EventArgs e)
        {
            string input = Txt_AddArray.Text;
            int[] numbers = ParseInputToArray(input);
            arrayOfNumbers = new ArrayOfNumbers(numbers);
        }

        private void Btn_AddInt_Click(object sender, EventArgs e)
        {

            int.TryParse(Txt_AddIndex.Text, out arrayIndex);
            int.TryParse(Txt_AddInt.Text, out arrayValue);
            arrayOfNumbers.SetValueAtIndex(arrayIndex, arrayValue);
            Lbl_ArrayElements.Text = string.Join(" ", arrayOfNumbers.Array);

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Lbl_FindMax.Text = arrayOfNumbers.FindMax().ToString();
        }

        private void Btn_CountElements_Click(object sender, EventArgs e)
        {
            Lbl_CountElements.Text = arrayOfNumbers.ArraySize.ToString();
        }

        private void Btn_Sum_Click(object sender, EventArgs e)
        {
            Lbl_Sum.Text = arrayOfNumbers.SumArray().ToString();
        }

        private void Btn_Avg_Click(object sender, EventArgs e)
        {
            Lbl_Avg.Text = arrayOfNumbers.AvgArray().ToString();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_EqualIndex1.Text, out inputEqualIndex1);
            int.TryParse(Txt_EqualIndex2.Text, out inputEqualIndex2);

            Lbl_Equal.Text = arrayOfNumbers.Equal(inputEqualIndex1, inputEqualIndex2).ToString();
        }

        private void Btn_GCD_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_GCD1.Text, out inputGCDIndex1);
            int.TryParse(Txt_GCD2.Text, out inputGCDIndex2);

            Lbl_GCD.Text = arrayOfNumbers.EuclidAlgorithm(inputGCDIndex1, inputGCDIndex2).ToString();
        }

        private void Btn_ShowArray_Click(object sender, EventArgs e)
        {
            Lbl_Array.Text = arrayOfNumbers.ToString();
        }
    }
}

//string.Join(" ", arrayOfNumbers.Array);
