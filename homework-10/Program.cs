using System;

namespace homework_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       IAccount (interface):
                   - PasswordChecker() - parametr olaraq string password qəbul edir.
                   - ShowInfo()
                      User class (IAccount-u implement edir)
                   - Id
                   - Fullname
                   - Email
                   - Password
                   - PasswordChecker() - PasswordChecker methodu -
                     gələn string password dəyərinin şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarir.    

                                           Şərtlər:
                        - şifrədə minimum 8 character olmalıdır
                        - şifrədə ən az 1 böyük hərf olmalıdır
                        - şifrədə ən az 1 kiçik hərf olmalıdır
                        - şifrədə ən az 1 rəqəm olmalıdır
                   - ShowInfo() - bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır

                ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır 
                və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar.
                User yarandığı zaman email və password təyin edilməsi məcburidir.
                User-ə şifrə təyin edilərkən şifrənin PasswordChecker methodunun şərtlərini ödəməsi lazımdır.


            */


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
