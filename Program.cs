namespace topic_8_tut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            string name;

            name = "Aldworth";

            Console.WriteLine(name[0]);
            Console.WriteLine(name.Substring(3, 4));//four letters starting from letter 3
            Console.WriteLine(name[2] + name.Substring(4, 4));

            char.ToUpper(name[0]);
            (name[0] + "").ToUpper();
            name[0].ToString().ToUpper();
            name.Substring(0, 1).ToUpper();
            //all of these take the first letter and capatalize it 
            */

            string firstName, lastName, studentNum;
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            firstName[0].ToString().ToUpper();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            lastName[0].ToString().ToUpper();
            Console.WriteLine("What is your student number?");
            studentNum = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}. Here is your information:");
            Console.WriteLine("Username:");
            Console.WriteLine(firstName.Substring(0, 3) + lastName.Substring(0, 3) + studentNum.Substring(0, 3));
            Console.WriteLine("Email:");
            Console.WriteLine(firstName[0] + lastName + "@parkside.com");


        } 
       
    }
}
