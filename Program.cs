using System;
using System.Collections.Generic;

namespace Plan_Your_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(@"Plan Your Heist!
           
           ");
           bool keepLooping = true;
           Console.Write("On a scale of 1 to 100 how good is the bank's security?");
           Console.WriteLine("");
           int bankLevel = int.Parse(Console.ReadLine());
           List<TeamMember> teamList = new List<TeamMember>();
           

           while(keepLooping==true)
           {
               Console.Write("Whats your team member's name?");
               string name = Console.ReadLine();
               if (name == "") 
               {
                   Console.WriteLine("");
                   keepLooping=false;
               } 
               else
               {
                   Console.WriteLine("");
                    Console.Write("On a scale of 1 to 10 what is this team member's skill level?");
                    int skill = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("On a scale of .0 to 2.0 what is this team member's courage factor?");
                    double courage = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
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
           Console.WriteLine("");

           List<SingleReport> failedAttempts = new List<SingleReport>();
           List<SingleReport> successfulAttempts = new List<SingleReport>();

           for (int i=0; i<trialRuns;i++)
           {
           int luckValue = new Random().Next(-10,11);
           int bankDifficulty = bankLevel + luckValue;


           if(accumulatedSkill<bankDifficulty)
           {
               SingleReport failed = new SingleReport(bankDifficulty, accumulatedSkill);
               failedAttempts.Add(failed);
           }
           else
           {
               SingleReport success = new SingleReport(bankDifficulty, accumulatedSkill); 
               successfulAttempts.Add(success);

           }
           }

           Console.WriteLine("Success Report");

           foreach(SingleReport i in successfulAttempts)
           {
               Console.WriteLine($"The bank's difficulty of {i.BankLevel} beat your team's skill level of {i.SkillLevel}.");
            }

            Console.WriteLine("Failure Report");

            foreach(SingleReport i in failedAttempts)
            {
                Console.WriteLine($"Your team's skill level of {i.SkillLevel} beat the bank's difficulty of {i.BankLevel}.");
            }
           
        }
    }
}
