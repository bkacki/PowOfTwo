namespace PowOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var powersOfTwo = new PowersOfTwo();
            for(int i = 0; i<powersOfTwo.Count(); i++)
                Console.WriteLine($"2^{i} = {powersOfTwo[i]}");
        }
    }
}
