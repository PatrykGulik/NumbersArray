namespace NumbersArray
{
    public partial class Form1 : Form
    {

        private ArrayOfNumbers arrayOfNumbers;

        private int arraySize;

        private int arrayIndex;

        private int arrayValue;


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ArraySize_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_ArraySize.Text, out arraySize);
            arrayOfNumbers = new ArrayOfNumbers(arraySize);
            Lbl_ArraySize.Text = $"The size of array is: {arrayOfNumbers.Array.Length.ToString()}";
            
        }

        private void Btn_AddInt_Click(object sender, EventArgs e)
        {

            int.TryParse(Txt_AddIndex.Text, out arrayIndex);
            int.TryParse(Txt_AddInt.Text, out arrayValue);
            arrayOfNumbers.SetValueAtIndex(arrayOfNumbers.Array, arrayIndex, arrayValue);
            Lbl_ArrayElements.Text = string.Join(" ", arrayOfNumbers.Array);

        }
    }
}

//string.Join(" ", arrayOfNumbers.Array);
