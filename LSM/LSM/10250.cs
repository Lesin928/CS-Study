class Program
{
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine()!); 
        for (int i = 0; i < T; i++)
        {
            string[] input = (Console.ReadLine()!).Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);
            int N = int.Parse(input[2]);

            int result = ((N - 1) / H) + ((N - 1) % H) * 100 + 101;
            Console.WriteLine(result);
        }
    }
}