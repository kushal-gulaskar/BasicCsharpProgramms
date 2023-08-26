namespace CSharpProgramms
{
    internal class ReverseEachWordFromStringNew
    {
        public static void Main(string[] args)
        {
            string originalString = "This Is Kushal";

            string[] Splitstring = originalString.Split(' ');

            string reverseWordString = string.Join(" ", Splitstring
            .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(reverseWordString);
        }
    }
}
