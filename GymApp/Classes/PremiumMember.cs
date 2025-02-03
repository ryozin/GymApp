using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymApp
{
    internal class PremiumMember : BasicMember
    {
        public double discountPercentage;
        private double sum;

        public PremiumMember(string name, double baseFee, double discountPercentage) : base(name, baseFee)
        {
            this.discountPercentage = discountPercentage;
        }

        public override string GetMemberShipInfo(BasicMember basicmember)
        {
           return base.GetMemberShipInfo(basicmember) + "premium";
        }

        public override double CalculateMonthlyFee(BasicMember basicMember)
        {
            return sum = base.CalculateMonthlyFee(basicMember) * ( (100 - discountPercentage )/ 100) ;
        }

        public override string ToString()
        {
            return $"{name}, składka miesięczna: {baseFee} zł (Premium)";
        }
    }
}
