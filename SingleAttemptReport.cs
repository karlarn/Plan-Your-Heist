using System;
using System.Collections.Generic;

namespace Plan_Your_Heist
{
    public class SingleReport
    {
        public int BankLevel {get; set; }

        public int SkillLevel {get; set;}
         


       public SingleReport(int name, int skill)
        {
            BankLevel = name;
            SkillLevel = skill;
        }
    }
    
}