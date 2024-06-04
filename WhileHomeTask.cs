using System;

namespace DovrlerTasks
{
    internal class WhileHomeTask
    {
        static void Main(string[] args)
        {
            int enterNum = int.Parse(Console.ReadLine());
            ArrCreater(enterNum);
            int element;

        }
        public static void ArrCreater(int num)
        {
            int[] arr;
            Random random;
            int arrCounter = 0;
            int index = 0;
            int randomNum;
            int totalCounter = 0;
            while (totalCounter < num)
            {
                arrCounter = 0;
                while (arrCounter < num)
                {
                    arrCounter++;
                    arr = new int[num];
                    index = 0;
                    while (index < num)
                    {
                        random = new Random();
                        randomNum = random.Next(1, 50);
                        while (arr.Contains(randomNum))
                        {
                            randomNum = random.Next(1, 50 - randomNum);
                        }
                        arr[index] = randomNum;
                        Console.Write(arr[index] + " ");
                        index++;
                    }
                    Console.WriteLine();

                }
                Console.WriteLine(new String('-', 100));
                totalCounter++;

            }

        }

    }
}
