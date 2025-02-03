using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    internal interface IMember
    {
        public string GetMemberShipInfo(BasicMember basicMember);

        public double CalculateMonthlyFee(BasicMember basicMember);

             

    }
}
