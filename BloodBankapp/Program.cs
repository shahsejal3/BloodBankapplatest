using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var BloodDonor = Bloodbank.CreateBloodDonor("JohnWillis",20,BloodGroupType.AB, RHfactorType.positive,4);
            
            
            Console.WriteLine($"DonorID:{BloodDonor.DonorId}," +
                $"DonarName:{BloodDonor.DonorName}," +
                $"Donorage:{BloodDonor.DonorAge}," +
                $"BloodGroup:{BloodDonor.BloodGroup}," +
                $"RHFactor:{BloodDonor.RHFactor}," +
                $"DonorBloodRecord:{BloodDonor.DonorBloodRecord}");

            var BloodDonor2 = Bloodbank.CreateBloodDonor("JoannaThomas", 20, BloodGroupType.O, RHfactorType.negative, 8);

            Console.WriteLine($"DonorID:{BloodDonor2.DonorId}," +
                $"DonorName:{BloodDonor2.DonorName}," +
                $"Donorage:{BloodDonor2.DonorAge}," +
                $"BloodGroup:{BloodDonor2.BloodGroup}," +
                $"RHFactor:{BloodDonor2.RHFactor}," +
                $"DonorBloodRecord:{BloodDonor2.DonorBloodRecord}");  
        }
    }
}
