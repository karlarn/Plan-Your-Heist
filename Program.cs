using System;

namespace Plan_Your_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember hal= new TeamMember("hal",6,1.2);

            Console.WriteLine($"{hal.Name}, {hal.SkillLevel}, {hal.CourageFactor}");
        }
    }
}
