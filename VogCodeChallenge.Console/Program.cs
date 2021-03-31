namespace VogCodeChallenge.Console
{
    internal class Program
    {
        public static void Main()
        {
            using var enumerator = QuestionClass.NamesList.GetEnumerator();

            while (enumerator.MoveNext())
            {
                System.Console.WriteLine(enumerator.Current);
            }
        }
    }
}
