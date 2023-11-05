using System.Security.Cryptography.X509Certificates;

namespace project2
{
    internal class Program
    {
        static void Divider()
        {
            Console.WriteLine("************************************************************");
        }
            public static void FibonacciRecursive(int len)
            {
                FibonacciRecursiveTemp(0, 1, 1, len);
            }
        public static void ّFibonacciRecursiveTemp (int a,int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.WriteLine(a);
                FibonacciRecursiveTemp(b, a + b, counter + 1, len);

            }
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hellocsharp!");
            Divider();
            //Console.WriteLine("please enter your gender? (m,F)");
            //string genderSTR = Console.ReadLine();
            //Console.WriteLine("pleas enter your age");
            //string ageSTR= Console.ReadLine();
            //int age = Convert.ToInt32(ageSTR);
            //if (genderSTR == "F" &&  age <= 30) 
            //{
            //    Console.WriteLine("registeration");
            //}
            //else
            //{
            //    Console.WriteLine("reject");
            //}
            Divider();
            Console.WriteLine("please enter your gender? (m,F)");
            string genderSTR = Console.ReadLine();
            Console.WriteLine("pleas enter your age");
            string ageSTR = Console.ReadLine();
            int age = Convert.ToInt32(ageSTR);
            string massage = genderSTR == "F" && age <= 30 ? "Valide" : "Intvalid";
            Console.WriteLine(massage);
            Divider();
            try
            {
                Console.WriteLine("pleas enter your phoneNumber:");
                string phonSTR = Console.ReadLine();
                int phon = Convert.ToInt32(phonSTR);

            }
            catch
            {
                Console.WriteLine("your number Invalid");
                throw;
            }
            Divider();












        }
    }
}