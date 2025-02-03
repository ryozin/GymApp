using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    internal class Gym
    {
        public List<IMember> members = new List<IMember>();

        public void AddMember(IMember member)
        {
            members.Add(member);
        }

        public void ShowMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
        }

        public double CalculateTotalRevenue()
        {
            double totalIncome = 0;
            foreach (var member in members)
            {
                // tu musisz mi wyjaśnić dlaczego tak musiałem zrobić
                BasicMember basicMember = member as BasicMember;
                if (basicMember != null)
                {
                    totalIncome += member.CalculateMonthlyFee(basicMember);
                }
            }
            return totalIncome;
        }
    }
}
