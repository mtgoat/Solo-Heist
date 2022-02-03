using System;

namespace soloHeist
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("\n Let Us Plan Your Heist!");

            Questions("\n Let us gather a team for the heist.  \n What is a member's name?","\nGreat!  Next, what is the member's skill level?", "\nSuper! Lastly what is the member's courage factor? Please enter from 0.00 to 2.00.");

            

        }

        static void Questions (string question1, string question2, string question3){
            Console.WriteLine(question1);

            string typedName = Console.ReadLine();

            Console.WriteLine(question2);

            int typedSkillLevel = Int32.Parse(Console.ReadLine());

            Console.WriteLine(question3);

            double typedCourageFactor = Double.Parse(Console.ReadLine ());

            Member member1 = new Member {
            name = typedName,
            skillLevel = typedSkillLevel,
            courageFactor = typedCourageFactor
             };

             Console.WriteLine($"\nYou have entered the member's name as \"{member1.name}\" with the skill level of \"{member1.skillLevel}\" and with the courage factor of \"{member1.courageFactor}.\" ");

        }

             


             

            

             

           






        }
    }

