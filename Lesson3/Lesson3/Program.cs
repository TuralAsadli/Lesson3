namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FindSmallerNumber();
            FindBiggerNumber();
            FIndWithBubbleShort();
        }

        //O(n)
        //Task1 First solutions
        public static void FindSmallerNumber()
        {
            int[] number = { 4, 5, 6, 3, 2, 5, 7, 2, 1, 6, 0,-1,-5,-7 };
            int start = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (start > number[i])
                {
                    start=number[i];
                }
            }
            Console.WriteLine(start);
            

        }

        //O(2n)
        //Task2 First solutions
        public static void FindBiggerNumber()
        {
            int[] numbers = { 3, 5, 6, 2, 1, 55, 66, 22, 11, 7777, 0 };
            int start = 0;
            int caunt = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > start) start = numbers[i];
                
            }
            while (start > 1)
            {
                start /= 10;
                caunt++;

            }
            Console.WriteLine(caunt);
            
            
        }

        //Task2 Second solutions
        //(Algorithm : Bubble sort) O(n**2)
        public static void FIndWithBubbleShort()
        {
            int[] numbers = { 3, 5, 6, 2, 1, 55, 66, 22, 11, 7777, 0 };
            int start = 0;
            int end = 0;
            int caunt = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[j-1])
                    {
                        start = numbers[j];
                        end = numbers[j-1];
                        numbers[j - 1] = start;
                        numbers[j] = end;
                        
                    }
                }
            }
            int biggerNumber = numbers[numbers.Length - 1];
            while (biggerNumber > 1)
            {
                biggerNumber /= 10;
                caunt++;

            }
            Console.WriteLine(caunt);

        }

        //Task1 Second solutions
        //Added for fun and cry
        public static void ForFunAndCry()
        {
            int[] number = { 4, 5, 6, 3, 2, 5, 7, 2, 1, 6, 0, -1, -5, -7 };
            var i = number.Min();
            Console.WriteLine(i);
        }

    }
}