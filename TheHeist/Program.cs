using System;
using TheHeist.Team;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("");

            var teammember = new TeamMember();
            //var TeamMember = new TeamMember();




            teammember.BuildTeamMember();




            Console.ReadKey();

        }






    }
}


// Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.