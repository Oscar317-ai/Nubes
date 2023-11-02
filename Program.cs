namespace Calc
{
    internal class Program
    {   
        //how to find the sum of numbers eg. 123 = 1+2+3
        static void Main(string[] args)
        {   
            //am using a loop to repeat the program "n" (3) times 
            for (int i = 0; i < 3; i++)
            {   
                // the try and catch is used to prevent the program from crashing incase words are written instead of numbers
                try
                {
                    Console.WriteLine("Give me some numbers ");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    

                    int backupValue = inputNumber;
                    int sum = 0, remainder = 0;
                    
                    // first ensure the number is not zero
                    while (inputNumber != 0)
                    {   
                        //eg. say inputNumber is 123
                        // find the remainder when inputNumber(123) is divided by 10
                        remainder = inputNumber % 10;
                        // add remainder + sum (3+0) then record it as the new sum
                        sum = (sum + remainder);
                        // divide 123 by 10
                        inputNumber = inputNumber / 10;
                    }
                    Console.WriteLine($"Sum of {inputNumber} is {sum}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("msee acha kunipima");
                }
            }
           
        }
    }
}