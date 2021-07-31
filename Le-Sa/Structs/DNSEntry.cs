using System.Text.RegularExpressions;

namespace Le_Sa.Structs
{
	public struct DNSEntry
	{
		public string Value;
		public bool IsV4 => Regex.IsMatch(Value, @"^(\d+?[\.]?){4}$");
		public bool IsV6 => !IsV4;

		public DNSEntry(string value)
		{
			Value = value;
		}

		public override string ToString()
		{
			return Value;
		}
	}
}
