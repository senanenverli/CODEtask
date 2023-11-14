using System;

namespace code_task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                User user1 = new User("senan", "elekberovsenan22@gmail.com", "Password123", 1);
   
                user1.ShowInfo();
            }
            catch (IncorrectPaswordException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
