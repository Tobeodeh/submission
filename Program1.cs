using System;

namespace NumSelfdes
{
   
    class Program
    {
        private static int count;
        private static int b;

        static int sSelfdescribing(int num)
        {   /* Member fuction sSelfdescribing compares the values of */

            /*converts the inputed arguement to string and then loop through the string
             s represnts the whole inputed integer convertrd to a string
            temp reperesents each value of the string seperated by space
            b represent the integer form of temp */
            string s = num.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                int count;
                string temp = s[i] + "";
                 b = int.Parse(temp);
              
                count = 0;
                //creating another for loop to check 
                for (int j = 0; j < s.Length; j++)
                {
                    int temp_value = int.Parse(s[j] + "");
                    if (temp_value == i)
                    {
                        count++;
                    }

                }
                
            }
            return count;
        }
         static bool check(int num)
            {
                if (sSelfdescribing(num) != b)
                {
                    return false;  
                }

            return true;  
            }
        public void print(int num)
        {
            if (check(num) == true)
            {
                Console.WriteLine("Self Describing");
            }

            if(check(num)== false)
            {
                Console.WriteLine(" Not Self Describing");
            }
        }
           
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of values to check: ");
            int no_times = int.Parse(Console.ReadLine());
            for(int i = 0; i<no_times; i++)
            {
                Console.WriteLine("Enter Number to check: ");
                int num = int.Parse(Console.ReadLine());

                Program Test = new Program();
                Test.print(num);
            }

        }
    }
}
