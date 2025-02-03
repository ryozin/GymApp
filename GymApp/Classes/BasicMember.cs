using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymApp
{
    internal class BasicMember : IMember
    {
        public string name;
        public double baseFee;


        public BasicMember(string name, double baseFee)
        {
            this.name = name;
            this.baseFee = baseFee;
        }

        public virtual string GetMemberShipInfo(BasicMember basicMember)
        {
           return ("Podstawowe członkostwo.");
        }
        
        public virtual double CalculateMonthlyFee(BasicMember basicMember)
        {
            return baseFee;
        }

        public override string ToString()
        {
            return $"{name}, składka miesięczna: {baseFee} zł (Basic)";
        }


    }

    
}
