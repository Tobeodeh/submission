using System;

namespace ppo
{
    class Program
    {
        public void up(string sum)
           
        {
            int length = sum.Length;
            int count = 0;
            
            for(int i = 0; i<length; i++)
            {
                if (sum[i] == 'u')
                {
                    count++;
                }
                else
                {
                    break;
                }

                Console.WriteLine(count) ;
            }
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Ent the numbe of steps to check");
            int no_times = int.Parse(Console.ReadLine());
            for(int j = 0; j < no_times; j++)
            {
               string step = Console.ReadLine();

                Program Step = new Program();
                Step.up(step);

            }
        }
    }
}
