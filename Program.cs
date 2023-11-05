namespace project2
{
    internal class Program
    {
        static void Divider()
        {
            Console.WriteLine("************************************************************");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hellocsharp!");
            Divider();
            Console.WriteLine("please enter your gender? (m,F)");
            string genderSTR = Console.ReadLine();
            Console.WriteLine("pleas enter your age");
            string ageSTR= Console.ReadLine();
            int age = Convert.ToInt32(ageSTR);
            if (genderSTR == "F" &&  age <= 30) 
            {
                Console.WriteLine("registeration");
            }
            else
            {
                Console.WriteLine("reject");
            }
            Divider();

            Console.WriteLine("Hellocsharp!");
            Divider();
            Console.WriteLine("please enter your gender? (m,F)");
            string genderSTR2 = Console.ReadLine();
            Console.WriteLine("pleas enter your age");
            string ageSTR2 = Console.ReadLine();
            int age2 = Convert.ToInt32(ageSTR);

            bool gender = default;
            gender = genderSTR == "F" && age <=30? true : false;    
            
          
            

        }
    }
}