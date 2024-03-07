using System.Xml.Linq;

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
            
            name[0].ToString().ToUpper();
            name.Substring(0, 1).ToUpper();
            //all of these take the first letter and capatalize it 
            */

            string firstName, lastName, studentNum, reverseName, backwards;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your student number?");
            studentNum = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}. Here is your information:");
            Console.WriteLine("Username:");
            Console.WriteLine(firstName.Substring(0, 3) + lastName.Substring(0, 3) + studentNum.Substring(0, 3));
            Console.WriteLine("Email:");
            Console.WriteLine(firstName[0] + lastName + "@parkside.com");

            Console.WriteLine($"{firstName.ToUpper()} {lastName.ToLower()}");
            reverseName = (firstName + lastName);
            Console.WriteLine(reverseName);
            backwards = "";
            for (int i = reverseName.Length - 1; i >= 0; i--)
            {
                backwards = backwards + reverseName.Substring(i, 1);
            }

            backwards = "";

            for (int i = 0; i < reverseName.Length; i++)
            {
                backwards = reverseName.Substring(i, 1) + backwards;
            }

            Console.WriteLine(backwards);

            
            /*
            string name1 = "jordyna";
            string name2 = "Jordyna";
            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            string words = "Tom and Jerry";
            if (words.Contains("and"))
            {
                Console.WriteLine("The phrase contains and.");
            }
            else
            {
                Console.WriteLine("The phrase does not contain and.");
            }
            */

            

        } 
       
    }
}
