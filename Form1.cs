namespace NumbersArray
{
    public partial class Form1 : Form
    {

        private ArrayOfNumbers arrayOfNumbers;

        private int arraySize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ArraySize_Click(object sender, EventArgs e)
        {
            int.TryParse(Txt_ArraySize.Text, out arraySize);
            arrayOfNumbers = new ArrayOfNumbers(arraySize);
            Lbl_Test.Text = arrayOfNumbers.Array.Length.ToString();
        }
    }
}
