using System;
namespace YatzyDemo
{
class Program
{
    static void Main(string[] args)
    {
        int[] result = RollFive();
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
            Console.ReadLine();
    }
    static int[] RollFive()
    {
        Random random = new Random();
        int[] dice = new int[5];

        for (int i = 0; i < 5; i++)
        {
            dice[i] = random.Next(1, 7);
        }
        return dice;


    }
}