using System;

namespace homework_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FullName daxil edin");
            string fullname = Console.ReadLine();
            Console.WriteLine("emailinizi daxil edin");
            string email = Console.ReadLine();
            Console.WriteLine("passwordunuzu daxil en 1 boyuk herf bir balaca herif ve 1 reqem olmalidi edin");
            string password = Console.ReadLine();
            User user = new User(fullname, email, password);





            Console.WriteLine("FullName daxil edin");
            string Fullname = Console.ReadLine();
            Console.WriteLine("emailinizi daxil edin");
            string Email = Console.ReadLine();
            Console.WriteLine("passwordunuzu daxil edin");
            string Password = Console.ReadLine();

            User user1 = new User(Fullname, Email, Password);


        }

        public interface IAccount
        {
            bool PassswordChecker(string password);

            void ShowInfo();

        }
    




    }
}
