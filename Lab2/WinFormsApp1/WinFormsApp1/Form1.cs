namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        MyTestClass testClass = new MyTestClass();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1OnClick;
        }

        private void Button1OnClick(object? sender, EventArgs e)
        {
            testClass.ShowMethodNamesContainingStrParams(NAME_SPACE + ClassNameStrParamsTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testClass.InvokeMethodFromFile(NAME_SPACE + ClassNameInvokeMethodTextBox.Text, MethodNameTextBox.Text);
        }

        private string NAME_SPACE = "WinFormsApp1.";

        private void button3_Click(object sender, EventArgs e)
        {
            testClass.PrintAllMembersToFile(NAME_SPACE + ClassNameAllMembersToFileTextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testClass.GenerateClassFile(ClassNameGenerateFileTextBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            testClass.Parse(NAME_SPACE + ClassNameConsoleParserTextBox.Text, CommandTextBox.Text);
        }
    }
}