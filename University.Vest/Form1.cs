namespace University.Osipan
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input = richTextBox1.Text;

			var result = Encryptor.Vest.Crypt.Encrypt(input);
			label5.Text = result.ToUpper();

			result = Encryptor.Vest.Crypt.Decrypt(result);
			label9.Text = result.ToUpper();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
