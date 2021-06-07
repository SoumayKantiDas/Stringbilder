using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		StringBuilder sb = new StringBuilder("Hello ", 50);

		sb.Append("World!!");
		sb.AppendLine("Hello C#!");
		sb.AppendLine("This is new line.");

		Console.WriteLine(sb);
	}
}