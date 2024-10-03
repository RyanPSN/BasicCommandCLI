namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length.Equals(0))
            {
                Console.WriteLine("Enter Command: ");
                string? command = Console.ReadLine();

                for (int i = 0; i < 1; i++)
                {
                    switch (IsEmpty(command))
                    {
                        case true:
                            Console.WriteLine("Empty...");
                            Console.ReadLine();
                            break;
                        case false:
                            Console.WriteLine("Command: {0}", command);
                            Console.WriteLine("Enter Your Age: ");
                            int age = Convert.ToUInt16(Console.ReadLine());
                            isOldEnough(age);
                            break;
                    }
                }
            }

            void isOldEnough(int a)
            {
                bool ageOlder = (a <= 18);
                if (ageOlder)
                {
                    Console.WriteLine("To Young To Talk");
                    return;
                }

                if (!ageOlder)
                {
                    Console.WriteLine("To Old Enough To Talk");
                    string? message = Console.ReadLine();

                    Console.WriteLine("Message: {0}", message);
                    Console.ReadLine();
                    return;
                }
            }

            static bool IsEmpty(string i)
            {
                return i == "";
            }
        }
    }
}
