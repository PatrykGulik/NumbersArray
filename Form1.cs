using System;

namespace NumbersArray
{
    public partial class Form1 : Form
    {

        private ArrayOfNumbers arrayOfNumbers;

        private int arraySize;

        private int arrayIndex;
        private int index;

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
            Lbl_Array.Text = string.Join(" ", arrayOfNumbers.Array);
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
    }
}

//string.Join(" ", arrayOfNumbers.Array);
