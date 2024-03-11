namespace Encryptor.Tests
{
	internal class CryptTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("a b c d", "z a b c")]
		[TestCase("code", "bncd")]
		[TestCase("Aboba", "zanaz")]
		[TestCase("Hello world", "gdkkn vnqkc")]
		public void EncodeTest_Ok(string code, string result)
		{
			var encode = Vest.Crypt.Encode(code);
			Console.WriteLine(encode);
			Assert.IsTrue(encode.Equals(result));
		}

		[TestCase("bncd", "code")]
		[TestCase("zanaz", "aboba")]
		[TestCase("gdkkn vnqkc", "hello world")]
		public void DecodeTest_Ok(string code, string result)
		{
			var decode = Vest.Crypt.Decode(code);
			Console.WriteLine(decode);
			Assert.IsTrue(decode.Equals(result));
		}

		[TestCase("nasta suchka krashenaya", "suchka krashenaya nasta")]
		[TestCase("suchka krashenaya nasta", "krashenaya nasta suchka")]
		[TestCase("gdkkn vnqkc", "vnqkc gdkkn")]
		[TestCase("vnqkc gdkkn", "gdkkn vnqkc")]
		[TestCase("abcr dfgw hcfq qwer", "dfgw hcfq abcr qwer")]
		[TestCase("abcr dfgw hcfq qwer wert", "dfgw hcfq abcr qwer wert")]
		public void TranspositionTest_Ok(string input, string result)
		{
			var trans = Vest.Crypt.Transposition(input);
			Console.WriteLine(trans);
			Assert.IsTrue(trans.Equals(result));
		}

		[TestCase("nasta suchka krashenaya")]
		[TestCase("nasta suchka krashenaya a")]
		[TestCase("nasta suchka")]
		public void TranspositionTest_Tuda(string input)
		{
			var trans = Vest.Crypt.Transposition(input);
			Console.WriteLine(trans);
			trans = Vest.Crypt.Detransposition(trans);
			Console.WriteLine(trans);
			Assert.IsTrue(trans.Equals(input));
		}
	}
}
