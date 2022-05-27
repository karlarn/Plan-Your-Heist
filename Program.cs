using System;
using System.Collections.Generic;

namespace Plan_Your_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Plan Your Heist!");
           bool keepLooping = true;
           List<TeamMember> teamList = new List<TeamMember>();
           

           while(keepLooping==true)
           {
               Console.Write("Whats your team member's name?");
               string name = Console.ReadLine();
               if (name == "") 
               {
                   keepLooping=false;
               } 
               else
               {
                    Console.Write("On a scale of 1 to 10 what is this team member's skill level?");
                    int skill = int.Parse(Console.ReadLine());
                    Console.Write("On a scale of .0 to 2.0 what is this team member's courage factor?");
                    double courage = double.Parse(Console.ReadLine());
                    TeamMember member = new TeamMember(name, skill, courage);
                    teamList.Add(member);
               }  
           }

           int accumulatedSkill = 0;
           foreach(TeamMember i in teamList)
           {
               accumulatedSkill+= i.SkillLevel;
           }

           Console.WriteLine($@"You have {teamList.Count} members on your team.
           
           The team's combined skill level is {accumulatedSkill}
           ");
           Console.Write(@"Let's do some trial runs to see how successful you are. 
           how many trials would you like to run?");
           int trialRuns = int.Parse(Console.ReadLine());

           for (int i=0; i<trialRuns;i++)
           {
            int bankLevel = 100;
           int luckValue = new Random().Next(-10,11);
           int bankDifficulty = bankLevel + luckValue;

           Console.WriteLine($"The bank has a difficulty level of {bankDifficulty}");

           if(accumulatedSkill<bankDifficulty)
           {
               Console.WriteLine("Your Heist Failed");
           }
           else
           {
               Console.WriteLine("Your Heist Succeded");
           }
           }

           
           
        }
    }
}
