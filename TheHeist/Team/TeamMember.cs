using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist.Team
{
    class TeamMember
    {
        //properties
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }





        public TeamMember()
        {
            //Name = name;
            //SkillLevel = skillLevel;
            //CourageFactor = courageFactor; 
        }


        //public List<TeamMembers> TeamMembers = new List<TeamMembers>();


        // methods
        public void BuildTeamMember()
        {

           
            Console.WriteLine("Who do you want to add to your team?");
            var Name = Console.ReadLine();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("");





            Console.WriteLine("What's their skill level? Enter a positive number.");
            var SkillLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Skill Level: {SkillLevel.GetType()}");
            Console.WriteLine($"Skill Level: {SkillLevel}");

            Console.WriteLine("");





            Console.WriteLine("Enter a courage factor between 0.0 and 2.0");
            var CourageFactor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Courage Factor: {CourageFactor}");
            Console.WriteLine("");



            Console.WriteLine($"You picked {Name} that has a skill level of {SkillLevel} and a courage factor of {CourageFactor}.");



            

            var individualTeamMember = new TeamMember (string "{Name}", int SkillLevel, decimal CourageFactor);
            //Console.WriteLine($"individualTeamMember: {individualTeamMember}");
            //Console.WriteLine(individualTeamMember.GetType());


            Console.ReadKey();

        }


    }
}


//1. Print the message "Plan Your Heist!".
//2. Create a way to store a single team member.A team member will have a * name*, a* skill Level* and a* courage factor*. The* skill Level* will be a positive integer and the * courage factor* will be a decimal between 0.0 and 2.0.
//3. Prompt the user to enter a team member's name and save that name.
//4. Prompt the user to enter a team member's skill level and save that skill level with the name.
//5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
//6. Display the team member's information.