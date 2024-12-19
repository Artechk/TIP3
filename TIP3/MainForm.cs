namespace TIP3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string alphabet = alphabetTextBox.Text;
            string inputText = inputTextBox.Text.ToUpper();
            int key = (int)keyNumericUpDown.Value;

            if (string.IsNullOrWhiteSpace(alphabet) || string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please fill all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result;
            if (operationComboBox.SelectedItem.ToString() == "Encrypt")
            {
                result = CipherLogic.Encrypt(inputText, key, alphabet);
            }
            else
            {
                result = CipherLogic.Decrypt(inputText, key, alphabet);
            }

            outputTextBox.Text = result;
        }
    }
}
