using System.Diagnostics.CodeAnalysis;
using GymApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Gym myGym = new Gym();

        IMember john = new BasicMember("Jan Kowalski", 100);
        IMember anna = new PremiumMember("Anna Nowak", 150, 20);
      

        myGym.AddMember(john);
        myGym.AddMember(anna);
        

        myGym.ShowMembers();
        Console.WriteLine($"\nCałkowity miesięczny przychód siłowni: {myGym.CalculateTotalRevenue()} zł");
    }
}