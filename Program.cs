using System;

namespace selfdescribingApp
{
    class SelfDescribing
    {
        // method to check the number of digits
        public void runTest()
        {
            getNumberDigits(number);
            digitApperanceCheck(number, digit);
            test();

        }

        private int getNumberDigits(int number)
        {
            int digits = 0;
            while (number > 0)
            {
                digits++;
                number = number / 10;
            }
            return digits - 1;
        }

        // method to check he amount of times a digit appears
        private int digitApperanceCheck(int number, int digit)
        {
            int count = 0;
            while (number > 0)
            {
                if (number % 10 == digit)
                {
                    count++;
                }
                number = number / 10;
            }
            return count;
        }

        public int number;
        public int temp; public int flag; public int numberDigit;
        public int appearance; public int digit;

        private void test()
        {
            temp = number;
            flag = 1;

            /*getting the returned value from the getNumberDigits function with temp as its parameter
            and assigning it to the numberDigit variable*/
            numberDigit = getNumberDigits(temp);
            while (temp > 0)
            {
                digit = temp % 10;

                /*getting the returned value from the digitApperanceCheck function
                with number and number and numberDigit as their parameters
                and assigning it to the count variable*/
                appearance = digitApperanceCheck(number, numberDigit);
                if (appearance != digit)
                {
                    flag = 0;
                    Console.WriteLine(" Not self-describing\n");
                    break;
                }
                temp = temp / 10;
                numberDigit--;
            }
            if (flag == 1)
            {
                Console.WriteLine(" Self-describing\n");
            }
        }
    }

    class NumberTest
    {
        public static int testcases;
        public static int numberInput;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of testcases\n");
            testcases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcases; i++)
            {
                Console.WriteLine("Enter number\n");
                numberInput = int.Parse(Console.ReadLine());

                SelfDescribing Testcase = new SelfDescribing();
                Testcase.number = numberInput;
                Testcase.runTest();
            }
        }
    }
}






