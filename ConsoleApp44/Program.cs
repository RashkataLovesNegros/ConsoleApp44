namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            int diddy = int.Parse(Console.ReadLine());

            Console.WriteLine(Sort.SortN(array, diddy));
        }
    }
}
