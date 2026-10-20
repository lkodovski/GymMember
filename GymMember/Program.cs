using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMember
{
    internal class Program
    {
        public class GymMember
        {
            public string Name;
            public string MembershipType;
            public int MonthsActive;

            public void TrackWorkout(string exercise, int sets, int reps)
            {
                int totalReps = sets * reps;
                Console.WriteLine($"{Name} completed {sets} sets of {exercise} — {totalReps} total reps");
            }

            public void RenewMembership(int months, double pricePerMonth, double discount)
            {
                // pricePerMonth = price for one month in €
                // discount = fixed discount amount in €, not percentage
                double total = months * pricePerMonth;
                double finalPrice = total - discount;
                MonthsActive += months;

                Console.WriteLine($"{Name} renewed {MembershipType} membership for {months} month(s). Paid: {finalPrice}€. Total active: {MonthsActive} months");
            }
        }

        static void Main(string[] args)
        {
            var member = new GymMember();
            member.Name = "Nikola";
            member.MembershipType = "Premium";
            member.MonthsActive = 3;

            member.TrackWorkout("Push-up", 4, 15);
            member.RenewMembership(2, 20.00, 5.00);
        }
    }
}
